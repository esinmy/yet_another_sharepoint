using System;
using System.Collections.Generic;
using PortalBackend.Models;

namespace PortalBackend.Data
{
    public class MockPersonRepo : IPersonRepo
    {
        public IEnumerable<Person> GetAllPersons()
        {
            return new List<Person> {
                new Person
                {
                    FamilyName = "Ivanov",
                    FirstName = "Ivan",
                    PatronymName = "Ivanovich",
                    Birthday = new DateTime(2008, 5, 1)
                },
                new Person
                {
                    FamilyName = "Ivanov2",
                    FirstName = "Ivan2",
                    PatronymName = "Ivanovich2",
                    Birthday = new DateTime(2010, 5, 1)
                }
        };
        }

        public Person GetClosestBirthdayPerson()
        {
            return new Person
            {
                FamilyName = "Ivanov",
                FirstName = "Ivan",
                PatronymName = "Ivanovich",
                Birthday = new DateTime(2008, 5, 1)
            };
        }
    }
}