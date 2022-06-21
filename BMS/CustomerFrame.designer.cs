namespace Boutique_Management_System
{
    partial class CustomerFrame
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
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.firstNameL = new System.Windows.Forms.Label();
            this.lastNameL = new System.Windows.Forms.Label();
            this.phoneNoL = new System.Windows.Forms.Label();
            this.addressL = new System.Windows.Forms.Label();
            this.genderL = new System.Windows.Forms.Label();
            this.searchByNameL = new System.Windows.Forms.Label();
            this.searchByNameF = new System.Windows.Forms.TextBox();
            this.addressF = new System.Windows.Forms.TextBox();
            this.firstNameF = new System.Windows.Forms.TextBox();
            this.lastNameF = new System.Windows.Forms.TextBox();
            this.phoneNoF = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.header = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Blue;
            this.addBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(738, 75);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(184, 51);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(738, 132);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(184, 51);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Blue;
            this.updateBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(738, 189);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(184, 51);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(738, 248);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(184, 51);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(279, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(304, 75);
            this.title.TabIndex = 6;
            this.title.Text = "Customers";
            // 
            // firstNameL
            // 
            this.firstNameL.AutoSize = true;
            this.firstNameL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameL.Location = new System.Drawing.Point(12, 168);
            this.firstNameL.Name = "firstNameL";
            this.firstNameL.Size = new System.Drawing.Size(181, 35);
            this.firstNameL.TabIndex = 7;
            this.firstNameL.Text = "First Name *";
            // 
            // lastNameL
            // 
            this.lastNameL.AutoSize = true;
            this.lastNameL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameL.Location = new System.Drawing.Point(12, 210);
            this.lastNameL.Name = "lastNameL";
            this.lastNameL.Size = new System.Drawing.Size(153, 35);
            this.lastNameL.TabIndex = 8;
            this.lastNameL.Text = "Last Name";
            // 
            // phoneNoL
            // 
            this.phoneNoL.AutoSize = true;
            this.phoneNoL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNoL.Location = new System.Drawing.Point(12, 258);
            this.phoneNoL.Name = "phoneNoL";
            this.phoneNoL.Size = new System.Drawing.Size(153, 35);
            this.phoneNoL.TabIndex = 9;
            this.phoneNoL.Text = "Phone No *";
            // 
            // addressL
            // 
            this.addressL.AutoSize = true;
            this.addressL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressL.Location = new System.Drawing.Point(397, 168);
            this.addressL.Name = "addressL";
            this.addressL.Size = new System.Drawing.Size(140, 35);
            this.addressL.TabIndex = 10;
            this.addressL.Text = "Address *";
            // 
            // genderL
            // 
            this.genderL.AutoSize = true;
            this.genderL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderL.Location = new System.Drawing.Point(397, 250);
            this.genderL.Name = "genderL";
            this.genderL.Size = new System.Drawing.Size(103, 35);
            this.genderL.TabIndex = 11;
            this.genderL.Text = "Gender";
            // 
            // searchByNameL
            // 
            this.searchByNameL.AutoSize = true;
            this.searchByNameL.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByNameL.Location = new System.Drawing.Point(27, 89);
            this.searchByNameL.Name = "searchByNameL";
            this.searchByNameL.Size = new System.Drawing.Size(267, 41);
            this.searchByNameL.TabIndex = 12;
            this.searchByNameL.Text = "Search By Name";
            // 
            // searchByNameF
            // 
            this.searchByNameF.Location = new System.Drawing.Point(316, 97);
            this.searchByNameF.Name = "searchByNameF";
            this.searchByNameF.Size = new System.Drawing.Size(243, 22);
            this.searchByNameF.TabIndex = 13;
            this.searchByNameF.TextChanged += new System.EventHandler(this.SearchByNameF_TextChanged);
            // 
            // addressF
            // 
            this.addressF.Location = new System.Drawing.Point(543, 175);
            this.addressF.Multiline = true;
            this.addressF.Name = "addressF";
            this.addressF.Size = new System.Drawing.Size(189, 65);
            this.addressF.TabIndex = 14;
            // 
            // firstNameF
            // 
            this.firstNameF.Location = new System.Drawing.Point(199, 175);
            this.firstNameF.Name = "firstNameF";
            this.firstNameF.Size = new System.Drawing.Size(176, 22);
            this.firstNameF.TabIndex = 15;
            // 
            // lastNameF
            // 
            this.lastNameF.Location = new System.Drawing.Point(199, 218);
            this.lastNameF.Name = "lastNameF";
            this.lastNameF.Size = new System.Drawing.Size(176, 22);
            this.lastNameF.TabIndex = 16;
            // 
            // phoneNoF
            // 
            this.phoneNoF.Location = new System.Drawing.Point(199, 265);
            this.phoneNoF.Name = "phoneNoF";
            this.phoneNoF.Size = new System.Drawing.Size(176, 22);
            this.phoneNoF.TabIndex = 17;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(532, 256);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(77, 29);
            this.male.TabIndex = 18;
            this.male.TabStop = true;
            this.male.Text = "male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(625, 256);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(94, 29);
            this.female.TabIndex = 19;
            this.female.TabStop = true;
            this.female.Text = "female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.table);
            this.tablePanel.Controls.Add(this.header);
            this.tablePanel.Location = new System.Drawing.Point(1, 305);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(947, 277);
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
            this.table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.table.GridColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 65);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(947, 212);
            this.table.TabIndex = 2;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Bradley Hand ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(271, 11);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(372, 59);
            this.header.TabIndex = 0;
            this.header.Text = "Customers Detail";
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(869, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(53, 38);
            this.closeBtn.TabIndex = 23;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ClientFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 583);
            this.ControlBox = false;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.phoneNoF);
            this.Controls.Add(this.lastNameF);
            this.Controls.Add(this.firstNameF);
            this.Controls.Add(this.addressF);
            this.Controls.Add(this.searchByNameF);
            this.Controls.Add(this.searchByNameL);
            this.Controls.Add(this.genderL);
            this.Controls.Add(this.addressL);
            this.Controls.Add(this.phoneNoL);
            this.Controls.Add(this.lastNameL);
            this.Controls.Add(this.firstNameL);
            this.Controls.Add(this.title);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ClientFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label firstNameL;
        private System.Windows.Forms.Label lastNameL;
        private System.Windows.Forms.Label phoneNoL;
        private System.Windows.Forms.Label addressL;
        private System.Windows.Forms.Label genderL;
        private System.Windows.Forms.Label searchByNameL;
        private System.Windows.Forms.TextBox searchByNameF;
        private System.Windows.Forms.TextBox addressF;
        private System.Windows.Forms.TextBox firstNameF;
        private System.Windows.Forms.TextBox lastNameF;
        private System.Windows.Forms.TextBox phoneNoF;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button closeBtn;
    }
}