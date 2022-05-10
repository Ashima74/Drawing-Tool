using System;

namespace ProfilerWPF.Services
{
    public class FilePathGenerator :IFilePathGenerator
    {
        private string filepath = AppDomain.CurrentDomain.BaseDirectory + "../../../../";
        public string GetFilePath(string fileName)
        {
            return filepath + fileName;
        }
    }
}