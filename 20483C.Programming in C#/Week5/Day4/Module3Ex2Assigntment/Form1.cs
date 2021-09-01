using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module3Ex2
{
    public partial class Form1 : Form
    {
        ArrayList accountList;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            
        }

        private void OpenAccountWindow()
        {
            
        }

        private void GrdAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //GrdAccount.Visible = false;
            lbSuccess.Visible = false;
            cbAccount.DataSource = Enum.GetValues(typeof(AccountType));
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BankAccount newAccount = new BankAccount();
            newAccount.LowBalance += Obj_LowBalance;
            accountList = new ArrayList();
            newAccount.AccountNumber = BankAccount.GetAccountNumber();
            newAccount.FirstName = txtFname.Text;
            newAccount.LastName = txtLname.Text;
            newAccount.AccountType = (AccountType)cbAccount.SelectedValue;
            newAccount._balance = Double.Parse(txtBalance.Text);
            accountList.Add(newAccount);
            //gbLogin.Visible = false;
            /*GrdAccount.DataSource = accountList;
            GrdAccount.Visible = true;*/
            if(txtFname.Text != null && txtLname.Text != null && Double.Parse(txtBalance.Text) >= 200)
            {
                gbLogin.Visible = false;
                lbSuccess.Visible = true;

            }
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Obj_LowBalance(double balance)
        {
            MessageBox.Show($"A balance over $200 is required. You submitted: ${balance}");
        }

        private void lbLname_Click(object sender, EventArgs e)
        {

        }
    }
}
