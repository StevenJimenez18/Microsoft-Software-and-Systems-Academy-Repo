using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Steven\Desktop\MSSA\Microsoft-Software-and-Systems-Academy-Repo\20483C.Programming in C#\Week7\Day12\MathLibrary\MathLibrary\bin\Debug\MathLibrary.dll";

            var dynamic_assembly = Assembly.LoadFrom(path);
            Console.WriteLine($"Name of assembly: {dynamic_assembly.FullName}");
            var types = dynamic_assembly.GetTypes();
            object[] parameters = new object[] { 40, 20 };

            foreach(Type t in types)
            {
                Console.WriteLine(t.FullName);
                var methods = t.GetMethods();
                foreach(MethodInfo m in methods)
                {
                    Console.WriteLine(m.Name);
                    if(m.Name == "Equals" || m.Name == "ToString" || m.Name == "GetHashCode" || m.Name == "GetType")
                    {
                        break;
                    }
                    var dynamic_object = Activator.CreateInstance(t);
                    var result = (int)t.InvokeMember(m.Name, BindingFlags.InvokeMethod, null, dynamic_object,parameters);
                    Console.WriteLine($"result is: {result}");
                }
            }

            Console.ReadLine();
        }
    }
}
