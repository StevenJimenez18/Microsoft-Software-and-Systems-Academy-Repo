using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day3Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Lets reverse some arrays!");
            GetArray();
            Console.WriteLine("You may close the application now.");
            Console.ReadLine();
        }

        static void GetArray()
        {
            int[] newArray;
            Console.Write("Enter a whole number for the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            newArray = new int[size];
            Console.WriteLine($"Please enter {size} individual numbers for your array");
            for(int i = 0; i < newArray.Length; i++)
            {
                Console.Write($"Number {i+1}: ");
                newArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Your Array is: ");
            foreach(int num in newArray)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            ReverseArray(newArray);
            RepeatOperation();
        }

        static void ReverseArray(int[] newArray)
        {
            Console.WriteLine("- Would you like to reverse your array? Y/N: ");
            char userAnswer = Convert.ToChar(Console.ReadLine());
            if(userAnswer == 'y' || userAnswer == 'Y')
            {
                Console.Write("Your reveresed array is: ");
                Array.Reverse(newArray);
                foreach (int num in newArray)
                {
                    Console.Write(num + " ");
                }
            }
        }

        static void RepeatOperation()
        {
            Console.WriteLine("- Would you like to reverse another array? Y/N: ");
            char userAnswer = Convert.ToChar(Console.ReadLine());
            if (userAnswer == 'y' || userAnswer == 'Y')
            {
                GetArray();
            }
        }
    }
}
