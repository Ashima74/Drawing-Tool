#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class VacuumHoldDown
    {
        public long Number { get; set; }
        public string Name { get; set; }
        public long? VacuumHoldDownOutputBit { get; set; }
        public long? VacuumHoldDownZoneOutputBit { get; set; }
        public double? StartDelay { get; set; }
        public long? UseAutoVacuum { get; set; }
        public long? UseAutoVacuumZones { get; set; }
        public double? XBottomLeftZone { get; set; }
        public double? YBottomLeftZone { get; set; }
        public double? ZoneWidth { get; set; }
        public double? ZoneHeight { get; set; }

        public virtual DigitalInput VacuumHoldDownOutputBitNavigation { get; set; }
        public virtual DigitalInput VacuumHoldDownZoneOutputBitNavigation { get; set; }
    }
}
