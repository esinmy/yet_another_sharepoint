using Microsoft.EntityFrameworkCore;
using PortalBackend.Models;

namespace PortalBackend.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> opt) : base(opt)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}