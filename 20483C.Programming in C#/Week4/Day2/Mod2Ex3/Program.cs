using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            Console.WriteLine("You may close the application now.");
            Console.ReadLine();
        }

        static void Intro()
        {
            Console.WriteLine("Hello, lets have some fun with numbers!");
            GetNumbers();
        }
        static void Tryagain()
        {
            Console.WriteLine("Would you like to try again? 1.Yes 2.No: ");
            int tryagain;
            bool result3 = int.TryParse(Console.ReadLine(), out tryagain);
            if (tryagain == 1)
            {
                GetNumbers();
            }
            else if(tryagain != 1 && tryagain !=2)
            {
                Console.WriteLine("You did not enter a valid selection. Please try again");
                Tryagain();
            }
        }

        static void GetNumbers()
        {
            Console.Write("how many numbers would you like to use? 2 or 3: ");
            int choice1;
            bool result = int.TryParse(Console.ReadLine(), out choice1);
            if(choice1 != 2 && choice1 != 3)
            {
                Console.WriteLine("A valid choice wasn't selected.");
                GetNumbers();
            }
            else
            {
                Console.Write("Would you like to try addition or Multiplication? 1.Addition 2.Multiplcation: ");
                int choice2;
                bool result2 = int.TryParse(Console.ReadLine(), out choice2);
                if (choice2 != 1 && choice2 != 2)
                {
                    Console.WriteLine("A valid choice wasn't selected.");
                    GetNumbers();
                }
                else
                {

                    AddOrMult(choice1, choice2);
                }
            }

            Tryagain();
        }

        static void AddOrMult(int choice1, int choice2)
        {
            if(choice2 == 1)
            {
                string word = "whole number";
                int[] numList = new int[choice1];

                for (int i = 0; i < choice1; i++)
                {
                    Console.Write($"Please enter a {word} for num{i+1}: ");
                    int num;
                    bool result2 = int.TryParse(Console.ReadLine(), out num);
                    numList[i] = num;
                }

                if(numList.Length == 2)
                {
                    Add(numList[0], numList[1]);
                }
                else
                {
                    Add(numList[0], numList[1], numList[2]);
                }
            }
            else if(choice2 == 2)
            {
                string word = "float";
                float[] numList = new float[choice1];
                for (int i = 0; i < choice1; i++)
                {
                    Console.Write($"Please enter a {word} for num{i+1}: ");
                    float num;
                    bool result2 = float.TryParse(Console.ReadLine(), out num);
                    numList[i] = num;
                }

                if (numList.Length == 2)
                {
                    Multiply(numList[0], numList[1]);
                }
                else
                {
                    Multiply(numList[0], numList[1], numList[2]);
                }
            }
        }

        static void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
        }

        static void Add(int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine($"{a} + {b} + {c} = {d}");
        }

        static void Multiply(float a, float b)
        {
            float c = a * b;
            Console.WriteLine($"{a} * {b} = {c}");
        }

        static void Multiply(float a, float b, float c)
        {
            float d = a * b * c;
            Console.WriteLine($"{a} * {b} * {c} = {d}");
        }

    }
}
