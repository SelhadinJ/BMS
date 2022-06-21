using System;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class FirstUser : Form
    {
        string userType = "Super Admin";
        public FirstUser()
        {
            InitializeComponent();
        }
        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameF.Text;
            string lastName = lastNameF.Text;
            string phoneNo = phoneNoF.Text;
            string userName = userNameF.Text;
            string passwd = passwdF.Text;
            if (firstName.Equals("") || phoneNo.Equals("") || userName.Equals("") || passwd.Equals(""))
            {
                MessageBox.Show("Please fill the required fields (*).");
            }
            else
            {
                User firstUser = new User(firstName, lastName, phoneNo, userType, userName, passwd);
                bool isCreated = firstUser.CreateUser();
                if (isCreated)
                {
                    MessageBox.Show("User Created Successfully!");
                    new FirstLogin(firstUser).Visible = true;
                    Visible = false;
                }
                else MessageBox.Show("Something Is Wrong, Try Again!");
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
