using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class HeightControlFixture
    {
        public HeightControlFixture()
        {
            ToolFixtures = new HashSet<ToolFixture>();
        }

        public long Number { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public long? AxisType { get; set; }
        public double? MaxSpeed { get; set; }
        public double? MaxAccel { get; set; }
        public long? HighInputBit { get; set; }
        public long? LowInputBit { get; set; }
        public long? UseHardwareAdc { get; set; }
        public long? SerialHeightControlPort { get; set; }
        public long? SerialHeightControlBaudRate { get; set; }
        public long? InputMinValue { get; set; }
        public long? InputMaxValue { get; set; }
        public long? FixtureSetPoint { get; set; }
        public double? InputControlScale { get; set; }
        public double? Kp { get; set; }
        public double? Kd { get; set; }
        public double? Ki { get; set; }
        public double? HcCheckAccuracy { get; set; }
        public long? HcSaveMeasurements { get; set; }
        public long? HcWaitingMeasurementMs { get; set; }
        public long? HcDuringMeasurementMs { get; set; }
        public long? ReferencePoint { get; set; }
        public double? ReferenceVoltageStepSize { get; set; }
        public double? SetPointVoltageStepSize { get; set; }
        public double? MaxVoltage { get; set; }
        public double? FineVoltageSteps { get; set; }
        public double? VoltageLinearOffsetFudge { get; set; }
        public double? VoltageLinearSlopeFudge { get; set; }

        public virtual AxisTypeEnum AxisTypeNavigation { get; set; }
        public virtual DigitalInput HighInputBitNavigation { get; set; }
        public virtual DigitalInput LowInputBitNavigation { get; set; }
        public virtual HeightControlTypeEnum TypeNavigation { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtures { get; set; }
    }
}
