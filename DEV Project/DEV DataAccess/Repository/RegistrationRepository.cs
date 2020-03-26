using System;
using System.Collections.Generic;
using System.Text;
using DEV_Library.Interface;
using DEV_Library.Models;


namespace DEV_DataAccess.Repository
{
    public class RegistrationRepository : DEV_Library.Interface.IRegistrationRepository
    {
        private Entities.DEVContext _context;

        public RegistrationRepository(Entities.DEVContext context)
        {
            _context = context;
        }

        public void AddRegistration(DEV_Library.Models.Registration registration)
        {
            Entities.Registration newRegistration = Mapper.MapRegistration(registration);
            _context.Add(newRegistration);
        }

        public void DeleteRegistration(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Registration> GetAllRegistrations()
        {
            throw new NotImplementedException();
        }

        public Guid GetCourseIdByStudentId(Guid studentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Registration> GetRegistrationByCourse(Guid courseId)
        {
            throw new NotImplementedException();
        }

        public DEV_Library.Models.Registration GetRegistrationById(Guid id)
        {
            Entities.Registration registration = _context.Registration.Find(id);
            return Mapper.MapRegistration(registration);
        }



    }
}
