#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class TempMachinePropertyVisibility
    {
        public long Number { get; set; }
        public string TableName { get; set; }
        public string Type { get; set; }
        public string Property { get; set; }
        public long? Visible { get; set; }
        public long? Enabled { get; set; }
    }
}
