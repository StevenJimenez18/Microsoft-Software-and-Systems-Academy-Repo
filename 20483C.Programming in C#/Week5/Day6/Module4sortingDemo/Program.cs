using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4sortingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Studlist = new List<Student>();
            Studlist.Add(new Student() { Name = "Bill", Adress = "NY", Grades = 80, Age = 45});
            Studlist.Add(new Student() { Name = "Steven", Adress = "CA", Grades = 95, Age = 22});
            Studlist.Add(new Student() { Name = "Bob", Adress = "FL", Grades = 70, Age = 35 });
            Studlist.Add(new Student() { Name = "Robin", Adress = "MI", Grades = 84, Age = 29});
            Studlist.Add(new Student() { Name = "Kevin", Adress = "MA", Grades = 68, Age = 42});
            Studlist.Add(new Student() { Name = "Alex", Adress = "OH", Grades = 60, Age = 55});

            Studlist.Sort();
            foreach (var s in Studlist)
            {
                Console.WriteLine($"Name: {s.Name}, Address: {s.Adress}, Grades: {s.Grades}, Age: {s.Age}");
            }

            Console.WriteLine("--------------------------");
            //Studlist.Sort(new StudentComparer());
            foreach (var s in Studlist)
            {
                Console.WriteLine($"Name: {s.Name}, Address: {s.Adress}, Grades: {s.Grades}, Age: {s.Age}");
            }
            
            Console.WriteLine("--------------------------");
            Studlist.Sort(new StudentAgeComparer());
            foreach (var s in Studlist)
            {
                Console.WriteLine($"Name: {s.Name}, Address: {s.Adress}, Grades: {s.Grades}, Age: {s.Age}");
            }
            Console.ReadLine();
        }
    }
}
