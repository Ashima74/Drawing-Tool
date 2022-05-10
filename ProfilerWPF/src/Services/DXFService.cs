using System.IO;
using ProfilerWPF.interOp;
using ProfilerWPF.rendering.renderer;

namespace ProfilerWPF.Services
{
    public class DXFService :IDXFService
    {
        private IAmcMediator _amcMediator;
        private IRSQdbo _rsQdbo;
        //file path referes to the location of the dxf file.

        private Renderer _renderer;


        public DXFService(IAmcMediator amcMediator,IRSQdbo rsQdbo,Renderer renderer)
        {
            _rsQdbo = rsQdbo;
            _amcMediator = amcMediator;
            _renderer = renderer;
        }
        public void LoadDxf(string filepath)
        {
            string dxffile = File.ReadAllText(filepath);
            _rsQdbo.saveDXF(dxffile);
            //call the methods from the AMCMediator to get from the rsq and load into the renderer.
            _renderer.loadShapes();
        }
        //file path refers to the desired location for saving and filename

        public void SaveDxf(string filepath)
        {
            _renderer.SaveShapes();
            string text = _rsQdbo.loadDXF();
            File.WriteAllText(filepath,text);
        }
    }
}