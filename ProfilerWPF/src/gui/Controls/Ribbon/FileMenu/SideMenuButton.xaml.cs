﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Prism.Commands;
using ProfilerWPF.gui.DataTypes.Interfaces;

namespace ProfilerWPF.gui.Controls.Ribbon.FileMenu
{
    public partial class SideMenuButton : UserControl
    {
        //Dependency property for the width of the button internal icon
        public static readonly DependencyProperty ButtonWidthProperty = DependencyProperty.Register("ButtonWidth", typeof(double), typeof(SideMenuButton), new FrameworkPropertyMetadata(0.00));
        public double ButtonWidth
        {
            get { return (double)GetValue(ButtonWidthProperty); }
            set { SetValue(ButtonWidthProperty, value); }
        }

        //Dependency property for the SVG style used for the button
        public static readonly DependencyProperty IconStyleProperty = DependencyProperty.Register("IconStyle", typeof(Style), typeof(SideMenuButton), new FrameworkPropertyMetadata(null));
        public Style IconStyle
        {
            get { return (Style)GetValue(IconStyleProperty); }
            set { SetValue(IconStyleProperty, value); }
        }

        //Dependency property for the height of the internal icon
        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.Register("IconHeight", typeof(double), typeof(SideMenuButton), new FrameworkPropertyMetadata(25.0));
        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }

        //Dependency property for the height of the internal icon
        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.Register("IconWidth", typeof(double), typeof(SideMenuButton), new FrameworkPropertyMetadata(20.0));
        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        //Dependency property for padding around the icon button
        public static readonly DependencyProperty ButtonPaddingProperty = DependencyProperty.Register("ButtonPadding", typeof(System.Windows.Thickness), typeof(SideMenuButton), new FrameworkPropertyMetadata(new Thickness(5,0,5,0)));
        public Thickness ButtonPadding
        {
            get { return (Thickness)GetValue(ButtonPaddingProperty); }
            set { SetValue(ButtonPaddingProperty, value); }
        }

        //Dependency property for padding around the icon button
        public static readonly DependencyProperty IconPaddingProperty = DependencyProperty.Register("IconPadding", typeof(System.Windows.Thickness), typeof(SideMenuButton), new FrameworkPropertyMetadata(new Thickness(0, 0, 10, 0)));
        public Thickness IconPadding
        {
            get { return (Thickness)GetValue(IconPaddingProperty); }
            set { SetValue(IconPaddingProperty, value); }
        }

        //Dependency property for Text
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(SideMenuButton), new FrameworkPropertyMetadata(""));
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        //Dependency property for Text
        public static readonly DependencyProperty ParagraphProperty = DependencyProperty.Register("Paragraph", typeof(string), typeof(SideMenuButton), new FrameworkPropertyMetadata(""));
        public string Paragraph
        {
            get { return (string)GetValue(ParagraphProperty); }
            set { SetValue(ParagraphProperty, value); }
        }

        //Dependency property for Orientation
        public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register("Orientation", typeof(string), typeof(SideMenuButton), new FrameworkPropertyMetadata("Vertical"));
        public string Orientation
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        //Dependency property for items in itemlist
        public static readonly DependencyProperty ContextMenuItemsProperty = DependencyProperty.Register("ContextMenuItems", typeof(List<ContextMenuItem>), typeof(SideMenuButton), new FrameworkPropertyMetadata(new List<ContextMenuItem>()));
        public List<ContextMenuItem> ContextMenuItems
        {
            get { return (List<ContextMenuItem>)GetValue(ContextMenuItemsProperty); }
            set { SetValue(ContextMenuItemsProperty, value); }
        }

        
        private static readonly DependencyProperty _command = DependencyProperty.Register("Command", typeof(DelegateCommand), typeof(SideMenuButton));
        public DelegateCommand Command
        {
            get { return (DelegateCommand)GetValue(_command); }
            set { SetValue(_command, value); }
        }

        //Dependency property for Toggled, true if the button is currently selected
        public static readonly DependencyProperty ToggledProperty = DependencyProperty.Register("Toggled", typeof(bool), typeof(SideMenuButton), new FrameworkPropertyMetadata(false));
        public string Toggled
        {
            get { return (string)GetValue(ToggledProperty); }
            set { SetValue(ToggledProperty, value); }
        }

        public SideMenuButton()
        {
            InitializeComponent();
            this.DataContext = this;
        }

    }
}
