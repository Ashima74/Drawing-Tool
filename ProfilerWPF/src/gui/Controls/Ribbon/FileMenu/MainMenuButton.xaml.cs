using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Prism.Commands;
using ProfilerWPF.gui.DataTypes.Interfaces;

namespace ProfilerWPF.gui.Controls.Ribbon.FileMenu
{
    public partial class MainMenuButton : UserControl
    {
        //Dependency property for the width of the button internal icon
        public static readonly DependencyProperty ButtonWidthProperty = DependencyProperty.Register("ButtonWidth", typeof(double), typeof(MainMenuButton), new FrameworkPropertyMetadata(0.00));
        public double ButtonWidth
        {
            get { return (double)GetValue(ButtonWidthProperty); }
            set { SetValue(ButtonWidthProperty, value); }
        }

        //Dependency property for the SVG style used for the button
        public static readonly DependencyProperty IconStyleProperty = DependencyProperty.Register("IconStyle", typeof(Style), typeof(MainMenuButton), new FrameworkPropertyMetadata(null));
        public Style IconStyle
        {
            get { return (Style)GetValue(IconStyleProperty); }
            set { SetValue(IconStyleProperty, value); }
        }

        //Dependency property for the height of the internal icon
        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.Register("IconHeight", typeof(double), typeof(MainMenuButton), new FrameworkPropertyMetadata(25.0));
        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }

        //Dependency property for the height of the internal icon
        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.Register("IconWidth", typeof(double), typeof(MainMenuButton), new FrameworkPropertyMetadata(20.0));
        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        //Dependency property for padding around the icon button
        public static readonly DependencyProperty ButtonPaddingProperty = DependencyProperty.Register("ButtonPadding", typeof(System.Windows.Thickness), typeof(MainMenuButton), new FrameworkPropertyMetadata(new Thickness(5,0,5,0)));
        public Thickness ButtonPadding
        {
            get { return (Thickness)GetValue(ButtonPaddingProperty); }
            set { SetValue(ButtonPaddingProperty, value); }
        }

        //Dependency property for padding around the icon button
        public static readonly DependencyProperty IconPaddingProperty = DependencyProperty.Register("IconPadding", typeof(System.Windows.Thickness), typeof(MainMenuButton), new FrameworkPropertyMetadata(new Thickness(0, 0, 10, 0)));
        public Thickness IconPadding
        {
            get { return (Thickness)GetValue(IconPaddingProperty); }
            set { SetValue(IconPaddingProperty, value); }
        }

        //Dependency property for Text
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(MainMenuButton), new FrameworkPropertyMetadata(""));
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        //Dependency property for Orientation
        public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register("Orientation", typeof(string), typeof(MainMenuButton), new FrameworkPropertyMetadata("Vertical"));
        public string Orientation
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        //Dependency property for items in itemlist
        public static readonly DependencyProperty ContextMenuItemsProperty = DependencyProperty.Register("ContextMenuItems", typeof(List<ContextMenuItem>), typeof(MainMenuButton), new FrameworkPropertyMetadata(new List<ContextMenuItem>()));
        public List<ContextMenuItem> ContextMenuItems
        {
            get { return (List<ContextMenuItem>)GetValue(ContextMenuItemsProperty); }
            set { SetValue(ContextMenuItemsProperty, value); }
        }

        
        private static readonly DependencyProperty _command = DependencyProperty.Register("Command", typeof(DelegateCommand<string>), typeof(MainMenuButton));
        public DelegateCommand<string> Command
        {
            get { return (DelegateCommand<string>)GetValue(_command); }
            set { SetValue(_command, value); }
        }

        private static readonly DependencyProperty _peekCommand = DependencyProperty.Register("PeekCommand", typeof(DelegateCommand<string>), typeof(MainMenuButton));
        public DelegateCommand<string> PeekCommand
        {
            get { return (DelegateCommand<string>)GetValue(_peekCommand); }
            set { SetValue(_peekCommand, value); }
        }

        private static readonly DependencyProperty _resetCommand = DependencyProperty.Register("ResetCommand", typeof(DelegateCommand), typeof(MainMenuButton));
        public DelegateCommand ResetCommand
        {
            get { return (DelegateCommand)GetValue(_resetCommand); }
            set { SetValue(_resetCommand, value); }
        }


        private static readonly DependencyProperty _commandParameter = DependencyProperty.Register("CommandParameter", typeof(string), typeof(MainMenuButton));
        public string CommandParameter
        {
            get { return (string)GetValue(_commandParameter); }
            set { SetValue(_commandParameter, value); }
        }

        //Dependency property for Toggled, true if the button is currently selected
        public static readonly DependencyProperty ToggledProperty = DependencyProperty.Register("Toggled", typeof(bool), typeof(MainMenuButton), new FrameworkPropertyMetadata(false));
        public string Toggled
        {
            get { return (string)GetValue(ToggledProperty); }
            set { SetValue(ToggledProperty, value); }
        }

        public MainMenuButton()
        {
            InitializeComponent();
            this.DataContext = this;
        }

    }
}
