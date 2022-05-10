#nullable disable

namespace ProfilerWPF.data.Models.RSQDatabase.Models
{
    public partial class Job
    {
        public long Number { get; set; }
        public string Name { get; set; }
        public string OriginalFileName { get; set; }
        public string JobDataType { get; set; }
        public byte[] JobData { get; set; }
        public byte[] JobMachineData { get; set; }
    }
}
