using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Ex2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            PromptUser();
            Console.WriteLine("You may close the application now.");
            Console.ReadLine();
        }

        static void PromptUser()
        {
            Console.Write("Please enter a year to be checked: ");
            string stringyear = (Console.ReadLine());
            int year;
            bool result = int.TryParse(stringyear, out year);
            IsLeapYear(year);
            CheckAgain();
        }

        static bool IsLeapYear(int year)
        {
           
            if (year % 4 == 0 && year % 100 == 0 )
            {
                Console.WriteLine($"sorry, {year} is not a leap year.");
                return false;
            }

            if (year % 4 == 0)
            {
                Console.WriteLine($"congrats, {year} is a leap year!");
                return true;
            }

            else
            {
                Console.WriteLine($"sorry, {year} is not a leap year.");
                return false;
            }

        }

        static void CheckAgain()
        {
            Console.Write("Would you like to try again? Y/N: ");
            char answer = Convert.ToChar(Console.ReadLine());
            if (answer == 'y' || answer == 'Y')
            {
                PromptUser();
            }
            if (answer == 'N' || answer == 'n')
            {
                return;
            }
            else if (answer == 'Y' || answer == 'y' || answer == 'N' || answer == 'n')
            {
                Console.WriteLine("You did not make a valid selection");
                CheckAgain();
            }
        }
    }
}
