using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class Axis
    {
        public Axis()
        {
            AxisMotorRels = new HashSet<AxisMotorRel>();
            ToolFixtureAxisRels = new HashSet<ToolFixtureAxisRel>();
        }

        public long Number { get; set; }
        public string Name { get; set; }
        public long? TypeNum { get; set; }
        public double? Scale { get; set; }
        public double? Length { get; set; }
        public long? LimitMoves { get; set; }
        public double? MaxSpeed { get; set; }
        public double? MaxAccel { get; set; }
        public double? MaxCutAccel { get; set; }
        public double? MaxJogSpeed { get; set; }
        public double? MaxJogAccel { get; set; }
        public long? HomeMotorsSeparately { get; set; }
        public long? HomeSwitchAtAxisMin { get; set; }
        public double? DistOffHomeSwitch { get; set; }
        public long? UseSlowHoming { get; set; }
        public double? SlowHomingSpeed { get; set; }
        public double? FastHomingSpeed { get; set; }
        public double? HomingAcceleration { get; set; }
        public long? HomingInputBit { get; set; }
        public long? HomeHasBeenFoundOnAxis { get; set; }
        public long? LastHomingDifference { get; set; }

        public virtual DigitalInput HomingInputBitNavigation { get; set; }
        public virtual ICollection<AxisMotorRel> AxisMotorRels { get; set; }
        public virtual ICollection<ToolFixtureAxisRel> ToolFixtureAxisRels { get; set; }
    }
}
