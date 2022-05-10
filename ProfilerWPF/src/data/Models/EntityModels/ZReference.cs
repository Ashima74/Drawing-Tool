#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class ZReference
    {
        public long Number { get; set; }
        public long? MasterToolNumber { get; set; }
        public string MasterToolName { get; set; }
        public long? Date { get; set; }
        public long? ZWasteBoardValid { get; set; }
        public double? ZWasteBoard { get; set; }
        public long? ZCalibrationSurfaceValid { get; set; }
        public double? ZCalibrationSurface { get; set; }
        public long? ZTipoffValid { get; set; }
        public double? ZTipoff { get; set; }
        public long? ZBottomLimitValid { get; set; }
        public double? ZBottomLimit { get; set; }
    }
}
