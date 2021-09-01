
namespace Module6FilesDemo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lbCustId = new System.Windows.Forms.Label();
            this.lbLname = new System.Windows.Forms.Label();
            this.lbFname = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exitNotepadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1994, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewDocument});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // NewDocument
            // 
            this.NewDocument.Name = "NewDocument";
            this.NewDocument.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewDocument.Size = new System.Drawing.Size(173, 22);
            this.NewDocument.Text = "Document";
            this.NewDocument.Click += new System.EventHandler(this.documentToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // exitNotepadToolStripMenuItem
            // 
            this.exitNotepadToolStripMenuItem.Name = "exitNotepadToolStripMenuItem";
            this.exitNotepadToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.exitNotepadToolStripMenuItem.Text = "Exit Notepad";
            this.exitNotepadToolStripMenuItem.Click += new System.EventHandler(this.exitNotepadToolStripMenuItem_Click);
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(1157, 27);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(825, 965);
            this.textArea.TabIndex = 2;
            this.textArea.Text = "";
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
            this.gbLogin.Location = new System.Drawing.Point(12, 27);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(389, 297);
            this.gbLogin.TabIndex = 3;
            this.gbLogin.TabStop = false;
            this.gbLogin.Enter += new System.EventHandler(this.gbLogin_Enter);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1994, 1046);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewDocument;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitNotepadToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lbCustId;
        private System.Windows.Forms.Label lbLname;
        private System.Windows.Forms.Label lbFname;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btnCreate;
    }
}

