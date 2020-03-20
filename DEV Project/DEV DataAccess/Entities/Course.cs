using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_DataAccess.Entities
{
    public class Course
    {
        public Guid Id { get; set; }

        public string CourseName { get; set; }

        public Guid InstructorId { get; set; }

        public string SectionNumber { get; set; }

       
    }
}
