using Microsoft.Win32;

namespace ProfilerWPF.data.FileDialogServices
{
    public class OpenFileService : IOpenFileService
    {
        private OpenFileDialog _openFileDialog = new OpenFileDialog();
        string[] _selectedFileNames;
        public bool? OpenFile()
        {
            _openFileDialog.Multiselect = false;
            var ofd = _openFileDialog.ShowDialog();
            if(ofd.HasValue && ofd.Value)
            {
                _selectedFileNames = _openFileDialog.FileNames;
            }
            return ofd;
        }
        public string[] FileNames
        {
            get { return _selectedFileNames; }
        }
    }
}
