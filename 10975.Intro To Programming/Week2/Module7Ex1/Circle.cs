using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7Ex1
{
    class Circle : Shape
    {
        public decimal radius { get; set; }

        public override decimal CalculateArea()
        {
            decimal pi = Convert.ToDecimal(Math.PI);
            decimal area = pi * ((decimal)Math.Pow((double)radius, 2));
            return area;
        }
    }
}
