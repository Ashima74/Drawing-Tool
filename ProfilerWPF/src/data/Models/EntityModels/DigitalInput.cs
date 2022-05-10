using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class DigitalInput
    {
        public DigitalInput()
        {
            Axes = new HashSet<Axis>();
            HeightControlFixtureHighInputBitNavigations = new HashSet<HeightControlFixture>();
            HeightControlFixtureLowInputBitNavigations = new HashSet<HeightControlFixture>();
            MachineExternalJobStartInputBitNavigations = new HashSet<Machine>();
            MachineJig1InputBitNavigations = new HashSet<Machine>();
            MachineJig1OutputBitNavigations = new HashSet<Machine>();
            MachineJig2InputBitNavigations = new HashSet<Machine>();
            MachineJig2OutputBitNavigations = new HashSet<Machine>();
            MachineStopInputBitNavigations = new HashSet<Machine>();
            Motors = new HashSet<Motor>();
            Tipoffs = new HashSet<Tipoff>();
            ToolChangers = new HashSet<ToolChanger>();
            ToolFixtureArcOnInputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureBottomDelayInputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureKnifeOkInputBitNavigations = new HashSet<ToolFixture>();
            ToolFixturePrintingFinishedInputBitNavigations = new HashSet<ToolFixture>();
            ToolFixtureRpmInputRegisterNavigations = new HashSet<ToolFixture>();
            ToolFixtureSensorInputBitNavigations = new HashSet<ToolFixture>();
            VacuumHoldDownVacuumHoldDownOutputBitNavigations = new HashSet<VacuumHoldDown>();
            VacuumHoldDownVacuumHoldDownZoneOutputBitNavigations = new HashSet<VacuumHoldDown>();
        }

        public long Number { get; set; }
        public string Name { get; set; }
        public long? ReverseLogic { get; set; }

        public virtual ICollection<Axis> Axes { get; set; }
        public virtual ICollection<HeightControlFixture> HeightControlFixtureHighInputBitNavigations { get; set; }
        public virtual ICollection<HeightControlFixture> HeightControlFixtureLowInputBitNavigations { get; set; }
        public virtual ICollection<Machine> MachineExternalJobStartInputBitNavigations { get; set; }
        public virtual ICollection<Machine> MachineJig1InputBitNavigations { get; set; }
        public virtual ICollection<Machine> MachineJig1OutputBitNavigations { get; set; }
        public virtual ICollection<Machine> MachineJig2InputBitNavigations { get; set; }
        public virtual ICollection<Machine> MachineJig2OutputBitNavigations { get; set; }
        public virtual ICollection<Machine> MachineStopInputBitNavigations { get; set; }
        public virtual ICollection<Motor> Motors { get; set; }
        public virtual ICollection<Tipoff> Tipoffs { get; set; }
        public virtual ICollection<ToolChanger> ToolChangers { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureArcOnInputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureBottomDelayInputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureKnifeOkInputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixturePrintingFinishedInputBitNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureRpmInputRegisterNavigations { get; set; }
        public virtual ICollection<ToolFixture> ToolFixtureSensorInputBitNavigations { get; set; }
        public virtual ICollection<VacuumHoldDown> VacuumHoldDownVacuumHoldDownOutputBitNavigations { get; set; }
        public virtual ICollection<VacuumHoldDown> VacuumHoldDownVacuumHoldDownZoneOutputBitNavigations { get; set; }
    }
}
