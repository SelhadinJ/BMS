namespace Boutique_Management_System
{
    partial class ProductFrameForOwner
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
            this.title = new System.Windows.Forms.Label();
            this.searchByProNoL = new System.Windows.Forms.Label();
            this.searchByBrand = new System.Windows.Forms.Label();
            this.searchByProNoF = new System.Windows.Forms.TextBox();
            this.searchByBrandF = new System.Windows.Forms.TextBox();
            this.quantityL = new System.Windows.Forms.Label();
            this.unitPriceL = new System.Windows.Forms.Label();
            this.descriptionL = new System.Windows.Forms.Label();
            this.catgoryNoL = new System.Windows.Forms.Label();
            this.brandL = new System.Windows.Forms.Label();
            this.descriptionF = new System.Windows.Forms.TextBox();
            this.brandF = new System.Windows.Forms.TextBox();
            this.unitPriceF = new System.Windows.Forms.TextBox();
            this.quantityF = new System.Windows.Forms.TextBox();
            this.categoryC = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(221, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(258, 75);
            this.title.TabIndex = 1;
            this.title.Text = "Products";
            // 
            // searchByProNoL
            // 
            this.searchByProNoL.AutoSize = true;
            this.searchByProNoL.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByProNoL.Location = new System.Drawing.Point(-2, 84);
            this.searchByProNoL.Name = "searchByProNoL";
            this.searchByProNoL.Size = new System.Drawing.Size(299, 46);
            this.searchByProNoL.TabIndex = 2;
            this.searchByProNoL.Text = "Search By ProNo";
            // 
            // searchByBrand
            // 
            this.searchByBrand.AutoSize = true;
            this.searchByBrand.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByBrand.Location = new System.Drawing.Point(-2, 130);
            this.searchByBrand.Name = "searchByBrand";
            this.searchByBrand.Size = new System.Drawing.Size(306, 46);
            this.searchByBrand.TabIndex = 3;
            this.searchByBrand.Text = "Search By Brand";
            // 
            // searchByProNoF
            // 
            this.searchByProNoF.Location = new System.Drawing.Point(332, 99);
            this.searchByProNoF.Name = "searchByProNoF";
            this.searchByProNoF.Size = new System.Drawing.Size(134, 22);
            this.searchByProNoF.TabIndex = 4;
            this.searchByProNoF.TextChanged += new System.EventHandler(this.SearchByProNoF_TextChanged);
            // 
            // searchByBrandF
            // 
            this.searchByBrandF.Location = new System.Drawing.Point(345, 145);
            this.searchByBrandF.Name = "searchByBrandF";
            this.searchByBrandF.Size = new System.Drawing.Size(167, 22);
            this.searchByBrandF.TabIndex = 5;
            this.searchByBrandF.TextChanged += new System.EventHandler(this.SearchByBrandF_TextChanged);
            // 
            // quantityL
            // 
            this.quantityL.AutoSize = true;
            this.quantityL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityL.Location = new System.Drawing.Point(23, 343);
            this.quantityL.Name = "quantityL";
            this.quantityL.Size = new System.Drawing.Size(161, 35);
            this.quantityL.TabIndex = 6;
            this.quantityL.Text = "Quantity *";
            // 
            // unitPriceL
            // 
            this.unitPriceL.AutoSize = true;
            this.unitPriceL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceL.Location = new System.Drawing.Point(23, 308);
            this.unitPriceL.Name = "unitPriceL";
            this.unitPriceL.Size = new System.Drawing.Size(168, 35);
            this.unitPriceL.TabIndex = 7;
            this.unitPriceL.Text = "Unit Price *";
            // 
            // descriptionL
            // 
            this.descriptionL.AutoSize = true;
            this.descriptionL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionL.Location = new System.Drawing.Point(23, 210);
            this.descriptionL.Name = "descriptionL";
            this.descriptionL.Size = new System.Drawing.Size(180, 35);
            this.descriptionL.TabIndex = 8;
            this.descriptionL.Text = "Description *";
            // 
            // catgoryNoL
            // 
            this.catgoryNoL.AutoSize = true;
            this.catgoryNoL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catgoryNoL.Location = new System.Drawing.Point(23, 378);
            this.catgoryNoL.Name = "catgoryNoL";
            this.catgoryNoL.Size = new System.Drawing.Size(153, 35);
            this.catgoryNoL.TabIndex = 9;
            this.catgoryNoL.Text = "Category *";
            // 
            // brandL
            // 
            this.brandL.AutoSize = true;
            this.brandL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandL.Location = new System.Drawing.Point(23, 273);
            this.brandL.Name = "brandL";
            this.brandL.Size = new System.Drawing.Size(119, 35);
            this.brandL.TabIndex = 10;
            this.brandL.Text = "Brand *";
            // 
            // descriptionF
            // 
            this.descriptionF.Location = new System.Drawing.Point(209, 210);
            this.descriptionF.Multiline = true;
            this.descriptionF.Name = "descriptionF";
            this.descriptionF.Size = new System.Drawing.Size(180, 57);
            this.descriptionF.TabIndex = 11;
            // 
            // brandF
            // 
            this.brandF.Location = new System.Drawing.Point(209, 280);
            this.brandF.Name = "brandF";
            this.brandF.Size = new System.Drawing.Size(180, 22);
            this.brandF.TabIndex = 12;
            // 
            // unitPriceF
            // 
            this.unitPriceF.Location = new System.Drawing.Point(209, 315);
            this.unitPriceF.Name = "unitPriceF";
            this.unitPriceF.Size = new System.Drawing.Size(180, 22);
            this.unitPriceF.TabIndex = 13;
            // 
            // quantityF
            // 
            this.quantityF.Location = new System.Drawing.Point(209, 350);
            this.quantityF.Name = "quantityF";
            this.quantityF.Size = new System.Drawing.Size(180, 22);
            this.quantityF.TabIndex = 14;
            // 
            // categoryC
            // 
            this.categoryC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryC.FormattingEnabled = true;
            this.categoryC.Location = new System.Drawing.Point(209, 385);
            this.categoryC.Name = "categoryC";
            this.categoryC.Size = new System.Drawing.Size(180, 24);
            this.categoryC.TabIndex = 15;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Blue;
            this.addBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(428, 228);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(170, 60);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(428, 303);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(170, 64);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(613, 228);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(170, 60);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Blue;
            this.updateBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(613, 303);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(170, 64);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Bradley Hand ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(193, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(336, 59);
            this.header.TabIndex = 0;
            this.header.Text = "Products Detail";
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.table);
            this.tablePanel.Controls.Add(this.header);
            this.tablePanel.Location = new System.Drawing.Point(1, 419);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(794, 274);
            this.tablePanel.TabIndex = 22;
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
            this.table.GridColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 67);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(794, 207);
            this.table.TabIndex = 1;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(720, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(53, 38);
            this.closeBtn.TabIndex = 25;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ProductFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 692);
            this.ControlBox = false;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.categoryC);
            this.Controls.Add(this.quantityF);
            this.Controls.Add(this.unitPriceF);
            this.Controls.Add(this.brandF);
            this.Controls.Add(this.descriptionF);
            this.Controls.Add(this.brandL);
            this.Controls.Add(this.catgoryNoL);
            this.Controls.Add(this.descriptionL);
            this.Controls.Add(this.unitPriceL);
            this.Controls.Add(this.quantityL);
            this.Controls.Add(this.searchByBrandF);
            this.Controls.Add(this.searchByProNoF);
            this.Controls.Add(this.searchByBrand);
            this.Controls.Add(this.searchByProNoL);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ProductFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label searchByProNoL;
        private System.Windows.Forms.Label searchByBrand;
        private System.Windows.Forms.TextBox searchByProNoF;
        private System.Windows.Forms.TextBox searchByBrandF;
        private System.Windows.Forms.Label quantityL;
        private System.Windows.Forms.Label unitPriceL;
        private System.Windows.Forms.Label descriptionL;
        private System.Windows.Forms.Label catgoryNoL;
        private System.Windows.Forms.Label brandL;
        private System.Windows.Forms.TextBox descriptionF;
        private System.Windows.Forms.TextBox brandF;
        private System.Windows.Forms.TextBox unitPriceF;
        private System.Windows.Forms.TextBox quantityF;
        private System.Windows.Forms.ComboBox categoryC;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button closeBtn;
    }
}