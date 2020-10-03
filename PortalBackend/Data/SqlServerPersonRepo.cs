using System.Collections.Generic;
using System.Linq;
using PortalBackend.Models;

namespace PortalBackend.Data
{
    public class SqlServerPersonRepo : IPersonRepo
    {
        private readonly PersonContext _context;

        public SqlServerPersonRepo(PersonContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _context.Persons.ToList();
        }

        public Person GetClosestBirthdayPerson()
        {
            // TODO: add logic to find closest birthday person
            return _context.Persons.FirstOrDefault();
        }
    }
}