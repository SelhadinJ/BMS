namespace Boutique_Management_System
{
    partial class UserFrame
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
            this.searchByIdL = new System.Windows.Forms.Label();
            this.SearchByNameL = new System.Windows.Forms.Label();
            this.searchByIdF = new System.Windows.Forms.TextBox();
            this.firstNameF = new System.Windows.Forms.TextBox();
            this.lastNameF = new System.Windows.Forms.TextBox();
            this.phoneNoF = new System.Windows.Forms.TextBox();
            this.userNameF = new System.Windows.Forms.TextBox();
            this.passwdF = new System.Windows.Forms.TextBox();
            this.userTypeC = new System.Windows.Forms.ComboBox();
            this.firstNameL = new System.Windows.Forms.Label();
            this.lastNameL = new System.Windows.Forms.Label();
            this.phoneNoL = new System.Windows.Forms.Label();
            this.usernameL = new System.Windows.Forms.Label();
            this.passwdL = new System.Windows.Forms.Label();
            this.userTypeL = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.header = new System.Windows.Forms.Label();
            this.searchByNameF = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // searchByIdL
            // 
            this.searchByIdL.AutoSize = true;
            this.searchByIdL.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByIdL.Location = new System.Drawing.Point(12, 91);
            this.searchByIdL.Name = "searchByIdL";
            this.searchByIdL.Size = new System.Drawing.Size(237, 46);
            this.searchByIdL.TabIndex = 0;
            this.searchByIdL.Text = "Search By ID";
            // 
            // SearchByNameL
            // 
            this.SearchByNameL.AutoSize = true;
            this.SearchByNameL.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByNameL.Location = new System.Drawing.Point(12, 139);
            this.SearchByNameL.Name = "SearchByNameL";
            this.SearchByNameL.Size = new System.Drawing.Size(297, 46);
            this.SearchByNameL.TabIndex = 1;
            this.SearchByNameL.Text = "Search By Name";
            // 
            // searchByIdF
            // 
            this.searchByIdF.Location = new System.Drawing.Point(273, 106);
            this.searchByIdF.Name = "searchByIdF";
            this.searchByIdF.Size = new System.Drawing.Size(206, 22);
            this.searchByIdF.TabIndex = 2;
            this.searchByIdF.TextChanged += new System.EventHandler(this.SearchByIdF_TextChanged);
            // 
            // firstNameF
            // 
            this.firstNameF.Location = new System.Drawing.Point(226, 216);
            this.firstNameF.Name = "firstNameF";
            this.firstNameF.Size = new System.Drawing.Size(202, 22);
            this.firstNameF.TabIndex = 4;
            // 
            // lastNameF
            // 
            this.lastNameF.Location = new System.Drawing.Point(226, 254);
            this.lastNameF.Name = "lastNameF";
            this.lastNameF.Size = new System.Drawing.Size(202, 22);
            this.lastNameF.TabIndex = 5;
            // 
            // phoneNoF
            // 
            this.phoneNoF.Location = new System.Drawing.Point(226, 294);
            this.phoneNoF.Name = "phoneNoF";
            this.phoneNoF.Size = new System.Drawing.Size(202, 22);
            this.phoneNoF.TabIndex = 6;
            // 
            // userNameF
            // 
            this.userNameF.Location = new System.Drawing.Point(226, 335);
            this.userNameF.Name = "userNameF";
            this.userNameF.Size = new System.Drawing.Size(202, 22);
            this.userNameF.TabIndex = 7;
            // 
            // passwdF
            // 
            this.passwdF.Location = new System.Drawing.Point(226, 373);
            this.passwdF.Name = "passwdF";
            this.passwdF.Size = new System.Drawing.Size(202, 22);
            this.passwdF.TabIndex = 8;
            // 
            // userTypeC
            // 
            this.userTypeC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userTypeC.FormattingEnabled = true;
            this.userTypeC.Items.AddRange(new object[] {
            "Sales Person"});
            this.userTypeC.Location = new System.Drawing.Point(226, 412);
            this.userTypeC.Name = "userTypeC";
            this.userTypeC.Size = new System.Drawing.Size(202, 24);
            this.userTypeC.TabIndex = 9;
            // 
            // firstNameL
            // 
            this.firstNameL.AutoSize = true;
            this.firstNameL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameL.Location = new System.Drawing.Point(23, 209);
            this.firstNameL.Name = "firstNameL";
            this.firstNameL.Size = new System.Drawing.Size(181, 35);
            this.firstNameL.TabIndex = 10;
            this.firstNameL.Text = "First Name *";
            // 
            // lastNameL
            // 
            this.lastNameL.AutoSize = true;
            this.lastNameL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameL.Location = new System.Drawing.Point(26, 247);
            this.lastNameL.Name = "lastNameL";
            this.lastNameL.Size = new System.Drawing.Size(153, 35);
            this.lastNameL.TabIndex = 11;
            this.lastNameL.Text = "Last Name";
            // 
            // phoneNoL
            // 
            this.phoneNoL.AutoSize = true;
            this.phoneNoL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNoL.Location = new System.Drawing.Point(26, 287);
            this.phoneNoL.Name = "phoneNoL";
            this.phoneNoL.Size = new System.Drawing.Size(153, 35);
            this.phoneNoL.TabIndex = 12;
            this.phoneNoL.Text = "Phone No *";
            // 
            // usernameL
            // 
            this.usernameL.AutoSize = true;
            this.usernameL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameL.Location = new System.Drawing.Point(26, 329);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(164, 35);
            this.usernameL.TabIndex = 13;
            this.usernameL.Text = "Username *";
            // 
            // passwdL
            // 
            this.passwdL.AutoSize = true;
            this.passwdL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdL.Location = new System.Drawing.Point(26, 366);
            this.passwdL.Name = "passwdL";
            this.passwdL.Size = new System.Drawing.Size(154, 35);
            this.passwdL.TabIndex = 14;
            this.passwdL.Text = "Password *";
            // 
            // userTypeL
            // 
            this.userTypeL.AutoSize = true;
            this.userTypeL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeL.Location = new System.Drawing.Point(26, 405);
            this.userTypeL.Name = "userTypeL";
            this.userTypeL.Size = new System.Drawing.Size(165, 35);
            this.userTypeL.TabIndex = 15;
            this.userTypeL.Text = "User Type *";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(459, 332);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(179, 69);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Blue;
            this.addBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(459, 253);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(179, 69);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Add User";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(660, 254);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(179, 68);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Blue;
            this.updateBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(660, 329);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(179, 66);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(322, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(176, 75);
            this.title.TabIndex = 20;
            this.title.Text = "Users";
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.table);
            this.tablePanel.Controls.Add(this.header);
            this.tablePanel.Location = new System.Drawing.Point(0, 454);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(866, 304);
            this.tablePanel.TabIndex = 21;
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
            this.table.Location = new System.Drawing.Point(0, 67);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(866, 237);
            this.table.TabIndex = 3;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Bradley Hand ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(307, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(271, 59);
            this.header.TabIndex = 0;
            this.header.Text = "Users Detail";
            // 
            // searchByNameF
            // 
            this.searchByNameF.Location = new System.Drawing.Point(345, 154);
            this.searchByNameF.Name = "searchByNameF";
            this.searchByNameF.Size = new System.Drawing.Size(206, 22);
            this.searchByNameF.TabIndex = 22;
            this.searchByNameF.TextChanged += new System.EventHandler(this.SearchByNameF_TextChanged_1);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(786, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(53, 38);
            this.closeBtn.TabIndex = 24;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // UserFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 758);
            this.ControlBox = false;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.searchByNameF);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.userTypeL);
            this.Controls.Add(this.passwdL);
            this.Controls.Add(this.usernameL);
            this.Controls.Add(this.phoneNoL);
            this.Controls.Add(this.lastNameL);
            this.Controls.Add(this.firstNameL);
            this.Controls.Add(this.userTypeC);
            this.Controls.Add(this.passwdF);
            this.Controls.Add(this.userNameF);
            this.Controls.Add(this.phoneNoF);
            this.Controls.Add(this.lastNameF);
            this.Controls.Add(this.firstNameF);
            this.Controls.Add(this.searchByIdF);
            this.Controls.Add(this.SearchByNameL);
            this.Controls.Add(this.searchByIdL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "UserFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchByIdL;
        private System.Windows.Forms.Label SearchByNameL;
        private System.Windows.Forms.TextBox searchByIdF;
        private System.Windows.Forms.TextBox firstNameF;
        private System.Windows.Forms.TextBox lastNameF;
        private System.Windows.Forms.TextBox phoneNoF;
        private System.Windows.Forms.TextBox userNameF;
        private System.Windows.Forms.TextBox passwdF;
        private System.Windows.Forms.ComboBox userTypeC;
        private System.Windows.Forms.Label firstNameL;
        private System.Windows.Forms.Label lastNameL;
        private System.Windows.Forms.Label phoneNoL;
        private System.Windows.Forms.Label usernameL;
        private System.Windows.Forms.Label passwdL;
        private System.Windows.Forms.Label userTypeL;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TextBox searchByNameF;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button closeBtn;
    }
}