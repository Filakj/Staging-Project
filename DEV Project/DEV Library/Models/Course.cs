using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_Library.Models
{
    public partial class Course
    {
        public Guid Id { get; set; }

        public string CourseName { get; set; }

        public Guid InstructorId { get; set; }

        public string SectionNumber { get; set; }

    }
}
