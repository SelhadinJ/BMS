using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class FirstLogin : Form
    {
        User firstUser;
        SqlDataReader _sqlReader;
        public FirstLogin(object firstUser)
        {
            InitializeComponent();
            this.firstUser = (User) firstUser;
            userNameF.Text = this.firstUser.UserName;
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!(passwdF.Text.Equals("")))
            {
                string userName = userNameF.Text;
                string passwd = passwdF.Text;
                _sqlReader = new User().Authenticate(userName, passwd);
                if (_sqlReader.HasRows)
                {
                    if (_sqlReader.Read())
                    {
                        int userId = _sqlReader.GetInt32(0);
                        firstUser = new User().GetUser(userId);
                    }
                    new AdminHomePage(firstUser).Visible = true;
                    Visible = false;
                }
                else
                {
                    passwdErr.Visible = false;
                    MessageBox.Show("Super Admin's Password Is Incorrect. Try again!!");
                }
            }
            else passwdErr.Visible = true;
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}