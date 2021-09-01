using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book
    {
        public int BookId { get; set; }

        public string BookName { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public string Description { get; set; }

        static public List<Book> bookList = new List<Book>();


        public Book(int id, string bookName, string author, DateTime published, string description)
        {
            this.BookId = id;
            this.BookName = bookName;
            this.Author = author;
            this.Published = published;
            this.Description = description;
        }

        static public void Addbook(Book book)
        {
            bookList.Add(book);
        }

        static public void UpdateBook(Book book, string bookName, string author, DateTime published, string description)
        {
            
            book.BookName = bookName;
            book.Author = author;
            book.Published = published;
            book.Description = description;
        }

        static public void RemoveBook(Book book)
        {
           bookList.Remove(book);
        }
        
    }
}
