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



        Guid GetCourseIdByStudentId(Guid studentId);

        IEnumerable<DEV_Library.Models.Registration> GetRegistrationByCourse(Guid courseId); 

        

    }
}
