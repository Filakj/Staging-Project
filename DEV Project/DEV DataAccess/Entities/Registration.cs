using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_DataAccess.Entities
{
    public class Registration
    {
        public Guid Id { get; set; }

        public Guid StudentId { get; set; }

        public Guid CourseID { get; set; }
    }
}
