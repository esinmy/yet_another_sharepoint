using AutoMapper;
using PortalBackend.Dtos;
using PortalBackend.Models;

namespace PortalBackend.Profiles
{
    public class PersonsProfile : Profile
    {
        public PersonsProfile()
        {
            CreateMap<Person, PersonReadDto>();
        }
    }
}