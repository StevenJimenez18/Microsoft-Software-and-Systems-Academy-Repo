using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Module3Demo2
{
    public partial class Form1 : Form
    {
        ArrayList elist;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowData_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lbfirstname_Click(object sender, EventArgs e)
        {

        }

        private void lbDepartment_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxHireDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elist = new ArrayList();
            elist.Add(new Employee(1, "Steven", "Jimenez", "New York", (HireDate)1, (Department)3));
            elist.Add(new Employee(2, "Bob", "Saget", "California", (HireDate)2, (Department)1));
            elist.Add(new Employee(3, "Billy", "Mayes", "Georgia", (HireDate)3, (Department)4));
            EmpGrid.DataSource = elist;
            GrpEmp.Visible = false;
            comboBoxHireDate.DataSource = Enum.GetValues(typeof(HireDate));
            comboDepartment.DataSource = Enum.GetValues(typeof(Department));
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            GrpEmp.Visible = true;
            if(textID.Text != string.Empty && textFirstName.Text != string.Empty && textLastName.Text != string.Empty && textBoxAddress.Text != string.Empty)
            {
                Employee newEmp = new Employee();
                newEmp.Eid = Int32.Parse(textID.Text);
                newEmp.FirstName = textFirstName.Text;
                newEmp.LastName = textLastName.Text;
                newEmp.Address = textBoxAddress.Text;
                newEmp.HireDate = (HireDate)comboBoxHireDate.SelectedValue;
                newEmp.Department = (Department)comboDepartment.SelectedValue;
                elist.Add(newEmp);
                RefreshData();
            }
        }

        private void RefreshData()
        {
            GrpEmp.Visible = false;
            textID.Clear();
            textFirstName.Clear();
            textLastName.Clear();
            textBoxAddress.Clear();
            EmpGrid.DataSource = null;
            EmpGrid.DataSource = elist;
            
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            elist.RemoveAt(EmpGrid.CurrentRow.Index);
            EmpGrid.DataSource = null;
            EmpGrid.DataSource = elist;
        }
    }
}
