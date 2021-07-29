using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.) If year is leap

            //    Given a year as integer, write a method that checks if year is leap.

            //    Expected input and output

            //    IfYearIsLeap(2016) → true IfYearIsLeap(2018) → false


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
            int checkMonth = DateTime.DaysInMonth(year, 2);

            if (checkMonth == 29)
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
            if(answer == 'y' || answer == 'Y')
            {
                PromptUser();
            }
            if(answer == 'N' || answer =='n')
            {
                return;
            }
            else if(answer == 'Y' || answer == 'y' || answer == 'N' || answer == 'n')
            {
                Console.WriteLine("You did not make a valid selection");
                CheckAgain();
            }
        }
    }
}
