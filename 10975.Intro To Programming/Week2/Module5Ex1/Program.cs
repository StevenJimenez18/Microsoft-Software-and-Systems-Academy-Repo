using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module5Ex1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Lets compare some points!");
            Console.Write("Please enter a X coordinate for your first point: ");
            Point p1 = new Point();
            p1.X = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Please enter a Y coordinate for your first point: ");
            p1.Y = Convert.ToDecimal(Console.ReadLine()); 
            Point p2 = new Point();
            Console.Write("Please enter a X coordinate for your second point: ");
            p2.X = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Please enter a Y coordinate for your second point: ");
            p2.Y = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Loading Comparison: ");
            ConsoleUtility.WriteProgressBar(0);
            for (var i = 0; i <= 100; ++i)
            {
                ConsoleUtility.WriteProgressBar(i, true);
                Thread.Sleep(20);
            }
            Console.WriteLine();
            CheckPoints(p1,p2);
            
            Console.ReadLine();

        }

        static bool CheckPoints(Point p1, Point p2)
        {
            if(p2.X > p1.X)
            {
                Console.WriteLine("Point 2 is to the right of point 1");
            }
            else if (p2.X == p1.Y)
            {
                Console.WriteLine("Point 2 is to the right of point 1");
            }
            else
            {
                Console.WriteLine("Point 2 is to the left of point 1");
            }
            return true;
        }

        public class ConsoleUtility
        {
            const char _block = '■';
            const string _back = "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b";
            const string _twirl = "-\\|/";
            public static void WriteProgressBar(int percent, bool update = false)
            {
                if (update)
                    Console.Write(_back);
                Console.Write("[");
                var p = (int)((percent / 10f) + .5f);
                for (var i = 0; i < 10; ++i)
                {
                    if (i >= p)
                        Console.Write(' ');
                    else
                        Console.Write(_block);
                }
                Console.Write("] {0,3:##0}%", percent);
            }
            public static void WriteProgress(int progress, bool update = false)
            {
                if (update)
                    Console.Write("\b");
                Console.Write(_twirl[progress % _twirl.Length]);
            }
        }
    }

}
