using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class InverterTypeEnum
    {
        public InverterTypeEnum()
        {
            ToolFixtures = new HashSet<ToolFixture>();
        }

        public long Number { get; set; }
        public string Type { get; set; }

        public virtual ICollection<ToolFixture> ToolFixtures { get; set; }
    }
}
