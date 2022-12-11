using System;
using System.Collections.Generic;

namespace Учебный_план.Models
{
    public partial class KindOfTypeDiscipline
    {
        public KindOfTypeDiscipline()
        {
            TypeDisciplines = new HashSet<TypeDiscipline>();
        }

        public int KindOfTypeDisciplinesId { get; set; }
        public string KindOfTypeDisciplines { get; set; } = null!;

        public virtual ICollection<TypeDiscipline> TypeDisciplines { get; set; }
    }
}
