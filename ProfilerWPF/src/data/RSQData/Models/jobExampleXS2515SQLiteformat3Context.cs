using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ProfilerWPF.data.RSQData.Models
{
    public partial class jobExampleXS2515SQLiteformat3Context : DbContext
    {
        public jobExampleXS2515SQLiteformat3Context()
        {
        }

        public jobExampleXS2515SQLiteformat3Context(DbContextOptions<jobExampleXS2515SQLiteformat3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ArrayOrderTypeEnum> ArrayOrderTypeEnums { get; set; }
        public virtual DbSet<ArrayStartPointTypeEnum> ArrayStartPointTypeEnums { get; set; }
        public virtual DbSet<ArrayingParam> ArrayingParams { get; set; }
        public virtual DbSet<CutModeTypeEnum> CutModeTypeEnums { get; set; }
        public virtual DbSet<DepthTypeEnum> DepthTypeEnums { get; set; }
        public virtual DbSet<GroupDatum> GroupData { get; set; }
        public virtual DbSet<HeightControlProfile> HeightControlProfiles { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobDataTypeEnum> JobDataTypeEnums { get; set; }
        public virtual DbSet<JobParam> JobParams { get; set; }
        public virtual DbSet<LaserIntensity> LaserIntensities { get; set; }
        public virtual DbSet<ToolProfile> ToolProfiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=D:\\UNI\\ProfilerV2\\ProfilerWPF\\src\\data\\RSQData\\jobExampleXS2515 - SQLite format 3.rsq;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArrayOrderTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("arrayOrderTypeEnum");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ArrayStartPointTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("arrayStartPointTypeEnum");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ArrayingParam>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("arrayingParams");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.ArrayColSpace).HasColumnName("arrayColSpace");

                entity.Property(e => e.ArrayCols).HasColumnName("arrayCols");

                entity.Property(e => e.ArrayOrderType).HasColumnName("arrayOrderType");

                entity.Property(e => e.ArrayRowSpace).HasColumnName("arrayRowSpace");

                entity.Property(e => e.ArrayRows).HasColumnName("arrayRows");

                entity.Property(e => e.ArrayStartPoint).HasColumnName("arrayStartPoint");

                entity.Property(e => e.JobArrayColSpace).HasColumnName("jobArrayColSpace");

                entity.Property(e => e.JobArrayCols).HasColumnName("jobArrayCols");

                entity.Property(e => e.JobArrayOrderType).HasColumnName("jobArrayOrderType");

                entity.Property(e => e.JobArrayRowSpace).HasColumnName("jobArrayRowSpace");

                entity.Property(e => e.JobArrayRows).HasColumnName("jobArrayRows");

                entity.Property(e => e.JobArrayStartPoint).HasColumnName("jobArrayStartPoint");
            });

            modelBuilder.Entity<CutModeTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("cutModeTypeEnum");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<DepthTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("depthTypeEnum");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type).HasColumnName("type");
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

                entity.HasOne(d => d.ToolProfileNumberNavigation)
                    .WithMany(p => p.GroupData)
                    .HasForeignKey(d => d.ToolProfileNumber)
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
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("job");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.JobData).HasColumnName("jobData");

                entity.Property(e => e.JobDataType).HasColumnName("jobDataType");

                entity.Property(e => e.JobMachineData).HasColumnName("jobMachineData");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OriginalFileName).HasColumnName("originalFileName");
            });

            modelBuilder.Entity<JobDataTypeEnum>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("jobDataTypeEnum");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<JobParam>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("jobParams");

                entity.Property(e => e.Number)
                    .ValueGeneratedNever()
                    .HasColumnName("number");

                entity.Property(e => e.AbsOriginW).HasColumnName("absOriginW");

                entity.Property(e => e.AbsOriginX).HasColumnName("absOriginX");

                entity.Property(e => e.AbsOriginY).HasColumnName("absOriginY");

                entity.Property(e => e.AbsOriginZ).HasColumnName("absOriginZ");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FinishPositionX).HasColumnName("finishPositionX");

                entity.Property(e => e.FinishPositionY).HasColumnName("finishPositionY");

                entity.Property(e => e.JobComments).HasColumnName("jobComments");

                entity.Property(e => e.MachineConfigFileName).HasColumnName("machineConfigFileName");

                entity.Property(e => e.MasterToolName).HasColumnName("masterToolName");

                entity.Property(e => e.MasterToolNumber).HasColumnName("masterToolNumber");

                entity.Property(e => e.MaterialName).HasColumnName("materialName");

                entity.Property(e => e.MaterialThickness).HasColumnName("materialThickness");

                entity.Property(e => e.UseAutoOffsets).HasColumnName("useAutoOffsets");

                entity.Property(e => e.UseGroupsWhenRunningNcCode).HasColumnName("useGroupsWhenRunningNcCode");

                entity.Property(e => e.UseWasteBoardSurface).HasColumnName("useWasteBoardSurface");

                entity.Property(e => e.ZBottom).HasColumnName("zBottom");

                entity.Property(e => e.ZBottomClearance).HasColumnName("zBottomClearance");

                entity.Property(e => e.ZBottomValid).HasColumnName("zBottomValid");

                entity.Property(e => e.ZSurface).HasColumnName("zSurface");

                entity.Property(e => e.ZSurfaceValid).HasColumnName("zSurfaceValid");

                entity.Property(e => e.ZTop).HasColumnName("zTop");

                entity.Property(e => e.ZTopClearance).HasColumnName("zTopClearance");

                entity.Property(e => e.ZTopValid).HasColumnName("zTopValid");
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

                entity.HasOne(d => d.HcProfileNumberNavigation)
                    .WithMany(p => p.ToolProfiles)
                    .HasForeignKey(d => d.HcProfileNumber)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
