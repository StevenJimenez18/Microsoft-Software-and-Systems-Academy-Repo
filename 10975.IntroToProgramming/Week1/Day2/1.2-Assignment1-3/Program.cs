using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Assignment1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNum();
            Console.WriteLine("This is the end of the application");
            Console.ReadLine();
        }

        static void GetNum()
        {
            Console.WriteLine("Please enter two numbers: ");
            Console.Write($"Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            SelectOperation(num1, num2);
            Console.Write("Would you like to do more operations? Y/N: ");
            char answer = Convert.ToChar(Console.ReadLine());


            if (answer == 'Y' || answer == 'y')
            {
                GetNum();
            }
        }

        static void SelectOperation(int num1, int num2)
        {
            Console.Write("Please select which operation you would like: 1.Add 2.Subtract 3.Divide: ");
            int result = Convert.ToInt32(Console.ReadLine());
            switch (result)
            {
                case 1:
                    result = Add(num1, num2);
                    Console.WriteLine($"Result is: {result}");
                    break;
                case 2:
                    result = Sub(num1, num2);
                    Console.WriteLine($"Result is: {result}");
                    break;
                case 3:
                    decimal newResult = Div(num1, num2);
                    Console.WriteLine($"Result is: {newResult}");
                    break;
                default:
                    Console.WriteLine("Didnt select a valid choice");
                    SelectOperation(num1, num2);
                    break;
            }
          
        }
        static int Add(int i, int j)
        {
            return i + j;
        }

        static int Sub(int i, int j)
        {
            return i - j;
        }

        static int Div(int i, int j)
        {
            return i / j;
        }
    }
}
