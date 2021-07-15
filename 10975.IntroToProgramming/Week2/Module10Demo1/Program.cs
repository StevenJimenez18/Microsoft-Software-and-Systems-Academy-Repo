using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10Demo1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            num1 = 100;
            num2 = 200;
            Swap(ref num1,ref num2);
            Console.WriteLine($"Swapped Values: num1: {num1}, num2 {num2}");
            Console.ReadLine();

        }

        static void Swap(ref int i,ref int j)
        {
            int temp;
            temp = i;
            i = j;
            j = temp;
        }
    }
}
