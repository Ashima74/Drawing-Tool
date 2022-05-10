using Microsoft.EntityFrameworkCore;
using ProfilerWPF.data.Models.EntityModels;

namespace ProfilerWPF.data.Contexts
{
    public partial class RobotSystemsXS2515SQLiteformat3Context : DbContext, IRobotSystemsXS2515SQLiteformat3Context
    {
        private readonly ISqlLiteSettings _settings;

        public RobotSystemsXS2515SQLiteformat3Context(ISqlLiteSettings settings)
        {
            _settings = settings;
        }

        public RobotSystemsXS2515SQLiteformat3Context(DbContextOptions<RobotSystemsXS2515SQLiteformat3Context> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies().UseSqlite(_settings.GetConnectionString());

            }
        }

        public virtual DbSet<AvailableTool> AvailableTools { get; set; }
        public virtual DbSet<Axis> Axes { get; set; }
        public virtual DbSet<AxisMotorRel> AxisMotorRels { get; set; }
        public virtual DbSet<AxisTypeEnum> AxisTypeEnums { get; set; }
        public virtual DbSet<DataTypeEnum> DataTypeEnums { get; set; }
        public virtual DbSet<DebugLevelTypeEnum> DebugLevelTypeEnums { get; set; }
        public virtual DbSet<DigitalInput> DigitalInputs { get; set; }
        public virtual DbSet<DigitalOutput> DigitalOutputs { get; set; }
        public virtual DbSet<GroupDatum> GroupData { get; set; }
        public virtual DbSet<HardwareSimulation> HardwareSimulations { get; set; }
        public virtual DbSet<HeightControlFixture> HeightControlFixtures { get; set; }
        public virtual DbSet<HeightControlProfile> HeightControlProfiles { get; set; }
        public virtual DbSet<HeightControlTypeEnum> HeightControlTypeEnums { get; set; }
        public virtual DbSet<InverterTypeEnum> InverterTypeEnums { get; set; }
        public virtual DbSet<KeypadTypeEnum> KeypadTypeEnums { get; set; }
        public virtual DbSet<LaserAlignment> LaserAlignments { get; set; }
        public virtual DbSet<LaserFrequency> LaserFrequencies { get; set; }
        public virtual DbSet<LaserIntensity> LaserIntensities { get; set; }
        public virtual DbSet<LaserModulationTypeEnum> LaserModulationTypeEnums { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<MachinePropertyVisibility> MachinePropertyVisibilities { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Modbu> Modbus { get; set; }
        public virtual DbSet<MotionControl> MotionControls { get; set; }
        public virtual DbSet<Motor> Motors { get; set; }
        public virtual DbSet<NcGroupTypeEnum> NcGroupTypeEnums { get; set; }
        public virtual DbSet<Origin> Origins { get; set; }
        public virtual DbSet<ProcedureTypeEnum> ProcedureTypeEnums { get; set; }
        public virtual DbSet<Profiler> Profilers { get; set; }
        public virtual DbSet<RsmUpgrade> RsmUpgrades { get; set; }
        public virtual DbSet<TempMachinePropertyVisibility> TempMachinePropertyVisibilities { get; set; }
        public virtual DbSet<Tipoff> Tipoffs { get; set; }
        public virtual DbSet<Tool> Tools { get; set; }
        public virtual DbSet<ToolChangeTypeEnum> ToolChangeTypeEnums { get; set; }
        public virtual DbSet<ToolChanger> ToolChangers { get; set; }
        public virtual DbSet<ToolFixture> ToolFixtures { get; set; }
        public virtual DbSet<ToolFixtureAxisRel> ToolFixtureAxisRels { get; set; }
        public virtual DbSet<ToolFixtureTypeEnum> ToolFixtureTypeEnums { get; set; }
        public virtual DbSet<ToolHistory> ToolHistories { get; set; }
        public virtual DbSet<ToolProfile> ToolProfiles { get; set; }
        public virtual DbSet<ToolReplacement> ToolReplacements { get; set; }
        public virtual DbSet<ToolToToolFixtureRel> ToolToToolFixtureRels { get; set; }
        public virtual DbSet<VacuumHoldDown> VacuumHoldDowns { get; set; }
        public virtual DbSet<ZReference> ZReferences { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvailableTool>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("availableTool");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.IsCalibrated).HasColumnName("isCalibrated");

                entity.Property(e => e.SlotNum).HasColumnName("slotNum");

                entity.Property(e => e.ToolChangerNumber).HasColumnName("toolChangerNumber");

                entity.Property(e => e.ToolNumber).HasColumnName("toolNumber");

                entity.Property(e => e.ZDisplacement).HasColumnName("zDisplacement");

                entity.HasOne(d => d.ToolChangerNumberNavigation)
                    .WithMany(p => p.AvailableTools)
                    .HasForeignKey(d => d.ToolChangerNumber)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ToolNumberNavigation)
                    .WithMany(p => p.AvailableTools)
                    .HasForeignKey(d => d.ToolNumber)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Axis>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("axis");

                entity.HasIndex(e => e.Name, "IX_axis_name")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.DistOffHomeSwitch).HasColumnName("distOffHomeSwitch");

                entity.Property(e => e.FastHomingSpeed).HasColumnName("fastHomingSpeed");

                entity.Property(e => e.HomeHasBeenFoundOnAxis).HasColumnName("homeHasBeenFoundOnAxis");

                entity.Property(e => e.HomeMotorsSeparately).HasColumnName("homeMotorsSeparately");

                entity.Property(e => e.HomeSwitchAtAxisMin).HasColumnName("homeSwitchAtAxisMin");

                entity.Property(e => e.HomingAcceleration).HasColumnName("homingAcceleration");

                entity.Property(e => e.HomingInputBit).HasColumnName("homingInputBit");

