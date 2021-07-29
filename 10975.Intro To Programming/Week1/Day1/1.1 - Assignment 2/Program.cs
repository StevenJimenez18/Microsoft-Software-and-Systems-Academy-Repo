using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1___Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hard coded values

            /*int minInt = -2147483648;
            int maxInt = 2147483647;
            double minDouble = -1.7976931348623157E+308;
            double maxDouble = 1.7976931348623157E+308;
            byte minByte = 0;
            byte maxByte = 255;
            long minLong = -9223372036854775808;
            long maxLong = 9223372036854775807;
            Console.WriteLine($"Int min:{minInt}");
            Console.WriteLine($"Int max:{maxInt}");
            Console.WriteLine($"Double min:{minDouble}");
            Console.WriteLine($"Double min:{maxDouble}");
            Console.WriteLine($"Byte min:{minByte}");
            Console.WriteLine($"Byte min:{maxByte}");
            Console.WriteLine($"Long min:{minLong}");
            Console.WriteLine($"Long min:{maxLong}");*/

           //



            Console.WriteLine($"Int min: {int.MinValue}");
            Console.WriteLine($"Int min: {int.MaxValue}");
            Console.WriteLine($"Double min: {double.MinValue}");
            Console.WriteLine($"Double max: {double.MaxValue}");
            Console.WriteLine($"Byte min: {byte.MinValue}");
            Console.WriteLine($"Byte max: {byte.MaxValue}");
            Console.WriteLine($"Long min: {long.MinValue}");
            Console.WriteLine($"Long max: {long.MaxValue}");

            Console.ReadLine();
        }
    }
}
