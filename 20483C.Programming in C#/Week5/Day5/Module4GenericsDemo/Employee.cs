using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4GenericsDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location
        {
            get; set;
        }

        public class CustomList<T>
        {
            static public void AddItem(List<T> list, T val)
            {

                list.Add(val);

            }

            static public void RemoveItem(List<T> list, T val)
            {
                list.Remove(val);
            }
        }

        public class Swap<T>
        {
            public static void SwapFunction(ref T one, ref T two)
            {
                T temp;
                temp = one;
                one = two;
                two = temp;
            }
        }
    }

}
