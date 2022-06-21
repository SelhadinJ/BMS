using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    public partial class ProductFrameForSalesPerson : Form
    {
        public ProductFrameForSalesPerson()
        {
            InitializeComponent();
        }

        private void SearchByProNoF_TextChanged(object sender, EventArgs e)
        {
            if (new Product().SearchByProNo(searchByProNoF, table, tablePanel))
                tablePanel.Visible = true;
            else tablePanel.Visible = false;
        }

        private void SearchByBrandF_TextChanged(object sender, EventArgs e)
        {
            if (new Product().SearchByBrand(searchByBrandF, table, tablePanel))
                tablePanel.Visible = true;
            else tablePanel.Visible = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
