using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.RSQDatabase.Models
{
    public partial class ToolProfile
    {
        public ToolProfile()
        {
            GroupData = new HashSet<GroupDatum>();
            LaserIntensities = new HashSet<LaserIntensity>();
        }

        public long Number { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ToolName { get; set; }
        public double? CutSpeed { get; set; }
        public double? PlungeSpeed { get; set; }
        public double? RotationalSpeed { get; set; }
        public long? SpindleRevsPerMinute { get; set; }
        public double? BottomDelay { get; set; }
        public long? BottomDelayByInput { get; set; }
        public double? EndDelay { get; set; }
        public long? UseMist { get; set; }
        public long? UseTangential { get; set; }
        public long? UseOscillatingKnife { get; set; }
        public double? TwistRadiusMinimum { get; set; }
        public double? OverCutStart { get; set; }
        public double? OverCutFinish { get; set; }
        public double? LiftAngle { get; set; }
        public long? SsOffsetHasBeenSet { get; set; }
        public double? SsOffset { get; set; }
        public double? WarpTolerance { get; set; }
        public double? EdgeSearchZshiftFromDetectedSurface { get; set; }
        public double? EdgeSearchCompensationPosX { get; set; }
        public double? EdgeSearchCompensationPosY { get; set; }
        public double? EdgeSearchCompensationNegX { get; set; }
        public double? EdgeSearchCompensationNegY { get; set; }
        public long? UseHeightControl { get; set; }
        public long? UseIntensityOutput { get; set; }
        public string IntensityTable { get; set; }
        public long? DoFrequencySetting { get; set; }
        public long? CutFrequency { get; set; }
        public double? CutGasWaitTime { get; set; }
        public long? BottomDelayIntensity { get; set; }
        public long? UsePierceSequence { get; set; }
        public double? PierceHeightAboveSurface { get; set; }
        public double? PierceGasWaitTime { get; set; }
        public long? PierceFrequency { get; set; }
        public long? PierceIntensity { get; set; }
        public double? PierceTime { get; set; }
        public double? PierceGasPurgeTime { get; set; }
        public double? CrawlDistance { get; set; }
        public double? CrawlSpeed { get; set; }
        public long? EndDelayIntensity { get; set; }
        public long? UseOhmicContact { get; set; }
        public double? OhmicUpDistance { get; set; }
        public double? ZClickUpDistance { get; set; }
        public double? PlasmaTransferHeight { get; set; }
        public double? CutHeight { get; set; }
        public double? ArcOnDebounceTime { get; set; }
        public long? WaitForArcOnInput { get; set; }
        public double? PlasmaArcOnWaitTimeOut { get; set; }
        public double? EndOfShapeArcCutoffDistance { get; set; }
        public double? CutVoltage { get; set; }
        public double? CutCurrent { get; set; }
        public double? CutPressure { get; set; }
        public string CutMode { get; set; }
        public long? RaiseOnPause { get; set; }
        public long? UseAirAssist { get; set; }
        public long? UseAutoOffsetting { get; set; }
        public long? XyFastMovesAtZhigh { get; set; }
        public long? HcProfileNumber { get; set; }

        public virtual HeightControlProfile HcProfileNumberNavigation { get; set; }
        public virtual ICollection<GroupDatum> GroupData { get; set; }
        public virtual ICollection<LaserIntensity> LaserIntensities { get; set; }
    }
}
