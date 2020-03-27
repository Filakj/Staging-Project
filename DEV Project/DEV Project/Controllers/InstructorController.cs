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
    public class InstructorController : ControllerBase
    {
        private readonly ILogger<InstructorController> _logger;
        private readonly IInstructorRepository _instructorRepository; 

        public InstructorController(ILogger<InstructorController> logger, IInstructorRepository instructorRepository)
        {
            _logger = logger;
            _instructorRepository = instructorRepository; 
        }

        

        // GET: api/Instructor/5
        [HttpGet("{id}")]
        public IActionResult GetInstructorById(Guid id)
        {
            Instructor instructor = _instructorRepository.GetInstructorById(id);
            return Ok(instructor);
        }


        
        // POST: api/Instructor
        [HttpPost]
        public IActionResult PostInstructor(Instructor instructor)
        {

            _instructorRepository.AddInstructor(instructor);
            _instructorRepository.SaveChanges();

            Guid newId = new Guid();
            instructor.Id = newId; 
       
            return CreatedAtAction(nameof(GetInstructorById), new { id = instructor.Id }, instructor);
        }

        // PUT: api/Instructor/5
        [HttpPut("{id}")]
        public IActionResult Put(Instructor instructor)
        {
            _instructorRepository.UpdateInstructor(instructor);
            _instructorRepository.SaveChanges();

            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult DeleteInstructor(Guid id)
        {
            _instructorRepository.DeleteInstructor(id);
            _instructorRepository.SaveChanges();

            return Content($"Account with id: {id} has been deleted.");
        }
        

    }
}
