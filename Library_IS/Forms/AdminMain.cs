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
    public partial class AdminMain : Form
    {
        private User _user;

        Helper helper = new Helper();
        Factory factory = new Factory();
        public AdminMain(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void ReloadBooks()
        {
            List<GridAction> gridActions = new List<GridAction>
            {
                new GridAction { Name = "btnDelete", Text = "Delete" },
                new GridAction { Name = "btnUpdate", Text = "Update" }
            };
            helper.ReloadGrid(gv_Books, factory.GetAllBooks(), new List<int> { 0 }, gridActions);
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            ReloadBooks();
        }

        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void gv_Books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    BookView book = (BookView)gv_Books.Rows[e.RowIndex].DataBoundItem;
                    if (e.ColumnIndex == gv_Books.Columns["btnDelete"].Index)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            if (factory.DeleteBook(book.ID_Book))
                            {
                                ReloadBooks();
                            }
                            else
                            {
                                MessageBox.Show("Problems with camp Deletion...");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            try
            {

                using (BookMng popup = new BookMng())
                {
                    popup.StartPosition = FormStartPosition.CenterParent;
                    popup.ShowDialog();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
