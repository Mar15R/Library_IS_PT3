using Library_IS.Lib;
using Library_IS.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_IS.Forms
{
    public partial class BookMng : Form
    {
        Factory factory = new Factory();
        private BookView _book;
        public BookMng()
        {
            InitializeComponent();
        }
        public BookMng(BookView book)
        {
            InitializeComponent();
            _book = book;
            bnt_AddBook.Text = "Update Book";
        }

        private void BookMng_Load(object sender, EventArgs e)
        {
            cb_SelectAuthor.DataSource = factory.GetAllAuthors();
            cb_SelectAuthor.DisplayMember = "FullName";
            cb_SelectAuthor.ValueMember = "ID_Author";

            if (_book != null)
            {
                txt_BookName.Text = _book.Book_Name;
                txt_Isbn.Text = _book.ISBN;
                txt_Year.Text = _book.Year.ToString();
                cb_SelectAuthor.Text = _book.AuthorFullName;
            }
        }

        private void bnt_AddBook_Click(object sender, EventArgs e)
        {
            string bookName = txt_BookName.Text;
            string isbn = txt_Isbn.Text;
            int.TryParse(txt_Year.Text, out int year);
            long authorId = (long)cb_SelectAuthor.SelectedValue;

            if (_book != null)
            {
                factory.UpdateBook(_book.ID_Book, bookName, isbn, (short)year, authorId);
            }
            else
            {
                Book book = new Book
                {
                    Book_Name = bookName,
                    ISBN = isbn,
                    Year = (short)year,
                    ID_Author = authorId
                };
                factory.AddBook(book);
            }
            this.Close();
        }
    }
}
