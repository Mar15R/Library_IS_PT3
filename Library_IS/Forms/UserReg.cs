using Library_IS.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_IS.Forms
{
    public partial class UserReg : Form
    {
        public UserReg()
        {
            InitializeComponent();
        }
        Factory factory = new Factory();
        private void btn_Register_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;
            bool canRegister = ValidateInput();
            if (txt_Password.Text != txt_Password2.Text)
            {
                lb_Error2.Text = "Password do not match!";
                canRegister = false;
            }

            if (factory.UserNameExists(userName))
            {
                lb_Error2.Text = "Username already exists!";
                canRegister = false;
            }

            if (!IsValidEmail(txt_Email.Text))
            {
                lb_Error2.Text = "Invalid email format!";
                canRegister = false;
            }

            if (canRegister)
            {
                User user = new User()
                {
                    Email = txt_Email.Text,
                    Name = userName,
                    Surname = txt_Surname.Text,
                    Phone = txt_Phone.Text,
                    Password = txt_Password.Text,
                    UserName = txt_UserName.Text,
                    Role = Enums.UserRole.User.ToString()
                };

                factory.CreateUser(user);
                this.Close();
            }

           

        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txt_UserName.Text) ||
                string.IsNullOrWhiteSpace(txt_Password.Text) ||
                string.IsNullOrWhiteSpace(txt_Password2.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_Surname.Text) ||
                string.IsNullOrWhiteSpace(txt_Phone.Text))
            {
                lb_Error2.Text = "All fields are required!";
                return false;
            }
            return true;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
    }

}
