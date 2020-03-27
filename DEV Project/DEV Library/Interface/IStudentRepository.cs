using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_Library.Interface
{
    public interface IStudentRepository
    {
        void AddStudent(DEV_Library.Models.Student student);

        DEV_Library.Models.Student GetStudentById(Guid id);

        void UpdateStudent(DEV_Library.Models.Student student);

        void DeleteStudent(Guid id);
        void SaveChanges();
    }
}
