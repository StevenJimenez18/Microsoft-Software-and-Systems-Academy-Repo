using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module3DelagtesDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            Coffee obj = new Coffee();
            obj.LowStock += Obj_LowStock;
            obj._stock = Int32.Parse(txtStock.Text);
        }

        private void Obj_LowStock(int stock)
        {
            MessageBox.Show("This is low stock: " + stock);
        }
    }
}
