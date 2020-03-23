using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_Library.Models
{
    public partial class Registration
    {
        public Guid Id { get; set; }

        public Guid StudentId { get; set; } 

        public Guid CourseId { get; set; }


    }
}
