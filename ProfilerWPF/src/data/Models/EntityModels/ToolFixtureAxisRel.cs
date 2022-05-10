#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class ToolFixtureAxisRel
    {
        public long Number { get; set; }
        public long? ToolFixtureNumber { get; set; }
        public long? AxisNumber { get; set; }

        public virtual Axis AxisNumberNavigation { get; set; }
        public virtual ToolFixture ToolFixtureNumberNavigation { get; set; }
    }
}
