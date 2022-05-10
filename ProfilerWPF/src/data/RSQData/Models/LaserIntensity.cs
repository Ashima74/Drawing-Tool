#nullable disable

namespace ProfilerWPF.data.RSQData.Models
{
    public partial class LaserIntensity
    {
        public long Number { get; set; }
        public long ToolProfileNumber { get; set; }
        public long? TableIndex { get; set; }
        public long Intensity { get; set; }

        public virtual ToolProfile ToolProfileNumberNavigation { get; set; }
    }
}
