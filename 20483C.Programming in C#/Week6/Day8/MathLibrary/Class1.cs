using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Maths
    {
        ComplexOperations co;

        public Maths()
        {
            co = new ComplexOperations();
        }
        public int Add(int a, int b)
        {
            co.CalArea();
            return a + b;
        }

        public int Product(int i, int j)
        {
            return i * j;
        }
    }

    class ComplexOperations
    {
        public int CalArea()
        {
            return 0;
        }
    }
}
