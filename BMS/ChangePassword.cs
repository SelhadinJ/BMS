using System;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class ChangePassword : Form
    {
        User passedUser;
        public ChangePassword(object passedUser)
        {
            InitializeComponent();
            this.passedUser = (User) passedUser;
        }
        private void ChangePasswdBtn_Click(object sender, EventArgs e)
        {
            string existingPass = new User().HashPassword(existingPasswd.Text);
            string newPass = newPasswd.Text;
            string confirmPass = confirmPasswd.Text;

            if (!existingPass.Equals("") && !newPass.Equals("") && !confirmPass.Equals(""))
            {
                if (passedUser.Password.Equals(existingPass))
                {
                    existingPasswdErr.Visible = false;
                    if (newPass.Equals(confirmPass))
                    {
                        if (!existingPass.Equals(new User().HashPassword(newPass)))
                        {
                            passedUser.ChangePassword(newPass);
                            MessageBox.Show("Your password have been changed.");
                            Close();
                        }
                        else MessageBox.Show("There is no change in your password.");
                    }
                    else
                    {
                        confirmPasswdErr.Visible = true;
                        existingPasswdErr.Visible = false;
                    }
                }
                else existingPasswdErr.Visible = true;
            }
            else MessageBox.Show("Input required fields to change your password.");
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
