#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class Modbu
    {
        public long Number { get; set; }
        public string Name { get; set; }
        public long? ModBusComPort { get; set; }
        public long? ModBusBaudRate { get; set; }
        public long? ModBusDtr { get; set; }
        public long? ModBusParity { get; set; }
        public long? ModBusStopBits { get; set; }
        public long? ModBusResponseTimeout { get; set; }
        public long? ModBusRetries { get; set; }
        public string ModBusProtocol { get; set; }
    }
}
