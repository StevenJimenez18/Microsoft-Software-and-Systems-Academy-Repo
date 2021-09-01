
namespace Module6Ex1
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
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lbCustId = new System.Windows.Forms.Label();
            this.lbLname = new System.Windows.Forms.Label();
            this.lbFname = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSubHeader = new System.Windows.Forms.Label();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.btnJSON = new System.Windows.Forms.Button();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.lbthree = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbLogin.Controls.Add(this.txtCustId);
            this.gbLogin.Controls.Add(this.txtLname);
            this.gbLogin.Controls.Add(this.txtFname);
            this.gbLogin.Controls.Add(this.lbCustId);
            this.gbLogin.Controls.Add(this.lbLname);
            this.gbLogin.Controls.Add(this.lbFname);
            this.gbLogin.Controls.Add(this.lbLogin);
            this.gbLogin.Controls.Add(this.btnCreate);
            this.gbLogin.Location = new System.Drawing.Point(58, 53);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(389, 297);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(185, 99);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(180, 20);
            this.txtCustId.TabIndex = 8;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(185, 184);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(180, 20);
            this.txtLname.TabIndex = 7;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(185, 142);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(180, 20);
            this.txtFname.TabIndex = 6;
            // 
            // lbCustId
            // 
            this.lbCustId.AutoSize = true;
            this.lbCustId.BackColor = System.Drawing.Color.White;
            this.lbCustId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustId.ForeColor = System.Drawing.Color.Blue;
            this.lbCustId.Location = new System.Drawing.Point(21, 93);
            this.lbCustId.Name = "lbCustId";
            this.lbCustId.Size = new System.Drawing.Size(120, 27);
            this.lbCustId.TabIndex = 5;
            this.lbCustId.Text = "Customer Id";
            // 
            // lbLname
            // 
            this.lbLname.AutoSize = true;
            this.lbLname.BackColor = System.Drawing.Color.GhostWhite;
            this.lbLname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLname.ForeColor = System.Drawing.Color.Blue;
            this.lbLname.Location = new System.Drawing.Point(21, 184);
            this.lbLname.Name = "lbLname";
            this.lbLname.Size = new System.Drawing.Size(108, 27);
            this.lbLname.TabIndex = 3;
            this.lbLname.Text = "Last Name";
            // 
            // lbFname
            // 
            this.lbFname.AutoSize = true;
            this.lbFname.BackColor = System.Drawing.Color.GhostWhite;
            this.lbFname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFname.ForeColor = System.Drawing.Color.Blue;
            this.lbFname.Location = new System.Drawing.Point(21, 142);
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
            this.lbLogin.Size = new System.Drawing.Size(210, 27);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Hello New Customer";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Blue;
            this.btnCreate.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnCreate.Location = new System.Drawing.Point(126, 247);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbHeader.Location = new System.Drawing.Point(726, 53);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(2, 38);
            this.lbHeader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(750, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // lbSubHeader
            // 
            this.lbSubHeader.AutoSize = true;
            this.lbSubHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSubHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSubHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbSubHeader.Location = new System.Drawing.Point(691, 119);
            this.lbSubHeader.Name = "lbSubHeader";
            this.lbSubHeader.Size = new System.Drawing.Size(448, 38);
            this.lbSubHeader.TabIndex = 4;
            this.lbSubHeader.Text = "Select a method to get started.";
            this.lbSubHeader.Click += new System.EventHandler(this.lbSubHeader_Click);
            // 
            // btnBinary
            // 
            this.btnBinary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinary.Location = new System.Drawing.Point(555, 239);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(200, 47);
            this.btnBinary.TabIndex = 6;
            this.btnBinary.Text = "Binary";
            this.btnBinary.UseVisualStyleBackColor = false;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnXML
            // 
            this.btnXML.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXML.Location = new System.Drawing.Point(795, 239);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(200, 47);
            this.btnXML.TabIndex = 7;
            this.btnXML.Text = "XML";
            this.btnXML.UseVisualStyleBackColor = false;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnJSON
            // 
            this.btnJSON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJSON.Location = new System.Drawing.Point(1033, 239);
            this.btnJSON.Name = "btnJSON";
            this.btnJSON.Size = new System.Drawing.Size(200, 47);
            this.btnJSON.TabIndex = 8;
            this.btnJSON.Text = "JSON";
            this.btnJSON.UseVisualStyleBackColor = false;
            this.btnJSON.Click += new System.EventHandler(this.btnJSON_Click);
            // 
            // btnSerialize
            // 
            this.btnSerialize.BackColor = System.Drawing.Color.Bisque;
            this.btnSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialize.Location = new System.Drawing.Point(132, 507);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(200, 47);
            this.btnSerialize.TabIndex = 9;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = false;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.BackColor = System.Drawing.Color.Bisque;
            this.btnDeserialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeserialize.Location = new System.Drawing.Point(1477, 507);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(200, 47);
            this.btnDeserialize.TabIndex = 10;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = false;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // textArea
            // 
            this.textArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArea.Location = new System.Drawing.Point(555, 302);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(678, 609);
            this.textArea.TabIndex = 11;
            this.textArea.Text = "";
            // 
            // lbthree
            // 
            this.lbthree.AutoSize = true;
            this.lbthree.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbthree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbthree.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthree.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbthree.Location = new System.Drawing.Point(648, 177);
            this.lbthree.Name = "lbthree";
            this.lbthree.Size = new System.Drawing.Size(497, 38);
            this.lbthree.TabIndex = 12;
            this.lbthree.Text = "your info is ready to be serialized.";
            this.lbthree.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1907, 1021);
            this.Controls.Add(this.lbthree);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.btnJSON);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnBinary);
            this.Controls.Add(this.lbSubHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.gbLogin);
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
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lbCustId;
        private System.Windows.Forms.Label lbLname;
        private System.Windows.Forms.Label lbFname;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSubHeader;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button btnJSON;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.Label lbthree;
    }
}

