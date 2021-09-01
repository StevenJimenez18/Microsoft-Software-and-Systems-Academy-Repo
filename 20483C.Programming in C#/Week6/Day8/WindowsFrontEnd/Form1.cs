using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathLibrary;

namespace WindowsFrontEnd
{
    public partial class Form1 : Form
    {
        Maths mathobj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mathobj = new Maths();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = mathobj.Add(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
            MessageBox.Show($"Result: {result.ToString()}");
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            int result = mathobj.Product(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
            MessageBox.Show($"Result: {result.ToString()}");
        }
    }
}
