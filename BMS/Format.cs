using System;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class Format : Form
    {
        public Format()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormatBtn_Click(object sender, EventArgs e)
        {
            string passwd = passwdF.Text;
            if (passwd.Equals(""))
            {
                passFieldErr.Text = "password required to continue!!";
                passFieldErr.Visible = true;
            } else
            {
                string hashPasswd = new User().HashPassword(passwd);
                if (new User().GetSuperAdmin().Password.Equals(hashPasswd))
                {
                    passFieldErr.Visible = false;
                    DialogResult confirmResult = MessageBox.Show("Are You Sure ?? Once Formatted It Can't Be Undone!!",
                                     "Confirm Format!!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        new Database().DropTabels();
                        new Database().CreateTabels();
                        Visible = false;
                        MessageBox.Show("Format Done!");
                        Application.Exit();
                    }
                }
                else
                {
                    passFieldErr.Text = "Incorrect password!!";
                    passFieldErr.Visible = true;
                }
            }
                
;           
        }
    }
}
