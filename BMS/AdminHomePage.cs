using System;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class AdminHomePage : Form
    {
        User passedUser;
        public AdminHomePage(Object passedUser)
        {
            InitializeComponent();
            this.passedUser = (User) passedUser;
            loggedInAs.Text = this.passedUser.UserType;
            if (this.passedUser.UserType.Equals("Super Admin"))
                other.DropDownItems.Add("Format App").Click += new System.EventHandler(this.FormatApp_Click); ;
        }
        private void CustomerQuickAccess_Click(object sender, EventArgs e)
        {
            new CustomerFrame(passedUser).Visible = true;
        }
        private void FormatApp_Click(object sender, EventArgs e)
        {
            new Format().Visible = true;
        }
        private void ProductQuickAccess_Click(object sender, EventArgs e)
        {
            new ProductFrameForOwner().Visible = true;
        }
        private void UserQuickAccess_Click(object sender, EventArgs e)
        {
            new UserFrame(passedUser).Visible = true;
        }
        private void PurchaseQuickAccess_Click(object sender, EventArgs e)
        {
            new PurchaseFrameForOwner(passedUser).Visible = true;
        }
        private void AuditQuickAccess_Click(object sender, EventArgs e)
        {
            new AuditFrame().Visible = true;
        }
        private void Profile_Click(object sender, EventArgs e)
        {
            new Profile(passedUser).Visible = true;
        }
        private void SignOut_Click(object sender, EventArgs e)
        {
            if (new User().SingleUser())
                new FirstLogin(new User().GetSuperAdmin()).Visible = true;
            else 
            {
                //Registering sign-out
                if (!this.passedUser.UserType.Equals("Super Admin"))
                    new Audit(passedUser, "Logged Out").InsertAuditRecord();
                new NotFirstLogin().Visible = true;
            }
            Visible = false;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            //Registering sign-out
            if (!this.passedUser.UserType.Equals("Super Admin"))
                new Audit(passedUser, "Logged Out").InsertAuditRecord();
            Application.Exit();
        }
        private void AddCustomer_Click(object sender, EventArgs e)
        {
            new CustomerFrame(passedUser).Visible = true;
        }
        private void AddUser_Click(object sender, EventArgs e)
        {
            new UserFrame(passedUser).Visible = true;
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {
            new ProductFrameForOwner().Visible = true;
        }
        private void AddCategory_Click(object sender, EventArgs e)
        {
            new CategoryFrame().Visible = true;
        }
        private void EditCustomer_Click(object sender, EventArgs e)
        {
            new CustomerFrame(passedUser).Visible = true;
        }
        private void EditUser_Click(object sender, EventArgs e)
        {
            new UserFrame(passedUser).Visible = true;
        }
        private void EditProduct_Click(object sender, EventArgs e)
        {
            new ProductFrameForOwner().Visible = true;
        }
        private void EditCategory_Click(object sender, EventArgs e)
        {
            new CategoryFrame().Visible = true;
        }
        private void Audit_Click(object sender, EventArgs e)
        {
            new AuditFrame().Visible = true;
        }
        private void About_Click(object sender, EventArgs e)
        {
            new About().Visible = true;
        }
        private void ChangePassword_Click(object sender, EventArgs e)
        {
            new ChangePassword(passedUser).Visible = true;
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            //Registering sign-out
            if (!this.passedUser.UserType.Equals("Super Admin"))
                new Audit(passedUser, "Logged Out").InsertAuditRecord();
            Application.Exit();
        }
        private void CategoriesQuickAccess_Click(object sender, EventArgs e)
        {
            new CategoryFrame().Visible = true;
        }
    }
}