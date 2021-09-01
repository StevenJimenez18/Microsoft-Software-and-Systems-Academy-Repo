
namespace Module4Ex1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.GrpEmployees = new System.Windows.Forms.GroupBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.lbHired = new System.Windows.Forms.Label();
            this.lbLname = new System.Windows.Forms.Label();
            this.lbFname = new System.Windows.Forms.Label();
            this.lbSID = new System.Windows.Forms.Label();
            this.txtHired = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            this.GrpEmployees.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHeader.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.Linen;
            this.labelHeader.Location = new System.Drawing.Point(239, 56);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(720, 31);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Mircosoft SQL Server Database Management Studio";
            this.labelHeader.Click += new System.EventHandler(this.labelHeader_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("NSimSun", 20F);
            this.btnAdd.Location = new System.Drawing.Point(142, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(264, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Employee";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("NSimSun", 20F);
            this.btnDelete.Location = new System.Drawing.Point(787, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(264, 48);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Employee";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Location = new System.Drawing.Point(41, 255);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.Size = new System.Drawing.Size(478, 315);
            this.EmployeeGrid.TabIndex = 3;
            this.EmployeeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GrpEmployees
            // 
            this.GrpEmployees.Controls.Add(this.txtHired);
            this.GrpEmployees.Controls.Add(this.txtFname);
            this.GrpEmployees.Controls.Add(this.txtLname);
            this.GrpEmployees.Controls.Add(this.txtSID);
            this.GrpEmployees.Controls.Add(this.lbHired);
            this.GrpEmployees.Controls.Add(this.lbLname);
            this.GrpEmployees.Controls.Add(this.lbFname);
            this.GrpEmployees.Controls.Add(this.lbSID);
            this.GrpEmployees.Location = new System.Drawing.Point(541, 245);
            this.GrpEmployees.Name = "GrpEmployees";
            this.GrpEmployees.Size = new System.Drawing.Size(589, 325);
            this.GrpEmployees.TabIndex = 4;
            this.GrpEmployees.TabStop = false;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(237, 131);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(278, 20);
            this.txtFname.TabIndex = 12;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(237, 192);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(278, 20);
            this.txtLname.TabIndex = 10;
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(237, 71);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(278, 20);
            this.txtSID.TabIndex = 7;
            // 
            // lbHired
            // 
            this.lbHired.AutoSize = true;
            this.lbHired.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHired.ForeColor = System.Drawing.Color.Linen;
            this.lbHired.Location = new System.Drawing.Point(28, 252);
            this.lbHired.Name = "lbHired";
            this.lbHired.Size = new System.Drawing.Size(116, 26);
            this.lbHired.TabIndex = 5;
            this.lbHired.Text = "Hired Date";
            // 
            // lbLname
            // 
            this.lbLname.AutoSize = true;
            this.lbLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLname.ForeColor = System.Drawing.Color.Linen;
            this.lbLname.Location = new System.Drawing.Point(30, 186);
            this.lbLname.Name = "lbLname";
            this.lbLname.Size = new System.Drawing.Size(118, 26);
            this.lbLname.TabIndex = 3;
            this.lbLname.Text = "Last Name";
            // 
            // lbFname
            // 
            this.lbFname.AutoSize = true;
            this.lbFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFname.ForeColor = System.Drawing.Color.Linen;
            this.lbFname.Location = new System.Drawing.Point(29, 125);
            this.lbFname.Name = "lbFname";
            this.lbFname.Size = new System.Drawing.Size(119, 26);
            this.lbFname.TabIndex = 2;
            this.lbFname.Text = "First Name";
            // 
            // lbSID
            // 
            this.lbSID.AutoSize = true;
            this.lbSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSID.ForeColor = System.Drawing.Color.Linen;
            this.lbSID.Location = new System.Drawing.Point(29, 65);
            this.lbSID.Name = "lbSID";
            this.lbSID.Size = new System.Drawing.Size(138, 26);
            this.lbSID.TabIndex = 1;
            this.lbSID.Text = "Employee ID";
            // 
            // txtHired
            // 
            this.txtHired.Location = new System.Drawing.Point(237, 252);
            this.txtHired.Name = "txtHired";
            this.txtHired.Size = new System.Drawing.Size(278, 20);
            this.txtHired.TabIndex = 13;
            this.txtHired.TextChanged += new System.EventHandler(this.txtHired_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("NSimSun", 20F);
            this.btnUpdate.Location = new System.Drawing.Point(433, 141);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(326, 51);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Employee List";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Navy;
            this.groupBox1.Controls.Add(this.EmployeeGrid);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.labelHeader);
            this.groupBox1.Controls.Add(this.GrpEmployees);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(168, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1154, 669);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.BackgroundImage = global::Module3Ex1.Properties.Resources.windows;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1523, 925);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            this.GrpEmployees.ResumeLayout(false);
            this.GrpEmployees.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView EmployeeGrid;
        private System.Windows.Forms.GroupBox GrpEmployees;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label lbHired;
        private System.Windows.Forms.Label lbLname;
        private System.Windows.Forms.Label lbFname;
        private System.Windows.Forms.Label lbSID;
        private System.Windows.Forms.TextBox txtHired;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

