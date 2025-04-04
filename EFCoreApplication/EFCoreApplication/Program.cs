using System;
using System.Linq;
using EFCoreApplication;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using (var context = new DBContext())
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var city = new City { Name = "Mäder" };
            var city2 = new City { Name = "Vienna" };

            context.Cities.AddRange(city, city2);
            context.SaveChanges();

            var person1 = new Person { FirstName = "Lars", LastName = "Veljaca", Age = 17, City = city };
            var person2 = new Person { FirstName = "Hans", LastName = "Peter", Age = 55, City = city2 };

            context.People.AddRange(person1, person2);
            context.SaveChanges();

            var people = context.People.Include(p => p.City).ToList();

            Console.WriteLine("\n Alle Personen in der Datenbank:");
            foreach (var p in people)
            {
                Console.WriteLine($"Id: {p.Id}, Name: {p.FirstName} {p.LastName}, Alter: {p.Age}, Stadt: {p.City.Name}");
            }
        }
    }
}