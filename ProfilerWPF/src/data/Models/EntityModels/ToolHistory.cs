#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class ToolHistory
    {
        public long Number { get; set; }
        public long ToolNumber { get; set; }
        public string ToolName { get; set; }
        public string PartNumber { get; set; }
        public string JobName { get; set; }
        public long? Date { get; set; }
        public double? CutTime { get; set; }
        public double? CutDistance { get; set; }
        public double? NumShapes { get; set; }
        public string Comment { get; set; }

        public virtual Tool ToolNumberNavigation { get; set; }
    }
}
