#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class AxisMotorRel
    {
        public long Number { get; set; }
        public long? AxisNumber { get; set; }
        public long? MotorNumber { get; set; }

        public virtual Axis AxisNumberNavigation { get; set; }
        public virtual Motor MotorNumberNavigation { get; set; }
    }
}
