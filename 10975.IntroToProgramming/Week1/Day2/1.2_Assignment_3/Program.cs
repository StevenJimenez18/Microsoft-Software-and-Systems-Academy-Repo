using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfTen();
            Console.WriteLine("This is the end of the application");
            Console.ReadLine();
        }

        static void SumOfTen()
        {
            int counter = 0;
            for(int i = 0; i <= 10; i++)
            {
                counter += i;
            }

            Console.WriteLine($"The sum is {counter} ");
        }
    }
}
