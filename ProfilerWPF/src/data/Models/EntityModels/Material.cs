using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class Material
    {
        public Material()
        {
            GroupData = new HashSet<GroupDatum>();
        }

        public long Number { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GroupDatum> GroupData { get; set; }
    }
}
