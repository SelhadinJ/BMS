using System;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class CustomerFrame : Form
    {
        User passedUser;
        Customer selectedCustomer;
        int selectedRow;
        bool nameField;

        public CustomerFrame(object passedUser)
        {
            InitializeComponent();
            this.passedUser = (User) passedUser;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameF.Text;
            string lastName = lastNameF.Text;
            string phoneNo = phoneNoF.Text;
            string gender = (female.Checked) ? "F" : "M";
            string address = addressF.Text;
            if (firstName.Equals("") || phoneNo.Equals("") || address.Equals(""))
                MessageBox.Show("Please fill the required fields (*).");
            else
            {
                if (new Customer().IsPhoneValid(phoneNo))
                {
                    Customer newCustomer = new Customer(firstName, lastName, phoneNo, gender, address, passedUser);
                    if (newCustomer.CheckCustomer()) MessageBox.Show("Sorry, This Customer Already Exists In Database!");
                    else
                    {
                        if (newCustomer.RegisterCustomer())
                        {
                            MessageBox.Show("Customer Registered Successfully!");
                            new Customer().Clear(firstNameF, lastNameF, phoneNoF, addressF, male, female);
                            selectedCustomer = null;
                            string name = searchByNameF.Text;
                            if (name.Equals("")) tablePanel.Visible = false;
                            else if (new Customer().SearchByName(name, table)) tablePanel.Visible = true;
                            else tablePanel.Visible = false;
                        }
                        else MessageBox.Show("Something Is Wrong, Try Again!");
                    }
                }
                else MessageBox.Show("PhoneNo Can Only Contain Numbers!");
                
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            new Customer().Clear(firstNameF, lastNameF, phoneNoF, addressF, male, female);
            selectedCustomer = null;
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedCustomer != null)
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this Customer ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (selectedCustomer.DeleteCustomer())
                    {
                        MessageBox.Show(selectedCustomer.FirstName + " Have Been Deleted Successfully!");
                        new Customer().Clear(firstNameF, lastNameF, phoneNoF, addressF, male, female);
                        selectedCustomer = null;
                        if (nameField == true) new Customer().SearchByName(searchByNameF, table, tablePanel);
                        new Customer().Clear(firstNameF, lastNameF, phoneNoF, addressF, male, female);
                        selectedCustomer = null;
                    }
                }
            }
            else MessageBox.Show("You Haven't Selected Any Customer Yet!");
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (selectedCustomer != null)
            {
                string firstName = firstNameF.Text;
                string lastName = lastNameF.Text;
                string phoneNo = phoneNoF.Text;
                string gender = (female.Checked) ? "F" : "M";
                string address = addressF.Text;
                if (firstName.Equals("") || phoneNo.Equals("") || address.Equals(""))
                    MessageBox.Show("Please fill the required fields (*).");
                else if (
                    selectedCustomer.FirstName.Equals(firstName) &&
                    selectedCustomer.LastName.Equals(lastName) &&
                    selectedCustomer.PhoneNo.Equals(phoneNo) &&
                    selectedCustomer.Gender.Equals(gender) &&
                    selectedCustomer.Address.Equals(address))
                    MessageBox.Show("Nothing Have Been Updated!");
                else 
                {
                    if (new Customer().IsPhoneValid(phoneNo))
                    {
                        selectedCustomer.Update(firstName, lastName, phoneNo, gender, address);
                        MessageBox.Show("Customer's Information Have Been Successfully Updated!");
                        if (nameField == true) new Customer().SearchByName(searchByNameF, table, tablePanel);
                        new Customer().Clear(firstNameF, lastNameF, phoneNoF, addressF, male, female);
                        selectedCustomer = null;
                    } else MessageBox.Show("PhoneNo Can Only Contain Numbers!");
                }
            }
            else MessageBox.Show("You Haven't Selected Any Category Yet!");
        }
        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                int customerId = (int) table[0, selectedRow].Value;
                firstNameF.Text = table[1, selectedRow].Value.ToString();
                lastNameF.Text = table[2, selectedRow].Value.ToString();
                phoneNoF.Text = table[3, selectedRow].Value.ToString();
                string gender = table[4, selectedRow].Value.ToString();
                if (gender.Equals("M"))
                    male.Checked = true;
                else female.Checked = true;
                addressF.Text = table[5, selectedRow].Value.ToString();

                //This line gets the product in the selected row as an object
                selectedCustomer = new Customer().GetCustomer(customerId);
            }
        }
        private void SearchByNameF_TextChanged(object sender, EventArgs e)
        {
            nameField = new Customer().SearchByName(searchByNameF, table, tablePanel);
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}