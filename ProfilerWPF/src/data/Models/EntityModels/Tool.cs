using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class Tool
    {
        public Tool()
        {
            AvailableTools = new HashSet<AvailableTool>();
            ToolHistories = new HashSet<ToolHistory>();
            ToolProfiles = new HashSet<ToolProfile>();
            ToolReplacements = new HashSet<ToolReplacement>();
            ToolToToolFixtureRels = new HashSet<ToolToToolFixtureRel>();
        }

        public long Number { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public long NcNumber { get; set; }
        public string PartNumber { get; set; }
        public long? CanRaiseOnPause { get; set; }
        public long? CanBeTippedOff { get; set; }
        public long? UseAirAssist { get; set; }
        public long? UseMist { get; set; }
        public double? TipZadjustment { get; set; }
        public double? MaxCutSpeed { get; set; }
        public double? MaxPlungeSpeed { get; set; }
        public double? MaxSpindleRevsPerMinute { get; set; }
        public double? DefaultSpindleRevsPerMinute { get; set; }
        public double? MaxRotationalSpeed { get; set; }
        public long? RotateSpindleCw { get; set; }
        public double? Compensation { get; set; }
        public double? Diameter { get; set; }
        public double? Angle { get; set; }
        public double? Pitch { get; set; }
        public long? LeftHandThread { get; set; }
        public double? Width { get; set; }
        public string OtherName { get; set; }
        public double? FastSearchSpeed { get; set; }
        public double? SlowSearchSpeed { get; set; }
        public string Procedure { get; set; }
        public virtual ProcedureTypeEnum ProcedureNavigation { get; set; }
        public virtual ToolFixtureTypeEnum TypeNavigation { get; set; }
        public virtual ICollection<AvailableTool> AvailableTools { get; set; }
        public virtual ICollection<ToolHistory> ToolHistories { get; set; }
        public virtual ICollection<ToolProfile> ToolProfiles { get; set; }
        public virtual ICollection<ToolReplacement> ToolReplacements { get; set; }
        public virtual ICollection<ToolToToolFixtureRel> ToolToToolFixtureRels { get; set; }
    }
}
