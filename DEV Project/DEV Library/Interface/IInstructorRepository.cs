using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_Library.Interface
{
    public interface IInstructorRepository
    {

        void AddInstructor(DEV_Library.Models.Instructor instructor);

        DEV_Library.Models.Instructor GetInstructorById(Guid id);

        void UpdateInstructor(DEV_Library.Models.Instructor instructor);

        void DeleteInstructor(Guid id);

        void SaveChanges();
    }
}
