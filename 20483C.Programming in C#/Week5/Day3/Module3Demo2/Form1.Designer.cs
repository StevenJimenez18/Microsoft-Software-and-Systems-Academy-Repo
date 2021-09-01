
namespace Module3Demo2
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.EmpGrid = new System.Windows.Forms.DataGridView();
            this.GrpEmp = new System.Windows.Forms.GroupBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.comboDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxHireDate = new System.Windows.Forms.ComboBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lbHireDate = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).BeginInit();
            this.GrpEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShow.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShow.Location = new System.Drawing.Point(112, 144);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(247, 50);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show Data";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHeader.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(586, 57);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(271, 42);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Employee Records";
            this.labelHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Green;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(413, 144);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(263, 50);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add Employee";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.Red;
            this.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDel.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.Location = new System.Drawing.Point(1079, 144);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(307, 50);
            this.BtnDel.TabIndex = 3;
            this.BtnDel.Text = "Delete Employee";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // EmpGrid
            // 
            this.EmpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGrid.Location = new System.Drawing.Point(721, 244);
            this.EmpGrid.Name = "EmpGrid";
            this.EmpGrid.Size = new System.Drawing.Size(641, 404);
            this.EmpGrid.TabIndex = 4;
            // 
            // GrpEmp
            // 
            this.GrpEmp.Controls.Add(this.textBoxAddress);
            this.GrpEmp.Controls.Add(this.lbAddress);
            this.GrpEmp.Controls.Add(this.comboDepartment);
            this.GrpEmp.Controls.Add(this.comboBoxHireDate);
            this.GrpEmp.Controls.Add(this.textFirstName);
            this.GrpEmp.Controls.Add(this.textLastName);
            this.GrpEmp.Controls.Add(this.textID);
            this.GrpEmp.Controls.Add(this.lbDepartment);
            this.GrpEmp.Controls.Add(this.lbHireDate);
            this.GrpEmp.Controls.Add(this.lbLastName);
            this.GrpEmp.Controls.Add(this.lbFirstName);
            this.GrpEmp.Controls.Add(this.lbID);
            this.GrpEmp.Location = new System.Drawing.Point(79, 244);
            this.GrpEmp.Name = "GrpEmp";
            this.GrpEmp.Size = new System.Drawing.Size(597, 404);
            this.GrpEmp.TabIndex = 6;
            this.GrpEmp.TabStop = false;
            this.GrpEmp.Text = "EmployeeRecord";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(248, 197);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(258, 20);
            this.textBoxAddress.TabIndex = 13;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(75, 193);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(87, 24);
            this.lbAddress.TabIndex = 12;
            this.lbAddress.Text = "Address";
            this.lbAddress.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // comboDepartment
            // 
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.Location = new System.Drawing.Point(248, 301);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(258, 21);
            this.comboDepartment.TabIndex = 11;
            // 
            // comboBoxHireDate
            // 
            this.comboBoxHireDate.FormattingEnabled = true;
            this.comboBoxHireDate.Location = new System.Drawing.Point(248, 248);
            this.comboBoxHireDate.Name = "comboBoxHireDate";
            this.comboBoxHireDate.Size = new System.Drawing.Size(258, 21);
            this.comboBoxHireDate.TabIndex = 10;
            this.comboBoxHireDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxHireDate_SelectedIndexChanged);
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(248, 101);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(258, 20);
            this.textFirstName.TabIndex = 9;
            this.textFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(248, 149);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(258, 20);
            this.textLastName.TabIndex = 8;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(248, 52);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(258, 20);
            this.textID.TabIndex = 5;
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartment.Location = new System.Drawing.Point(78, 296);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(117, 24);
            this.lbDepartment.TabIndex = 4;
            this.lbDepartment.Text = "Department";
            this.lbDepartment.Click += new System.EventHandler(this.lbDepartment_Click);
            // 
            // lbHireDate
            // 
            this.lbHireDate.AutoSize = true;
            this.lbHireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHireDate.Location = new System.Drawing.Point(78, 243);
            this.lbHireDate.Name = "lbHireDate";
            this.lbHireDate.Size = new System.Drawing.Size(97, 24);
            this.lbHireDate.TabIndex = 3;
            this.lbHireDate.Text = "Hire Date";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(78, 145);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(108, 24);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "Last Name";
            this.lbLastName.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(75, 96);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(111, 24);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "First Name";
            this.lbFirstName.Click += new System.EventHandler(this.lbfirstname_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(75, 47);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(129, 24);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Employee ID";
            this.lbID.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(721, 144);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(307, 50);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Employee";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 844);
            this.Controls.Add(this.GrpEmp);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.EmpGrid);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.BtnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).EndInit();
            this.GrpEmp.ResumeLayout(false);
            this.GrpEmp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        public System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.DataGridView EmpGrid;
        private System.Windows.Forms.GroupBox GrpEmp;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Label lbHireDate;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.ComboBox comboDepartment;
        private System.Windows.Forms.ComboBox comboBoxHireDate;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Button btnUpdate;
    }
}

