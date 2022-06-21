namespace Boutique_Management_System
{
    partial class ProductFrameForSalesPerson
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.searchByBrandF = new System.Windows.Forms.TextBox();
            this.searchByProNoF = new System.Windows.Forms.TextBox();
            this.searchByBrand = new System.Windows.Forms.Label();
            this.searchByProNoL = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.header = new System.Windows.Forms.Label();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(718, 21);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(53, 38);
            this.closeBtn.TabIndex = 31;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // searchByBrandF
            // 
            this.searchByBrandF.Location = new System.Drawing.Point(435, 157);
            this.searchByBrandF.Name = "searchByBrandF";
            this.searchByBrandF.Size = new System.Drawing.Size(167, 22);
            this.searchByBrandF.TabIndex = 30;
            this.searchByBrandF.TextChanged += new System.EventHandler(this.SearchByBrandF_TextChanged);
            // 
            // searchByProNoF
            // 
            this.searchByProNoF.Location = new System.Drawing.Point(435, 111);
            this.searchByProNoF.Name = "searchByProNoF";
            this.searchByProNoF.Size = new System.Drawing.Size(134, 22);
            this.searchByProNoF.TabIndex = 29;
            this.searchByProNoF.TextChanged += new System.EventHandler(this.SearchByProNoF_TextChanged);
            // 
            // searchByBrand
            // 
            this.searchByBrand.AutoSize = true;
            this.searchByBrand.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByBrand.Location = new System.Drawing.Point(88, 142);
            this.searchByBrand.Name = "searchByBrand";
            this.searchByBrand.Size = new System.Drawing.Size(306, 46);
            this.searchByBrand.TabIndex = 28;
            this.searchByBrand.Text = "Search By Brand";
            // 
            // searchByProNoL
            // 
            this.searchByProNoL.AutoSize = true;
            this.searchByProNoL.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByProNoL.Location = new System.Drawing.Point(88, 96);
            this.searchByProNoL.Name = "searchByProNoL";
            this.searchByProNoL.Size = new System.Drawing.Size(299, 46);
            this.searchByProNoL.TabIndex = 27;
            this.searchByProNoL.Text = "Search By ProNo";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(242, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(258, 75);
            this.title.TabIndex = 26;
            this.title.Text = "Products";
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.table);
            this.tablePanel.Controls.Add(this.header);
            this.tablePanel.Location = new System.Drawing.Point(1, 201);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(804, 246);
            this.tablePanel.TabIndex = 32;
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
            this.table.Size = new System.Drawing.Size(802, 179);
            this.table.TabIndex = 1;
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
            // ProductFrameForSalesPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.searchByBrandF);
            this.Controls.Add(this.searchByProNoF);
            this.Controls.Add(this.searchByBrand);
            this.Controls.Add(this.searchByProNoL);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductFrameForSalesPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductFrameForSalesPerson";
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox searchByBrandF;
        private System.Windows.Forms.TextBox searchByProNoF;
        private System.Windows.Forms.Label searchByBrand;
        private System.Windows.Forms.Label searchByProNoL;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label header;
    }
}