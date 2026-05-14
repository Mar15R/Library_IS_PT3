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

        //private void ReloadBooks()
        //{
        //    List<GridAction> gridActions = new List<GridAction>
        //    {
        //        new GridAction { Name = "btnDelete", Text = "Delete" },
        //        new GridAction { Name = "btnUpdate", Text = "Update" }
        //    };
        //    helper.ReloadGrid(gv_Books, factory.GetBookViews(), new List<int> { 0 }, gridActions);
        //}

        private void AdminMain_Load(object sender, EventArgs e)
        {
            //ReloadBooks();
        }
    }
}
