#nullable disable

namespace ProfilerWPF.data.RSQData.Models
{
    public partial class JobParam
    {
        public long Number { get; set; }
        public string JobComments { get; set; }
        public string MachineConfigFileName { get; set; }
        public string MaterialName { get; set; }
        public double? MaterialThickness { get; set; }
        public double? ZTopClearance { get; set; }
        public long? ZSurfaceValid { get; set; }
        public double? ZSurface { get; set; }
        public double? ZBottomClearance { get; set; }
        public long? UseWasteBoardSurface { get; set; }
        public long? MasterToolNumber { get; set; }
        public string MasterToolName { get; set; }
        public long? Date { get; set; }
        public double? AbsOriginX { get; set; }
        public double? AbsOriginY { get; set; }
        public double? AbsOriginZ { get; set; }
        public double? AbsOriginW { get; set; }
        public double? FinishPositionX { get; set; }
        public double? FinishPositionY { get; set; }
        public long? UseAutoOffsets { get; set; }
        public long? UseGroupsWhenRunningNcCode { get; set; }
        public long? ZTopValid { get; set; }
        public double? ZTop { get; set; }
        public long? ZBottomValid { get; set; }
        public double? ZBottom { get; set; }
    }
}
