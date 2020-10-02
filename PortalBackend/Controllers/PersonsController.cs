using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PortalBackend.Data;
using PortalBackend.Models;

namespace PortalBackend.Controllers
{
    //api/commands
    // try to use [controller]
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly MockPersonRepo _repo = new MockPersonRepo();
        //GET api/persons
        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetAllPersons()
        {
            var personItems = _repo.GetAllPersons();
            return Ok(personItems);
        }

        //GET api/persons/closest_birthday
        [HttpGet("closest_birthday")]
        public ActionResult<Person> GetClosestBirthdayPerson()
        {
            var person = _repo.GetClosestBirthdayPerson();
            return Ok(person);
        }
    }
}