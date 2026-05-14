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
    public partial class UserMain : Form
    {
        private User _user;
        Helper helper = new Helper();
        Factory factory = new Factory();
        public UserMain(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void UserMain_Load(object sender, EventArgs e)
        {
            ReloadBooks();            
        }

        private void ReloadBooks()
        {
            List<GridAction> gridActionsT = new List<GridAction>
            {
                new GridAction { Name = "btnTaken", Text = "Taken" }//,
                //new GridAction { Name = "btnUpdate", Text = "Update" }
            };

            List<GridAction> gridActionsR = new List<GridAction>
            {
                new GridAction { Name = "btnReturn", Text = "Return" }//,
                //new GridAction { Name = "btnUpdate", Text = "Update" }
            };

            helper.ReloadGrid(gv_AvailableBooks, factory.GetAvailableBooks(), new List<int> { 0 }, gridActionsT);
            helper.ReloadGrid(gv_TakenBooks, factory.GetBooksByUserID(_user.UserName), new List<int> { 0 }, gridActionsR);
        }

        private void gv_TakenBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    BookView book = (BookView)gv_TakenBooks.Rows[e.RowIndex].DataBoundItem;
                    if (e.ColumnIndex == gv_TakenBooks.Columns["btnReturn"].Index)
                    {
                        //DialogResult result = MessageBox.Show("Are you sure you want to return this book?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        
                            if (factory.ReturnBook(book.ID_Book))
                            {
                                ReloadBooks();
                            }
                            else
                            {
                                MessageBox.Show("Problems with returning of the book...");
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void gv_AvailableBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    BookView book = (BookView)gv_AvailableBooks.Rows[e.RowIndex].DataBoundItem;
                    if (e.ColumnIndex == gv_AvailableBooks.Columns["btnTaken"].Index)
                    {

                        if (factory.TakeBook(book.ID_Book, _user.UserName))
                        {
                            ReloadBooks();
                        }
                        else
                        {
                            MessageBox.Show("Problems with taking the book...");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
    }
}