                entity.Property(e => e.LastHomingDifference).HasColumnName("lastHomingDifference");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.LimitMoves).HasColumnName("limitMoves");

                entity.Property(e => e.MaxAccel).HasColumnName("maxAccel");

                entity.Property(e => e.MaxCutAccel).HasColumnName("maxCutAccel");

                entity.Property(e => e.MaxJogAccel).HasColumnName("maxJogAccel");

                entity.Property(e => e.MaxJogSpeed).HasColumnName("maxJogSpeed");

                entity.Property(e => e.MaxSpeed).HasColumnName("maxSpeed");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Scale).HasColumnName("scale");

                entity.Property(e => e.SlowHomingSpeed).HasColumnName("slowHomingSpeed");

                entity.Property(e => e.TypeNum).HasColumnName("typeNum");

                entity.Property(e => e.UseSlowHoming).HasColumnName("useSlowHoming");

                entity.HasOne(d => d.HomingInputBitNavigation)
                    .WithMany(p => p.Axes)
                    .HasForeignKey(d => d.HomingInputBit)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AxisMotorRel>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("axisMotorRel");

                entity.HasIndex(e => new { e.AxisNumber, e.MotorNumber }, "IX_axisMotorRel_axisNumber_motorNumber")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.AxisNumber).HasColumnName("axisNumber");

                entity.Property(e => e.MotorNumber).HasColumnName("motorNumber");

                entity.HasOne(d => d.AxisNumberNavigation)
                    .WithMany(p => p.AxisMotorRels)
                    .HasForeignKey(d => d.AxisNumber)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.MotorNumberNavigation)
                    .WithMany(p => p.AxisMotorRels)
                    .HasForeignKey(d => d.MotorNumber)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AxisTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("axisTypeEnum");

                entity.HasIndex(e => e.Type, "IX_axisTypeEnum_type")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<DataTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("dataTypeEnum");

                entity.HasIndex(e => e.Type, "IX_dataTypeEnum_type")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<DebugLevelTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("debugLevelTypeEnum");

                entity.HasIndex(e => e.Type, "IX_debugLevelTypeEnum_type")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<DigitalInput>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("digitalInput");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ReverseLogic).HasColumnName("reverseLogic");
            });

            modelBuilder.Entity<DigitalOutput>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("digitalOutput");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<GroupDatum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("groupData");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Colour).HasColumnName("colour");

                entity.Property(e => e.DepthType).HasColumnName("depthType");

                entity.Property(e => e.DoDoubleOffset).HasColumnName("doDoubleOffset");

                entity.Property(e => e.IsOn).HasColumnName("isOn");

                entity.Property(e => e.LastPassOffset).HasColumnName("lastPassOffset");

                entity.Property(e => e.LeadInAngle).HasColumnName("leadInAngle");

                entity.Property(e => e.LeadInLength).HasColumnName("leadInLength");

                entity.Property(e => e.LeadOutAngle).HasColumnName("leadOutAngle");

                entity.Property(e => e.LeadOutLength).HasColumnName("leadOutLength");

                entity.Property(e => e.Material).HasColumnName("material");

                entity.Property(e => e.MmDepth).HasColumnName("mmDepth");

                entity.Property(e => e.MpassDepthPp).HasColumnName("mpassDepthPP");

                entity.Property(e => e.MpassLast).HasColumnName("mpassLast");

                entity.Property(e => e.MpassStartDepth).HasColumnName("mpassStartDepth");

                entity.Property(e => e.MpassThick).HasColumnName("mpassThick");

                entity.Property(e => e.Multipass).HasColumnName("multipass");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NumOffsets).HasColumnName("numOffsets");

                entity.Property(e => e.OffsetAdjustment).HasColumnName("offsetAdjustment");

                entity.Property(e => e.Parent).HasColumnName("parent");

                entity.Property(e => e.ReverseShapeForCutting).HasColumnName("reverseShapeForCutting");

                entity.Property(e => e.TagLength).HasColumnName("tagLength");

                entity.Property(e => e.ToolProfileNumber).HasColumnName("toolProfileNumber");

                entity.Property(e => e.Traverse).HasColumnName("traverse");

                entity.Property(e => e.UseLineTypeLeads).HasColumnName("useLineTypeLeads");

                entity.Property(e => e.UseRampTypeLeads).HasColumnName("useRampTypeLeads");

                entity.HasOne(d => d.MaterialNavigation)
                    .WithMany(p => p.GroupData)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Material)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ToolProfileNumberNavigation)
                    .WithMany(p => p.GroupData)
                    .HasForeignKey(d => d.ToolProfileNumber)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<HardwareSimulation>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("hardwareSimulation");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.AxisNumber).HasColumnName("axisNumber");

                entity.Property(e => e.InputBit).HasColumnName("inputBit");

                entity.Property(e => e.InputBit2).HasColumnName("inputBit2");

                entity.Property(e => e.Mx).HasColumnName("mx");

                entity.Property(e => e.My).HasColumnName("my");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OffDirIsNeg).HasColumnName("offDirIsNeg");

                entity.Property(e => e.SearchPosition).HasColumnName("searchPosition");

                entity.Property(e => e.SearchPositionOffset).HasColumnName("searchPositionOffset");

                entity.Property(e => e.SurfaceType).HasColumnName("surfaceType");

                entity.Property(e => e.TipoffPosition).HasColumnName("tipoffPosition");

                entity.Property(e => e.TipoffToolLengthFactor).HasColumnName("tipoffToolLengthFactor");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.XStepHeight).HasColumnName("xStepHeight");

                entity.Property(e => e.XStepPosition).HasColumnName("xStepPosition");

                entity.Property(e => e.ZAtX0y0).HasColumnName("zAtX0Y0");
            });

            modelBuilder.Entity<HeightControlFixture>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("heightControlFixture");

                entity.HasIndex(e => e.Name, "IX_heightControlFixture_name")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.AxisType).HasColumnName("axisType");

                entity.Property(e => e.FineVoltageSteps).HasColumnName("fineVoltageSteps");

                entity.Property(e => e.FixtureSetPoint).HasColumnName("fixtureSetPoint");

                entity.Property(e => e.HcCheckAccuracy).HasColumnName("hcCheckAccuracy");

                entity.Property(e => e.HcDuringMeasurementMs).HasColumnName("hcDuringMeasurementMs");

                entity.Property(e => e.HcSaveMeasurements).HasColumnName("hcSaveMeasurements");

                entity.Property(e => e.HcWaitingMeasurementMs).HasColumnName("hcWaitingMeasurementMs");

                entity.Property(e => e.HighInputBit).HasColumnName("highInputBit");

                entity.Property(e => e.InputControlScale).HasColumnName("inputControlScale");

                entity.Property(e => e.InputMaxValue).HasColumnName("inputMaxValue");

                entity.Property(e => e.InputMinValue).HasColumnName("inputMinValue");

                entity.Property(e => e.LowInputBit).HasColumnName("lowInputBit");

                entity.Property(e => e.MaxAccel).HasColumnName("maxAccel");

                entity.Property(e => e.MaxSpeed).HasColumnName("maxSpeed");

                entity.Property(e => e.MaxVoltage).HasColumnName("maxVoltage");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.ReferencePoint).HasColumnName("referencePoint");

                entity.Property(e => e.ReferenceVoltageStepSize).HasColumnName("referenceVoltageStepSize");

                entity.Property(e => e.SerialHeightControlPort).HasColumnName("serialHeightControlPort");

                entity.Property(e => e.SetPointVoltageStepSize).HasColumnName("setPointVoltageStepSize");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UseHardwareAdc).HasColumnName("useHardwareADC");

                entity.Property(e => e.VoltageLinearOffsetFudge).HasColumnName("voltageLinearOffsetFudge");

                entity.Property(e => e.VoltageLinearSlopeFudge).HasColumnName("voltageLinearSlopeFudge");

                entity.HasOne(d => d.AxisTypeNavigation)
                    .WithMany(p => p.HeightControlFixtures)
                    .HasForeignKey(d => d.AxisType)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.HighInputBitNavigation)
                    .WithMany(p => p.HeightControlFixtureHighInputBitNavigations)
                    .HasForeignKey(d => d.HighInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.LowInputBitNavigation)
                    .WithMany(p => p.HeightControlFixtureLowInputBitNavigations)
                    .HasForeignKey(d => d.LowInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.HeightControlFixtures)
                    .HasPrincipalKey(p => p.Type)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<HeightControlProfile>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("heightControlProfile");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Accel).HasColumnName("accel");

                entity.Property(e => e.DoHeightControlBetweenShapes).HasColumnName("doHeightControlBetweenShapes");

                entity.Property(e => e.MinimumCutspeedFactor).HasColumnName("minimumCutspeedFactor");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PlungeDetectionAngle).HasColumnName("plungeDetectionAngle");

                entity.Property(e => e.PlungeDetectionFilterSize).HasColumnName("plungeDetectionFilterSize");

                entity.Property(e => e.PlungeDetectionOffDistance).HasColumnName("plungeDetectionOffDistance");

                entity.Property(e => e.ReferencePoint).HasColumnName("referencePoint");

                entity.Property(e => e.SetPoint).HasColumnName("setPoint");

                entity.Property(e => e.SetPointAdjustment).HasColumnName("setPointAdjustment");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.StartDelay).HasColumnName("startDelay");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Voltage).HasColumnName("voltage");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.HeightControlProfiles)
                    .HasPrincipalKey(p => p.Type)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<HeightControlTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("heightControlTypeEnum");

                entity.HasIndex(e => e.Type, "IX_heightControlTypeEnum_type")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<InverterTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("inverterTypeEnum");

                entity.HasIndex(e => e.Type, "IX_inverterTypeEnum_type")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<KeypadTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("keypadTypeEnum");

                entity.HasIndex(e => e.Type, "IX_keypadTypeEnum_type")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<LaserAlignment>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("laserAlignment");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.AxisAorientation).HasColumnName("axisAOrientation");

                entity.Property(e => e.AxisBorientation).HasColumnName("axisBOrientation");

                entity.Property(e => e.LaserAlignmentAccuracy).HasColumnName("laserAlignmentAccuracy");

                entity.Property(e => e.LaserSettlingTimeMs).HasColumnName("laserSettlingTimeMs");

                entity.Property(e => e.ServerAddress).HasColumnName("serverAddress");
            });

            modelBuilder.Entity<LaserFrequency>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("laserFrequency");

                entity.HasIndex(e => e.Frequency, "IX_laserFrequency_frequency")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.FrequencyCode).HasColumnName("frequencyCode");

                entity.Property(e => e.TableIndex).HasColumnName("tableIndex");

                entity.Property(e => e.ToolFixtureNumber).HasColumnName("toolFixtureNumber");

                entity.HasOne(d => d.ToolFixtureNumberNavigation)
                    .WithMany(p => p.LaserFrequencies)
                    .HasForeignKey(d => d.ToolFixtureNumber);
            });

            modelBuilder.Entity<LaserIntensity>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("laserIntensity");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Intensity).HasColumnName("intensity");

                entity.Property(e => e.TableIndex).HasColumnName("tableIndex");

                entity.Property(e => e.ToolProfileNumber).HasColumnName("toolProfileNumber");

                entity.HasOne(d => d.ToolProfileNumberNavigation)
                    .WithMany(p => p.LaserIntensities)
                    .HasForeignKey(d => d.ToolProfileNumber);
            });

            modelBuilder.Entity<LaserModulationTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("laserModulationTypeEnum");

                entity.HasIndex(e => e.Type, "IX_laserModulationTypeEnum_type")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("machine");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.AmberLightOutputBit).HasColumnName("amberLightOutputBit");

                entity.Property(e => e.AngleUnits).HasColumnName("angleUnits");

                entity.Property(e => e.BoardName).HasColumnName("boardName");

                entity.Property(e => e.ExternalJobStartInputBit).HasColumnName("externalJobStartInputBit");

                entity.Property(e => e.GreenLightOutputBit).HasColumnName("greenLightOutputBit");

                entity.Property(e => e.IpAddress).HasColumnName("ipAddress");

                entity.Property(e => e.Jig1InputBit).HasColumnName("jig1InputBit");

                entity.Property(e => e.Jig1OutputBit).HasColumnName("jig1OutputBit");

                entity.Property(e => e.Jig2InputBit).HasColumnName("jig2InputBit");

                entity.Property(e => e.Jig2OutputBit).HasColumnName("jig2OutputBit");

                entity.Property(e => e.JigDividerPosition).HasColumnName("jigDividerPosition");

                entity.Property(e => e.JobRunningOutputBit).HasColumnName("jobRunningOutputBit");

                entity.Property(e => e.KeypadFastRepeatKeyTimeout).HasColumnName("keypadFastRepeatKeyTimeout");

                entity.Property(e => e.KeypadRepeatKeyTimeout).HasColumnName("keypadRepeatKeyTimeout");

                entity.Property(e => e.KeypadType).HasColumnName("keypadType");

                entity.Property(e => e.KpBaudRate).HasColumnName("kpBaudRate");

                entity.Property(e => e.KpComPort).HasColumnName("kpComPort");

                entity.Property(e => e.LengthUnits).HasColumnName("lengthUnits");

                entity.Property(e => e.MonitorServoDrivesFailure).HasColumnName("monitorServoDrivesFailure");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PermissibleHomingErrorAngle).HasColumnName("permissibleHomingErrorAngle");

                entity.Property(e => e.PermissibleHomingErrorDistance).HasColumnName("permissibleHomingErrorDistance");

                entity.Property(e => e.RedLightOutputBit).HasColumnName("redLightOutputBit");

                entity.Property(e => e.StopInputBit).HasColumnName("stopInputBit");

                entity.Property(e => e.UseExternalJobStartInput).HasColumnName("useExternalJobStartInput");

                entity.Property(e => e.UseFastRepeatKeyTimeout).HasColumnName("useFastRepeatKeyTimeout");

                entity.Property(e => e.UseTwoJigs).HasColumnName("useTwoJigs");

                entity.Property(e => e.UseVacuumExtractionAutoMode).HasColumnName("useVacuumExtractionAutoMode");

                entity.Property(e => e.VacuumExtractionEndDelay).HasColumnName("vacuumExtractionEndDelay");

                entity.Property(e => e.VacuumExtractionOutputBit).HasColumnName("vacuumExtractionOutputBit");

                entity.Property(e => e.VacuumExtractionStartDelay).HasColumnName("vacuumExtractionStartDelay");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.AmberLightOutputBitNavigation)
                    .WithMany(p => p.MachineAmberLightOutputBitNavigations)
                    .HasForeignKey(d => d.AmberLightOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ExternalJobStartInputBitNavigation)
                    .WithMany(p => p.MachineExternalJobStartInputBitNavigations)
                    .HasForeignKey(d => d.ExternalJobStartInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.GreenLightOutputBitNavigation)
                    .WithMany(p => p.MachineGreenLightOutputBitNavigations)
                    .HasForeignKey(d => d.GreenLightOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Jig1InputBitNavigation)
                    .WithMany(p => p.MachineJig1InputBitNavigations)
                    .HasForeignKey(d => d.Jig1InputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Jig1OutputBitNavigation)
                    .WithMany(p => p.MachineJig1OutputBitNavigations)
                    .HasForeignKey(d => d.Jig1OutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Jig2InputBitNavigation)
                    .WithMany(p => p.MachineJig2InputBitNavigations)
                    .HasForeignKey(d => d.Jig2InputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Jig2OutputBitNavigation)
                    .WithMany(p => p.MachineJig2OutputBitNavigations)
                    .HasForeignKey(d => d.Jig2OutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.JobRunningOutputBitNavigation)
                    .WithMany(p => p.MachineJobRunningOutputBitNavigations)
                    .HasForeignKey(d => d.JobRunningOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.KeypadTypeNavigation)
                    .WithMany(p => p.Machines)
                    .HasPrincipalKey(p => p.Type)
                    .HasForeignKey(d => d.KeypadType)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.RedLightOutputBitNavigation)
                    .WithMany(p => p.MachineRedLightOutputBitNavigations)
                    .HasForeignKey(d => d.RedLightOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.StopInputBitNavigation)
                    .WithMany(p => p.MachineStopInputBitNavigations)
                    .HasForeignKey(d => d.StopInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.VacuumExtractionOutputBitNavigation)
                    .WithMany(p => p.MachineVacuumExtractionOutputBitNavigations)
                    .HasForeignKey(d => d.VacuumExtractionOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<MachinePropertyVisibility>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("machinePropertyVisibility");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.Property).HasColumnName("property");

                entity.Property(e => e.TableName).HasColumnName("tableName");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Visible).HasColumnName("visible");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("material");

                entity.HasIndex(e => e.Name, "IX_material_name")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Modbu>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("modbus");

                entity.HasIndex(e => e.Name, "IX_modbus_name")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.ModBusBaudRate).HasColumnName("modBusBaudRate");

                entity.Property(e => e.ModBusComPort).HasColumnName("modBusComPort");

                entity.Property(e => e.ModBusDtr).HasColumnName("modBusDtr");

                entity.Property(e => e.ModBusParity).HasColumnName("modBusParity");

                entity.Property(e => e.ModBusProtocol).HasColumnName("modBusProtocol");

                entity.Property(e => e.ModBusResponseTimeout).HasColumnName("modBusResponseTimeout");

                entity.Property(e => e.ModBusRetries).HasColumnName("modBusRetries");

                entity.Property(e => e.ModBusStopBits).HasColumnName("modBusStopBits");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<MotionControl>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("motionControl");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.ArrowAccelPercent).HasColumnName("arrowAccelPercent");

                entity.Property(e => e.ArrowSpeedPercent).HasColumnName("arrowSpeedPercent");

                entity.Property(e => e.CentripetalAccelPercent).HasColumnName("centripetalAccelPercent");

                entity.Property(e => e.ConcurrentAngle).HasColumnName("concurrentAngle");

                entity.Property(e => e.LinearStartStopVelocity).HasColumnName("linearStartStopVelocity");

                entity.Property(e => e.MaxJerk).HasColumnName("maxJerk");

                entity.Property(e => e.MaxMuPerSec).HasColumnName("maxMuPerSec");

                entity.Property(e => e.MinChangeSpeedDistance).HasColumnName("minChangeSpeedDistance");

                entity.Property(e => e.RaiseOnPause).HasColumnName("raiseOnPause");

                entity.Property(e => e.RotationalStartStopVelocity).HasColumnName("rotationalStartStopVelocity");

                entity.Property(e => e.SmoothAnglesLessThan).HasColumnName("smoothAnglesLessThan");

                entity.Property(e => e.SmoothMaxError).HasColumnName("smoothMaxError");

                entity.Property(e => e.SmoothingFactor).HasColumnName("smoothingFactor");

                entity.Property(e => e.SplineArcError).HasColumnName("splineArcError");

                entity.Property(e => e.StepsPerMm).HasColumnName("stepsPerMM");

                entity.Property(e => e.StopAngle).HasColumnName("stopAngle");

                entity.Property(e => e.ToleranceAngle).HasColumnName("toleranceAngle");

                entity.Property(e => e.YAxisCuttingSpeedFactor).HasColumnName("yAxisCuttingSpeedFactor");
            });

            modelBuilder.Entity<Motor>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("motor");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.BrakeOffOutputBit).HasColumnName("brakeOffOutputBit");

                entity.Property(e => e.DirectionDelay).HasColumnName("directionDelay");

                entity.Property(e => e.EnableOutputBit).HasColumnName("enableOutputBit");

                entity.Property(e => e.FailInputBit).HasColumnName("failInputBit");

                entity.Property(e => e.InvertStep).HasColumnName("invertStep");

                entity.Property(e => e.MonitorFailure).HasColumnName("monitorFailure");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ReverseDirection).HasColumnName("reverseDirection");

                entity.Property(e => e.StepDelay).HasColumnName("stepDelay");

                entity.HasOne(d => d.BrakeOffOutputBitNavigation)
                    .WithMany(p => p.MotorBrakeOffOutputBitNavigations)
                    .HasForeignKey(d => d.BrakeOffOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.EnableOutputBitNavigation)
                    .WithMany(p => p.MotorEnableOutputBitNavigations)
                    .HasForeignKey(d => d.EnableOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.FailInputBitNavigation)
                    .WithMany(p => p.Motors)
                    .HasForeignKey(d => d.FailInputBit)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<NcGroupTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("ncGroupTypeEnum");

                entity.HasIndex(e => e.Type, "IX_ncGroupTypeEnum_type")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Origin>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("origin");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.UseWasteBoard).HasColumnName("useWasteBoard");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<ProcedureTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("procedureTypeEnum");

                entity.HasIndex(e => e.Type, "IX_procedureTypeEnum_type")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Profiler>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("profiler");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.AllowConfiguration).HasColumnName("allowConfiguration");

                entity.Property(e => e.ChangeJobOriginAtStart).HasColumnName("changeJobOriginAtStart");

                entity.Property(e => e.DebugLevel).HasColumnName("debugLevel");

                entity.Property(e => e.DisplayAllGroups).HasColumnName("displayAllGroups");

                entity.Property(e => e.DisplayMachiningSections).HasColumnName("displayMachiningSections");

                entity.Property(e => e.DisplayShapesUsingGroupColour).HasColumnName("displayShapesUsingGroupColour");

                entity.Property(e => e.DoDoubleJobStart).HasColumnName("doDoubleJobStart");

                entity.Property(e => e.DrawData).HasColumnName("drawData");

                entity.Property(e => e.DrawDataBoundingBox).HasColumnName("drawDataBoundingBox");

                entity.Property(e => e.DrawLastPassOffsetPaths).HasColumnName("drawLastPassOffsetPaths");

                entity.Property(e => e.DrawMachineBounds).HasColumnName("drawMachineBounds");

                entity.Property(e => e.DrawMachiningPath).HasColumnName("drawMachiningPath");

                entity.Property(e => e.DrawSmoothedPaths).HasColumnName("drawSmoothedPaths");

                entity.Property(e => e.DrawVertices).HasColumnName("drawVertices");

                entity.Property(e => e.DrawXyaxes).HasColumnName("drawXYAxes");

                entity.Property(e => e.EnableThorlabsDialogue).HasColumnName("enableThorlabsDialogue");

                entity.Property(e => e.FindHomes).HasColumnName("findHomes");

                entity.Property(e => e.JoinDistance).HasColumnName("joinDistance");

                entity.Property(e => e.JoinReplace).HasColumnName("joinReplace");

                entity.Property(e => e.MinDrawTime).HasColumnName("minDrawTime");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NcGroupType).HasColumnName("ncGroupType");

                entity.Property(e => e.ProgramParameters).HasColumnName("programParameters");

                entity.Property(e => e.SearchRadius).HasColumnName("searchRadius");

                entity.Property(e => e.ShowFilteredVertices).HasColumnName("showFilteredVertices");

                entity.Property(e => e.ShowJobComments).HasColumnName("showJobComments");

                entity.Property(e => e.ShowPathStarts).HasColumnName("showPathStarts");

                entity.Property(e => e.ShowStopVertices).HasColumnName("showStopVertices");

                entity.Property(e => e.ShowTips).HasColumnName("showTips");

                entity.Property(e => e.SupervisorMode).HasColumnName("supervisorMode");

                entity.Property(e => e.UseSheetFeeder).HasColumnName("useSheetFeeder");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.VertexFilterDistance).HasColumnName("vertexFilterDistance");

                entity.Property(e => e.WHomeOnJobStart).HasColumnName("wHomeOnJobStart");

                entity.Property(e => e.WHomeOnProgramStart).HasColumnName("wHomeOnProgramStart");

                entity.Property(e => e.WinExpand).HasColumnName("winExpand");

                entity.Property(e => e.XHomeOnJobStart).HasColumnName("xHomeOnJobStart");

                entity.Property(e => e.XHomeOnProgramStart).HasColumnName("xHomeOnProgramStart");

                entity.Property(e => e.YHomeOnJobStart).HasColumnName("yHomeOnJobStart");

                entity.Property(e => e.YHomeOnProgramStart).HasColumnName("yHomeOnProgramStart");

                entity.Property(e => e.ZHomeOnJobStart).HasColumnName("zHomeOnJobStart");

                entity.Property(e => e.ZHomeOnProgramStart).HasColumnName("zHomeOnProgramStart");

                entity.HasOne(d => d.DebugLevelNavigation)
                    .WithMany(p => p.Profilers)
                    .HasPrincipalKey(p => p.Type)
                    .HasForeignKey(d => d.DebugLevel)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.NcGroupTypeNavigation)
                    .WithMany(p => p.Profilers)
                    .HasPrincipalKey(p => p.Type)
                    .HasForeignKey(d => d.NcGroupType)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<RsmUpgrade>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("rsmUpgrade");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.ConfigFile).HasColumnName("configFile");

                entity.Property(e => e.DataConfigFile).HasColumnName("dataConfigFile");

                entity.Property(e => e.DataFile).HasColumnName("dataFile");

                entity.Property(e => e.IniFile).HasColumnName("iniFile");

                entity.Property(e => e.ToolChangeFile).HasColumnName("toolChangeFile");

                entity.Property(e => e.ToolsFile).HasColumnName("toolsFile");
            });

            modelBuilder.Entity<TempMachinePropertyVisibility>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("tempMachinePropertyVisibility");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.Property).HasColumnName("property");

                entity.Property(e => e.TableName).HasColumnName("tableName");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Visible).HasColumnName("visible");
            });

            modelBuilder.Entity<Tipoff>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("tipoff");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.IsOnGantry).HasColumnName("isOnGantry");

                entity.Property(e => e.PlungeSpeed).HasColumnName("plungeSpeed");

                entity.Property(e => e.SurfaceDisplacement).HasColumnName("surfaceDisplacement");

                entity.Property(e => e.SurfaceDisplacementHasBeenSet).HasColumnName("surfaceDisplacementHasBeenSet");

                entity.Property(e => e.TipoffInputBit).HasColumnName("tipoffInputBit");

                entity.Property(e => e.XPosition).HasColumnName("xPosition");

                entity.Property(e => e.YPosition).HasColumnName("yPosition");

                entity.HasOne(d => d.TipoffInputBitNavigation)
                    .WithMany(p => p.Tipoffs)
                    .HasForeignKey(d => d.TipoffInputBit)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Tool>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("tool");

                entity.HasIndex(e => e.Name, "IX_tool_name")
                    .IsUnique();

                entity.HasIndex(e => e.NcNumber, "IX_tool_ncNumber")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Angle)
                    .HasColumnName("angle")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CanBeTippedOff)
                    .HasColumnName("canBeTippedOff")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CanRaiseOnPause)
                    .HasColumnName("canRaiseOnPause")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Compensation)
                    .HasColumnName("compensation")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefaultSpindleRevsPerMinute)
                    .HasColumnName("defaultSpindleRevsPerMinute")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Diameter)
                    .HasColumnName("diameter")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FastSearchSpeed)
                    .HasColumnName("fastSearchSpeed")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LeftHandThread)
                    .HasColumnName("leftHandThread")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxCutSpeed)
                    .HasColumnName("maxCutSpeed")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxPlungeSpeed)
                    .HasColumnName("maxPlungeSpeed")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxRotationalSpeed)
                    .HasColumnName("maxRotationalSpeed")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxSpindleRevsPerMinute)
                    .HasColumnName("maxSpindleRevsPerMinute")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.NcNumber).HasColumnName("ncNumber");

                entity.Property(e => e.OtherName).HasColumnName("otherName");

                entity.Property(e => e.PartNumber).HasColumnName("partNumber");

                entity.Property(e => e.Pitch)
                    .HasColumnName("pitch")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Procedure).HasColumnName("procedure");

                entity.Property(e => e.RotateSpindleCw)
                    .HasColumnName("rotateSpindleCW")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SlowSearchSpeed)
                    .HasColumnName("slowSearchSpeed")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TipZadjustment)
                    .HasColumnName("tipZAdjustment")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UseAirAssist)
                    .HasColumnName("useAirAssist")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UseMist)
                    .HasColumnName("useMist")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ProcedureNavigation)
                    .WithMany(p => p.Tools)
                    .HasPrincipalKey(p => p.Type)
                    .HasForeignKey(d => d.Procedure)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Tools)
                    .HasPrincipalKey(p => p.Type)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ToolChangeTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("toolChangeTypeEnum");

                entity.HasIndex(e => e.Type, "IX_toolChangeTypeEnum_type")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ToolChanger>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("toolChanger");

                entity.HasIndex(e => e.Name, "IX_toolChanger_name")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.AlwaysCalibrate).HasColumnName("alwaysCalibrate");

                entity.Property(e => e.ErrorRegister).HasColumnName("errorRegister");

                entity.Property(e => e.IsOnGantry).HasColumnName("isOnGantry");

                entity.Property(e => e.ModbusSlaveNumber).HasColumnName("modbusSlaveNumber");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.NumToolSlots).HasColumnName("numToolSlots");

                entity.Property(e => e.PositionTolerance).HasColumnName("positionTolerance");

                entity.Property(e => e.RaiseToolRackOutputBit).HasColumnName("raiseToolRackOutputBit");

                entity.Property(e => e.RequiresPositioning).HasColumnName("requiresPositioning");

                entity.Property(e => e.SlotNumberRegister).HasColumnName("slotNumberRegister");

                entity.Property(e => e.StatusRegister).HasColumnName("statusRegister");

                entity.Property(e => e.ToolChangeTimeout).HasColumnName("toolChangeTimeout");

                entity.Property(e => e.ToolRackIsRaisedInputBit).HasColumnName("toolRackIsRaisedInputBit");

                entity.Property(e => e.ToolRackTimeout).HasColumnName("toolRackTimeout");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UseApproachPosition).HasColumnName("useApproachPosition");

                entity.Property(e => e.XApproachPosition).HasColumnName("xApproachPosition");

                entity.Property(e => e.XPosition).HasColumnName("xPosition");

                entity.Property(e => e.YApproachPosition).HasColumnName("yApproachPosition");

                entity.Property(e => e.YPosition).HasColumnName("yPosition");

                entity.Property(e => e.ZApproachPosition).HasColumnName("zApproachPosition");

                entity.Property(e => e.ZPosition).HasColumnName("zPosition");

                entity.HasOne(d => d.RaiseToolRackOutputBitNavigation)
                    .WithMany(p => p.ToolChangers)
                    .HasForeignKey(d => d.RaiseToolRackOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ToolRackIsRaisedInputBitNavigation)
                    .WithMany(p => p.ToolChangers)
                    .HasForeignKey(d => d.ToolRackIsRaisedInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.ToolChangers)
                    .HasPrincipalKey(p => p.Type)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ToolFixture>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("toolFixture");

                entity.HasIndex(e => e.Name, "IX_toolFixture_name")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.ActivateChillerOutputBit).HasColumnName("activateChillerOutputBit");

                entity.Property(e => e.AirAssistOutputBit).HasColumnName("airAssistOutputBit");

                entity.Property(e => e.AirCylinderDelay).HasColumnName("airCylinderDelay");

                entity.Property(e => e.AirCylinderOutputBit).HasColumnName("airCylinderOutputBit");

                entity.Property(e => e.AlignmentPointerOutputBit).HasColumnName("alignmentPointerOutputBit");

                entity.Property(e => e.Angle).HasColumnName("angle");

                entity.Property(e => e.ArcOnInputBit).HasColumnName("arcOnInputBit");

                entity.Property(e => e.BottomDelayInputBit).HasColumnName("bottomDelayInputBit");

                entity.Property(e => e.Calibrated).HasColumnName("calibrated");

                entity.Property(e => e.CameraData).HasColumnName("cameraData");

                entity.Property(e => e.CutGasOutputBit).HasColumnName("cutGasOutputBit");

                entity.Property(e => e.CutOutputBit).HasColumnName("cutOutputBit");

                entity.Property(e => e.DefaultRpm).HasColumnName("defaultRPM");

                entity.Property(e => e.DoFrequencySetting).HasColumnName("doFrequencySetting");

                entity.Property(e => e.EngravingCutOutputBit).HasColumnName("engravingCutOutputBit");

                entity.Property(e => e.FrequencyTable).HasColumnName("frequencyTable");

                entity.Property(e => e.HasIntensityOutput).HasColumnName("hasIntensityOutput");

                entity.Property(e => e.HeightControllerName).HasColumnName("heightControllerName");

                entity.Property(e => e.InverterType).HasColumnName("inverterType");

                entity.Property(e => e.IsAtoolChangeHead).HasColumnName("isAToolChangeHead");

                entity.Property(e => e.KnifeOkInputBit).HasColumnName("knifeOkInputBit");

                entity.Property(e => e.LaserModulationType).HasColumnName("laserModulationType");

                entity.Property(e => e.LensCoolingEndDelay).HasColumnName("lensCoolingEndDelay");

                entity.Property(e => e.LensCoolingOutputBit).HasColumnName("lensCoolingOutputBit");

                entity.Property(e => e.MaxDutyCycle).HasColumnName("maxDutyCycle");

                entity.Property(e => e.MaxPulseWidth).HasColumnName("maxPulseWidth");

                entity.Property(e => e.MaxRpm).HasColumnName("maxRPM");

                entity.Property(e => e.MaxRpmOutputRegister).HasColumnName("maxRpmOutputRegister");

                entity.Property(e => e.MinPulseWidth).HasColumnName("minPulseWidth");

                entity.Property(e => e.MistOutputBit).HasColumnName("mistOutputBit");

                entity.Property(e => e.MtcAngle).HasColumnName("mtcAngle");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.OhmicTipTouchEnableOutputBit).HasColumnName("ohmicTipTouchEnableOutputBit");

                entity.Property(e => e.OpenToolClampOutputBit).HasColumnName("openToolClampOutputBit");

                entity.Property(e => e.OscillatingKnifeOutputBit).HasColumnName("oscillatingKnifeOutputBit");

                entity.Property(e => e.PersistentToolNumber).HasColumnName("persistentToolNumber");

                entity.Property(e => e.PierceGasOutputBit).HasColumnName("pierceGasOutputBit");

                entity.Property(e => e.PowerSupplyOkInputBit).HasColumnName("powerSupplyOkInputBit");

                entity.Property(e => e.PrintingFinishedInputBit).HasColumnName("printingFinishedInputBit");

                entity.Property(e => e.RfEnableDelay).HasColumnName("rfEnableDelay");

                entity.Property(e => e.RfEnableOutputBit).HasColumnName("rfEnableOutputBit");

                entity.Property(e => e.RfIsOnInputBit).HasColumnName("rfIsOnInputBit");

                entity.Property(e => e.RpmInputRegister).HasColumnName("rpmInputRegister");

                entity.Property(e => e.SawOutputBit).HasColumnName("sawOutputBit");

                entity.Property(e => e.SensorInputBit).HasColumnName("sensorInputBit");

                entity.Property(e => e.ShutterDelay).HasColumnName("shutterDelay");

                entity.Property(e => e.ShutterIsClosedInputBit).HasColumnName("shutterIsClosedInputBit");

                entity.Property(e => e.ShutterIsOpenInputBit).HasColumnName("shutterIsOpenInputBit");

                entity.Property(e => e.ShutterOutputBit).HasColumnName("shutterOutputBit");

                entity.Property(e => e.SlaveNumber).HasColumnName("slaveNumber");

                entity.Property(e => e.SpindleOutputBit).HasColumnName("spindleOutputBit");

                entity.Property(e => e.SpindleSafetyInputBit).HasColumnName("spindleSafetyInputBit");

                entity.Property(e => e.StartToolEarly).HasColumnName("startToolEarly");

                entity.Property(e => e.ToolClampDelay).HasColumnName("toolClampDelay");

                entity.Property(e => e.ToolIsPersistent).HasColumnName("toolIsPersistent");

                entity.Property(e => e.ToolOutputBit).HasColumnName("toolOutputBit");

                entity.Property(e => e.ToolStartDelay).HasColumnName("toolStartDelay");

                entity.Property(e => e.TurnChillerOnOutputBit).HasColumnName("turnChillerOnOutputBit");

                entity.Property(e => e.TurnLaserOnOutputBit).HasColumnName("turnLaserOnOutputBit");

                entity.Property(e => e.TurnPlasmaOnOutputBit).HasColumnName("turnPlasmaOnOutputBit");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnderTableDoorsInputBit).HasColumnName("underTableDoorsInputBit");

                entity.Property(e => e.UseMistAutoMode).HasColumnName("useMistAutoMode");

                entity.Property(e => e.UseRpm).HasColumnName("useRPM");

                entity.Property(e => e.UseVacuumExtractionAutoMode).HasColumnName("useVacuumExtractionAutoMode");

                entity.Property(e => e.VacuumExtractionEndDelay).HasColumnName("vacuumExtractionEndDelay");

                entity.Property(e => e.VacuumExtractionOutputBit).HasColumnName("vacuumExtractionOutputBit");

                entity.Property(e => e.VacuumExtractionStartDelay).HasColumnName("vacuumExtractionStartDelay");

                entity.Property(e => e.WarmupTime).HasColumnName("warmupTime");

                entity.Property(e => e.XBeamCoverInputBit).HasColumnName("xBeamCoverInputBit");

                entity.Property(e => e.XOffset).HasColumnName("xOffset");

                entity.Property(e => e.XyMoveFastAtZhigh).HasColumnName("xyMoveFastAtZHigh");

                entity.Property(e => e.YBeamCoverInputBit).HasColumnName("yBeamCoverInputBit");

                entity.Property(e => e.YOffset).HasColumnName("yOffset");

                entity.Property(e => e.ZOffset).HasColumnName("zOffset");

                entity.HasOne(d => d.ActivateChillerOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureActivateChillerOutputBitNavigations)
                    .HasForeignKey(d => d.ActivateChillerOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.AirAssistOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureAirAssistOutputBitNavigations)
                    .HasForeignKey(d => d.AirAssistOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.AirCylinderOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureAirCylinderOutputBitNavigations)
                    .HasForeignKey(d => d.AirCylinderOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.AlignmentPointerOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureAlignmentPointerOutputBitNavigations)
                    .HasForeignKey(d => d.AlignmentPointerOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ArcOnInputBitNavigation)
                    .WithMany(p => p.ToolFixtureArcOnInputBitNavigations)
                    .HasForeignKey(d => d.ArcOnInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.BottomDelayInputBitNavigation)
                    .WithMany(p => p.ToolFixtureBottomDelayInputBitNavigations)
                    .HasForeignKey(d => d.BottomDelayInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.CutGasOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureCutGasOutputBitNavigations)
                    .HasForeignKey(d => d.CutGasOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.CutOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureCutOutputBitNavigations)
                    .HasForeignKey(d => d.CutOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.EngravingCutOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureEngravingCutOutputBitNavigations)
                    .HasForeignKey(d => d.EngravingCutOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.HeightControllerNameNavigation)
                    .WithMany(p => p.ToolFixtures)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.HeightControllerName)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.InverterTypeNavigation)
                    .WithMany(p => p.ToolFixtures)
                    .HasPrincipalKey(p => p.Type)
                    .HasForeignKey(d => d.InverterType)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.KnifeOkInputBitNavigation)
                    .WithMany(p => p.ToolFixtureKnifeOkInputBitNavigations)
                    .HasForeignKey(d => d.KnifeOkInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.LaserModulationTypeNavigation)
                    .WithMany(p => p.ToolFixtures)
                    .HasPrincipalKey(p => p.Type)
                    .HasForeignKey(d => d.LaserModulationType)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.LensCoolingOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureLensCoolingOutputBitNavigations)
                    .HasForeignKey(d => d.LensCoolingOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.MaxRpmOutputRegisterNavigation)
                    .WithMany(p => p.ToolFixtureMaxRpmOutputRegisterNavigations)
                    .HasForeignKey(d => d.MaxRpmOutputRegister)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.MistOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureMistOutputBitNavigations)
                    .HasForeignKey(d => d.MistOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.OhmicTipTouchEnableOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureOhmicTipTouchEnableOutputBitNavigations)
                    .HasForeignKey(d => d.OhmicTipTouchEnableOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.OpenToolClampOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureOpenToolClampOutputBitNavigations)
                    .HasForeignKey(d => d.OpenToolClampOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.OscillatingKnifeOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureOscillatingKnifeOutputBitNavigations)
                    .HasForeignKey(d => d.OscillatingKnifeOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.PierceGasOutputBitNavigation)
                    .WithMany(p => p.ToolFixturePierceGasOutputBitNavigations)
                    .HasForeignKey(d => d.PierceGasOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.PowerSupplyOkInputBitNavigation)
                    .WithMany(p => p.ToolFixturePowerSupplyOkInputBitNavigations)
                    .HasForeignKey(d => d.PowerSupplyOkInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.PrintingFinishedInputBitNavigation)
                    .WithMany(p => p.ToolFixturePrintingFinishedInputBitNavigations)
                    .HasForeignKey(d => d.PrintingFinishedInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.RfEnableOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureRfEnableOutputBitNavigations)
                    .HasForeignKey(d => d.RfEnableOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.RfIsOnInputBitNavigation)
                    .WithMany(p => p.ToolFixtureRfIsOnInputBitNavigations)
                    .HasForeignKey(d => d.RfIsOnInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.RpmInputRegisterNavigation)
                    .WithMany(p => p.ToolFixtureRpmInputRegisterNavigations)
                    .HasForeignKey(d => d.RpmInputRegister)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.SawOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureSawOutputBitNavigations)
                    .HasForeignKey(d => d.SawOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.SensorInputBitNavigation)
                    .WithMany(p => p.ToolFixtureSensorInputBitNavigations)
                    .HasForeignKey(d => d.SensorInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ShutterIsClosedInputBitNavigation)
                    .WithMany(p => p.ToolFixtureShutterIsClosedInputBitNavigations)
                    .HasForeignKey(d => d.ShutterIsClosedInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ShutterIsOpenInputBitNavigation)
                    .WithMany(p => p.ToolFixtureShutterIsOpenInputBitNavigations)
                    .HasForeignKey(d => d.ShutterIsOpenInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ShutterOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureShutterOutputBitNavigations)
                    .HasForeignKey(d => d.ShutterOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.SpindleOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureSpindleOutputBitNavigations)
                    .HasForeignKey(d => d.SpindleOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.SpindleSafetyInputBitNavigation)
                    .WithMany(p => p.ToolFixtureSpindleSafetyInputBitNavigations)
                    .HasForeignKey(d => d.SpindleSafetyInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ToolOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureToolOutputBitNavigations)
                    .HasForeignKey(d => d.ToolOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.TurnChillerOnOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureTurnChillerOnOutputBitNavigations)
                    .HasForeignKey(d => d.TurnChillerOnOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.TurnLaserOnOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureTurnLaserOnOutputBitNavigations)
                    .HasForeignKey(d => d.TurnLaserOnOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.TurnPlasmaOnOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureTurnPlasmaOnOutputBitNavigations)
                    .HasForeignKey(d => d.TurnPlasmaOnOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.UnderTableDoorsInputBitNavigation)
                    .WithMany(p => p.ToolFixtureUnderTableDoorsInputBitNavigations)
                    .HasForeignKey(d => d.UnderTableDoorsInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.VacuumExtractionOutputBitNavigation)
                    .WithMany(p => p.ToolFixtureVacuumExtractionOutputBitNavigations)
                    .HasForeignKey(d => d.VacuumExtractionOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.XBeamCoverInputBitNavigation)
                    .WithMany(p => p.ToolFixtureXBeamCoverInputBitNavigations)
                    .HasForeignKey(d => d.XBeamCoverInputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.YBeamCoverInputBitNavigation)
                    .WithMany(p => p.ToolFixtureYBeamCoverInputBitNavigations)
                    .HasForeignKey(d => d.YBeamCoverInputBit)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ToolFixtureAxisRel>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("toolFixtureAxisRel");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.AxisNumber).HasColumnName("axisNumber");

                entity.Property(e => e.ToolFixtureNumber).HasColumnName("toolFixtureNumber");

                entity.HasOne(d => d.AxisNumberNavigation)
                    .WithMany(p => p.ToolFixtureAxisRels)
                    .HasForeignKey(d => d.AxisNumber)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ToolFixtureNumberNavigation)
                    .WithMany(p => p.ToolFixtureAxisRels)
                    .HasForeignKey(d => d.ToolFixtureNumber)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ToolFixtureTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("toolFixtureTypeEnum");

                entity.HasIndex(e => e.Type, "IX_toolFixtureTypeEnum_type")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ToolHistory>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("toolHistory");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CutDistance).HasColumnName("cutDistance");

                entity.Property(e => e.CutTime).HasColumnName("cutTime");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.JobName).HasColumnName("jobName");

                entity.Property(e => e.NumShapes).HasColumnName("numShapes");

                entity.Property(e => e.PartNumber).HasColumnName("partNumber");

                entity.Property(e => e.ToolName).HasColumnName("toolName");

                entity.Property(e => e.ToolNumber).HasColumnName("toolNumber");

                entity.HasOne(d => d.ToolNumberNavigation)
                    .WithMany(p => p.ToolHistories)
                    .HasForeignKey(d => d.ToolNumber);
            });

            modelBuilder.Entity<ToolProfile>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("toolProfile");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.ArcOnDebounceTime).HasColumnName("arcOnDebounceTime");

                entity.Property(e => e.BottomDelay).HasColumnName("bottomDelay");

                entity.Property(e => e.BottomDelayByInput).HasColumnName("bottomDelayByInput");

                entity.Property(e => e.BottomDelayIntensity).HasColumnName("bottomDelayIntensity");

                entity.Property(e => e.CrawlDistance).HasColumnName("crawlDistance");

                entity.Property(e => e.CrawlSpeed).HasColumnName("crawlSpeed");

                entity.Property(e => e.CutCurrent).HasColumnName("cutCurrent");

                entity.Property(e => e.CutFrequency).HasColumnName("cutFrequency");

                entity.Property(e => e.CutGasWaitTime).HasColumnName("cutGasWaitTime");

                entity.Property(e => e.CutHeight).HasColumnName("cutHeight");

                entity.Property(e => e.CutMode).HasColumnName("cutMode");

                entity.Property(e => e.CutPressure).HasColumnName("cutPressure");

                entity.Property(e => e.CutSpeed).HasColumnName("cutSpeed");

                entity.Property(e => e.CutVoltage).HasColumnName("cutVoltage");

                entity.Property(e => e.DoFrequencySetting).HasColumnName("doFrequencySetting");

                entity.Property(e => e.EdgeSearchCompensationNegX).HasColumnName("edgeSearchCompensation_negX");

                entity.Property(e => e.EdgeSearchCompensationNegY).HasColumnName("edgeSearchCompensation_negY");

                entity.Property(e => e.EdgeSearchCompensationPosX).HasColumnName("edgeSearchCompensation_posX");

                entity.Property(e => e.EdgeSearchCompensationPosY).HasColumnName("edgeSearchCompensation_posY");

                entity.Property(e => e.EdgeSearchZshiftFromDetectedSurface).HasColumnName("edgeSearchZShiftFromDetectedSurface");

                entity.Property(e => e.EndDelay).HasColumnName("endDelay");

                entity.Property(e => e.EndDelayIntensity).HasColumnName("endDelayIntensity");

                entity.Property(e => e.EndOfShapeArcCutoffDistance).HasColumnName("endOfShapeArcCutoffDistance");

                entity.Property(e => e.HcProfileNumber).HasColumnName("hcProfileNumber");

                entity.Property(e => e.IntensityTable).HasColumnName("intensityTable");

                entity.Property(e => e.LiftAngle).HasColumnName("liftAngle");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OhmicUpDistance).HasColumnName("ohmicUpDistance");

                entity.Property(e => e.OverCutFinish).HasColumnName("overCutFinish");

                entity.Property(e => e.OverCutStart).HasColumnName("overCutStart");

                entity.Property(e => e.PierceFrequency).HasColumnName("pierceFrequency");

                entity.Property(e => e.PierceGasPurgeTime).HasColumnName("pierceGasPurgeTime");

                entity.Property(e => e.PierceGasWaitTime).HasColumnName("pierceGasWaitTime");

                entity.Property(e => e.PierceHeightAboveSurface).HasColumnName("pierceHeightAboveSurface");

                entity.Property(e => e.PierceIntensity).HasColumnName("pierceIntensity");

                entity.Property(e => e.PierceTime).HasColumnName("pierceTime");

                entity.Property(e => e.PlasmaArcOnWaitTimeOut).HasColumnName("plasmaArcOnWaitTimeOut");

                entity.Property(e => e.PlasmaTransferHeight).HasColumnName("plasmaTransferHeight");

                entity.Property(e => e.PlungeSpeed).HasColumnName("plungeSpeed");

                entity.Property(e => e.RaiseOnPause).HasColumnName("raiseOnPause");

                entity.Property(e => e.RotationalSpeed).HasColumnName("rotationalSpeed");

                entity.Property(e => e.SpindleRevsPerMinute).HasColumnName("spindleRevsPerMinute");

                entity.Property(e => e.SsOffset).HasColumnName("ssOffset");

                entity.Property(e => e.SsOffsetHasBeenSet).HasColumnName("ssOffsetHasBeenSet");

                entity.Property(e => e.ToolName).HasColumnName("toolName");

                entity.Property(e => e.TwistRadiusMinimum).HasColumnName("twistRadiusMinimum");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UseAirAssist).HasColumnName("useAirAssist");

                entity.Property(e => e.UseAutoOffsetting).HasColumnName("useAutoOffsetting");

                entity.Property(e => e.UseHeightControl).HasColumnName("useHeightControl");

                entity.Property(e => e.UseIntensityOutput).HasColumnName("useIntensityOutput");

                entity.Property(e => e.UseMist).HasColumnName("useMist");

                entity.Property(e => e.UseOhmicContact).HasColumnName("useOhmicContact");

                entity.Property(e => e.UseOscillatingKnife).HasColumnName("useOscillatingKnife");

                entity.Property(e => e.UsePierceSequence).HasColumnName("usePierceSequence");

                entity.Property(e => e.UseTangential).HasColumnName("useTangential");

                entity.Property(e => e.WaitForArcOnInput).HasColumnName("waitForArcOnInput");

                entity.Property(e => e.WarpTolerance).HasColumnName("warpTolerance");

                entity.Property(e => e.XyFastMovesAtZhigh).HasColumnName("xyFastMovesAtZHigh");

                entity.Property(e => e.ZClickUpDistance).HasColumnName("zClickUpDistance");

                entity.HasOne(d => d.CutFrequencyNavigation)
                    .WithMany(p => p.ToolProfileCutFrequencyNavigations)
                    .HasPrincipalKey(p => p.Frequency)
                    .HasForeignKey(d => d.CutFrequency)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.HcProfileNumberNavigation)
                    .WithMany(p => p.ToolProfiles)
                    .HasForeignKey(d => d.HcProfileNumber)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.PierceFrequencyNavigation)
                    .WithMany(p => p.ToolProfilePierceFrequencyNavigations)
                    .HasPrincipalKey(p => p.Frequency)
                    .HasForeignKey(d => d.PierceFrequency)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ToolNameNavigation)
                    .WithMany(p => p.ToolProfiles)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.ToolName)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.ToolProfiles)
                    .HasPrincipalKey(p => p.Type)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ToolReplacement>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("toolReplacement");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.ToolName).HasColumnName("toolName");

                entity.Property(e => e.ToolNumber).HasColumnName("toolNumber");

                entity.HasOne(d => d.ToolNumberNavigation)
                    .WithMany(p => p.ToolReplacements)
                    .HasForeignKey(d => d.ToolNumber);
            });

            modelBuilder.Entity<ToolToToolFixtureRel>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("toolToToolFixtureRel");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.ToolFixtureNumber).HasColumnName("toolFixtureNumber");

                entity.Property(e => e.ToolNumber).HasColumnName("toolNumber");

                entity.HasOne(d => d.ToolFixtureNumberNavigation)
                    .WithMany(p => p.ToolToToolFixtureRels)
                    .HasForeignKey(d => d.ToolFixtureNumber)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ToolNumberNavigation)
                    .WithMany(p => p.ToolToToolFixtureRels)
                    .HasForeignKey(d => d.ToolNumber);
            });

            modelBuilder.Entity<VacuumHoldDown>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("vacuumHoldDown");

                entity.HasIndex(e => e.Name, "IX_vacuumHoldDown_name")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.StartDelay).HasColumnName("startDelay");

                entity.Property(e => e.UseAutoVacuum).HasColumnName("useAutoVacuum");

                entity.Property(e => e.UseAutoVacuumZones).HasColumnName("useAutoVacuumZones");

                entity.Property(e => e.VacuumHoldDownOutputBit).HasColumnName("vacuumHoldDownOutputBit");

                entity.Property(e => e.VacuumHoldDownZoneOutputBit).HasColumnName("vacuumHoldDownZoneOutputBit");

                entity.Property(e => e.XBottomLeftZone).HasColumnName("xBottomLeftZone");

                entity.Property(e => e.YBottomLeftZone).HasColumnName("yBottomLeftZone");

                entity.Property(e => e.ZoneHeight).HasColumnName("zoneHeight");

                entity.Property(e => e.ZoneWidth).HasColumnName("zoneWidth");

                entity.HasOne(d => d.VacuumHoldDownOutputBitNavigation)
                    .WithMany(p => p.VacuumHoldDownVacuumHoldDownOutputBitNavigations)
                    .HasForeignKey(d => d.VacuumHoldDownOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.VacuumHoldDownZoneOutputBitNavigation)
                    .WithMany(p => p.VacuumHoldDownVacuumHoldDownZoneOutputBitNavigations)
                    .HasForeignKey(d => d.VacuumHoldDownZoneOutputBit)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ZReference>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("zReference");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.MasterToolName).HasColumnName("masterToolName");

                entity.Property(e => e.MasterToolNumber).HasColumnName("masterToolNumber");

                entity.Property(e => e.ZBottomLimit).HasColumnName("zBottomLimit");

                entity.Property(e => e.ZBottomLimitValid).HasColumnName("zBottomLimitValid");

                entity.Property(e => e.ZCalibrationSurface).HasColumnName("zCalibrationSurface");

                entity.Property(e => e.ZCalibrationSurfaceValid).HasColumnName("zCalibrationSurfaceValid");

                entity.Property(e => e.ZTipoff).HasColumnName("zTipoff");

                entity.Property(e => e.ZTipoffValid).HasColumnName("zTipoffValid");

                entity.Property(e => e.ZWasteBoard).HasColumnName("zWasteBoard");

                entity.Property(e => e.ZWasteBoardValid).HasColumnName("zWasteBoardValid");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
