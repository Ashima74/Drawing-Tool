#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class HardwareSimulation
    {
        public long Number { get; set; }
        public string Name { get; set; }
        public long? Type { get; set; }
        public long? InputBit { get; set; }
        public long? AxisNumber { get; set; }
        public long? OffDirIsNeg { get; set; }
        public double? SearchPosition { get; set; }
        public long? InputBit2 { get; set; }
        public double? SearchPositionOffset { get; set; }
        public double? TipoffPosition { get; set; }
        public double? TipoffToolLengthFactor { get; set; }
        public long? SurfaceType { get; set; }
        public double? ZAtX0y0 { get; set; }
        public double? Mx { get; set; }
        public double? My { get; set; }
        public double? XStepPosition { get; set; }
        public double? XStepHeight { get; set; }
    }
}
