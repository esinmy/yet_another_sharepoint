using System;

namespace PortalBackend.Dtos
{
    public class PersonReadDto
    {
        public string FamilyName { get; set; }
        public string FirstName { get; set; }
        public string PatronymName { get; set; }
        public DateTime Birthday { get; set; }
    }
}