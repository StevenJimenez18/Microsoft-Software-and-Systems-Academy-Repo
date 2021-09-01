using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3IndexerDemo
{
    struct BeveragesMenu
    {
        private string[] beverages;
        public string this[int index]
        {
            get { return this.beverages[index]; }
            set { this.beverages[index] = value; }
        }

        public BeveragesMenu(string s)
        {
            beverages = new string[] { "Americano", "Latte", "Expresso", "Mocha Frap", "Black"};
        }
    }
}
