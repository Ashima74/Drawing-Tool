#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class Tipoff
    {
        public long Number { get; set; }
        public double? XPosition { get; set; }
        public double? YPosition { get; set; }
        public double? PlungeSpeed { get; set; }
        public double? SurfaceDisplacement { get; set; }
        public long? SurfaceDisplacementHasBeenSet { get; set; }
        public long? TipoffInputBit { get; set; }
        public long? IsOnGantry { get; set; }

        public virtual DigitalInput TipoffInputBitNavigation { get; set; }
    }
}
