using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.RSQDatabase.Models
{
    public partial class HeightControlProfile
    {
        public HeightControlProfile()
        {
            ToolProfiles = new HashSet<ToolProfile>();
        }

        public long Number { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double? Speed { get; set; }
        public double? Accel { get; set; }
        public double? StartDelay { get; set; }
        public long? MinimumCutspeedFactor { get; set; }
        public double? SetPointAdjustment { get; set; }
        public double? PlungeDetectionAngle { get; set; }
        public long? PlungeDetectionFilterSize { get; set; }
        public double? PlungeDetectionOffDistance { get; set; }
        public double? Voltage { get; set; }
        public long? SetPoint { get; set; }
        public long? ReferencePoint { get; set; }
        public long? DoHeightControlBetweenShapes { get; set; }

        public virtual ICollection<ToolProfile> ToolProfiles { get; set; }
    }
}
