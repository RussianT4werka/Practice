using System;
using System.Collections.Generic;

namespace Учебный_план.Models
{
    public partial class TypeGroup
    {
        public TypeGroup()
        {
            Groups = new HashSet<Group>();
        }

        public int TypeGroupId { get; set; }
        public string TypeGroupName { get; set; } = null!;

        public virtual ICollection<Group> Groups { get; set; }
    }
}
