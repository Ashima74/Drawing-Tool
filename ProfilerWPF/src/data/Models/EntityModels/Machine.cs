#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class Machine
    {
        public long Number { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string BoardName { get; set; }
        public string IpAddress { get; set; }
        public string LengthUnits { get; set; }
        public string AngleUnits { get; set; }
        public long? MonitorServoDrivesFailure { get; set; }
        public long? StopInputBit { get; set; }
        public long? JobRunningOutputBit { get; set; }
        public long? RedLightOutputBit { get; set; }
        public long? AmberLightOutputBit { get; set; }
        public long? GreenLightOutputBit { get; set; }
        public long? VacuumExtractionOutputBit { get; set; }
        public double? VacuumExtractionStartDelay { get; set; }
        public double? VacuumExtractionEndDelay { get; set; }
        public long? UseVacuumExtractionAutoMode { get; set; }
        public long? ExternalJobStartInputBit { get; set; }
        public long? UseExternalJobStartInput { get; set; }
        public long? Jig1InputBit { get; set; }
        public long? Jig2InputBit { get; set; }
        public long? Jig1OutputBit { get; set; }
        public long? Jig2OutputBit { get; set; }
        public long? UseTwoJigs { get; set; }
        public double? JigDividerPosition { get; set; }
        public long? KeypadRepeatKeyTimeout { get; set; }
        public long? KeypadFastRepeatKeyTimeout { get; set; }
        public long? UseFastRepeatKeyTimeout { get; set; }
        public string KeypadType { get; set; }
        public long? KpComPort { get; set; }
        public long? KpBaudRate { get; set; }
        public double? PermissibleHomingErrorDistance { get; set; }
        public double? PermissibleHomingErrorAngle { get; set; }

        public virtual DigitalOutput AmberLightOutputBitNavigation { get; set; }
        public virtual DigitalInput ExternalJobStartInputBitNavigation { get; set; }
        public virtual DigitalOutput GreenLightOutputBitNavigation { get; set; }
        public virtual DigitalInput Jig1InputBitNavigation { get; set; }
        public virtual DigitalInput Jig1OutputBitNavigation { get; set; }
        public virtual DigitalInput Jig2InputBitNavigation { get; set; }
        public virtual DigitalInput Jig2OutputBitNavigation { get; set; }
        public virtual DigitalOutput JobRunningOutputBitNavigation { get; set; }
        public virtual KeypadTypeEnum KeypadTypeNavigation { get; set; }
        public virtual DigitalOutput RedLightOutputBitNavigation { get; set; }
        public virtual DigitalInput StopInputBitNavigation { get; set; }
        public virtual DigitalOutput VacuumExtractionOutputBitNavigation { get; set; }
    }
}
