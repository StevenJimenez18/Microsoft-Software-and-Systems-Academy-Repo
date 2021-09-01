using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module2Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentNames();



            Console.ReadLine();
        }

        static void GetStudentNames()
        {
            string[] students = new string[5];
            Console.WriteLine("Please enter 5 student names.");
            for (int i = 0; i < 5; i++)
            {

                Console.Write($"Student {i + 1}: ");
                students[i] = (Console.ReadLine());

            }

            Console.WriteLine("----------------");
            GetGrades(students);
        }

        static void GetGrades(string[] names)
        {
            char[][] jaggedArray = new char[5][];
            Random rand = new Random();

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new char[rand.Next(1, 5)];
            }

                for (int i = 0; i < jaggedArray.Length; i++)
                {

                Console.WriteLine($"Please enter the grades for {names[i]}: ");

                for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        Console.Write($"Class {j + 1}: ");
                        jaggedArray[i][j] = Convert.ToChar(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("----------------");

            Console.WriteLine("Now loading student data......");
            for (var i = 0; i <= 100; ++i)
            {
                ConsoleUtility.WriteProgressBar(i, true);
                Thread.Sleep(20);
            }
            Console.WriteLine(" Data has been loaded successfully...");

            for (int i = 0; i < jaggedArray.Length; i++)
                    {
                    Console.WriteLine($"Here are the grades for {names[i]}: ");

                    for (int j = 0; j < jaggedArray[i].Length; j++)
                        {
                            Console.Write($"Class {i+1}: ");
                            Console.WriteLine($"{jaggedArray[i][j]}");
                        }
                        Console.WriteLine();
                    }


        }
    }
        
}
