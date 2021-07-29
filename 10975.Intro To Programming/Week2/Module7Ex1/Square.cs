using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7Ex1
{
    class Square : Shape
    {
        public decimal side { get; set; }

        public override decimal CalculateArea()
        {
            decimal area = (decimal)Math.Pow((double)this.side, 2);
            return area;
        }
    }
}
