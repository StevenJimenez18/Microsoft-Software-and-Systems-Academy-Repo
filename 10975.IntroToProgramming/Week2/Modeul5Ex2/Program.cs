using Modeul5Ex2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeul5Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome new student!");
            Console.WriteLine("Lets get you enrolled in our database.");
            Student newStudent = new Student();
            Console.Write("Please enter your first name: ");
            newStudent._FName = Console.ReadLine();
            Console.Write("Please enter your middle initial: ");
            newStudent._MInitial = Convert.ToChar(Console.ReadLine());
            Console.Write("Please enter your last name: ");
            newStudent._LName = Console.ReadLine();
            Console.Write("Please enter your previous GPA: ");
            newStudent._GPA = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Please enter your age: ");
            newStudent.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your gender: 1.Male 2.Female ");
            int response = Convert.ToInt32(Console.ReadLine());
            if(response == 1)
            {
                newStudent.isMale = true;
            }
            else
            {
                newStudent.isMale = false;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Thank you for the information.");
            Console.WriteLine("Here is your new student record:");
            Console.WriteLine("*******************");
            Console.WriteLine($"First Name: {newStudent._FName}");
            Console.WriteLine($"Middle Inital: {newStudent._MInitial}.");
            Console.WriteLine($"Last Name: {newStudent._LName}");
            Console.WriteLine($"GPA: {newStudent._GPA}");
            Console.WriteLine($"Age: {newStudent.Age}");
            if (newStudent.isMale == true)
            {
                Console.WriteLine("Gender: Male");
            }
            else
            {
                Console.WriteLine("Gender: Female");
            }
            Console.WriteLine("*******************");
            Console.ReadLine();
        }
    }
}
