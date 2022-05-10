using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class AxisTypeEnum
    {
        public AxisTypeEnum()
        {
            HeightControlFixtures = new HashSet<HeightControlFixture>();
        }

        public long Number { get; set; }
        public string Type { get; set; }

        public virtual ICollection<HeightControlFixture> HeightControlFixtures { get; set; }
    }
}
