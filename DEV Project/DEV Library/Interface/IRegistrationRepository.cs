using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_Library.Interface
{
    public interface IRegistrationRepository
    {

        IEnumerable<DEV_Library.Models.Registration> GetAllRegistrations(); 

        void AddRegistration(DEV_Library.Models.Registration registration);

        DEV_Library.Models.Registration GetRegistrationById(Guid id);

        void DeleteRegistration(Guid id);


        IEnumerable<DEV_Library.Models.Registration> GetCoursesIdByStudentId(Guid studentId);

        IEnumerable<DEV_Library.Models.Registration> GetRegistrationsByCourseId(Guid courseId);

        void SaveChanges();

    }
}
