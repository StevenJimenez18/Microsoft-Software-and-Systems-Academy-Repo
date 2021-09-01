using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4sortingDemo
{

    class StudentComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return (y.Grades.CompareTo(x.Grades));
        }
    }

    class StudentAgeComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return (y.Age.CompareTo(x.Age));
        }
    }

    class Student : IComparable
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Grades { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            Student temp = (Student)obj;
            return string.Compare(this.Name, temp.Name);
        }
    }
}
