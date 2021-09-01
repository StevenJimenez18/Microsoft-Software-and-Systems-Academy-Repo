using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3DelagtesDemo
{
    public delegate void StockCheck(int stock);
    class Coffee
    {
        private int stock;
        public event StockCheck LowStock;
        public int _stock
        {
            get { return this.stock; }
            set
            {
                if (value < 150)
                {
                    LowStock(value);
                }
                else{
                    this.stock = value;
                }
            }
        }
    }
}
