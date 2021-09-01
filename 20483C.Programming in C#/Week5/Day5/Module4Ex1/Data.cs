using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4Ex1
{
    

    struct Employee
    {
        public int Eid { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime HireDate { get; set; }
        
       
        public Employee(int id, string fname, string lname, DateTime hiredate)
        {
            this.Eid = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.HireDate = hiredate;
        }
    }
}
