using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class DebugLevelTypeEnum
    {
        public DebugLevelTypeEnum()
        {
            Profilers = new HashSet<Profiler>();
        }

        public long Number { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Profiler> Profilers { get; set; }
    }
}
