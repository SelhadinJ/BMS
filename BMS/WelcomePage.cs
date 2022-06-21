using System;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }
        private void GetStarted_Click(object sender, EventArgs e)
        {
            FirstUser firstUser = new FirstUser();
            firstUser.Visible = true;
            Visible = false;
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
