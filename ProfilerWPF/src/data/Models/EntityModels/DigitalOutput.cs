using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class DigitalOutput
    {
        public DigitalOutput()
        {
            MachineAmberLightOutputBitNavigations = new HashSet<Machine>();
            MachineGreenLightOutputBitNavigations = new HashSet<Machine>();
            MachineJobRunningOutputBitNavigations = new HashSet<Machine>();
            MachineRedLightOutputBitNavigations = new HashSet<Machine>();
            MachineVacuumExtractionOutputBitNavigations = new HashSet<Machine>();
            MotorBrakeOffOutputBitNavigations = new HashSet<Motor>();
            MotorEnableOutputBitNavigations = new HashSet<Motor>();
            ToolChangers = new HashSet<ToolChanger>();
            ToolFixtureActivateChillerOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureAirAssistOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureAirCylinderOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureAlignmentPointerOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureCutGasOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureCutOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureEngravingCutOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureLensCoolingOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureMaxRpmOutputRegisterNavigations = new HashSet<ToolFixture>();
            ToolFixtureMistOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureOhmicTipTouchEnableOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureOpenToolClampOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureOscillatingKnifeOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixturePierceGasOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixturePowerSupplyOkInputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureRfEnableOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureRfIsOnInputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureSawOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureShutterIsClosedInputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureShutterIsOpenInputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureShutterOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureSpindleOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureSpindleSafetyInputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureToolOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureTurnChillerOnOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureTurnLaserOnOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureTurnPlasmaOnOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureUnderTableDoorsInputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureVacuumExtractionOutputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureXBeamCoverInputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureYBeamCoverInputBitNavigations = new HashSet<ToolFixture>();
        }

        public long Number { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Machine> MachineAmberLightOutputBitNavigations { get; set; }
        public virtual ICollection<Machine> MachineGreenLightOutputBitNavigations { get; set; }
        public virtual ICollection<Machine> MachineJobRunningOutputBitNavigations { get; set; }
        public virtual ICollection<Machine> MachineRedLightOutputBitNavigations { get; set; }
        public virtual ICollection<Machine> MachineVacuumExtractionOutputBitNavigations { get; set; }
        public virtual ICollection<Motor> MotorBrakeOffOutputBitNavigations { get; set; }
        public virtual ICollection<Motor> MotorEnableOutputBitNavigations { get; set; }
        public virtual ICollection<ToolChanger> ToolChangers { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureActivateChillerOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureAirAssistOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureAirCylinderOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureAlignmentPointerOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureCutGasOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureCutOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureEngravingCutOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureLensCoolingOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureMaxRpmOutputRegisterNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureMistOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureOhmicTipTouchEnableOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureOpenToolClampOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureOscillatingKnifeOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixturePierceGasOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixturePowerSupplyOkInputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureRfEnableOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureRfIsOnInputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureSawOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureShutterIsClosedInputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureShutterIsOpenInputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureShutterOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureSpindleOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureSpindleSafetyInputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureToolOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureTurnChillerOnOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureTurnLaserOnOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureTurnPlasmaOnOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureUnderTableDoorsInputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureVacuumExtractionOutputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureXBeamCoverInputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureYBeamCoverInputBitNavigations { get; set; }
    }
}
