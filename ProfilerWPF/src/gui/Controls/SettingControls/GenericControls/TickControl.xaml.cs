using System;
using System.Windows;
using System.Windows.Controls;

namespace ProfilerWPF.gui.Controls.SettingControls.GenericControls
{
    /// <summary>
    /// Interaction logic for TickControl.xaml
    /// </summary>
    public partial class TickControl : UserControl
    {
        public event EventHandler inputChanged;

        public TickControl()
        {
            InitializeComponent();
        }

        public Boolean checkedValue { get; set; }
        public String Title
        {
            get { return (String)GetValue(String); }
            set { SetValue(String, value); }
        }

        public Boolean getValue()
        {
            checkedValue = (bool)check.IsChecked;
            return checkedValue;
        }

        public void setValue(Boolean value)
        {
            this.checkedValue = value;
            check.IsChecked = this.checkedValue;
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty String =
            DependencyProperty.Register("Title", typeof(String), typeof(TickControl), new PropertyMetadata("String"));


        //on change of checked status
        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkedValue = (bool)check.IsChecked;
            if (inputChanged != null)
            {
                inputChanged(this, e);
            }
        }
    }
}
