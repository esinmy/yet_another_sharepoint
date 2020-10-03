using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalBackend.Data;
using PortalBackend.Dtos;
using PortalBackend.Models;

namespace PortalBackend.Controllers
{
    //api/commands
    // try to use [controller]
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepo _repo;
        private readonly IMapper _mapper;

        public PersonsController(IPersonRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        //GET api/persons
        [HttpGet]
        public ActionResult<IEnumerable<PersonReadDto>> GetAllPersons()
        {
            var personItems = _repo.GetAllPersons();
            return Ok(_mapper.Map<IEnumerable<PersonReadDto>>(personItems));
        }

        //GET api/persons/closest_birthday
        [HttpGet("closest_birthday")]
        public ActionResult<PersonReadDto> GetClosestBirthdayPerson()
        {
            var person = _repo.GetClosestBirthdayPerson();
            return Ok(person);
        }
    }
}