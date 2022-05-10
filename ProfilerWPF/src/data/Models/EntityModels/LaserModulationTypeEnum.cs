using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class LaserModulationTypeEnum
    {
        public LaserModulationTypeEnum()
        {
            ToolFixtures = new HashSet<ToolFixture>();
        }

        public long Number { get; set; }
        public string Type { get; set; }

        public virtual ICollection<ToolFixture> ToolFixtures { get; set; }
    }
}
