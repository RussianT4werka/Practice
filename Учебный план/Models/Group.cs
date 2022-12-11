using System;
using System.Collections.Generic;

namespace Учебный_план.Models
{
    public partial class Group
    {
        public int GroupId { get; set; }
        public int GroupNumber { get; set; }
        public int GroupCountStudent { get; set; }
        public int? TypeGroupId { get; set; }

        public virtual TypeGroup? TypeGroup { get; set; }
    }
}
