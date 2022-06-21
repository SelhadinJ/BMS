using System;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class PurchaseFrameForSalesPerson : Form
    {
        User passedUser;
        public PurchaseFrameForSalesPerson(object passedUser)
        {
            InitializeComponent();
            this.passedUser = (User) passedUser;
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SearchByNameF_TextChanged(object sender, EventArgs e)
        {
            if (new Customer().SearchByName(searchByNameF, table, tablePanel))
                tablePanel.Visible = true;
            else tablePanel.Visible = false;
        }
        private void SearchByBrandF_TextChanged(object sender, EventArgs e)
        {
            if (new Product().SearchByBrand(searchByBrandF, table, tablePanel))
                tablePanel.Visible = true;
            else tablePanel.Visible = false;
        }
        private void AddPurchase_Click(object sender, EventArgs e)
        {
            string customerIdString = customerIdF.Text;
            string proNoString = productNoF.Text;
            string qtyString = quantityF.Text;
            if (customerIdString.Equals("") || proNoString.Equals("") || qtyString.Equals(""))
                MessageBox.Show("Please fill the required fields to add a purchase (*).");
            else
            {
                if (new Customer().IsCustomerIdValid(customerIdString))
                {
                    if (new Product().IsProNoValid(proNoString))
                    {
                        if (new Product().IsQtyValid(qtyString))
                        {
                            int customerId = Int32.Parse(customerIdString);
                            if (new Customer().CheckCustomerId(customerId))
                            {
                                int proNo = Int32.Parse(proNoString);
                                if (new Product().CheckProductNo(proNo))
                                {
                                    Product newProduct = new Product().GetProduct(proNo);
                                    int databaseQty = newProduct.Quantity;
                                    int toBeSoldQty = Int32.Parse(qtyString);
                                    Purchase newPurchase;
                                    DialogResult confirmResult;
                                    if (databaseQty != 0)
                                    {
                                        Customer customer = new Customer().GetCustomer(customerId);
                                        if (databaseQty >= toBeSoldQty)
                                        {
                                            newPurchase = new Purchase(customer, newProduct, toBeSoldQty, passedUser);
                                            confirmResult = MessageBox.Show(
                                                "\t\tPurchase To Be Done ..." +
                                                "\nProduct - " + newProduct.Description +
                                                "\nCustomer - " + customer.FirstName + " " + customer.LastName +
                                                "\nTotal Amount - " + newPurchase.TotalPrice +
                                                "\nSold By - " + passedUser.FirstName + " " + passedUser.LastName,
                                            "Confirmation Message!!", MessageBoxButtons.YesNoCancel);
                                        }
                                        else
                                        {
                                            newPurchase = new Purchase(customer, newProduct, databaseQty, passedUser);
                                            confirmResult = MessageBox.Show(
                                                "Remaining Quantity Of Product " + newProduct.Description + " is Only " + databaseQty
                                                            + "\n Do You Want to Sale All Of It?",
                                            "Insufficient Quantity!!", MessageBoxButtons.YesNoCancel);
                                            if (confirmResult == DialogResult.Yes)
                                            {
                                                confirmResult = MessageBox.Show(
                                                "\t\tPurchase To Be Done ..." +
                                                "\nProduct - " + newProduct.Description +
                                                "\nCustomer - " + customer.FirstName + " " + customer.LastName +
                                                "\nSold By - " + passedUser.FirstName + " " + passedUser.LastName,
                                            "Confirmation Message!!", MessageBoxButtons.YesNoCancel);
                                            }

                                        }
                                        if (confirmResult == DialogResult.Yes)
                                        {
                                            if (newPurchase.AddPurchase())
                                                MessageBox.Show("Purchase Done!");
                                        }
                                    }
                                    else MessageBox.Show("Sorry, This Product Is Sold Out!");
                                }
                                else MessageBox.Show("Sorry, Product Doesn't Exist!");
                            }
                            else MessageBox.Show("Sorry, Customer Doesn't Exist!");
                        }
                        else MessageBox.Show("Invalid Quantity!");
                    }
                    else MessageBox.Show("Invalid ProNo!");
                }
                else MessageBox.Show("Invalid CustomerId!");
            }
        }
    }
}
