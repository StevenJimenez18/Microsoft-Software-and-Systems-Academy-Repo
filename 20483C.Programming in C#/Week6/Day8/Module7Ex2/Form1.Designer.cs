
namespace Module7Ex2
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BookListGrid = new System.Windows.Forms.DataGridView();
            this.lbBookTable = new System.Windows.Forms.Label();
            this.lbAddorUpdate = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbPublished = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.gbAddorUpdate = new System.Windows.Forms.GroupBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublished = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddorUpdate = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookListGrid)).BeginInit();
            this.gbAddorUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.btnView);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.BtnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnRemove);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(107, 707);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(3, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 49);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View Books";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 49);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(3, 168);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 49);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Book";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(3, 113);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(100, 49);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Update Book";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BookListGrid
            // 
            this.BookListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookListGrid.Location = new System.Drawing.Point(178, 60);
            this.BookListGrid.Name = "BookListGrid";
            this.BookListGrid.Size = new System.Drawing.Size(539, 584);
            this.BookListGrid.TabIndex = 1;
            // 
            // lbBookTable
            // 
            this.lbBookTable.AutoSize = true;
            this.lbBookTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBookTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookTable.ForeColor = System.Drawing.Color.White;
            this.lbBookTable.Location = new System.Drawing.Point(360, 16);
            this.lbBookTable.Name = "lbBookTable";
            this.lbBookTable.Size = new System.Drawing.Size(141, 38);
            this.lbBookTable.TabIndex = 2;
            this.lbBookTable.Text = "Book List";
            // 
            // lbAddorUpdate
            // 
            this.lbAddorUpdate.AutoSize = true;
            this.lbAddorUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAddorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddorUpdate.ForeColor = System.Drawing.Color.White;
            this.lbAddorUpdate.Location = new System.Drawing.Point(963, 16);
            this.lbAddorUpdate.Name = "lbAddorUpdate";
            this.lbAddorUpdate.Size = new System.Drawing.Size(187, 38);
            this.lbAddorUpdate.TabIndex = 3;
            this.lbAddorUpdate.Text = "Place Holder";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.Location = new System.Drawing.Point(34, 78);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(127, 26);
            this.lbBookName.TabIndex = 0;
            this.lbBookName.Text = "Book Name";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.Location = new System.Drawing.Point(34, 174);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(76, 26);
            this.lbAuthor.TabIndex = 1;
            this.lbAuthor.Text = "Author";
            // 
            // lbPublished
            // 
            this.lbPublished.AutoSize = true;
            this.lbPublished.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublished.Location = new System.Drawing.Point(34, 275);
            this.lbPublished.Name = "lbPublished";
            this.lbPublished.Size = new System.Drawing.Size(160, 26);
            this.lbPublished.TabIndex = 2;
            this.lbPublished.Text = "Date Published";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(34, 375);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(121, 26);
            this.lbDescription.TabIndex = 3;
            this.lbDescription.Text = "Description";
            // 
            // gbAddorUpdate
            // 
            this.gbAddorUpdate.BackColor = System.Drawing.Color.AliceBlue;
            this.gbAddorUpdate.Controls.Add(this.btnAddorUpdate);
            this.gbAddorUpdate.Controls.Add(this.txtDescription);
            this.gbAddorUpdate.Controls.Add(this.txtPublished);
            this.gbAddorUpdate.Controls.Add(this.txtAuthor);
            this.gbAddorUpdate.Controls.Add(this.txtBookName);
            this.gbAddorUpdate.Controls.Add(this.lbDescription);
            this.gbAddorUpdate.Controls.Add(this.lbPublished);
            this.gbAddorUpdate.Controls.Add(this.lbAuthor);
            this.gbAddorUpdate.Controls.Add(this.lbBookName);
            this.gbAddorUpdate.Location = new System.Drawing.Point(776, 60);
            this.gbAddorUpdate.Name = "gbAddorUpdate";
            this.gbAddorUpdate.Size = new System.Drawing.Size(554, 584);
            this.gbAddorUpdate.TabIndex = 4;
            this.gbAddorUpdate.TabStop = false;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(202, 84);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(321, 20);
            this.txtBookName.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(202, 180);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(321, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // txtPublished
            // 
            this.txtPublished.Location = new System.Drawing.Point(202, 281);
            this.txtPublished.Name = "txtPublished";
            this.txtPublished.Size = new System.Drawing.Size(321, 20);
            this.txtPublished.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(202, 381);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(321, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // btnAddorUpdate
            // 
            this.btnAddorUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddorUpdate.ForeColor = System.Drawing.Color.Snow;
            this.btnAddorUpdate.Location = new System.Drawing.Point(202, 484);
            this.btnAddorUpdate.Name = "btnAddorUpdate";
            this.btnAddorUpdate.Size = new System.Drawing.Size(144, 39);
            this.btnAddorUpdate.TabIndex = 8;
            this.btnAddorUpdate.Text = "Placeholder";
            this.btnAddorUpdate.UseVisualStyleBackColor = false;
            this.btnAddorUpdate.Click += new System.EventHandler(this.btnAddorUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1370, 709);
            this.Controls.Add(this.gbAddorUpdate);
            this.Controls.Add(this.lbAddorUpdate);
            this.Controls.Add(this.lbBookTable);
            this.Controls.Add(this.BookListGrid);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookListGrid)).EndInit();
            this.gbAddorUpdate.ResumeLayout(false);
            this.gbAddorUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.DataGridView BookListGrid;
        private System.Windows.Forms.Label lbBookTable;
        private System.Windows.Forms.Label lbAddorUpdate;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbPublished;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.GroupBox gbAddorUpdate;
        private System.Windows.Forms.Button btnAddorUpdate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPublished;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookName;
    }
}

