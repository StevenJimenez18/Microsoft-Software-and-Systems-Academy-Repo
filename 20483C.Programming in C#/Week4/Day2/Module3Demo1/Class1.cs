using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Demo1
{
    class Circle
    {
        private int radius;

        public int _radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public static Circle operator +(Circle b, Circle c)
        {
            Circle cnew = new Circle();
            cnew._radius = b._radius + c._radius;
            return cnew;
        }

    }
}
