namespace Boutique_Management_System
{
    partial class AdminHomePage
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.addUser = new System.Windows.Forms.ToolStripMenuItem();
            this.addProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.profile = new System.Windows.Forms.ToolStripMenuItem();
            this.signOut = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.editUser = new System.Windows.Forms.ToolStripMenuItem();
            this.editProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.editCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.other = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.audit = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.boutiqueName2 = new System.Windows.Forms.Label();
            this.boutiqueName1 = new System.Windows.Forms.Label();
            this.loggedInAs = new System.Windows.Forms.Label();
            this.loggedAsL = new System.Windows.Forms.Label();
            this.innerPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.available = new System.Windows.Forms.Label();
            this.categoriesQuickAccess = new System.Windows.Forms.Button();
            this.customerQuickAccess = new System.Windows.Forms.Button();
            this.userQuickAccess = new System.Windows.Forms.Button();
            this.productQuickAccess = new System.Windows.Forms.Button();
            this.auditQuickAccess = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.purchaseQuickAccess = new System.Windows.Forms.Button();
            this.quickAccessL = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.innerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.edit,
            this.other});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1570, 28);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.profile,
            this.signOut,
            this.exit});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(46, 24);
            this.file.Text = "File";
            // 
            // newFile
            // 
            this.newFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomer,
            this.addUser,
            this.addProduct,
            this.addCategory});
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(147, 26);
            this.newFile.Text = "New";
            // 
            // addCustomer
            // 
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(155, 26);
            this.addCustomer.Text = "Customer";
            this.addCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // addUser
            // 
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(155, 26);
            this.addUser.Text = "User";
            this.addUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // addProduct
            // 
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(155, 26);
            this.addProduct.Text = "Product";
            this.addProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // addCategory
            // 
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(155, 26);
            this.addCategory.Text = "Category";
            this.addCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // profile
            // 
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(147, 26);
            this.profile.Text = "Profile";
            this.profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // signOut
            // 
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(147, 26);
            this.signOut.Text = "Sign out";
            this.signOut.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(147, 26);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDelete});
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(49, 24);
            this.edit.Text = "Edit";
            // 
            // updateDelete
            // 
            this.updateDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCustomer,
            this.editUser,
            this.editProduct,
            this.editCategory});
            this.updateDelete.Name = "updateDelete";
            this.updateDelete.Size = new System.Drawing.Size(191, 26);
            this.updateDelete.Text = "Update/Delete";
            // 
            // editCustomer
            // 
            this.editCustomer.Name = "editCustomer";
            this.editCustomer.Size = new System.Drawing.Size(155, 26);
            this.editCustomer.Text = "Customer";
            this.editCustomer.Click += new System.EventHandler(this.EditCustomer_Click);
            // 
            // editUser
            // 
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(155, 26);
            this.editUser.Text = "User";
            this.editUser.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // editProduct
            // 
            this.editProduct.Name = "editProduct";
            this.editProduct.Size = new System.Drawing.Size(155, 26);
            this.editProduct.Text = "Product";
            this.editProduct.Click += new System.EventHandler(this.EditProduct_Click);
            // 
            // editCategory
            // 
            this.editCategory.Name = "editCategory";
            this.editCategory.Size = new System.Drawing.Size(155, 26);
            this.editCategory.Text = "Category";
            this.editCategory.Click += new System.EventHandler(this.EditCategory_Click);
            // 
            // other
            // 
            this.other.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePassword,
            this.audit,
            this.about});
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(60, 24);
            this.other.Text = "Other";
            // 
            // changePassword
            // 
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(207, 26);
            this.changePassword.Text = "Change Password";
            this.changePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // audit
            // 
            this.audit.Name = "audit";
            this.audit.Size = new System.Drawing.Size(207, 26);
            this.audit.Text = "Audit";
            this.audit.Click += new System.EventHandler(this.Audit_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(207, 26);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.About_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.closeBtn);
            this.centerPanel.Controls.Add(this.boutiqueName2);
            this.centerPanel.Controls.Add(this.boutiqueName1);
            this.centerPanel.Controls.Add(this.loggedInAs);
            this.centerPanel.Controls.Add(this.loggedAsL);
            this.centerPanel.Controls.Add(this.innerPanel);
            this.centerPanel.Location = new System.Drawing.Point(263, 26);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1307, 723);
            this.centerPanel.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Black;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(1222, 18);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(73, 65);
            this.closeBtn.TabIndex = 26;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // boutiqueName2
            // 
            this.boutiqueName2.AutoSize = true;
            this.boutiqueName2.Font = new System.Drawing.Font("Calibri Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutiqueName2.ForeColor = System.Drawing.Color.Black;
            this.boutiqueName2.Location = new System.Drawing.Point(723, 68);
            this.boutiqueName2.Name = "boutiqueName2";
            this.boutiqueName2.Size = new System.Drawing.Size(395, 45);
            this.boutiqueName2.TabIndex = 4;
            this.boutiqueName2.Text = "----------  M E N \' S  ----------";
            // 
            // boutiqueName1
            // 
            this.boutiqueName1.AutoSize = true;
            this.boutiqueName1.Font = new System.Drawing.Font("Arial Black", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutiqueName1.ForeColor = System.Drawing.Color.Black;
            this.boutiqueName1.Location = new System.Drawing.Point(657, 2);
            this.boutiqueName1.Name = "boutiqueName1";
            this.boutiqueName1.Size = new System.Drawing.Size(517, 81);
            this.boutiqueName1.TabIndex = 3;
            this.boutiqueName1.Text = "E L D O R A D O";
            // 
            // loggedInAs
            // 
            this.loggedInAs.AutoSize = true;
            this.loggedInAs.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInAs.Location = new System.Drawing.Point(242, 669);
            this.loggedInAs.Name = "loggedInAs";
            this.loggedInAs.Size = new System.Drawing.Size(0, 41);
            this.loggedInAs.TabIndex = 2;
            // 
            // loggedAsL
            // 
            this.loggedAsL.AutoSize = true;
            this.loggedAsL.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedAsL.Location = new System.Drawing.Point(3, 669);
            this.loggedAsL.Name = "loggedAsL";
            this.loggedAsL.Size = new System.Drawing.Size(223, 41);
            this.loggedAsL.TabIndex = 1;
            this.loggedAsL.Text = "Logged In As:";
            // 
            // innerPanel
            // 
            this.innerPanel.BackColor = System.Drawing.Color.Black;
            this.innerPanel.Controls.Add(this.label3);
            this.innerPanel.Controls.Add(this.label2);
            this.innerPanel.Controls.Add(this.available);
            this.innerPanel.Location = new System.Drawing.Point(0, 229);
            this.innerPanel.Name = "innerPanel";
            this.innerPanel.Size = new System.Drawing.Size(1307, 417);
            this.innerPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 64.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-24, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 141);
            this.label3.TabIndex = 10;
            this.label3.Text = "&& Retail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 64.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-35, -15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 141);
            this.label2.TabIndex = 9;
            this.label2.Text = "Wholesale";
            // 
            // available
            // 
            this.available.AutoSize = true;
            this.available.Font = new System.Drawing.Font("Arial Black", 145.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available.ForeColor = System.Drawing.Color.White;
            this.available.Location = new System.Drawing.Point(-57, 126);
            this.available.Margin = new System.Windows.Forms.Padding(0);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(1337, 341);
            this.available.TabIndex = 7;
            this.available.Text = "available";
            // 
            // categoriesQuickAccess
            // 
            this.categoriesQuickAccess.BackColor = System.Drawing.Color.White;
            this.categoriesQuickAccess.FlatAppearance.BorderSize = 3;
            this.categoriesQuickAccess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.categoriesQuickAccess.Font = new System.Drawing.Font("Bradley Hand ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesQuickAccess.Location = new System.Drawing.Point(7, 651);
            this.categoriesQuickAccess.Name = "categoriesQuickAccess";
            this.categoriesQuickAccess.Size = new System.Drawing.Size(250, 87);
            this.categoriesQuickAccess.TabIndex = 7;
            this.categoriesQuickAccess.Text = "Categories";
            this.categoriesQuickAccess.UseVisualStyleBackColor = false;
            this.categoriesQuickAccess.Click += new System.EventHandler(this.CategoriesQuickAccess_Click);
            // 
            // customerQuickAccess
            // 
            this.customerQuickAccess.BackColor = System.Drawing.Color.White;
            this.customerQuickAccess.FlatAppearance.BorderSize = 3;
            this.customerQuickAccess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customerQuickAccess.Font = new System.Drawing.Font("Bradley Hand ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerQuickAccess.Location = new System.Drawing.Point(7, 186);
            this.customerQuickAccess.Name = "customerQuickAccess";
            this.customerQuickAccess.Size = new System.Drawing.Size(250, 87);
            this.customerQuickAccess.TabIndex = 6;
            this.customerQuickAccess.Text = "Customers";
            this.customerQuickAccess.UseVisualStyleBackColor = false;
            this.customerQuickAccess.Click += new System.EventHandler(this.CustomerQuickAccess_Click);
            // 
            // userQuickAccess
            // 
            this.userQuickAccess.BackColor = System.Drawing.Color.White;
            this.userQuickAccess.FlatAppearance.BorderSize = 3;
            this.userQuickAccess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.userQuickAccess.Font = new System.Drawing.Font("Bradley Hand ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userQuickAccess.Location = new System.Drawing.Point(7, 279);
            this.userQuickAccess.Name = "userQuickAccess";
            this.userQuickAccess.Size = new System.Drawing.Size(250, 87);
            this.userQuickAccess.TabIndex = 3;
            this.userQuickAccess.Text = "Users";
            this.userQuickAccess.UseVisualStyleBackColor = false;
            this.userQuickAccess.Click += new System.EventHandler(this.UserQuickAccess_Click);
            // 
            // productQuickAccess
            // 
            this.productQuickAccess.BackColor = System.Drawing.Color.White;
            this.productQuickAccess.FlatAppearance.BorderSize = 3;
            this.productQuickAccess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.productQuickAccess.Font = new System.Drawing.Font("Bradley Hand ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuickAccess.Location = new System.Drawing.Point(7, 465);
            this.productQuickAccess.Name = "productQuickAccess";
            this.productQuickAccess.Size = new System.Drawing.Size(250, 87);
            this.productQuickAccess.TabIndex = 4;
            this.productQuickAccess.Text = "Products";
            this.productQuickAccess.UseVisualStyleBackColor = false;
            this.productQuickAccess.Click += new System.EventHandler(this.ProductQuickAccess_Click);
            // 
            // auditQuickAccess
            // 
            this.auditQuickAccess.BackColor = System.Drawing.Color.White;
            this.auditQuickAccess.FlatAppearance.BorderSize = 3;
            this.auditQuickAccess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.auditQuickAccess.Font = new System.Drawing.Font("Bradley Hand ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auditQuickAccess.Location = new System.Drawing.Point(7, 558);
            this.auditQuickAccess.Name = "auditQuickAccess";
            this.auditQuickAccess.Size = new System.Drawing.Size(250, 87);
            this.auditQuickAccess.TabIndex = 2;
            this.auditQuickAccess.Text = "Audits";
            this.auditQuickAccess.UseVisualStyleBackColor = false;
            this.auditQuickAccess.Click += new System.EventHandler(this.AuditQuickAccess_Click);
            // 
            // purchaseQuickAccess
            // 
            this.purchaseQuickAccess.BackColor = System.Drawing.Color.White;
            this.purchaseQuickAccess.FlatAppearance.BorderSize = 2;
            this.purchaseQuickAccess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.purchaseQuickAccess.Font = new System.Drawing.Font("Bradley Hand ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseQuickAccess.Location = new System.Drawing.Point(7, 372);
            this.purchaseQuickAccess.Name = "purchaseQuickAccess";
            this.purchaseQuickAccess.Size = new System.Drawing.Size(250, 87);
            this.purchaseQuickAccess.TabIndex = 1;
            this.purchaseQuickAccess.Text = "Purchases";
            this.purchaseQuickAccess.UseVisualStyleBackColor = false;
            this.purchaseQuickAccess.Click += new System.EventHandler(this.PurchaseQuickAccess_Click);
            // 
            // quickAccessL
            // 
            this.quickAccessL.AutoSize = true;
            this.quickAccessL.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickAccessL.Location = new System.Drawing.Point(12, 67);
            this.quickAccessL.Name = "quickAccessL";
            this.quickAccessL.Size = new System.Drawing.Size(241, 42);
            this.quickAccessL.TabIndex = 1;
            this.quickAccessL.Text = "Quick Access";
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1570, 746);
            this.ControlBox = false;
            this.Controls.Add(this.quickAccessL);
            this.Controls.Add(this.categoriesQuickAccess);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.auditQuickAccess);
            this.Controls.Add(this.productQuickAccess);
            this.Controls.Add(this.userQuickAccess);
            this.Controls.Add(this.purchaseQuickAccess);
            this.Controls.Add(this.customerQuickAccess);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.Name = "AdminHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boutique Management System";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            this.innerPanel.ResumeLayout(false);
            this.innerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripMenuItem addCustomer;
        private System.Windows.Forms.ToolStripMenuItem addUser;
        private System.Windows.Forms.ToolStripMenuItem addProduct;
        private System.Windows.Forms.ToolStripMenuItem addCategory;
        private System.Windows.Forms.ToolStripMenuItem profile;
        private System.Windows.Forms.ToolStripMenuItem signOut;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem updateDelete;
        private System.Windows.Forms.ToolStripMenuItem editCustomer;
        private System.Windows.Forms.ToolStripMenuItem editUser;
        private System.Windows.Forms.ToolStripMenuItem editProduct;
        private System.Windows.Forms.ToolStripMenuItem editCategory;
        private System.Windows.Forms.ToolStripMenuItem other;
        private System.Windows.Forms.ToolStripMenuItem changePassword;
        private System.Windows.Forms.ToolStripMenuItem audit;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel innerPanel;
        private System.Windows.Forms.Button customerQuickAccess;
        private System.Windows.Forms.Button productQuickAccess;
        private System.Windows.Forms.Button userQuickAccess;
        private System.Windows.Forms.Button auditQuickAccess;
        private System.Windows.Forms.Label loggedAsL;
        private System.Windows.Forms.Label loggedInAs;
        private System.Windows.Forms.Label boutiqueName2;
        private System.Windows.Forms.Label boutiqueName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label available;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button categoriesQuickAccess;
        private System.Windows.Forms.Button purchaseQuickAccess;
        private System.Windows.Forms.Label quickAccessL;
    }
}