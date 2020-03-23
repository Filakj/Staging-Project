using System;
using System.Collections.Generic;

namespace DEV_DataAccess.Entities
{
    public partial class Registration
    {
        public Guid Id { get; set; }
        public Guid? StudentId { get; set; }
        public Guid? CourseId { get; set; }
    }
}
