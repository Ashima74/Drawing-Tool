#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class Origin
    {
        public long Number { get; set; }
        public string Name { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Z { get; set; }
        public long? UseWasteBoard { get; set; }
    }
}
