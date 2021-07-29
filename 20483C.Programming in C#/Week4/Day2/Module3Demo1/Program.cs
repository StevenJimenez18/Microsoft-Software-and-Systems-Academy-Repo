using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //operator overloading
            
            string name1 = "Steven";
            string name2 = "Jimenez";
            string name3 = name1 + name2; //overloaded

            Circle c1 = new Circle();
            c1._radius = 10;
            Circle c2 = new Circle();
            c2._radius = 4;

            Circle c3 = c1 + c2;
        }
    }
}
