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

namespace Module4Ex1
{
    public partial class Form1 : Form
    {
        List<Employee> empList;

        public Form1()
        {
            InitializeComponent();
        }

        private void lbSID_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            empList = new List<Employee>();
            empList.Add(new Employee());
            EmployeeGrid.DataSource = empList;
            GrpEmployees.Visible = false;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GrpEmployees.Visible = true;
            if (txtSID.Text != string.Empty && txtFname.Text != string.Empty && txtLname.Text != string.Empty && txtHired.Text != string.Empty)
            {
                Employee newEmployee = new Employee();
                newEmployee.Eid = Int32.Parse(txtSID.Text);
                newEmployee.FirstName = txtFname.Text;
                newEmployee.LastName = txtLname.Text;
                newEmployee.HireDate = DateTime.Parse(txtHired.Text);
                empList.Add(newEmployee);
                GrpEmployees.Visible = false;
            }
        }

        private void RefreshData()
        {
            GrpEmployees.Visible = false;
            txtSID.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtHired.Clear();
            EmployeeGrid.DataSource = null;
            EmployeeGrid.DataSource = empList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            empList.RemoveAt(EmployeeGrid.CurrentRow.Index);
            EmployeeGrid.DataSource = null;
            EmployeeGrid.DataSource = empList;
        }

        private void labelHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void txtHired_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
