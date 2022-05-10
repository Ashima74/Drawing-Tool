using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace ProfilerWPF.gui.Controls.SettingControls.GenericControls
{
    /// <summary>
    /// Interaction logic for SettingComboBox.xaml
    /// </summary>
    public partial class SettingComboBox : UserControl
    {
        public String selectedItem;
        public event EventHandler SelectionChanged;
        public void setSelectedItem(String value)
        {
            selectedItem = value;
         
            Combobox.SelectedItem = selectedItem;

        }

        public ObservableCollection<string> combosource;
        public void Setcombosource(ObservableCollection<string> value)
        {
            combosource = value;
            Combobox.ItemsSource = combosource;
        }
        public ObservableCollection<string> getComboSource()
        {
            return combosource;
        }

        public SettingComboBox()
        {
            InitializeComponent();
            combosource = new ObservableCollection<string>();
            selectedItem = "";

        }
        public String Title
        {
            get { return (String)GetValue(String); }
            set { SetValue(String, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty String =
            DependencyProperty.Register("Title", typeof(String), typeof(SettingComboBox), new PropertyMetadata("String"));
        //onchange of combobox;

        private void Combobox_Selected(object sender, RoutedEventArgs e)
        {
            selectedItem = (string)Combobox.SelectedItem;
            if (SelectionChanged != null)
            {
                SelectionChanged(this, e);
            }
        }

        public string getSelectedItem()
        {
            return selectedItem;
        }
    }
}
