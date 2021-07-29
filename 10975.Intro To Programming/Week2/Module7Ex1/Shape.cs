using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7Ex1
{
    abstract class Shape
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public virtual decimal CalculateArea()
        {
            return 0;
        }
    }
}
