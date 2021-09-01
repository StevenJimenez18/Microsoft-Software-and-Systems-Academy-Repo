
namespace Module3DelagtesDemo
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
            this.lbcoffee = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbcoffee
            // 
            this.lbcoffee.AutoSize = true;
            this.lbcoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcoffee.Location = new System.Drawing.Point(65, 74);
            this.lbcoffee.Name = "lbcoffee";
            this.lbcoffee.Size = new System.Drawing.Size(115, 24);
            this.lbcoffee.TabIndex = 0;
            this.lbcoffee.Text = "Coffee Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(186, 77);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(155, 20);
            this.txtStock.TabIndex = 1;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(347, 77);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(106, 23);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign Stock";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lbcoffee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcoffee;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnAssign;
    }
}

