#nullable disable

namespace ProfilerWPF.data.RSQData.Models
{
    public partial class GroupDatum
    {
        public long Number { get; set; }
        public string Name { get; set; }
        public string Parent { get; set; }
        public long? Colour { get; set; }
        public long? IsOn { get; set; }
        public string Material { get; set; }
        public long? ToolProfileNumber { get; set; }
        public double? OffsetAdjustment { get; set; }
        public long? ReverseShapeForCutting { get; set; }
        public string DepthType { get; set; }
        public double? MmDepth { get; set; }
        public long? Multipass { get; set; }
        public double? MpassStartDepth { get; set; }
        public double? MpassThick { get; set; }
        public double? MpassDepthPp { get; set; }
        public double? MpassLast { get; set; }
        public double? LastPassOffset { get; set; }
        public double? TagLength { get; set; }
        public long? UseLineTypeLeads { get; set; }
        public long? UseRampTypeLeads { get; set; }
        public double? LeadInLength { get; set; }
        public double? LeadOutLength { get; set; }
        public double? LeadInAngle { get; set; }
        public double? LeadOutAngle { get; set; }
        public long? Traverse { get; set; }
        public long? DoDoubleOffset { get; set; }
        public long? NumOffsets { get; set; }

        public virtual ToolProfile ToolProfileNumberNavigation { get; set; }
    }
}
