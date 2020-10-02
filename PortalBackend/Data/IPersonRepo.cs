using System.Collections.Generic;
using PortalBackend.Models;

namespace PortalBackend.Data
{
    public interface IPersonRepo
    {
        IEnumerable<Person> GetAllPersons();
        Person GetClosestBirthdayPerson();
    }
}