using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6SerializationDemo
{
    [Serializable] // First Step: Mark the class you want to preserve
    class Employee
    {
        private int id;
        private string name;
        public int _id
        {
            get { return this.id; }
            set
            {
                this.id = value;
            }
        }

        public string _name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }
    }
}
