using System;
using System.Collections.Generic;
using System.Text;
using DEV_Library.Interface;
using DEV_Library.Models; 

namespace DEV_DataAccess.Repository
{
    public class StudentRepository : DEV_Library.Interface.IStudentRepository
    {
        private Entities.DEVContext _context; 

        public StudentRepository(Entities.DEVContext context)
        {
            _context = context;
        }

        public void AddStudent(DEV_Library.Models.Student student)
        {
            Entities.Student newStudent = Mapper.MapStudent(student);
            _context.Add(newStudent);

        }

        public void DeleteStudent(Guid id)
        {
            Entities.Student student = _context.Student.Find(id);
            _context.Remove(student); 
        }

        public DEV_Library.Models.Student GetStudentById(Guid id)
        {
            Entities.Student student = _context.Student.Find(id);
            return Mapper.MapStudent(student);
        }


        public void UpdateStudent(DEV_Library.Models.Student student)
        {
            Entities.Student currentStudent = _context.Student.Find(student.Id);
            Entities.Student updatedStudent = Mapper.MapStudent(student);

            _context.Entry(currentStudent).CurrentValues.SetValues(updatedStudent); 
        }




    }//class 
}
