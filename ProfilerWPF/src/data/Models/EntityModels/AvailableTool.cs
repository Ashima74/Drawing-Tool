#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class AvailableTool
    {
        public long Number { get; set; }
        public long? ToolNumber { get; set; }
        public long? ToolChangerNumber { get; set; }
        public long? SlotNum { get; set; }
        public double? ZDisplacement { get; set; }
        public long? IsCalibrated { get; set; }

        public virtual ToolChanger ToolChangerNumberNavigation { get; set; }
        public virtual Tool ToolNumberNavigation { get; set; }
    }
}
