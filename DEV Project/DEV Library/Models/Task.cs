using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_Library.Models
{
    public partial class Task
    {
        public Guid Id { get; set; }

        public Guid CourseId { get; set; } 

        public string TaskName { get; set; } 

        public string TaskDescription { get; set; } 

        public DateTime DueDate { get; set; }

    }
}
