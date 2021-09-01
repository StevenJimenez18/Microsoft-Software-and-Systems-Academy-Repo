
namespace Module7SQLConnectionDemo
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
            this.EmpGrid = new System.Windows.Forms.DataGridView();
            this.lbEmpId = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lbFname = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lbLname = new System.Windows.Forms.Label();
            this.lbDesignation = new System.Windows.Forms.Label();
            this.lbSalaray = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbDeptId = new System.Windows.Forms.Label();
            this.cbDeptId = new System.Windows.Forms.ComboBox();
            this.cbDesignation = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnAddorUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).BeginInit();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpGrid
            // 
            this.EmpGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGrid.Location = new System.Drawing.Point(12, 350);
            this.EmpGrid.Name = "EmpGrid";
            this.EmpGrid.Size = new System.Drawing.Size(1297, 388);
            this.EmpGrid.TabIndex = 0;
            // 
            // lbEmpId
            // 
            this.lbEmpId.AutoSize = true;
            this.lbEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpId.Location = new System.Drawing.Point(61, 21);
            this.lbEmpId.Name = "lbEmpId";
            this.lbEmpId.Size = new System.Drawing.Size(120, 25);
            this.lbEmpId.TabIndex = 1;
            this.lbEmpId.Text = "Employee Id";
            this.lbEmpId.Click += new System.EventHandler(this.lbEmpId_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(281, 21);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(223, 20);
            this.txtEmpId.TabIndex = 2;
            // 
            // lbFname
            // 
            this.lbFname.AutoSize = true;
            this.lbFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFname.Location = new System.Drawing.Point(61, 67);
            this.lbFname.Name = "lbFname";
            this.lbFname.Size = new System.Drawing.Size(106, 25);
            this.lbFname.TabIndex = 3;
            this.lbFname.Text = "First Name";
            this.lbFname.Click += new System.EventHandler(this.lbFname_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(281, 67);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(223, 20);
            this.txtFname.TabIndex = 4;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(281, 117);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(223, 20);
            this.txtLname.TabIndex = 5;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(281, 258);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(223, 20);
            this.txtSalary.TabIndex = 7;
            // 
            // lbLname
            // 
            this.lbLname.AutoSize = true;
            this.lbLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLname.Location = new System.Drawing.Point(61, 117);
            this.lbLname.Name = "lbLname";
            this.lbLname.Size = new System.Drawing.Size(106, 25);
            this.lbLname.TabIndex = 8;
            this.lbLname.Text = "Last Name";
            // 
            // lbDesignation
            // 
            this.lbDesignation.AutoSize = true;
            this.lbDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesignation.Location = new System.Drawing.Point(61, 209);
            this.lbDesignation.Name = "lbDesignation";
            this.lbDesignation.Size = new System.Drawing.Size(115, 25);
            this.lbDesignation.TabIndex = 9;
            this.lbDesignation.Text = "Designation";
            // 
            // lbSalaray
            // 
            this.lbSalaray.AutoSize = true;
            this.lbSalaray.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalaray.Location = new System.Drawing.Point(61, 253);
            this.lbSalaray.Name = "lbSalaray";
            this.lbSalaray.Size = new System.Drawing.Size(68, 25);
            this.lbSalaray.TabIndex = 10;
            this.lbSalaray.Text = "Salary";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(36, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 58);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add New Record";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbDeptId
            // 
            this.lbDeptId.AutoSize = true;
            this.lbDeptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeptId.Location = new System.Drawing.Point(61, 165);
            this.lbDeptId.Name = "lbDeptId";
            this.lbDeptId.Size = new System.Drawing.Size(74, 25);
            this.lbDeptId.TabIndex = 12;
            this.lbDeptId.Text = "Dept Id";
            // 
            // cbDeptId
            // 
            this.cbDeptId.FormattingEnabled = true;
            this.cbDeptId.Location = new System.Drawing.Point(281, 165);
            this.cbDeptId.Name = "cbDeptId";
            this.cbDeptId.Size = new System.Drawing.Size(223, 21);
            this.cbDeptId.TabIndex = 13;
            // 
            // cbDesignation
            // 
            this.cbDesignation.FormattingEnabled = true;
            this.cbDesignation.Location = new System.Drawing.Point(281, 209);
            this.cbDesignation.Name = "cbDesignation";
            this.cbDesignation.Size = new System.Drawing.Size(223, 21);
            this.cbDesignation.TabIndex = 14;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Cornsilk;
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(36, 264);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(188, 58);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(36, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(188, 58);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(36, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 58);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnAddorUpdate);
            this.gbMain.Controls.Add(this.lbEmpId);
            this.gbMain.Controls.Add(this.txtEmpId);
            this.gbMain.Controls.Add(this.lbFname);
            this.gbMain.Controls.Add(this.txtFname);
            this.gbMain.Controls.Add(this.txtLname);
            this.gbMain.Controls.Add(this.cbDesignation);
            this.gbMain.Controls.Add(this.txtSalary);
            this.gbMain.Controls.Add(this.cbDeptId);
            this.gbMain.Controls.Add(this.lbLname);
            this.gbMain.Controls.Add(this.lbDeptId);
            this.gbMain.Controls.Add(this.lbDesignation);
            this.gbMain.Controls.Add(this.lbSalaray);
            this.gbMain.Location = new System.Drawing.Point(374, 9);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(561, 335);
            this.gbMain.TabIndex = 19;
            this.gbMain.TabStop = false;
            // 
            // btnAddorUpdate
            // 
            this.btnAddorUpdate.Location = new System.Drawing.Point(196, 306);
            this.btnAddorUpdate.Name = "btnAddorUpdate";
            this.btnAddorUpdate.Size = new System.Drawing.Size(155, 23);
            this.btnAddorUpdate.TabIndex = 15;
            this.btnAddorUpdate.Text = "PlaceHolder";
            this.btnAddorUpdate.UseVisualStyleBackColor = true;
            this.btnAddorUpdate.Click += new System.EventHandler(this.btnAddorUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1332, 750);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.EmpGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).EndInit();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmpGrid;
        private System.Windows.Forms.Label lbEmpId;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label lbFname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lbLname;
        private System.Windows.Forms.Label lbDesignation;
        private System.Windows.Forms.Label lbSalaray;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbDeptId;
        private System.Windows.Forms.ComboBox cbDeptId;
        private System.Windows.Forms.ComboBox cbDesignation;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Button btnAddorUpdate;
    }
}

