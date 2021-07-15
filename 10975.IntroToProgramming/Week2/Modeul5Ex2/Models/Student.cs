using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeul5Ex2.Models
{
    class Student
    {
        private int StudentId { get; set; }
        public int _StudentId
        {
            get { return StudentId; }
            set { StudentId = value; }
        }

        private string FName;

        public string _FName
        {
            get { return FName; }
            set { FName = value; }
        }


        private char MInitial;

        public char _MInitial
        {
            get { return MInitial; }
            set { MInitial = value; }
        }

        private string LName;

        public string _LName
        {
            get { return LName; }
            set { LName = value; }
        }


        private decimal GPA;

        public decimal _GPA
        {
            get { return GPA; }
            set { GPA = value; }
        }


        public int Age { get; set; }

        public bool isMale { get; set; }


    }
}
