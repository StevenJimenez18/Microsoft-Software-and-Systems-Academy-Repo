using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookLibrary;

namespace Module7Ex2
{
    public partial class Form1 : Form
    {
        
        int bookCounter = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            BookListGrid.Visible = false;
            lbBookTable.Visible = false;
            gbAddorUpdate.Visible = false;
            lbAddorUpdate.Visible = false;
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            
            if(BookListGrid.Visible == true)
            {
                BookListGrid.Visible = false;
                lbBookTable.Visible = false;
                
            }
            else if(BookListGrid.Visible == false)
            {
                BookListGrid.Visible = true;
                lbBookTable.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAuthor.Clear();
            txtBookName.Clear();
            txtDescription.Clear();
            txtPublished.Clear();
            gbAddorUpdate.Visible = true;
            lbAddorUpdate.Visible = true;
            lbAddorUpdate.Text = "Add a Book";
            btnAddorUpdate.Text = "Create";
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (Book.bookList.Count > 0)
            {

                Book book = (Book)BookListGrid.CurrentRow.DataBoundItem;
                /*Book.RemoveBook(book.BookId);*/
                Book.RemoveBook(book);
                RefreshData();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(Book.bookList.Count > 0 )
            {
                gbAddorUpdate.Visible = true;
                lbAddorUpdate.Visible = true;
                lbAddorUpdate.Text = "Update a Book";
                btnAddorUpdate.Text = "Update";
                Book book = (Book)BookListGrid.CurrentRow.DataBoundItem;
                txtBookName.Text = book.BookName;
                txtAuthor.Text = book.Author;
                txtPublished.Text = book.Published.ToString();
                txtDescription.Text = book.Description;
            }
            
        }

        private void btnAddorUpdate_Click(object sender, EventArgs e)
        {
            if(btnAddorUpdate.Text == "Create")
            {

                bookCounter++;
                Book newBook = new Book(bookCounter,
                    txtBookName.Text,
                    txtAuthor.Text,
                    DateTime.Parse(txtPublished.Text),
                    txtDescription.Text);
                Book.Addbook(newBook);
            }

            else if(btnAddorUpdate.Text == "Update")
            {
                Book book = (Book)BookListGrid.CurrentRow.DataBoundItem;
                Book.UpdateBook(book, txtBookName.Text, txtAuthor.Text, DateTime.Parse(txtPublished.Text), txtDescription.Text);
            }

            RefreshData();
            txtAuthor.Clear();
            txtBookName.Clear();
            txtDescription.Clear();
            txtPublished.Clear();

        }

        private void RefreshData()
        {
            BookListGrid.DataSource = null;
            BookListGrid.DataSource = Book.bookList;
            gbAddorUpdate.Visible = false;
            lbAddorUpdate.Visible = false;
        }
    }
}
