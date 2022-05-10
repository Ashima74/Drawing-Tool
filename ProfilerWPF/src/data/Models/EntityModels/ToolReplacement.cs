#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class ToolReplacement
    {
        public long Number { get; set; }
        public long ToolNumber { get; set; }
        public string ToolName { get; set; }
        public string Date { get; set; }
        public string Comment { get; set; }

        public virtual Tool ToolNumberNavigation { get; set; }
    }
}
