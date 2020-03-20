using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_Library.Models
{
    public partial class Student
    {
        public Guid Id { get; set; } 

        public string FirstName { get; set; } 

        public string LastName { get; set; } 

        public string Email { get; set; }

        public string Username { get; set; } 


    }
}
