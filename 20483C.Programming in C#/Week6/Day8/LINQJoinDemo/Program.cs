using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQJoinDemo
{
    class Program
    {

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Pet
        {
            public string Name { get; set; }
            public Person Owner { get; set; }
        }

        static void Main(string[] args)
        {
            Person terry = new Person() { FirstName = "Terry", LastName = "Crews" };
            Person jack = new Person() { FirstName = "Jack", LastName = "Black" };
            Person steven = new Person() { FirstName = "Steven", LastName = "Jimenez" };

            Pet bruno = new Pet { Name = "Bruno", Owner = steven };
            Pet meatball = new Pet { Name = "Meatball", Owner = jack };
            Pet fluffy = new Pet { Name = "Fluffy", Owner = terry };
            Pet sheebs = new Pet { Name = "Sheebs", Owner = steven };

            List<Person> people = new List<Person> { terry, jack, steven };

            List<Pet> pets = new List<Pet> { bruno, meatball, fluffy, sheebs };


            var result = from person in people
                         join pet in pets
                         on person equals pet.Owner
                         select new { Ownername = person.FirstName, Petname = pet.Name };

            foreach (var r in result)
                Console.WriteLine($"Owner: {r.Ownername}, Pet: {r.Petname}");

            Console.ReadLine();
        }
    }
}
