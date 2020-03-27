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
    public class RegistrationController : ControllerBase
    {
        private readonly ILogger<RegistrationController> _logger;
        private readonly IRegistrationRepository _registrationRepository;

        public RegistrationController(ILogger<RegistrationController> logger, IRegistrationRepository registrationRepository)
        {
            _logger = logger;
            _registrationRepository = registrationRepository; 
        }


        // GET: api/Registration
        [HttpGet]
        public IEnumerable<Registration> Get()
        {
            IEnumerable<Registration> registrations = _registrationRepository.GetAllRegistrations();
            return registrations.ToList();
        }

        // GET: api/Registration/5
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute]Guid id)
        {
            Registration registration = _registrationRepository.GetRegistrationById(id);
            _logger.LogInformation($"Getting registration with id: {id}");
            return Ok(registration);
        }

        // POST: api/Registration
        [HttpPost]
        public IActionResult PostRegistration(Registration registration)
        {

            _registrationRepository.AddRegistration(registration);
            _registrationRepository.SaveChanges();


            _logger.LogInformation($"Course with id: {registration.Id} has been added.");
            return CreatedAtAction(nameof(Get), new { id = registration.Id }, registration);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult DeleteRegistration(Guid id)
        {
            _registrationRepository.DeleteRegistration(id);
            _registrationRepository.SaveChanges();

            return Content($"Registration with id: {id} has been deleted.");
        }
    }
}
