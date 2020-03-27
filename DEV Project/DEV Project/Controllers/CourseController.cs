using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DEV_Library.Interface;
using DEV_Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DEV_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ILogger<CourseController> _logger;
        private readonly ICourseRepository _courseRepository;
        
        
        // GET: api/Course
        [HttpGet]
        public IEnumerable<Course> GetAllCourses()
        {
            IEnumerable<Course> courses = _courseRepository.GetAllCourses();
            return courses.ToList(); 
        }


        // GET: api/Course/5
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute]Guid id)
        {
            Course course = _courseRepository.GetCourseById(id);
            _logger.LogInformation($"Getting course with id: {id}");
            return Ok(course);
        }

        // POST: api/Course
        [HttpPost]
        public IActionResult PostCourse(Course course)
        {
            Guid newId = new Guid();
            course.Id = newId;

            _courseRepository.AddCourse(course);
            _courseRepository.SaveChanges();

            _logger.LogInformation($"Course with id: {course.Id} has been added.");
            return CreatedAtAction(nameof(Get), new { id = course.Id }, course);
        }

        // PUT: api/Course/5
        [HttpPut("{id}")]
        public IActionResult Put(Course course)
        {    
                _courseRepository.UpdateCourse(course);
                _courseRepository.SaveChanges();

            return NoContent();
        }
          

        // DELETE: api/Course/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(Guid id)
        {
            _courseRepository.DeleteCourse(id);
            _courseRepository.SaveChanges();

            return Content($"Course with id: {id} has been deleted.");
        }
    }
}
