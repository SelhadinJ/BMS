namespace Boutique_Management_System
{
    partial class PurchaseFrameForSalesPerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.close = new System.Windows.Forms.Button();
            this.addPurchase = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.quantityF = new System.Windows.Forms.TextBox();
            this.productNoF = new System.Windows.Forms.TextBox();
            this.customerIdF = new System.Windows.Forms.TextBox();
            this.quantityL = new System.Windows.Forms.Label();
            this.ProductNoL = new System.Windows.Forms.Label();
            this.ClientIdL = new System.Windows.Forms.Label();
            this.searchByBrandF = new System.Windows.Forms.TextBox();
            this.searchByBrand = new System.Windows.Forms.Label();
            this.searchByNameF = new System.Windows.Forms.TextBox();
            this.searchByNameL = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.header = new System.Windows.Forms.Label();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.close.FlatAppearance.BorderSize = 5;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Bradley Hand ITC", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(758, 252);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(153, 53);
            this.close.TabIndex = 66;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            // 
            // addPurchase
            // 
            this.addPurchase.BackColor = System.Drawing.Color.Blue;
            this.addPurchase.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addPurchase.FlatAppearance.BorderSize = 5;
            this.addPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPurchase.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPurchase.Location = new System.Drawing.Point(599, 187);
            this.addPurchase.Name = "addPurchase";
            this.addPurchase.Size = new System.Drawing.Size(312, 59);
            this.addPurchase.TabIndex = 65;
            this.addPurchase.Text = "Add Purchase";
            this.addPurchase.UseVisualStyleBackColor = false;
            this.addPurchase.Click += new System.EventHandler(this.AddPurchase_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearBtn.FlatAppearance.BorderSize = 5;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(599, 252);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(153, 53);
            this.clearBtn.TabIndex = 64;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // quantityF
            // 
            this.quantityF.Location = new System.Drawing.Point(445, 284);
            this.quantityF.Name = "quantityF";
            this.quantityF.Size = new System.Drawing.Size(123, 22);
            this.quantityF.TabIndex = 63;
            // 
            // productNoF
            // 
            this.productNoF.Location = new System.Drawing.Point(445, 243);
            this.productNoF.Name = "productNoF";
            this.productNoF.Size = new System.Drawing.Size(123, 22);
            this.productNoF.TabIndex = 62;
            // 
            // customerIdF
            // 
            this.customerIdF.Location = new System.Drawing.Point(445, 206);
            this.customerIdF.Name = "customerIdF";
            this.customerIdF.Size = new System.Drawing.Size(123, 22);
            this.customerIdF.TabIndex = 61;
            // 
            // quantityL
            // 
            this.quantityL.AutoSize = true;
            this.quantityL.Font = new System.Drawing.Font("Bradley Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityL.Location = new System.Drawing.Point(229, 275);
            this.quantityL.Name = "quantityL";
            this.quantityL.Size = new System.Drawing.Size(171, 37);
            this.quantityL.TabIndex = 60;
            this.quantityL.Text = "Quantity *";
            // 
            // ProductNoL
            // 
            this.ProductNoL.AutoSize = true;
            this.ProductNoL.Font = new System.Drawing.Font("Bradley Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNoL.Location = new System.Drawing.Point(229, 234);
            this.ProductNoL.Name = "ProductNoL";
            this.ProductNoL.Size = new System.Drawing.Size(190, 37);
            this.ProductNoL.TabIndex = 59;
            this.ProductNoL.Text = "Product No *";
            // 
            // ClientIdL
            // 
            this.ClientIdL.AutoSize = true;
            this.ClientIdL.Font = new System.Drawing.Font("Bradley Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientIdL.Location = new System.Drawing.Point(229, 197);
            this.ClientIdL.Name = "ClientIdL";
            this.ClientIdL.Size = new System.Drawing.Size(207, 37);
            this.ClientIdL.TabIndex = 58;
            this.ClientIdL.Text = "Customer ID *";
            // 
            // searchByBrandF
            // 
            this.searchByBrandF.Location = new System.Drawing.Point(650, 145);
            this.searchByBrandF.Name = "searchByBrandF";
            this.searchByBrandF.Size = new System.Drawing.Size(213, 22);
            this.searchByBrandF.TabIndex = 57;
            this.searchByBrandF.TextChanged += new System.EventHandler(this.SearchByBrandF_TextChanged);
            // 
            // searchByBrand
            // 
            this.searchByBrand.AutoSize = true;
            this.searchByBrand.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByBrand.Location = new System.Drawing.Point(150, 130);
            this.searchByBrand.Name = "searchByBrand";
            this.searchByBrand.Size = new System.Drawing.Size(441, 46);
            this.searchByBrand.TabIndex = 56;
            this.searchByBrand.Text = "Search Product By Brand";
            // 
            // searchByNameF
            // 
            this.searchByNameF.Location = new System.Drawing.Point(632, 99);
            this.searchByNameF.Name = "searchByNameF";
            this.searchByNameF.Size = new System.Drawing.Size(213, 22);
            this.searchByNameF.TabIndex = 55;
            this.searchByNameF.TextChanged += new System.EventHandler(this.SearchByNameF_TextChanged);
            // 
            // searchByNameL
            // 
            this.searchByNameL.AutoSize = true;
            this.searchByNameL.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByNameL.Location = new System.Drawing.Point(150, 84);
            this.searchByNameL.Name = "searchByNameL";
            this.searchByNameL.Size = new System.Drawing.Size(461, 46);
            this.searchByNameL.TabIndex = 54;
            this.searchByNameL.Text = "Search Customer By Name";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(379, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(290, 75);
            this.title.TabIndex = 50;
            this.title.Text = "Purchases";
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(1021, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(53, 38);
            this.closeBtn.TabIndex = 48;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.table);
            this.tablePanel.Controls.Add(this.header);
            this.tablePanel.Location = new System.Drawing.Point(3, 315);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(1107, 282);
            this.tablePanel.TabIndex = 67;
            this.tablePanel.Visible = false;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.BackgroundColor = System.Drawing.Color.White;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.table.GridColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(3, 64);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(1104, 215);
            this.table.TabIndex = 3;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Bradley Hand ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(422, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(313, 59);
            this.header.TabIndex = 0;
            this.header.Text = "Results Detail";
            // 
            // PurchaseFrameForSalesPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 609);
            this.ControlBox = false;
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.close);
            this.Controls.Add(this.addPurchase);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.quantityF);
            this.Controls.Add(this.productNoF);
            this.Controls.Add(this.customerIdF);
            this.Controls.Add(this.quantityL);
            this.Controls.Add(this.ProductNoL);
            this.Controls.Add(this.ClientIdL);
            this.Controls.Add(this.searchByBrandF);
            this.Controls.Add(this.searchByBrand);
            this.Controls.Add(this.searchByNameF);
            this.Controls.Add(this.searchByNameL);
            this.Controls.Add(this.title);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseFrameForSalesPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseFrameForSalesPerson";
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button addPurchase;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox quantityF;
        private System.Windows.Forms.TextBox productNoF;
        private System.Windows.Forms.TextBox customerIdF;
        private System.Windows.Forms.Label quantityL;
        private System.Windows.Forms.Label ProductNoL;
        private System.Windows.Forms.Label ClientIdL;
        private System.Windows.Forms.TextBox searchByBrandF;
        private System.Windows.Forms.Label searchByBrand;
        private System.Windows.Forms.TextBox searchByNameF;
        private System.Windows.Forms.Label searchByNameL;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label header;
    }
}