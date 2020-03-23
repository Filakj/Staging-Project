using System;
using System.Collections.Generic;
using System.Text;
using DEV_Library.Interface;
using DEV_Library.Models;

namespace DEV_DataAccess.Repository
{
    public class CourseRepository : DEV_Library.Interface.ICourseRepository
    {
        private Entities.DEVContext _context;

        public CourseRepository(Entities.DEVContext context)
        {
            _context = context;
        }

        public void AddCourse(DEV_Library.Models.Course course)
        {
            Entities.Course newCourse = Mapper.MapCourse(course);
            _context.Add(newCourse);
        }

        public DEV_Library.Models.Course GetCourseById(Guid id)
        {
            Entities.Course course = _context.Course.Find(id);
            return Mapper.MapCourse(course);
        }


    }
}
