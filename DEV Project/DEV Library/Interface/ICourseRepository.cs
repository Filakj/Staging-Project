using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Logic = DEV_Library.Models; 
namespace DEV_Library.Interface
{
    public interface ICourseRepository
    {
        /// <summary>
        /// Creates a new Course in the database 
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        //public Task<bool> CreateCourseAsync(Logic.Course course);

        void AddCourse(DEV_Library.Models.Course course);

        DEV_Library.Models.Course GetCourseById(Guid id);

        void UpdateCourse(DEV_Library.Models.Course course);

        IEnumerable<DEV_Library.Models.Course> GetAllCourses();

        void DeleteCourse(Guid id); 

        
        //TODO Upgrade C# to 8.0 

    }
}
