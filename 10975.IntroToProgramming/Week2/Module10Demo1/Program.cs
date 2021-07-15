using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Module10Demo1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            num1 = 100;
            num2 = 200;
            Swap(ref num1,ref num2); //Passing by reference
            Console.WriteLine($"Swapped Values: num1: {num1}, num2 {num2}");


            //Boxing 
            object o = num1; //value conversion to ref type... implicit 

            //Unboxing
            int i = (int)o;  // ref conversion to value type... explicit 


            //Example
            Stack st = new Stack();
            st.Push(num1); //Boxing
            int num3 = (int)st.Pop(); //UnBoxing



            Test obj = new Test(); //F-reachable queue - maintined in memory
            obj.Dispose();


            using(Test o1 = new Test())
            {

            }

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
