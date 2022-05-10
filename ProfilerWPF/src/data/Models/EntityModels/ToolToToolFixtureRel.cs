#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class ToolToToolFixtureRel
    {
        public long Number { get; set; }
        public long ToolNumber { get; set; }
        public long? ToolFixtureNumber { get; set; }

        public virtual ToolFixture ToolFixtureNumberNavigation { get; set; }
        public virtual Tool ToolNumberNavigation { get; set; }
    }
}
