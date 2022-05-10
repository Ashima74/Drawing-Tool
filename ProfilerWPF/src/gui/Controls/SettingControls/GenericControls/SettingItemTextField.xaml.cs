using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProfilerWPF.gui.Controls.SettingControls.GenericControls
{
    /// <summary>
    ///     Interaction logic for SettingItemTextField.xaml
    ///     TODO: Validation logic should be abstracted to common class or probably just leverage a validation library.
    ///     TODO: Don't use arbitrary integers to represent options, refactor to using an enum at a minimum
    /// </summary>
    public partial class SettingItemTextField : UserControl

    {
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty String =
            DependencyProperty.Register("Title", typeof(string), typeof(SettingItemTextField),
                new PropertyMetadata("String"));

        /// <summary>
        ///     test;
        /// </summary>
        public static readonly DependencyProperty OptionInput =
            DependencyProperty.Register("Option", typeof(int), typeof(SettingItemTextField), new PropertyMetadata(0));

        private bool Initialised;


        public string StoredValue = "";

        public SettingItemTextField()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => (string) GetValue(String);
            set => SetValue(String, value);
        }

        //used to decide what sort of restrictions are on the textbox.
        // 0 means no restriction (this is the default), 1 means text only, 2 means integers only, 3 means only ints and doubles(will check for no ..),4 means no input allowed. 
        //TODO: This makes for very hard to read code, at the very least should be refactored to use enumerables
        public int Option
        {
            get => (int) GetValue(OptionInput);
            set
            {
                SetValue(OptionInput, value);
                SetOption(value);
            }
        }

        public event EventHandler InputChanged;

        public string GetDefault(int value)
        {
            var output = " ";
            switch (value)
            {
                case 4:
                    output = Input.Text;
                    break;
                case 3: //return double default
                    output = "0";
                    break;
                case 2: // default for int
                    output = "0";
                    break;
                case 1:
                    output = " ";
                    break;
                case 0:
                    output = " ";
                    break;
            }

            return output;
        }

        /// <summary>
        ///     (0, no restriction), (1, Text only), (2, Ints only), (3, Double/Int only), (4, no input)
        /// </summary>
        private void SetOption(int value)
        {
            var change = CheckingInput(value, Input.Text);
            //if the value is incompatible with new Option should reset the input. 

            if (!change) Input.Text = GetDefault(Option);

            if (value == 4)
                Input.IsReadOnly = true;
            else
                Input.IsReadOnly = false;
        }

        public bool CheckingInput(int input, string value)
        {
            switch (input)
            {
                //checking whether the current value is acceptable for the new Option
                case 4:
                    return true; //return true as it isn't affected by the Option.
                case 3: //only ints and doubles
                    return IsIntOrDouble(value);
                case 2:
                    return IsAllDigits(value);
                case 1:
                    return !IsAllDigits(value);
                case 0:
                    return true;
                default:
                    return false;
            }
        }

        public bool IsAllDigits(string input)
        {
            foreach (var x in input)
                if (!char.IsDigit(x))
                    return false;
            return true;
        }

        public bool IsIntOrDouble(string input)
        {
            var includes_num = false;
            foreach (var x in input)
            {
                if (!char.IsDigit(x) && x != '.') return false;
                if (char.IsDigit(x)) includes_num = true;
            }

            return includes_num;
        }

        public string GetStoredValue()
        {
            var output = StoredValue;
            var check = CheckingInput(Option, StoredValue);
            if (!check) output = GetDefault(Option);
            return output;
        }

        public void SetSetting(string value)
        {
            StoredValue = value;
            Input.Text = value;
        }


        private void Input_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            StoredValue = Input.Text;
            if (InputChanged != null) InputChanged(this, e);
        }


        private void Input_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var full = Input.Text + e.Text;
            var checkInput = CheckingInput(Option, full);
            //if equals false then set to default value;
            if (!checkInput) e.Handled = true;
        }

        private void Input_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!Initialised)
            {
                SetOption(Option);
                Initialised = true;
            }
        }
    }
}