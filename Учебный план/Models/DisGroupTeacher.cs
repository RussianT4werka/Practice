using System;
using System.Collections.Generic;

namespace Учебный_план.Models
{
    public partial class DisGroupTeacher
    {
        public int DisciplineId { get; set; }
        public int GroupId { get; set; }
        public int? TeacherId { get; set; }

        public virtual Discipline Discipline { get; set; } = null!;
        public virtual Group Group { get; set; } = null!;
        public virtual Teacher? Teacher { get; set; }
    }
}
