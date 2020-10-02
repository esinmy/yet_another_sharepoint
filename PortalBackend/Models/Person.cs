using System;

namespace PortalBackend.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FamilyName { get; set; }
        public string FirstName { get; set; }
        public string PatronymName { get; set; }
        public DateTime Birthday { get; set; }
    }
}