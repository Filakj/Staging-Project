using System;
using System.Collections.Generic;
using System.Text;
using DEV_Library.Interface;
using DEV_Library.Models;

namespace DEV_DataAccess.Repository
{
    public class InstructorRepository : DEV_Library.Interface.IInstructorRepository
    {
        private Entities.DEVContext _context;

        public InstructorRepository(Entities.DEVContext context)
        {
            _context = context;
        }

        public void AddInstructor(DEV_Library.Models.Instructor instructor)
        {
            Entities.Instructor newInstructor = Mapper.MapInstructor(instructor);
            _context.Add(newInstructor);

        }

        public void DeleteInstructor(Guid id)
        {
            Entities.Course course = _context.Course.Find(id);
            _context.Remove(course); 
        }

        public DEV_Library.Models.Instructor GetInstructorById(Guid id)
        {
            Entities.Instructor instructor = _context.Instructor.Find(id);
            return Mapper.MapInstructor(instructor);
        }

        public void UpdateInstructor(DEV_Library.Models.Instructor instructor)
        {
            Entities.Instructor currentInstructor = _context.Instructor.Find(instructor.Id);
            Entities.Instructor updatedInstructor = Mapper.MapInstructor(instructor);

            _context.Entry(currentInstructor).CurrentValues.SetValues(updatedInstructor);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
