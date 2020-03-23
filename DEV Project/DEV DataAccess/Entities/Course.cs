using System;
using System.Collections.Generic;

namespace DEV_DataAccess.Entities
{
    public partial class Course
    {
        public Guid Id { get; set; }
        public string CourseName { get; set; }
        public Guid? InstructorId { get; set; }
        public string SectionNumber { get; set; }
    }
}
