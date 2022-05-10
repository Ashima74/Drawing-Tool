#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class MotionControl
    {
        public long Number { get; set; }
        public long? MaxMuPerSec { get; set; }
        public double? StepsPerMm { get; set; }
        public double? StopAngle { get; set; }
        public double? SmoothingFactor { get; set; }
        public double? ToleranceAngle { get; set; }
        public double? MinChangeSpeedDistance { get; set; }
        public double? ConcurrentAngle { get; set; }
        public double? SplineArcError { get; set; }
        public double? SmoothAnglesLessThan { get; set; }
        public double? SmoothMaxError { get; set; }
        public double? CentripetalAccelPercent { get; set; }
        public double? LinearStartStopVelocity { get; set; }
        public double? RotationalStartStopVelocity { get; set; }
        public double? MaxJerk { get; set; }
        public double? YAxisCuttingSpeedFactor { get; set; }
        public double? ArrowSpeedPercent { get; set; }
        public double? ArrowAccelPercent { get; set; }
        public long? RaiseOnPause { get; set; }
    }
}
