using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousLamdaDemo
{
    class Program
    {
        public delegate bool Mydel(int num);

        static void Main(string[] args)
        {
            // normal function call
            bool result = Check(5);

            //Delegate call
            Mydel pointer = new Mydel(Check);
            bool result2 = pointer(5);

            //anonymous methods
            Mydel newPointer = delegate (int num)
            {
                return (num > 25);
            };
            newPointer(200);


            //Lambda Call

            Mydel newDel = (num) =>
            {
                return (num > 50);
            };

            newDel(200);
        }

        public static bool Check(int num)
        {
            return (num > 10);
        }
    }
}
