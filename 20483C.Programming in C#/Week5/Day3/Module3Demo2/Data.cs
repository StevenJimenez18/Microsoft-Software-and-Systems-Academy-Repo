using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Demo2
{
    enum HireDate
    {
        Jan=1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec
    }

    enum Department
    {
        IT=1, HR, Marketing, Finance, Warehouse, Logistics
    }

    struct Employee
    {
        public int Eid{ get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }

        public string Address { get; set; }
        public HireDate HireDate { get; set; }
        public Department Department { get; set; }

        public Employee(int id, string fname, string lname, string address, HireDate hireDate, Department department)
        {
            this.Eid = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.Address = address;
            this.HireDate = hireDate;
            this.Department = department;
        }
    }


}
