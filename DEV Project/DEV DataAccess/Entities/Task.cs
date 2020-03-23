using System;
using System.Collections.Generic;

namespace DEV_DataAccess.Entities
{
    public partial class Task
    {
        public Guid Id { get; set; }
        public Guid? CourseId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
