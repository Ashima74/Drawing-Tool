#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class LaserAlignment
    {
        public long Number { get; set; }
        public long? AxisAorientation { get; set; }
        public long? AxisBorientation { get; set; }
        public string ServerAddress { get; set; }
        public long? LaserSettlingTimeMs { get; set; }
        public long? LaserAlignmentAccuracy { get; set; }
    }
}
