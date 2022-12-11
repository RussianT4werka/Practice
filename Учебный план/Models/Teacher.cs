using System;
using System.Collections.Generic;

namespace Учебный_план.Models
{
    public partial class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherSurname { get; set; } = null!;
        public string TeacherName { get; set; } = null!;
        public string? TeacherPatronymic { get; set; }
    }
}
