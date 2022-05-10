using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class ToolChangeTypeEnum
    {
        public ToolChangeTypeEnum()
        {
            ToolChangers = new HashSet<ToolChanger>();
        }

        public long Number { get; set; }
        public string Type { get; set; }

        public virtual ICollection<ToolChanger> ToolChangers { get; set; }
    }
}
