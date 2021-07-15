using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, lets do some area calculations!");
            UserMenu();
            Console.WriteLine("You may close the application now.");
            Console.ReadLine();
        }

        static void UserMenu()
        {
            
            Console.Write("Please select which operation you would like to perform: 1.Traingle 2.Square 3.Rectangle: ");
            int userAnswer = Convert.ToInt32(Console.ReadLine());
            if(userAnswer != 1 && userAnswer != 2 && userAnswer != 3)
            {
                Console.WriteLine("You made an invalid selection so lets try this again!");
                UserMenu();
            }
            int counter = 1;
            double num1;
            double num2;
            if(userAnswer == 1)
            {
                Console.WriteLine("You will be asked to enter two numbers");
                num1 = GetNumbers(counter);
                counter++;
                num2 = GetNumbers(counter);
                TriangleArea(num1, num2);
                RetryOperation();
            }
            if(userAnswer == 2)
            {
                Console.WriteLine("You will be asked to enter a number");
                num1 = GetNumbers(counter);
                SquareArea(num1);
                RetryOperation();
            }
            if (userAnswer == 3)
            {
                Console.WriteLine("You will be asked to enter two numbers");
                num1 = GetNumbers(counter);
                counter++;
                num2 = GetNumbers(counter);
                RectangleArea(num1, num2);
                RetryOperation();
            }
        }

        static double GetNumbers(int num)
        {

            Console.Write($"number {num}: ");
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }

        static void TriangleArea(double num1, double num2)
        {
            double area = .5 * (num1 * num2);
            Console.WriteLine($"The area of your triangle is {area}");
        }

        static void SquareArea(double num1)
        {
            double area = Math.Pow(num1, 2);
            Console.WriteLine($"The area of your square is {area}");
        }

        static void RectangleArea(double num1, double num2)
        {
            double area =  num1 * num2;
            Console.WriteLine($"The area of your rectangle is {area}");
        }

        static void RetryOperation()
        {
            Console.Write("Would you like to perfom another operation? Y/N: ");
            char userResponse = Convert.ToChar(Console.ReadLine());
            if (userResponse == 'y' || userResponse == 'Y')
            {
                UserMenu();
            }
        }
    }
}
