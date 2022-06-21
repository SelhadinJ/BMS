using System;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class UserFrame : Form
    {
        User selectedUser;
        int selectedRow;
        bool idField, nameField;
        User passedUser;
        public UserFrame(object passed)
        {
            InitializeComponent();
            passedUser = (User) passed;
            if (passedUser.UserType.Equals("Super Admin"))
                userTypeC.Items.Add("Admin");
            userTypeC.SelectedIndex = 0;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameF.Text;
            string lastName = lastNameF.Text;
            string phoneNo = phoneNoF.Text;
            string userName = userNameF.Text;
            string passwd = passwdF.Text;
            string userType = userTypeC.SelectedItem.ToString();
            if (firstName.Equals("") || phoneNo.Equals("") || userName.Equals("") || passwd.Equals(""))
            {
                MessageBox.Show("Please fill the required fields (*).");
            }
            else
            {
                if (new User().IsPhoneValid(phoneNo))
                {
                    User newUser = new User(firstName, lastName, phoneNo, userType, userName, passwd);
                    if (newUser.CheckUserName())
                    {
                        MessageBox.Show("Sorry, User Name Already Exists In A Given Scope!",
                                "Change User Name");
                    }
                    else
                    {
                        if (newUser.CreateUser())
                        {
                            MessageBox.Show("New " + newUser.UserType + " Created Successfully!");
                            //string userId = searchByIdF.Text;
                            if (idField == true || nameField == true)
                            {
                                if (nameField == true && idField == false)
                                    new User().SearchByName(searchByNameF, passedUser.UserType, table, tablePanel);
                                else new User().SearchById(searchByIdF, passedUser.UserType, table, tablePanel);
                            }
                            new User().Clear(firstNameF, lastNameF, phoneNoF, userNameF, passwdF);
                            selectedUser = null;
                        }
                        else MessageBox.Show("Something Is Wrong, Try Again!");
                    }
                } else MessageBox.Show("PhoneNo Can Only Contain Numbers!");
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            new User().Clear(firstNameF, lastNameF, phoneNoF, userNameF, passwdF);
            selectedUser = null;
        }
        private void SearchByIdF_TextChanged(object sender, EventArgs e)
        {
            idField = new User().SearchById(searchByIdF, passedUser.UserType, table, tablePanel);
        }
        private void SearchByNameF_TextChanged_1(object sender, EventArgs e)
        {
            nameField = new User().SearchByName(searchByNameF, passedUser.UserType, table, tablePanel);
        }
        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new User().Clear(firstNameF, lastNameF, phoneNoF, userNameF, passwdF);
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                int userId = (Int32)table[0, selectedRow].Value;
                firstNameF.Text = table[1, selectedRow].Value.ToString();
                lastNameF.Text = table[2, selectedRow].Value.ToString();
                phoneNoF.Text = table[3, selectedRow].Value.ToString();
                userTypeC.Text = table[4, selectedRow].Value.ToString();
                //This line gets the user in the selected row as an object
                selectedUser = new User().GetUser(userId);
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                if (!selectedUser.UserType.Equals("Super Admin"))
                {
                    DialogResult confirmResult = MessageBox.Show("Are you sure to delete this User ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        if (selectedUser.DeleteUser())
                        {
                            MessageBox.Show(selectedUser.FirstName + " Have Been Deleted Successfully!");
                            new User().Clear(firstNameF, lastNameF, phoneNoF, userNameF, passwdF);
                            selectedUser = null;
                            if (idField == true || nameField == true)
                            {
                                if (nameField == true && idField == false)
                                    new User().SearchByName(searchByNameF, passedUser.UserType, table, tablePanel);
                                else new User().SearchById(searchByIdF, passedUser.UserType, table, tablePanel);
                            }
                        }
                    }
                } else MessageBox.Show("Can't Delete Super Admin AKA Yourself!");
            }
            else MessageBox.Show("You Haven't Selected Any User Yet!");
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }  
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                string firstName = firstNameF.Text;
                string lastName = lastNameF.Text;
                string phoneNo = phoneNoF.Text;
                string userType = (selectedUser.UserType.Equals("Super Admin")) ? "Super Admin" : userTypeC.SelectedItem.ToString();
                if (firstName.Equals("") || phoneNo.Equals(""))
                    MessageBox.Show("Please fill the required fields (*).");
                else if (
                    selectedUser.FirstName.Equals(firstName) &&
                    selectedUser.LastName.Equals(lastName) &&
                    selectedUser.PhoneNo.Equals(phoneNo) &&
                    selectedUser.UserType.Equals(userType))
                    MessageBox.Show("Nothing Have Been Updated!");
                else
                {
                    if (new User().IsPhoneValid(phoneNo))
                    {
                        selectedUser.Update(firstName, lastName, phoneNo, userType);
                        MessageBox.Show("User's Information Have Been Successfully Updated!");
                        if (idField == true || nameField == true)
                        {
                            if (nameField == true && idField == false)
                                new User().SearchByName(searchByNameF, passedUser.UserType, table, tablePanel);
                            else new User().SearchById(searchByIdF, passedUser.UserType, table, tablePanel);
                        }    
                    }
                    else MessageBox.Show("PhoneNo Can Only Contain Numbers!");
                }
            }
            else MessageBox.Show("You Haven't Selected Any User Yet!");
        }
    }
}

