using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module10FileAsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
            Console.ReadLine();
        }

        static async void CallMethod()
        {
            string filepath = "C:\\Users\\Steven\\Desktop\\MSSA\\Microsoft-Software-and-Systems-Academy-Repo\\20483C.Programming in C#\\Week7\\Day12";
            Task<int> task = ReadFile(filepath);
            Console.WriteLine("Loading");
            Console.WriteLine("Loading");
            Console.WriteLine("Loading");
            Console.WriteLine("Loading");
            Console.WriteLine("Loading");
            Console.WriteLine("Loading");
            Console.WriteLine("Loading");
            Console.WriteLine("Loading");
            Console.WriteLine("Loading");
            Console.WriteLine("Loading");
            int len = await task;
            Console.WriteLine($"the file length is {len}");
        }

        static async Task<int> ReadFile(string fileName)
        {
            int length = 0;
            Console.WriteLine("Starting read file");
            using(StreamReader reader = new StreamReader(fileName)){
                string s = await reader.ReadToEndAsync();
                length = s.Length;
            }
            return length;
        }
    }
}
