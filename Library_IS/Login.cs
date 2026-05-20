using Library_IS.Forms;
using Library_IS.Lib;
using Library_IS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_IS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {

                using (UserReg popup = new UserReg())
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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = txt_Username.Text.Trim();
            string password = txt_Password.Text.Trim();


            if (userName != "" && password != "")
            {
                Security security = new Security();
                Result<User> user = security.AuthenticateUser(userName, password);
                if (user.IsSuccess)
                {
                    this.Hide();
                    switch (user.Data.Role)
                    {
                        case "Admin":
                            {
                                AdminMain adminMain = new AdminMain(user.Data);
                                adminMain.Show();
                                break;
                            }
                        case "User":
                            {
                                UserMain userMain = new UserMain(user.Data);
                                userMain.Show();
                                break;
                            }
                        default:
                            {
                                UserMain userMain = new UserMain(user.Data);
                                userMain.Show();
                                break;
                            }
                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_Username.Text = "MarisR";
            txt_Password.Text = "Parole123";

        }
    }
}
