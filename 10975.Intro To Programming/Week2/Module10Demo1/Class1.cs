using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10Demo1
{
    class Class1
    {
    }

    class Test : IDisposable
    {
        ~Test()//destructor (finalizer) // non deterministic
        {
            //dispose of the unmanaged resources: microsoft word

        }

        public void Dispose() // deterministic
        {
            //release / dispose
            throw new NotImplementedException();
        }
    }
}
