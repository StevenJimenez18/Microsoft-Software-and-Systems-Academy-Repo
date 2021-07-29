using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] posArray = new int[7] { 420,190, 291, 500, 209, 280, 300 };
            int[] negArray = new int[5] { -9, -2, -7, -8, -4};
            //int biggest = BiggestNumber(newArray);
            int biggest = BiggestNumber(negArray);
            Console.WriteLine($"The biggest number in the array is {biggest}");
            Console.ReadLine();
        }

        static int BiggestNumber(int[] array)
        {
            int placeHolder = array[0];
            for(int i = 0; i <= array.Length - 1; i++)
            {
               if(array[i] > placeHolder)
                {
                    placeHolder = array[i];
                }
            }

            return placeHolder;
        }
    }
}
