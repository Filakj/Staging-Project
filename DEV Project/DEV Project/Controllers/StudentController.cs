using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DEV_Library.Interface;
using DEV_Library.Models;
using Microsoft.Extensions.Logging;

namespace DEV_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly IStudentRepository _studentRepository; 

        public StudentController(ILogger<StudentController> logger, IStudentRepository studentRepository)
        {
            _logger = logger;
            _studentRepository = studentRepository;
        }

        //GET: api/Student/5
        [HttpGet("{id}")]
        public IActionResult GetStudentById(Guid id)
        {
            Student student = _studentRepository.GetStudentById(id);
            return Ok(student);
        }

        // POST: api/Student
        [HttpPost]
        public IActionResult PostStudent(Student student)
        {
            Guid newId = new Guid();
            student.Id = newId;

            _studentRepository.AddStudent(student);
            _studentRepository.SaveChanges();
       
            return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
        }

        // DELETE: api/Student/5
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(Guid id)
        {
            _studentRepository.DeleteStudent(id);
            _studentRepository.SaveChanges();

            return Content($"Account with id: {id} has been deleted.");
        }

        
        // PUT: api/Student/5
        [HttpPut("{id}")]
        public IActionResult Put(Student student)
        {
            _studentRepository.UpdateStudent(student);
            _studentRepository.SaveChanges();

            return NoContent();
        }



     
    }
}
