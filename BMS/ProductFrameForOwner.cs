using System;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class ProductFrameForOwner : Form
    {
        Product selectedProduct;
        int selectedRow;
        bool proNoField, brandField;
        public ProductFrameForOwner()
        {
            InitializeComponent();
            new Product().PopulateCategory(categoryC);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            string proDesc = descriptionF.Text;
            string brand = brandF.Text;
            string unitPriceString = unitPriceF.Text;
            string qtyString = quantityF.Text;
            if (proDesc.Equals("") || brand.Equals("") ||
                unitPriceString.Equals("") || qtyString.Equals("") || categoryC.SelectedIndex == -1) 
                MessageBox.Show("Please fill the required fields (*).");
            else
            {
                string catDesc = (string)categoryC.SelectedItem;
                if (new Product().IsUnitPriceValid(unitPriceString))
                {
                    if (new Product().IsQtyValid(qtyString))
                    {
                        int unitPrice = Int32.Parse(unitPriceString);
                        if (unitPrice > 0)
                        {
                            int quantity = Int32.Parse(qtyString);
                            if (quantity > 0)
                            {
                                Category category = new Category().GetCategory(catDesc);
                                Product newProduct = new Product(proDesc, brand, unitPrice, quantity, category);
                                if (newProduct.CheckProduct())
                                {
                                    DialogResult confirmResult = MessageBox.Show("Product Already Exists! " +
                                        "Do You Want To Add It To Your Current Inventory?",
                                     "Confirm Delete!!", MessageBoxButtons.YesNo);
                                    if (confirmResult == DialogResult.Yes)
                                    {
                                        Product product = new Product().GetProduct(proDesc, brand);
                                        int sumQty = quantity + product.Quantity;
                                        new Product().UpdateQty(product.ProNo, sumQty);
                                        MessageBox.Show("You Have Successfully Updated The Inventory!");
                                        new Product().Clear(descriptionF, brandF, unitPriceF, quantityF, categoryC);
                                        selectedProduct = null;
                                    }
                                } else
                                {
                                    newProduct.AddProduct();
                                    MessageBox.Show("New Product Added Successfully!");
                                    new Product().Clear(descriptionF, brandF, unitPriceF, quantityF, categoryC);
                                    selectedProduct = null;
                                    string proNo = searchByProNoF.Text;
                                    if (proNo.Equals("")) tablePanel.Visible = false;
                                    else if (new Product().SearchByProNo(proNo, table)) tablePanel.Visible = true;
                                    else tablePanel.Visible = false;
                                    string brandTxt = searchByBrandF.Text;
                                    if (brandTxt.Equals("")) tablePanel.Visible = false;
                                    else if (new Product().SearchByBrand(brandTxt, table)) tablePanel.Visible = true;
                                    else tablePanel.Visible = false;
                                }
                            } else MessageBox.Show("Quantity Should Be > 0");
                        } else MessageBox.Show("Unit Price Should Be > 0!");
                    } else MessageBox.Show("Invalid Quantity!");
                } else MessageBox.Show("Invalid Unit Price!");
            }
        }
        private void SearchByProNoF_TextChanged(object sender, EventArgs e)
        {
            proNoField = new Product().SearchByProNo(searchByProNoF, table, tablePanel);
        }
        private void SearchByBrandF_TextChanged(object sender, EventArgs e)
        {
            brandField = new Product().SearchByBrand(searchByBrandF, table, tablePanel);
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                string proDesc = descriptionF.Text;
                string brand = brandF.Text;
                string unitPriceString = unitPriceF.Text;
                string qtyString = quantityF.Text;
                string catDesc = (string)categoryC.SelectedItem;
                if (proDesc.Equals("") || brand.Equals("") ||
                    unitPriceString.Equals("") || qtyString.Equals("") || categoryC.SelectedIndex == -1)
                    MessageBox.Show("Please fill the required fields (*).");
                else
                {
                    if (proDesc == selectedProduct.Description &&
                        brand.Equals(selectedProduct.Brand) &&
                        unitPriceString.Equals(selectedProduct.UnitPrice.ToString()) && 
                        qtyString.Equals(selectedProduct.Quantity.ToString()) &&
                        catDesc.Equals(selectedProduct.Category.Description)) 
                        MessageBox.Show("There Is Nothing To Be Updated!");
                    else
                    {
                        if (new Product().IsUnitPriceValid(unitPriceString))
                        {
                            if (new Product().IsQtyValid(qtyString))
                            {
                                int unitPrice = Int32.Parse(unitPriceString);
                                if (unitPrice > 0)
                                {
                                    int quantity = Int32.Parse(qtyString);
                                    if (quantity > 0)
                                    {
                                        Category category = new Category().GetCategory(catDesc);
                                        Product updatedProduct = new Product(selectedProduct.ProNo, proDesc, brand, unitPrice, quantity, category);
                                        updatedProduct.Update();
                                        MessageBox.Show("Product Updated Successfully!");
                                        new Product().Clear(descriptionF, brandF, unitPriceF, quantityF, categoryC);
                                        selectedProduct = null;
                                        if (proNoField == true || brandField == true)
                                        {
                                            if (brandField == true && proNoField == false)
                                                new Product().SearchByBrand(searchByBrandF, table, tablePanel);
                                            else new Product().SearchByProNo(searchByProNoF, table, tablePanel);
                                             
                                        }
                                    }
                                    else MessageBox.Show("Quantity Should Be > 0");
                                }
                                else MessageBox.Show("Unit Price Should Be > 0!");
                            }
                            else MessageBox.Show("Invalid Quantity!");
                        }
                        else MessageBox.Show("Invalid Unit Price!");
                    }
                }
            }
            else MessageBox.Show("You Haven't Selected Any Category Yet!");
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            new Product().Clear(descriptionF, brandF, unitPriceF, quantityF, categoryC);
            selectedProduct = null;
        }
        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                int proNo = (Int32)table[0, selectedRow].Value;
                descriptionF.Text = table[1, selectedRow].Value.ToString();
                brandF.Text = table[2, selectedRow].Value.ToString();
                unitPriceF.Text = table[3, selectedRow].Value.ToString();
                quantityF.Text = table[4, selectedRow].Value.ToString();
                int catNo = (Int32)table[5, selectedRow].Value;
                categoryC.SelectedItem = new Category().GetCatDescription(catNo);
                //This line gets the product in the selected row as an object
                selectedProduct = new Product().GetProduct(proNo);
            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this Product ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (selectedProduct.DeleteProduct())
                    {
                        MessageBox.Show(selectedProduct.Description + "'s Product Have Been Deleted Successfully!");
                        new Product().Clear(descriptionF, brandF, unitPriceF, quantityF, categoryC);
                        selectedProduct = null;
                        if (proNoField == true || brandField == true)
                        {
                            if (brandField == true && proNoField == false)
                                new Product().SearchByBrand(searchByBrandF, table, tablePanel);
                            else new Product().SearchByProNo(searchByProNoF, table, tablePanel);
                        }
                    }
                }
            }
            else MessageBox.Show("You Haven't Selected Any Category Yet!");
        }
    }
}
