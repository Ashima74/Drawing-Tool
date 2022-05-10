using System;
using System.Collections.Generic;

namespace ProfilerWPF.Services
{
    public interface IRSQdbo
    {
        //takes in the dxf as string(from the file)
        public void saveDXF(string dxfdata);
        //returns the dxf as a string for saving to textfile.
        public string loadDXF();
    }
}