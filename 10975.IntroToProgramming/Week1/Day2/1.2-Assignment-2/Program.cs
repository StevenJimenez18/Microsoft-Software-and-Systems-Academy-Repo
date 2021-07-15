using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNum();

            Console.WriteLine("This is the end of the application.");
            Console.ReadLine();
        }
        static void GetNum()
        {
            Console.WriteLine("Please enter two whole numbers for comparison");
            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            CompareNumbers(num1, num2);
            Console.Write("Compare again? Y/N: ");
            char answer = Convert.ToChar(Console.ReadLine());
            if(answer == 'y' || answer == 'Y')
            {
                GetNum();
            }
        }
        static void CompareNumbers(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"Congratulations, Your numbers {num1} and {num2} match!");
            }
            else
            {
                Console.WriteLine($"Sorry, it looks like your numbers {num1} and {num2} don't match.");
            }
        }
    }
}
