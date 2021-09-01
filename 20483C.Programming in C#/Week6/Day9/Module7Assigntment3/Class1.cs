using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Class1
    {
        public static PCAD2EmployeesEntities entities;

         public static PCAD2EmployeesEntities GetEntities()
        {
            entities = new PCAD2EmployeesEntities();
            return entities;

        }

        public static void Add(decimal EmpId, string Fname, string Lname, decimal deptID, string designation, decimal salary)
        {
            EmpTable newEmp = new EmpTable();
            newEmp.Eid = EmpId;
            newEmp.EmpFirstName = Fname;
            newEmp.EmpLastName = Lname;
            newEmp.DepartmentId = deptID;
            newEmp.Designation = designation;
            newEmp.Salary = salary;
            entities.EmpTables.Add(newEmp);
            entities.SaveChanges();

        }
        public static void Update(EmpTable newEmp, decimal EmpId, string Fname, string Lname, decimal deptID, string designation, decimal salary)
        {
            newEmp.Eid = EmpId;
            newEmp.EmpFirstName = Fname;
            newEmp.EmpLastName = Lname;
            newEmp.DepartmentId = deptID;
            newEmp.Designation = designation;
            newEmp.Salary = salary;
            entities.SaveChanges();
        }
        
        public static void Delete(EmpTable employee)
        {
            entities.EmpTables.Remove(employee);
            entities.SaveChanges();
        }

    }
}
