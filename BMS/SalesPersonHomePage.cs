using System;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class SalesPersonHomePage : Form
    {
        User passedUser;
        public SalesPersonHomePage(Object passedUser)
        {
            InitializeComponent();
            this.passedUser = (User) passedUser;
            loggedInAs.Text = this.passedUser.UserType;
        }
        private void AddCustomer_Click(object sender, EventArgs e)
        {
            new CustomerFrame(passedUser).Visible = true;
        }
        private void Profile_Click(object sender, EventArgs e)
        {
            new Profile(passedUser).Visible = true;
        }
        private void SignOut_Click(object sender, EventArgs e)
        {
            //Registering sign-out
            new Audit(passedUser, "Logged Out").InsertAuditRecord();
            new NotFirstLogin().Visible = true;
            Visible = false;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            //Registering sign-out
            new Audit(passedUser, "Logged Out").InsertAuditRecord();
            Application.Exit();
        }
        private void EditCustomer_Click(object sender, EventArgs e)
        {
            new CustomerFrame(passedUser).Visible = true;
        }
        private void ChangePassword_Click(object sender, EventArgs e)
        {
            new ChangePassword(passedUser).Visible = true;
        }
        private void About_Click(object sender, EventArgs e)
        {
            new About().Visible = true;
        }
        private void ProfileQuickAccess_Click_1(object sender, EventArgs e)
        {
            new Profile(passedUser).Visible = true;
        }
        private void CustomerQuickAccess_Click_1(object sender, EventArgs e)
        {
            new CustomerFrame(passedUser).Visible = true;
        }
        private void ProductQuickAccess_Click_1(object sender, EventArgs e)
        {
            new ProductFrameForSalesPerson().Visible = true;
        }
        private void PurchaseQuickAccess_Click_1(object sender, EventArgs e)
        {
            new PurchaseFrameForSalesPerson(passedUser).Visible = true;
        }
        private void AboutQuickAccess_Click_1(object sender, EventArgs e)
        {
            new About().Visible = true;
        }
        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            //Registering sign-out
            new Audit(passedUser, "Logged Out").InsertAuditRecord();
            Application.Exit();
        }
        private void CustomerQuickAccess_Click(object sender, EventArgs e)
        {
            new CustomerFrame(passedUser).Visible = true;
        }
        private void purchaseQuickAccess_Click(object sender, EventArgs e)
        {
            new PurchaseFrameForSalesPerson(passedUser).Visible = true;
        }
    }
}
