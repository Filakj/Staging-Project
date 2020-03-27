using System;
using System.Collections.Generic;
using System.Linq;
using DEV_Library.Interface;
using DEV_Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace DEV_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ILogger<TaskController> _logger;
        private readonly ITaskRepository _taskRepository; 

        public TaskController(ILogger<TaskController> logger, ITaskRepository taskRepository)
        {
            _logger = logger;
            _taskRepository = taskRepository; 
        }

        // GET: api/Task
        [HttpGet]
        public IEnumerable<DEV_Library.Models.Task> Get()
        {
            IEnumerable<Task> tasks = _taskRepository.GetTasks();
            return tasks.ToList();
        }

        // GET: api/Task/5
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute]Guid id)
        {
           Task task = _taskRepository.GetTaskById(id);
            _logger.LogInformation($"Getting task with id: {id}");
            return Ok(task);
        }


        // POST: api/Task
        [HttpPost]
        public IActionResult PostRegistration(Task task)
        {
            Guid newId = new Guid();
            task.Id = newId;

            _taskRepository.AddTask(task);
            _taskRepository.SaveChanges();

            _logger.LogInformation($"Course with id: {task.Id} has been added.");
            return CreatedAtAction(nameof(Get), new { id = task.Id }, task);
        }

        // PUT: api/Task/5
        [HttpPut("{id}")]
        public IActionResult Put(Task task)
        {
            _taskRepository.UpdateTask(task);
            _taskRepository.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Task/5
        [HttpDelete("{id}")]
        public IActionResult DeleteRegistration(Guid id)
        {
            _taskRepository.DeleteTask(id);
            _taskRepository.SaveChanges();

            return Content($"Registration with id: {id} has been deleted.");
        }

        // GET: api/Task/Course/5
        [HttpGet("Course/{CourseId}")]
        public IActionResult GetByCourseId([FromRoute]Guid id)
        {
            IEnumerable<Task> tasks = _taskRepository.GetTasksByCourseId(id);

            _logger.LogInformation($"Getting tasks based on course with id: {id}");
            return Ok(tasks);
        }



    }
}
