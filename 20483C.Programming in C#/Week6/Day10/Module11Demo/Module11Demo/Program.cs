using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11Demo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DynamicClass wordObj = new DynamicClass();
            //wordObj.InvokeWord();

            //Explicit invocation
            //wordObj.Dispose();

            //Implicit invocation - deterministic
            using (DynamicClass wordobj1 = new DynamicClass())
            {
                wordobj1.InvokeWord();
            }

            Console.WriteLine("End of application");
            Console.ReadLine();
        }
    }
}
