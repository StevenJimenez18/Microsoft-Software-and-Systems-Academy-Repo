using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Module4GenericsDemo.Employee;

namespace Module4GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            Employee newEmp = new Employee()
            {
                Id = 2,
                Location = "NY",
                Name = "Steven"
            };

            CustomList<Employee>.AddItem(empList, newEmp);

            foreach(var emp in empList)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Location: {emp.Location}");
            }

            

            int i = 10;
            int j = 25;

            Swap<int>.SwapFunction(ref i, ref j);

            Console.WriteLine("i: " + i);
            Console.WriteLine("j: " + j);

            Console.ReadLine();
        }
    }
}
