using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class Motor
    {
        public Motor()
        {
            AxisMotorRels = new HashSet<AxisMotorRel>();
        }

        public long Number { get; set; }
        public string Name { get; set; }
        public long? ReverseDirection { get; set; }
        public long? InvertStep { get; set; }
        public long? DirectionDelay { get; set; }
        public long? StepDelay { get; set; }
        public long? MonitorFailure { get; set; }
        public long? EnableOutputBit { get; set; }
        public long? BrakeOffOutputBit { get; set; }
        public long? FailInputBit { get; set; }

        public virtual DigitalOutput BrakeOffOutputBitNavigation { get; set; }
        public virtual DigitalOutput EnableOutputBitNavigation { get; set; }
        public virtual DigitalInput FailInputBitNavigation { get; set; }
        public virtual ICollection<AxisMotorRel> AxisMotorRels { get; set; }
    }
}
