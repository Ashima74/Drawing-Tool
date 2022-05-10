using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProfilerWPF.Services
{
    public class DRMHandler : IDRMHandler
    {
        private IFilePathGenerator _filePathGenerator;
        private List<Byte> _drm;
        private List<Byte> _normal;

        //will create an object similar to sql settings to handle the file path.
        public DRMHandler(IFilePathGenerator filePathGenerator)
        {
            _filePathGenerator = filePathGenerator;
            _drm = File.ReadAllBytes(filePathGenerator.GetFilePath("DRM.rsq")).ToList();
            _normal = File.ReadAllBytes(filePathGenerator.GetFilePath("NormalFile.rsq")).ToList();
        }

        public bool addDRM(string filepath)
        {
            //open file if exists if not return false or return exception.
            List<Byte> array = File.ReadAllBytes(filepath).ToList();
            //generate the first part 
            List<Byte> firstPart = generatingFirstSection(array, _drm);
            //check that the file has the drm applied if it doesn't return false.
            if(!ifDRM(firstPart, _drm))
            {
                File.WriteAllBytes(filepath,addingDRM(array, _drm).ToArray());
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool removeDRM(string filepath)
        {
            //open file if exists if not return false or return exception.
            List<Byte> array = File.ReadAllBytes(filepath).ToList();
            //generate the first part 
            List<Byte> firstPart = generatingFirstSection(array, _drm);
            //check that the file has the drm applied if it doesn't return false.
            if(ifDRM(firstPart, _drm))
            {
                File.WriteAllBytes(filepath,removeDRM(array, _normal).ToArray());
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ifDRM(List<Byte> firstPart, List<Byte> DRM)
        {
            return firstPart.SequenceEqual(DRM);
        }

        private List<Byte> removeDRM(List<Byte> file,List<Byte> NormalFile)
        {
            //remove the drm
            file.RemoveRange(0, NormalFile.Count);
            file.InsertRange(0,NormalFile);
            return file;
        }

        private List<Byte> addingDRM(List<Byte> file, List<Byte> DRM)
        {
            //remove the drm
            file.RemoveRange(0, DRM.Count);
            file.InsertRange(0,DRM);
            return file;
        }

        private List<Byte> generatingFirstSection(List<Byte> file, List<Byte> Drm)
        {
            List<Byte> firstPart = file.GetRange(0, Drm.Count);
            return firstPart;
        }
    }
}