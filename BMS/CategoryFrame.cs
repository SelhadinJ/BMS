using System;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class CategoryFrame : Form
    {
        Category selectedCategory;
        public CategoryFrame()
        {
            InitializeComponent();
            new Category().ViewCategory(table);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            string desc = descriptionF.Text;
            if (catNoF.Text.Equals("") || desc.Equals(""))
            {
                MessageBox.Show("CategoryNo And Description Fields Are Required!");
            }
            else
            {
                bool success = Int32.TryParse(catNoF.Text, out int catNo);
                if (success)
                {
                    Category category = new Category(catNo, desc);
                    if (category.CheckCategory()) MessageBox.Show("Same Category Already Exists!");
                    else
                    {
                        if (category.CheckCategoryNo()) MessageBox.Show("CategoryNo Already Exists!");
                        else if (category.CheckDescription()) MessageBox.Show("Description Already Exists!");
                        else
                        {
                            if (category.AddCategory())
                            {
                                MessageBox.Show("New Category Created Successfully!");
                                new Category().ViewCategory(table);
                            }
                        }
                    }
                } else MessageBox.Show("CategoryNo Should Be An Integer Number!");
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (selectedCategory != null)
            {
                string description = descriptionF.Text;
                if (catNoF.Text.Equals("") || description.Equals(""))
                    MessageBox.Show("Both Fields Are Required For Category To Be Updated!!");
                else
                {
                    bool success = Int32.TryParse(catNoF.Text, out int catNo);
                    if (success)
                    {
                        if (catNo == selectedCategory.CatNo && description.Equals(selectedCategory.Description))
                            MessageBox.Show("There Is Nothing To Be Updated!");
                        else if (catNo == selectedCategory.CatNo)
                        {
                            bool found = new Category().CheckDescription(description);
                            if (!found)
                            {
                                selectedCategory.UpdateDescription(description);
                                MessageBox.Show(selectedCategory.Description + "'s Category Description Updated Successfully!");
                            } else MessageBox.Show("Description Already Exists!");
                        }
                        else
                        {
                            if (new Category().CheckCategoryNo(catNo)) MessageBox.Show("CategoryNo Already Exists!");
                            else if (new Category().CheckDescription(description)) MessageBox.Show("Description Already Exists!");
                            else 
                            {
                                selectedCategory.UpdateCategoryNo(catNo);
                                selectedCategory.UpdateDescription(description);
                                MessageBox.Show(selectedCategory.Description + "'s Category Updated Successfully!");
                            }
                        }
                    }
                    else MessageBox.Show("CategoryNo Should Be An Integer Number!");
                    new Category().ViewCategory(table);
                }
            }
            else MessageBox.Show("You Haven't Selected Any Category Yet!");
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            catNoF.Text = ""; descriptionF.Text = ""; selectedCategory = null;
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedCategory != null)
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (selectedCategory.RemoveCategory()) {
                        MessageBox.Show(selectedCategory.Description + "'s Category Have Been Deleted Successfully!");
                        catNoF.Text = ""; descriptionF.Text = ""; selectedCategory = null;
                        new Category().ViewCategory(table);
                    }
                }
            }
            else MessageBox.Show("You Haven't Selected Any Category Yet!");
        }
        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                int categoryNo = (Int32)table[0, selectedRow].Value;
                catNoF.Text = table[0, selectedRow].Value.ToString();
                descriptionF.Text = table[1, selectedRow].Value.ToString();
                //This line gets the category in the selected row as an object
                selectedCategory = new Category().GetCategory(categoryNo);
            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
