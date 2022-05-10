using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class ToolFixture
    {
        public ToolFixture()
        {
            LaserFrequencies = new HashSet<LaserFrequency>();
            ToolFixtureAxisRels = new HashSet<ToolFixtureAxisRel>();
            ToolToToolFixtureRels = new HashSet<ToolToToolFixtureRel>();
        }

        public long Number { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double? XOffset { get; set; }
        public double? YOffset { get; set; }
        public double? ZOffset { get; set; }
        public long? Calibrated { get; set; }
        public long? ToolIsPersistent { get; set; }
        public long? PersistentToolNumber { get; set; }
        public long? IsAtoolChangeHead { get; set; }
        public double? AirCylinderDelay { get; set; }
        public long? XyMoveFastAtZhigh { get; set; }
        public long? AirCylinderOutputBit { get; set; }
        public long? BottomDelayInputBit { get; set; }
        public long? AirAssistOutputBit { get; set; }
        public string HeightControllerName { get; set; }
        public long? VacuumExtractionOutputBit { get; set; }
        public double? VacuumExtractionStartDelay { get; set; }
        public double? VacuumExtractionEndDelay { get; set; }
        public long? UseVacuumExtractionAutoMode { get; set; }
        public long? ToolOutputBit { get; set; }
        public long? CutOutputBit { get; set; }
        public long? MistOutputBit { get; set; }
        public long? UseMistAutoMode { get; set; }
        public double? ToolStartDelay { get; set; }
        public long? StartToolEarly { get; set; }
        public long? SpindleOutputBit { get; set; }
        public long? SpindleSafetyInputBit { get; set; }
        public double? WarmupTime { get; set; }
        public long? SlaveNumber { get; set; }
        public string InverterType { get; set; }
        public double? DefaultRpm { get; set; }
        public long? UseRpm { get; set; }
        public double? MaxRpm { get; set; }
        public long? RpmInputRegister { get; set; }
        public long? MaxRpmOutputRegister { get; set; }
        public long? OscillatingKnifeOutputBit { get; set; }
        public long? OpenToolClampOutputBit { get; set; }
        public double? ToolClampDelay { get; set; }
        public double? MtcAngle { get; set; }
        public long? KnifeOkInputBit { get; set; }
        public long? SawOutputBit { get; set; }
        public double? Angle { get; set; }
        public double? MaxDutyCycle { get; set; }
        public long? MinPulseWidth { get; set; }
        public long? MaxPulseWidth { get; set; }
        public long? DoFrequencySetting { get; set; }
        public string FrequencyTable { get; set; }
        public long? HasIntensityOutput { get; set; }
        public string LaserModulationType { get; set; }
        public long? LensCoolingOutputBit { get; set; }
        public double? LensCoolingEndDelay { get; set; }
        public long? TurnChillerOnOutputBit { get; set; }
        public long? ActivateChillerOutputBit { get; set; }
        public long? ShutterOutputBit { get; set; }
        public double? ShutterDelay { get; set; }
        public long? ShutterIsClosedInputBit { get; set; }
        public long? ShutterIsOpenInputBit { get; set; }
        public long? AlignmentPointerOutputBit { get; set; }
        public long? YBeamCoverInputBit { get; set; }
        public long? XBeamCoverInputBit { get; set; }
        public long? UnderTableDoorsInputBit { get; set; }
        public long? PowerSupplyOkInputBit { get; set; }
        public long? RfEnableOutputBit { get; set; }
        public double? RfEnableDelay { get; set; }
        public long? RfIsOnInputBit { get; set; }
        public long? PierceGasOutputBit { get; set; }
        public long? CutGasOutputBit { get; set; }
        public long? TurnLaserOnOutputBit { get; set; }
        public long? EngravingCutOutputBit { get; set; }
        public long? OhmicTipTouchEnableOutputBit { get; set; }
        public long? TurnPlasmaOnOutputBit { get; set; }
        public long? ArcOnInputBit { get; set; }
        public long? SensorInputBit { get; set; }
        public long? PrintingFinishedInputBit { get; set; }
        public long? CameraData { get; set; }

        public virtual DigitalOutput ActivateChillerOutputBitNavigation { get; set; }
        public virtual DigitalOutput AirAssistOutputBitNavigation { get; set; }
        public virtual DigitalOutput AirCylinderOutputBitNavigation { get; set; }
        public virtual DigitalOutput AlignmentPointerOutputBitNavigation { get; set; }
        public virtual DigitalInput ArcOnInputBitNavigation { get; set; }
        public virtual DigitalInput BottomDelayInputBitNavigation { get; set; }
        public virtual DigitalOutput CutGasOutputBitNavigation { get; set; }
        public virtual DigitalOutput CutOutputBitNavigation { get; set; }
        public virtual DigitalOutput EngravingCutOutputBitNavigation { get; set; }
        public virtual HeightControlFixture HeightControllerNameNavigation { get; set; }
        public virtual InverterTypeEnum InverterTypeNavigation { get; set; }
        public virtual DigitalInput KnifeOkInputBitNavigation { get; set; }
        public virtual LaserModulationTypeEnum LaserModulationTypeNavigation { get; set; }
        public virtual DigitalOutput LensCoolingOutputBitNavigation { get; set; }
        public virtual DigitalOutput MaxRpmOutputRegisterNavigation { get; set; }
        public virtual DigitalOutput MistOutputBitNavigation { get; set; }
        public virtual DigitalOutput OhmicTipTouchEnableOutputBitNavigation { get; set; }
        public virtual DigitalOutput OpenToolClampOutputBitNavigation { get; set; }
        public virtual DigitalOutput OscillatingKnifeOutputBitNavigation { get; set; }
        public virtual DigitalOutput PierceGasOutputBitNavigation { get; set; }
        public virtual DigitalOutput PowerSupplyOkInputBitNavigation { get; set; }
        public virtual DigitalInput PrintingFinishedInputBitNavigation { get; set; }
        public virtual DigitalOutput RfEnableOutputBitNavigation { get; set; }
        public virtual DigitalOutput RfIsOnInputBitNavigation { get; set; }
        public virtual DigitalInput RpmInputRegisterNavigation { get; set; }
        public virtual DigitalOutput SawOutputBitNavigation { get; set; }
        public virtual DigitalInput SensorInputBitNavigation { get; set; }
        public virtual DigitalOutput ShutterIsClosedInputBitNavigation { get; set; }
        public virtual DigitalOutput ShutterIsOpenInputBitNavigation { get; set; }
        public virtual DigitalOutput ShutterOutputBitNavigation { get; set; }
        public virtual DigitalOutput SpindleOutputBitNavigation { get; set; }
        public virtual DigitalOutput SpindleSafetyInputBitNavigation { get; set; }
        public virtual DigitalOutput ToolOutputBitNavigation { get; set; }
        public virtual DigitalOutput TurnChillerOnOutputBitNavigation { get; set; }
        public virtual DigitalOutput TurnLaserOnOutputBitNavigation { get; set; }
        public virtual DigitalOutput TurnPlasmaOnOutputBitNavigation { get; set; }
        public virtual DigitalOutput UnderTableDoorsInputBitNavigation { get; set; }
        public virtual DigitalOutput VacuumExtractionOutputBitNavigation { get; set; }
        public virtual DigitalOutput XBeamCoverInputBitNavigation { get; set; }
        public virtual DigitalOutput YBeamCoverInputBitNavigation { get; set; }
        public virtual ICollection<LaserFrequency> LaserFrequencies { get; set; }
        public virtual ICollection<ToolFixtureAxisRel> ToolFixtureAxisRels { get; set; }
        public virtual ICollection<ToolToToolFixtureRel> ToolToToolFixtureRels { get; set; }
    }
}
