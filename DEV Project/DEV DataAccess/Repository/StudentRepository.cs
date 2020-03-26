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
            throw new NotImplementedException();
        }

        public DEV_Library.Models.Student GetStudentById(Guid id)
        {
            Entities.Student student = _context.Student.Find(id);
            return Mapper.MapStudent(student);
        }


        //TODO Finish Update 
        //update
        public void UpdateStudent(DEV_Library.Models.Student student)
        {
        }

        //Delete Student 
        // student delete their info ? Not Implemented 
       



    }//class 
}
