using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arryEx = new int[8] {8, 10, 12, 2, 5, 6, 11, 7 };
            //BubbleSortEx(arryEx);
            Fibonacci(8);
            //MyBubbleSort();
            Console.ReadLine();
        }

        static void MyBubbleSort()
        {
            //get size of list
            //get value of postion
            //compare next value
            //swap positions if greater

            int[] bubbleSort = new int[5] { 10, 2, 5, 6, 7 };
            int tempVal;
            int nextPosition;
            for(int i = 0; i < bubbleSort.Length-1; i++)
            {
                
                nextPosition = i + 1;
                if(bubbleSort[i] > bubbleSort[nextPosition])
                {
                    tempVal = bubbleSort[i];
                    bubbleSort[i] = bubbleSort[nextPosition];
                    bubbleSort[nextPosition] = tempVal;
                }
            }

            foreach(int num in bubbleSort)
            {
                Console.WriteLine(num);
            }
        }

        static void BubbleSortEx(int[] data)
        {
            int temp = 0;
            for(int i = 1; i <= data.Length-1; i++)
            {
                for(int j = 0; j < data.Length-1 ; j++)
                {
                    if(data[j+1] < data[j])
                    {
                        temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
            foreach(int num in data)
            {
                Console.WriteLine(num);
            }
        }

        static void Fibonacci(int limit)
        {
            //0,1,1,2,3,5,8,13,21
            int a = 0;
            int b = 1;
            int temp = 0;
            for(int i = 0; i < limit; i++)
            {
                temp = a;
                a = b;
                b = temp + a;
                Console.WriteLine($"instructor name: {}");
            }
        }

        static void ArrayDemo()
        {
            //Arrays are reference types. 
            int[] grades = new int[5] { 1, 2, 3, 4, 5 };
            string[] studentNames;
            studentNames = new string[5];
            grades[0] = 100;

            for (int i = 0; i < studentNames.Length; i++)
            {
                studentNames[i] = "Student" + (i + 1);
                Console.WriteLine(studentNames[i]);
            }

            Array.Reverse(studentNames);
            foreach (string name in studentNames)
            {
                Console.WriteLine(name);
            }

            foreach (int i in grades)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
