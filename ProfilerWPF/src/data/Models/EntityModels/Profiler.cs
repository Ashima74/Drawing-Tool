#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class Profiler
    {
        public long Number { get; set; }
        public string Name { get; set; }
        public long? Version { get; set; }
        public string ProgramParameters { get; set; }
        public long? SupervisorMode { get; set; }
        public double? SearchRadius { get; set; }
        public double? WinExpand { get; set; }
        public string NcGroupType { get; set; }
        public long? DisplayAllGroups { get; set; }
        public long? DisplayMachiningSections { get; set; }
        public long? DrawMachiningPath { get; set; }
        public long? DisplayShapesUsingGroupColour { get; set; }
        public long? DrawVertices { get; set; }
        public long? ShowPathStarts { get; set; }
        public long? ShowFilteredVertices { get; set; }
        public long? ShowStopVertices { get; set; }
        public long? DrawSmoothedPaths { get; set; }
        public long? DrawLastPassOffsetPaths { get; set; }
        public long? DrawMachineBounds { get; set; }
        public long? DrawXyaxes { get; set; }
        public long? DrawDataBoundingBox { get; set; }
        public long? DrawData { get; set; }
        public long? ShowTips { get; set; }
        public long? ShowJobComments { get; set; }
        public string DebugLevel { get; set; }
        public double? JoinDistance { get; set; }
        public long? JoinReplace { get; set; }
        public double? VertexFilterDistance { get; set; }
        public long? MinDrawTime { get; set; }
        public long? EnableThorlabsDialogue { get; set; }
        public long? UseSheetFeeder { get; set; }
        public long? AllowConfiguration { get; set; }
        public long? FindHomes { get; set; }
        public long? XHomeOnProgramStart { get; set; }
        public long? YHomeOnProgramStart { get; set; }
        public long? ZHomeOnProgramStart { get; set; }
        public long? WHomeOnProgramStart { get; set; }
        public long? XHomeOnJobStart { get; set; }
        public long? YHomeOnJobStart { get; set; }
        public long? ZHomeOnJobStart { get; set; }
        public long? WHomeOnJobStart { get; set; }
        public long? DoDoubleJobStart { get; set; }
        public long? ChangeJobOriginAtStart { get; set; }

        public virtual DebugLevelTypeEnum DebugLevelNavigation { get; set; }
        public virtual NcGroupTypeEnum NcGroupTypeNavigation { get; set; }
    }
}
