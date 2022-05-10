using Microsoft.EntityFrameworkCore;
using ProfilerWPF.data.Models.EntityModels;

namespace ProfilerWPF.data.Contexts
{
    public interface IRobotSystemsXS2515SQLiteformat3Context
    {
        int SaveChanges();
         DbSet<AvailableTool> AvailableTools { get; set; }
         DbSet<Axis> Axes { get; set; }
         DbSet<AxisMotorRel> AxisMotorRels { get; set; }
         DbSet<AxisTypeEnum> AxisTypeEnums { get; set; }
         DbSet<DataTypeEnum> DataTypeEnums { get; set; }
         DbSet<DebugLevelTypeEnum> DebugLevelTypeEnums { get; set; }
         DbSet<DigitalInput> DigitalInputs { get; set; }
         DbSet<DigitalOutput> DigitalOutputs { get; set; }
         DbSet<GroupDatum> GroupData { get; set; }
         DbSet<HardwareSimulation> HardwareSimulations { get; set; }
         DbSet<HeightControlFixture> HeightControlFixtures { get; set; }
         DbSet<HeightControlProfile> HeightControlProfiles { get; set; }
         DbSet<HeightControlTypeEnum> HeightControlTypeEnums { get; set; }
         DbSet<InverterTypeEnum> InverterTypeEnums { get; set; }
         DbSet<KeypadTypeEnum> KeypadTypeEnums { get; set; }
         DbSet<LaserAlignment> LaserAlignments { get; set; }
         DbSet<LaserFrequency> LaserFrequencies { get; set; }
         DbSet<LaserIntensity> LaserIntensities { get; set; }
         DbSet<LaserModulationTypeEnum> LaserModulationTypeEnums { get; set; }
         DbSet<Machine> Machines { get; set; }
         DbSet<MachinePropertyVisibility> MachinePropertyVisibilities { get; set; }
         DbSet<Material> Materials { get; set; }
         DbSet<Modbu> Modbus { get; set; }
         DbSet<MotionControl> MotionControls { get; set; }
         DbSet<Motor> Motors { get; set; }
         DbSet<NcGroupTypeEnum> NcGroupTypeEnums { get; set; }
         DbSet<Origin> Origins { get; set; }
         DbSet<ProcedureTypeEnum> ProcedureTypeEnums { get; set; }
         DbSet<Profiler> Profilers { get; set; }
         DbSet<RsmUpgrade> RsmUpgrades { get; set; }
         DbSet<TempMachinePropertyVisibility> TempMachinePropertyVisibilities { get; set; }
         DbSet<Tipoff> Tipoffs { get; set; }
         DbSet<Tool> Tools { get; set; }
         DbSet<ToolChangeTypeEnum> ToolChangeTypeEnums { get; set; }
         DbSet<ToolChanger> ToolChangers { get; set; }
         DbSet<ToolFixture> ToolFixtures { get; set; }
         DbSet<ToolFixtureAxisRel> ToolFixtureAxisRels { get; set; }
         DbSet<ToolFixtureTypeEnum> ToolFixtureTypeEnums { get; set; }
         DbSet<ToolHistory> ToolHistories { get; set; }
         DbSet<ToolProfile> ToolProfiles { get; set; }
         DbSet<ToolReplacement> ToolReplacements { get; set; }
         DbSet<ToolToToolFixtureRel> ToolToToolFixtureRels { get; set; }
         DbSet<VacuumHoldDown> VacuumHoldDowns { get; set; }
         DbSet<ZReference> ZReferences { get; set; }
    }
}
