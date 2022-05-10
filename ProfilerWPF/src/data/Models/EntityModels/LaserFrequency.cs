using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class LaserFrequency
    {
        public LaserFrequency()
        {
            ToolProfileCutFrequencyNavigations = new HashSet<ToolProfile>();
            ToolProfilePierceFrequencyNavigations = new HashSet<ToolProfile>();
        }

        public long Number { get; set; }
        public long ToolFixtureNumber { get; set; }
        public long? TableIndex { get; set; }
        public long? FrequencyCode { get; set; }
        public long Frequency { get; set; }

        public virtual ToolFixture ToolFixtureNumberNavigation { get; set; }
        public virtual ICollection<ToolProfile> ToolProfileCutFrequencyNavigations { get; set; }
        public virtual ICollection<ToolProfile> ToolProfilePierceFrequencyNavigations { get; set; }
    }
}
