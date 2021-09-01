using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4InterfaceDemo
{


    class Employee
    {
        public int Eid { get; set; }
        public string Name { get; set; }
        
    }

    interface CRUD
    {
        void Create(Employee obj);
        ICollection<Employee> Read();
        void Update(Employee obj);
        void Delete(int id);
    }

    class InMemoryData : CRUD
    {

        List<Employee> elist;
        

        public InMemoryData()
        {
            elist = new List<Employee>();
            
            elist.Add(new Employee() { Eid = 100, Name= "Steven"});
            elist.Add(new Employee() { Eid = 101, Name= "Mark"});

        }
        public void Create(Employee obj)
        {
            elist.Add(obj);
        }

        public void Delete(int id)
        {
            Employee selectEmp = elist.FirstOrDefault(e => e.Eid == id);
            elist.Remove(selectEmp);
        }

        public ICollection<Employee> Read()
        {
            return elist;
        }

        public void Update(Employee obj)
        {
            Employee selectEmp = elist.FirstOrDefault(e => e.Eid == obj.Eid);
        }
    }

    interface I1
    {
        int Add(int i, int j);
        int Product(int i, int j);
    }

    interface I2
    {
        int Display(int i);
    }

    class Maths : I1, I2, IDisposable
    {
        private bool disposedValue;

        public int Add(int i, int j)
        {
            return i + j;
        }

         int I2.Display(int i)
        {
            Console.WriteLine(i);
            return i;
        }

        public int Product(int i, int j)
        {
            return i * j;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Maths()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
