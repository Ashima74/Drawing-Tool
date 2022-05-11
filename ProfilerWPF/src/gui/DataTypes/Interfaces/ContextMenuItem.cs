using Prism.Commands;

namespace ProfilerWPF.gui.DataTypes.Interfaces
{
    //This class contains a text element and a command, used for specifying behaiviour for context menu items
    public class ContextMenuItem
    {
        public ContextMenuItem(string text, string subText = null, System.Windows.Style icon = null, DelegateCommand command = null)
        {
            Text = text;
            Icon = icon;
            SubText = subText;
            Command = command;
        }

        private DelegateCommand CommandProperty;

        public DelegateCommand Command
        {
            get { return CommandProperty; }
            set { CommandProperty = value; }
        }

        private object IconProperty;

        public object Icon
        {
            get { return IconProperty; }
            set { IconProperty = value; }
        }


        private string SubTextProperty;
        public string SubText
        {
            get { return SubTextProperty; }
            set { SubTextProperty = value; }
        }


        private string TextProperty;
        public string Text
        {
            get { return TextProperty; }
            set { TextProperty = value; }
        }
    }
}
