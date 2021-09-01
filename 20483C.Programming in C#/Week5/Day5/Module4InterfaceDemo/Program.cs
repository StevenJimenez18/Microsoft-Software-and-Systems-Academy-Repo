using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            InMemoryData data = new InMemoryData();
            CreateEmployees(data);
            GetEmployees(data);
            //CreateEmployees(data);
            //GetEmployees(data);
            DeleteEmployee(data);
            GetEmployees(data);
            Console.ReadLine();
        }

        static void GetEmployees(InMemoryData data)
        {

            ICollection<Employee> temp = data.Read();
            Console.WriteLine($"All Employees: ");
            foreach (var emp in temp)
            {
                Console.WriteLine($"{emp.Eid}, {emp.Name}");
            }
        }

        static void CreateEmployees(InMemoryData data)
        {
            Console.WriteLine("Please enter id and name");
            Employee newEmp = new Employee() { Eid = int.Parse(Console.ReadLine()), Name = Console.ReadLine() };
            data.Create(newEmp);
        }

        static void DeleteEmployee(InMemoryData data)
        {
            int temp;
            Console.WriteLine("Enter an employee id to delete: ");
            temp = Int32.Parse(Console.ReadLine());
            data.Delete(temp);
            Console.WriteLine($"Employee {temp} has been deleted.");
        }
    }
}
