namespace ProfilerWPF.Services
{
    public interface IDXFService
    {
        //fiel path referes to the location of the dxf file.
        public void LoadDxf(string filepath);
        //file path refers to the desired location for saving and filename
        public void SaveDxf(string filepath);
    }
}