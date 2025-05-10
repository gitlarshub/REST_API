using System;
using System.Collections.Generic;

namespace EFCoreApplication
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public List<Person> People { get; set; } = new List<Person>();
    }
}
