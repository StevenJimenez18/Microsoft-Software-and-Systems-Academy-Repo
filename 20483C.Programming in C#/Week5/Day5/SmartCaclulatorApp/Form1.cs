using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCaclulatorApp
{
    
    public partial class Form1 : Form
    {
        Calc newCalc = new Calc();
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void txtScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {

            newCalc.Create(0);
            txtScreen.Text = newCalc.sb.ToString();
        
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            
            newCalc.Create(1);
            txtScreen.Text = newCalc.sb.ToString();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            newCalc.Create(2);
            txtScreen.Text = newCalc.sb.ToString();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            newCalc.Create(3);
            txtScreen.Text = newCalc.sb.ToString();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            newCalc.Create(4);
            txtScreen.Text = newCalc.sb.ToString();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            newCalc.Create(5);
            txtScreen.Text = newCalc.sb.ToString();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            newCalc.Create(6);
            txtScreen.Text = newCalc.sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newCalc.Create(7);
            txtScreen.Text = newCalc.sb.ToString();
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            newCalc.Create(8);
            txtScreen.Text = newCalc.sb.ToString();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            newCalc.Create(9);
            txtScreen.Text = newCalc.sb.ToString();
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            
            txtScreen.Text = newCalc.value.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            newCalc.AddTotal();
            txtCurrentTotal.Text = newCalc.value.ToString();
            txtScreen.Text = newCalc.sb.ToString();
            newCalc.ClearSB();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            newCalc.ClearCalc();
            txtScreen.Clear();
            txtCurrentTotal.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            newCalc.SubTotal();
            txtCurrentTotal.Text = newCalc.value.ToString();
            txtScreen.Text = newCalc.sb.ToString();
            newCalc.ClearSB();
        }
    }
}
