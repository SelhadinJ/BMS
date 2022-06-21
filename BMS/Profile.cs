using System;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class Profile : Form
    {
        User passedUser;
        public Profile(object passedUser)
        {
            InitializeComponent();
            this.passedUser = (User) passedUser;
            userId.Text = this.passedUser.UserId.ToString();
            name.Text = this.passedUser.FirstName + " " + this.passedUser.LastName;
            phoneNo.Text = this.passedUser.PhoneNo;
            userName.Text = this.passedUser.UserName;
            loggedAs.Text = this.passedUser.UserType;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
