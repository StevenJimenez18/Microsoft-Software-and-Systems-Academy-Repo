using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Module6FilesDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void documentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Clear();
            textArea.Visible = true;
            textArea.Focus();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files(*.txt)|*.txt";
            openFile.ShowDialog();
            Stream sw = openFile.OpenFile();
            StreamReader reader = new StreamReader(sw);
            textArea.Text = reader.ReadToEnd();
            reader.Close();
            sw.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
            //Stream sw = saveFile.OpenFile();
            FileStream fileStream = new FileStream(saveFile.FileName, FileMode.Append, FileAccess.Write);
            StreamWriter writeFile = new StreamWriter(fileStream);
            writeFile.WriteLine(textArea.Text);
            writeFile.Close();
            fileStream.Close();
        }

        private void exitNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gbLogin_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            newAccount.CustId = Int32.Parse(txtCustId.Text);
            newAccount.FirstName = txtFname.Text;
            newAccount.LastName = txtLname.Text;
            fileToolStripMenuItem.Visible = true;
            editToolStripMenuItem.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textArea.Visible = false;
            fileToolStripMenuItem.Visible = false;
            editToolStripMenuItem.Visible = false;
        }
    }
}
