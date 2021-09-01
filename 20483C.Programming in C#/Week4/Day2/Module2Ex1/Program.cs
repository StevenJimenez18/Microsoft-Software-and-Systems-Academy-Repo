using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateArray();
            Console.ReadLine();
        }

        static void CreateArray()
        {
            int[,] newArray = new int[3,3] { { 1, 2 ,3}, { 4, 5, 6 }, { 7, 8, 9 } };

            
                for (int i = 0; i < newArray.GetLength(0); i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("---------");

                    for (int j = 0; j < newArray.GetLength(1); j++)
                    {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("|");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(newArray[i, j]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("|");
                }

                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("---------");

        }
    }
}
