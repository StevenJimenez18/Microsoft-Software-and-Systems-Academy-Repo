using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            Console.ReadLine();
        }

        static void Intro()
        {
            Console.WriteLine("Hello, lets calculate the area of some circles!");
            Console.WriteLine("First lets create two circles and then we'll use those values to get the area of your third circle!");
            CreateCircles();
        }

        static void CreateCircles()
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle();
            Console.WriteLine("Please enter the radius of your first circle: ");
            double rad1;
            bool result1 = double.TryParse(Console.ReadLine(), out rad1);
            c1._radius = rad1;
            c1.SetArea(c1);
            Console.WriteLine($"The area of your first circle is: {c1._area}");
            Console.WriteLine("Please enter the radius of your second circle: ");
            double rad2;
            bool result2 = double.TryParse(Console.ReadLine(), out rad2);
            c2._radius = rad2;
            c2.SetArea(c2);
            Console.WriteLine($"The area of your first circle is: {c2._area}");
            Console.WriteLine("Now lets use those areas for your third circles area.");
            Circle c3 = c1 + c2;
            Console.WriteLine($"When added the area for your third circle is : {c3._area}");
            Circle c4 = c1 - c2;
            Console.WriteLine($"When subtracted the area for your third circle is : {c4._area}");
        }
    }
}
