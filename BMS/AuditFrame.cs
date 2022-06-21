using System;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class AuditFrame : Form
    {
        string userIdString;
        string range;
        DateTime from, to;
        
        public AuditFrame()
        {
            InitializeComponent();
            rangeC.SelectedIndex = 0;
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            userIdF.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            if (userIdF.Text.Equals(""))
                MessageBox.Show("Please Enter User ID You Want To Reset");
            else
            {
                if (new User().IsUserIdValid(userIdF.Text))
                {
                    int userId = Int32.Parse(userIdF.Text);
                    if (new User().CheckUserId(userId))
                    {
                        DialogResult confirmResult = MessageBox.Show("Are You Sure You Want To Reset Audit Records Of " + new User().GetUser(userId).FirstName + "",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {
                            int recordsCount = new Audit().ResetAuditRecord(userId);
                            if (recordsCount > 0) MessageBox.Show(recordsCount + " Records Have Been Deleted!");
                            else
                            {
                                tablePanel.Visible = false;
                                MessageBox.Show("User's History Doesn't Exist In Audit Table!");
                            }
                        }
                        
                    } else
                    {
                        tablePanel.Visible = false ;
                        MessageBox.Show("User Doesn't Exist!");
                    }
                }
                else MessageBox.Show("UserId Invalid!");
            }
        }
        private void UserIdF_TextChanged(object sender, EventArgs e)
        {
            userIdString = userIdF.Text;
            to = DateTime.Now;
            if (userIdString.Equals("")) tablePanel.Visible = false;
            else if (new User().IsUserIdValid(userIdString))
            {
                int userId = Int32.Parse(userIdString);
                if (new Audit().GetAuditOf(userId, from, to, table))
                    tablePanel.Visible = true;
                else tablePanel.Visible = false;
            }
            else tablePanel.Visible = false;
        }
        private void RangeC_SelectedIndexChanged(object sender, EventArgs e)
        {
            userIdString = userIdF.Text;
            range = rangeC.SelectedItem.ToString();
            if (range.Equals("Today"))
                from = DateTime.Now.AddDays(-1);
            else if (range.Equals("Since Last Week"))
                from = DateTime.Now.AddDays(-7);
            else if (range.Equals("Since Last 2 Week"))
                from = DateTime.Now.AddDays(-14);
            else from = DateTime.Now.AddDays(-30);

            to = DateTime.Now;
            if (userIdString.Equals("")) tablePanel.Visible = false;
            else if (new User().IsUserIdValid(userIdString))
            {
                int userId = Int32.Parse(userIdString);
                if (new Audit().GetAuditOf(userId, from, to, table))
                    tablePanel.Visible = true;
                else tablePanel.Visible = false;
            }
            else tablePanel.Visible = false;
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
