using System;
using System.ComponentModel.DataAnnotations;

namespace PortalBackend.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FamilyName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string PatronymName { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
    }
}