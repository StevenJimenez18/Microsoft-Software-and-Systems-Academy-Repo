using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ex4
{
    class Circle
    {
        private double radius;

        public double _radius
        {
            get { return radius; }
            set { radius = value; }
        }

        private double area;

        public double _area
        {
            get { return area; }
            set { area = value; }
        }

        public Circle SetArea(Circle circle)
        {
            circle._area = Math.PI * (Math.Pow(circle._radius, 2));
            return circle;
        }

        public static Circle operator +(Circle a, Circle b)
        {
            Circle cnew = new Circle(); 
            cnew._area = a._area + b._area;
            return cnew;
        }

        public static Circle operator -(Circle a, Circle b)
        {
            Circle cnew = new Circle();
            cnew._area = a._area - b._area;
            return cnew;
        }
    }
}
