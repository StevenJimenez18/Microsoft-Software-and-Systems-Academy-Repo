using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10AsyncDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Synchronous call
            callMethod();
            Console.ReadLine();
        }

        public static async void callMethod()
        {
            Task<int> task = Method1(); //Asynchronous
            Method2();//Synchronus
            int count = await task;
            Method3(count);
        }

        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine("Method 1");
                    count++;
                    Task.Delay(100).Wait();

                }

            });
            return count;
        }

        public static void Method2()
        {
            /*await Task.Run(() =>
            {
*/
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 2");
                Task.Delay(100).Wait();
            }
           /* }
                );*/
        }

        public static void Method3(int num)
        {
            Console.WriteLine($"Count is: {num}");
        }
    }
}
