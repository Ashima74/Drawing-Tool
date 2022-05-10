#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class RsmUpgrade
    {
        public long Number { get; set; }
        public string IniFile { get; set; }
        public string ToolsFile { get; set; }
        public string ToolChangeFile { get; set; }
        public string ConfigFile { get; set; }
        public string DataFile { get; set; }
        public string DataConfigFile { get; set; }
    }
}
