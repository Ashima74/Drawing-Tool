using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class KeypadTypeEnum
    {
        public KeypadTypeEnum()
        {
            Machines = new HashSet<Machine>();
        }

        public long Number { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Machine> Machines { get; set; }
    }
}
