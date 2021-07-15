using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Module4Demo2
{
    class Program
    {
        static void Main(string[] args)
        {

            //highest level namespace: system
            //highest level class: object
            //object is a reference type
            //adding value tpes into a reference is called boxing
            //ref type to value is called unboxing

            //Stack is LIFO - last in first out
            Stack intStack = new Stack();
            intStack.Push(9);
            intStack.Pop();

            //FIFO =first in first out
            Queue newQueue = new Queue();
            newQueue.Enqueue(3);
            newQueue.Dequeue();

            ArrayList arrayList = new ArrayList();
            arrayList.Add(6);


            //uses key/value pairs that are sorted by
            //the keys and are accessible by key and by index.
            SortedList sortedList = new SortedList();
            sortedList.Add(2, "emma");
            sortedList.Add(3, "david");
        }
    }
}
