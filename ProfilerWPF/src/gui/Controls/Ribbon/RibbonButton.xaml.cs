using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Prism.Commands;
using ProfilerWPF.gui.DataTypes.Interfaces;

namespace ProfilerWPF.gui.Controls.Ribbon
{
    /// <summary>
    /// Interaction logic for RibbonButton.xaml
    /// </summary>
    public partial class RibbonButton : UserControl
    {
        //Dependency property for the SVG style used for the button
        private static readonly DependencyProperty _iconStyle = DependencyProperty.Register("IconStyle", typeof(Style), typeof(RibbonButton), new FrameworkPropertyMetadata(null));
        public Style IconStyle
        {
            get { return (Style)GetValue(_iconStyle); }
            set { SetValue(_iconStyle, value); }
        }

        //Dependency property for the height of the internal icon
        private static readonly DependencyProperty _iconHeight = DependencyProperty.Register("IconHeight", typeof(double), typeof(RibbonButton), new FrameworkPropertyMetadata(50.0));
        public double IconHeight
        {
            get { return (double)GetValue(_iconHeight); }
            set { SetValue(_iconHeight, value); }
        }

        //Dependency property for padding around the icon button
        private static readonly DependencyProperty _buttonPadding = DependencyProperty.Register("ButtonPadding", typeof(System.Windows.Thickness), typeof(RibbonButton), new FrameworkPropertyMetadata(new Thickness(5, 0, 5, 0)));
        public Thickness ButtonPadding
        {
            get { return (Thickness)GetValue(_buttonPadding); }
            set { SetValue(_buttonPadding, value); }
        }

        //Dependency property for Toggled, true if the button is currently selected
        public static readonly DependencyProperty ToggledProperty = DependencyProperty.Register("Toggled", typeof(bool), typeof(RibbonButton), new FrameworkPropertyMetadata(false));
        public string Toggled
        {
            get { return (string)GetValue(ToggledProperty); }
            set { SetValue(ToggledProperty, value); }
        }

        //Dependency property for Text
        private static readonly DependencyProperty _text = DependencyProperty.Register("Text", typeof(string), typeof(RibbonButton), new FrameworkPropertyMetadata(""));
        public string Text
        {
            get { return (string)GetValue(_text); }
            set { SetValue(_text, value); }
        }

        //Dependency property for items in itemlist
        private static readonly DependencyProperty _contextMenuItems = DependencyProperty.Register("ContextMenuItems", typeof(List<ContextMenuItem>), typeof(RibbonButton), new FrameworkPropertyMetadata(new List<ContextMenuItem>()));
        public List<ContextMenuItem> ContextMenuItems
        {
            get { return (List<ContextMenuItem>)GetValue(_contextMenuItems); }
            set { SetValue(_contextMenuItems, value); }
        }


        //Dependency property for items in itemlist
        private static readonly DependencyProperty _command = DependencyProperty.Register("Command", typeof(DelegateCommand), typeof(RibbonButton));
        public DelegateCommand Command
        {
            get { return (DelegateCommand)GetValue(_command); }
            set { SetValue(_command, value); }
        }

        //When button is clicked, if context menu items is not empty, open the context menu, otherwise perform original 
        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            //if control contains context menu items, open them
            if (ContextMenuItems.Count >= 1)
            {
                MainButton.ContextMenu.DataContext = MainButton.DataContext;
                MainButton.ContextMenu.IsOpen = true;
                e.Handled = true;
            }
            //Otherwise if the button has an onclick command, invoke it
            else if (Command != null)
            {
                Command.Execute();
            }
        }

        public RibbonButton()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
