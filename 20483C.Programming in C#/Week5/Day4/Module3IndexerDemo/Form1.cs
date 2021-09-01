using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module3IndexerDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //must be intilized through a constructor to avoid runtime error
            BeveragesMenu menu = new BeveragesMenu("Coffee");
            MessageBox.Show(menu[0]);

            /// Will cause runtime error since memery isnt being allocated
            BeveragesMenu beverages = new BeveragesMenu(); 
            beverages[0] = "Expresso";
            beverages[1] = "Latte";
            MessageBox.Show(beverages[0]);
            ///
        }
    }
}
