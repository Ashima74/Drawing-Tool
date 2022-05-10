using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class HeightControlTypeEnum
    {
        public HeightControlTypeEnum()
        {
            HeightControlFixtures = new HashSet<HeightControlFixture>();
            HeightControlProfiles = new HashSet<HeightControlProfile>();
        }

        public long Number { get; set; }
        public string Type { get; set; }

        public virtual ICollection<HeightControlFixture> HeightControlFixtures { get; set; }
        public virtual ICollection<HeightControlProfile> HeightControlProfiles { get; set; }
    }
}
