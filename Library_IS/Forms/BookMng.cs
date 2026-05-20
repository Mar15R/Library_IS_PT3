using Library_IS.Lib;
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
        Validation validation = new Validation();
        private long? bookId;

        public BookMng(long? _bookId)
        {
            InitializeComponent();
            bookId = _bookId;
        }

        private void BookMng_Load(object sender, EventArgs e)
        {
            cb_SelectAuthor.DataSource = factory.GetAllAuthors();
            cb_SelectAuthor.DisplayMember = "FullName";
            cb_SelectAuthor.ValueMember = "ID_Author";
        }

        private void bnt_AddBook_Click(object sender, EventArgs e)
        {
            string bookName = txt_BookName.Text;
            string isbn = txt_Isbn.Text;
            //int year = int.TryParse(txt_Year.Text, out int parsedYear) ? parsedYear : 0;//ja tryparse nenostrādā, tad year būs 0
            int.TryParse(txt_Year.Text, out int year);

            if (!validation.IsYearValid(year))
            {
                lbl_Error.Text = "Please enter a valid year.";
                return;//aptur koda AddBook_click funkcionalitāti, ja gads nav derīgs
            }

            long authorId = (long)cb_SelectAuthor.SelectedValue;

            Book book = new Book
            {
                Book_Name = bookName,
                ISBN = isbn,
                Year = (short)year,
                ID_Author = authorId
            };

            if (bookId != null)
            {
                book.ID_Book = (long)bookId;
                if (factory.UpdateBook(book))
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                if (factory.AddBook(book))
                {
                    this.DialogResult = DialogResult.OK;
                }
            }

            this.Close();
        }
    }
}
