using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ProfilerWPF.src.Services
{
    public interface IFileService
    {
        public string OpenFile(); //will return null if nothing was clicked. 
        public string SaveFile(); //will return null if nothing was clicked.
    }
}
