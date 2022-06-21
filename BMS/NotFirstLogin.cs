using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class NotFirstLogin : Form
    {
        User notFirstUser;
        SqlDataReader _sqlReader;
        public NotFirstLogin() { 
            InitializeComponent();
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!userNameF.Text.Equals("") && !passwdF.Text.Equals("") && !(userType.SelectedItem == null))
            {
                string userName = userNameF.Text;
                string passwd = passwdF.Text;
                string type = (string) userType.SelectedItem;
                _sqlReader = new User().Authenticate(userName, passwd, type);
                if (_sqlReader.HasRows)
                {
                    if (_sqlReader.Read())
                    {
                        int userId = _sqlReader.GetInt32(0);
                        notFirstUser = new User().GetUser(userId);
                    }
                    if (type.Equals("Sales Person"))
                       new SalesPersonHomePage(notFirstUser).Visible = true;
                    else new AdminHomePage(notFirstUser).Visible = true;

                    //Registering sign-in
                    if (!type.Equals("Super Admin"))
                        new Audit(notFirstUser, "Logged In").InsertAuditRecord();
                    Visible = false;
                }
                else
                {
                    userNameErr.Visible = false;
                    passwdErr.Visible = false;
                    userTypeErr.Visible = false;
                    MessageBox.Show("No Such " + type + " Found With This Username And Password. Try Again!", "Authentication Failed!");
                }
            }
            else
            {
                if (userNameF.Text.Equals("") && passwdF.Text.Equals(""))
                {
                    userNameErr.Visible = true;
                    passwdErr.Visible = true;
                }
                else if (userNameF.Text.Equals(""))
                {
                    userNameErr.Visible = true;
                    passwdErr.Visible = false;
                }
                else if (passwdF.Text.Equals(""))
                {
                    userNameErr.Visible = false;
                    passwdErr.Visible = true;
                }
                else if (userType.SelectedItem == null)
                {
                    userTypeErr.Visible = true;
                    userNameErr.Visible = false;
                    passwdErr.Visible = false;
                }
                else
                {
                    userNameErr.Visible = false;
                    passwdErr.Visible = false;
                    userTypeErr.Visible = false;
                }
            }
        }
        private void CancelBtn_Click(object sender, EventArgs e) 
        { 
            Application.Exit(); 
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
