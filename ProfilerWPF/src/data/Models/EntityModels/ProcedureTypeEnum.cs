using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class ProcedureTypeEnum
    {
        public ProcedureTypeEnum()
        {
            Tools = new HashSet<Tool>();
        }

        public long Number { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Tool> Tools { get; set; }
    }
}
