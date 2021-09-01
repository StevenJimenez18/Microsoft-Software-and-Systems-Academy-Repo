using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeLibrary;

namespace Module7SQLConnectionDemo
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void lbEmpId_Click(object sender, EventArgs e)
        {

        }

        private void lbFname_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var database = Class1.GetEntities();
            EmpGrid.DataSource = database.EmpTables.ToList();
            
            gbMain.Visible = false;
            foreach (var d in database.DeptTables)
            {
                cbDeptId.Items.Add(d.DepartmentId);
            }
            cbDesignation.Items.Add("Developer");
            cbDesignation.Items.Add("Tech");
            cbDesignation.Items.Add("Consultant");
            cbDesignation.Items.Add("Manager");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearDataNew();
            gbMain.Visible = true;
            btnAddorUpdate.Text = "Create";
        }

        private void ClearDataNew()
        {
            var database = Class1.GetEntities();
            txtEmpId.Clear();
            txtEmpId.ReadOnly = true;
            txtEmpId.Text = (database.EmpTables.Max(e => e.Eid) + 1).ToString();
            txtFname.Clear();
            txtLname.Clear();
            txtSalary.Clear();
        }

        private void ClearData()
        {
            txtEmpId.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtSalary.Clear();
            cbDeptId.Items.Clear();
            cbDesignation.Items.Clear();
            cbDesignation.Items.Add("Developer");
            cbDesignation.Items.Add("Tech");
            cbDesignation.Items.Add("Consultant");
            cbDesignation.Items.Add("Manager");
        }

        private void btnAddorUpdate_Click(object sender, EventArgs e)
        {
            var database = Class1.GetEntities();

            if (txtFname.Text != null && txtLname.Text != null && txtSalary.Text != null)
            {
                if (btnAddorUpdate.Text == "Create")
                {
                    Class1.Add(
                       Decimal.Parse(txtEmpId.Text),
                       txtFname.Text,
                       txtLname.Text,
                        Convert.ToDecimal(cbDeptId.SelectedItem),
                       (string)cbDesignation.SelectedItem,
                        Decimal.Parse(txtSalary.Text));
                }
                else if (btnAddorUpdate.Text == "Update")
                {
                    var eobj = EmpGrid.CurrentRow.Cells[0].Value;
                    var Emp = database.EmpTables.FirstOrDefault(emp => emp.Eid == (decimal)eobj);

                    Class1.Update(Emp,
                      Decimal.Parse(txtEmpId.Text),
                      txtFname.Text,
                      txtLname.Text,
                       Convert.ToDecimal(cbDeptId.SelectedItem),
                      (string)cbDesignation.SelectedItem,
                       Decimal.Parse(txtSalary.Text));
                }
                ClearData();
                gbMain.Visible = false;
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var database = Class1.GetEntities();
            EmpGrid.DataSource = database.EmpTables.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var database = Class1.GetEntities();
            var eobj = EmpGrid.CurrentRow.Cells[0].Value;
            var removeEmp = database.EmpTables.FirstOrDefault(emp => emp.Eid == (decimal)eobj);
            Class1.Delete(removeEmp);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var database = Class1.GetEntities();
            gbMain.Visible = true;
            btnAddorUpdate.Text = "Update";
            var eobj = EmpGrid.CurrentRow.Cells[0].Value;
            var employee = database.EmpTables.First(emp => emp.Eid == (decimal)eobj);
            txtEmpId.Text = employee.Eid.ToString();
            txtEmpId.ReadOnly = true;
            txtFname.Text = employee.EmpFirstName;
            txtLname.Text = employee.EmpLastName;
            txtSalary.Text = Convert.ToString(employee.Salary);
            cbDeptId.SelectedItem = employee.DepartmentId;
            cbDesignation.SelectedItem = employee.Designation;
            
        }
    }
}
