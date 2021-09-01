using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCaclulatorApp
{

    class Calc : CRUD
    {


        public List<int> numsOnScreen { get; set; }

        public int Total { get; set; }
        public int value { get; set; }

        public StringBuilder sb { get; set; }

        public Calc()
        {
            this.numsOnScreen = new List<int>();
            this.sb = new StringBuilder();
        }
        public void Create(int num)
        {
            this.sb.Append(num);
        }

        public void AddTotal()
        {
            int temp = int.Parse(this.sb.ToString()); 
            this.value += temp;
        }

        public void ClearCalc()
        {
            this.sb.Clear();
            this.value = 0;
        }

        public void ClearSB()
        {
            this.sb.Clear();
            
        }

        public void SubTotal()
        {
            int temp = int.Parse(this.sb.ToString());
            this.value -= temp;
        }
    }
}
