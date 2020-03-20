using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_DataAccess.Entities
{
    public class Instructor
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }
    }
}
