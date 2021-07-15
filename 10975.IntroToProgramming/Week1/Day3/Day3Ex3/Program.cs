using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Lets sort some arrays!");
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
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                newArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Your Array is: ");
            foreach (int num in newArray)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            SortArray(newArray);
            RepeatOperation();
        }

        static void SortArray(int[] newArray)
        {
            Console.WriteLine("- Would you like to sort your array? 1.Ascending 2.Descending: ");
            int userAnswer = Convert.ToInt32(Console.ReadLine());
            if(userAnswer != 1 && userAnswer != 2)
            {
                Console.WriteLine("You entered an invalid choice. Lets try again!");
                    SortArray(newArray);
                
            }
            if (userAnswer == 1)
            {
                Console.Write("Your sorted ascending array is: ");
                Array.Sort(newArray);
                foreach (int num in newArray)
                {
                    Console.Write(num + " ");
                }
            }
            if (userAnswer == 2)
            {
                Console.Write("Your sorted descending array is: ");
                Array.Sort(newArray);
                Array.Reverse(newArray);
                foreach (int num in newArray)
                {
                    Console.Write(num + " ");
                }
            }
        }

        static void RepeatOperation()
        {
            Console.WriteLine("- Would you like to sort another array? Y/N: ");
            char userAnswer = Convert.ToChar(Console.ReadLine());
            if (userAnswer == 'y' || userAnswer == 'Y')
            {
                GetArray();
            }
        }
    }
}
