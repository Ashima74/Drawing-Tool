using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class ToolFixtureTypeEnum
    {
        public ToolFixtureTypeEnum()
        {
            ToolProfiles = new HashSet<ToolProfile>();
            Tools = new HashSet<Tool>();
        }

        public long Number { get; set; }
        public string Type { get; set; }

        public virtual ICollection<ToolProfile> ToolProfiles { get; set; }
        public virtual ICollection<Tool> Tools { get; set; }
    }
}
