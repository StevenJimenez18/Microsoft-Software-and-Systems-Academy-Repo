
namespace Module3Ex2
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.cbAccount = new System.Windows.Forms.ComboBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbLname = new System.Windows.Forms.Label();
            this.lbFname = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lbSuccess = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbLogin.Controls.Add(this.cbAccount);
            this.gbLogin.Controls.Add(this.txtBalance);
            this.gbLogin.Controls.Add(this.txtLname);
            this.gbLogin.Controls.Add(this.txtFname);
            this.gbLogin.Controls.Add(this.lbBalance);
            this.gbLogin.Controls.Add(this.lbAccount);
            this.gbLogin.Controls.Add(this.lbLname);
            this.gbLogin.Controls.Add(this.lbFname);
            this.gbLogin.Controls.Add(this.lbLogin);
            this.gbLogin.Controls.Add(this.btnCreate);
            this.gbLogin.Location = new System.Drawing.Point(336, 149);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(395, 375);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbAccount
            // 
            this.cbAccount.FormattingEnabled = true;
            this.cbAccount.Location = new System.Drawing.Point(185, 184);
            this.cbAccount.Name = "cbAccount";
            this.cbAccount.Size = new System.Drawing.Size(180, 21);
            this.cbAccount.TabIndex = 9;
            this.cbAccount.SelectedIndexChanged += new System.EventHandler(this.cbAccount_SelectedIndexChanged);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(185, 229);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(180, 20);
            this.txtBalance.TabIndex = 8;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(185, 142);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(180, 20);
            this.txtLname.TabIndex = 7;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(185, 101);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(180, 20);
            this.txtFname.TabIndex = 6;
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.BackColor = System.Drawing.Color.White;
            this.lbBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.ForeColor = System.Drawing.Color.Blue;
            this.lbBalance.Location = new System.Drawing.Point(21, 224);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(157, 27);
            this.lbBalance.TabIndex = 5;
            this.lbBalance.Text = "Starting Balance";
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.BackColor = System.Drawing.Color.GhostWhite;
            this.lbAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccount.ForeColor = System.Drawing.Color.Blue;
            this.lbAccount.Location = new System.Drawing.Point(21, 184);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(136, 27);
            this.lbAccount.TabIndex = 4;
            this.lbAccount.Text = "Account Type";
            // 
            // lbLname
            // 
            this.lbLname.AutoSize = true;
            this.lbLname.BackColor = System.Drawing.Color.GhostWhite;
            this.lbLname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLname.ForeColor = System.Drawing.Color.Blue;
            this.lbLname.Location = new System.Drawing.Point(21, 142);
            this.lbLname.Name = "lbLname";
            this.lbLname.Size = new System.Drawing.Size(108, 27);
            this.lbLname.TabIndex = 3;
            this.lbLname.Text = "Last Name";
            this.lbLname.Click += new System.EventHandler(this.lbLname_Click);
            // 
            // lbFname
            // 
            this.lbFname.AutoSize = true;
            this.lbFname.BackColor = System.Drawing.Color.GhostWhite;
            this.lbFname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFname.ForeColor = System.Drawing.Color.Blue;
            this.lbFname.Location = new System.Drawing.Point(21, 101);
            this.lbFname.Name = "lbFname";
            this.lbFname.Size = new System.Drawing.Size(108, 27);
            this.lbFname.TabIndex = 2;
            this.lbFname.Text = "First Name";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.GhostWhite;
            this.lbLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.Blue;
            this.lbLogin.Location = new System.Drawing.Point(100, 46);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(197, 27);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Welcome to Chase";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Blue;
            this.btnCreate.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnCreate.Location = new System.Drawing.Point(140, 279);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lbSuccess
            // 
            this.lbSuccess.AutoSize = true;
            this.lbSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuccess.ForeColor = System.Drawing.Color.Blue;
            this.lbSuccess.Location = new System.Drawing.Point(105, 97);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(915, 39);
            this.lbSuccess.TabIndex = 1;
            this.lbSuccess.Text = "Thank you for completing your account. Welcome to Chase!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Module3Ex2.Properties.Resources.Chase;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 707);
            this.Controls.Add(this.lbSuccess);
            this.Controls.Add(this.gbLogin);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.ComboBox cbAccount;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label lbLname;
        private System.Windows.Forms.Label lbFname;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lbSuccess;
    }
}

