using Microsoft.EntityFrameworkCore;
using ProfilerWPF.data.Models.RSQDatabase.Models;

#nullable disable

namespace ProfilerWPF.data.Models.RSQDatabase.Context
{
    public interface IRSQContext
    {
        public DbSet<ArrayOrderTypeEnum> ArrayOrderTypeEnums { get; set; }
        public DbSet<ArrayStartPointTypeEnum> ArrayStartPointTypeEnums { get; set; }
        public DbSet<ArrayingParam> ArrayingParams { get; set; }
        public DbSet<CutModeTypeEnum> CutModeTypeEnums { get; set; }
        public DbSet<DepthTypeEnum> DepthTypeEnums { get; set; }
        public DbSet<GroupDatum> GroupData { get; set; }
        public DbSet<HeightControlProfile> HeightControlProfiles { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobDataTypeEnum> JobDataTypeEnums { get; set; }
        public DbSet<JobParam> JobParams { get; set; }
        public DbSet<LaserIntensity> LaserIntensities { get; set; }
        public DbSet<ToolProfile> ToolProfiles { get; set; }

    }
}
