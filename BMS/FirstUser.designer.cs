namespace Boutique_Management_System
{
    partial class FirstUser
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
            this.firstNameL = new System.Windows.Forms.Label();
            this.usernameL = new System.Windows.Forms.Label();
            this.passwdL = new System.Windows.Forms.Label();
            this.phoneNoL = new System.Windows.Forms.Label();
            this.lastNameL = new System.Windows.Forms.Label();
            this.firstNameF = new System.Windows.Forms.TextBox();
            this.lastNameF = new System.Windows.Forms.TextBox();
            this.phoneNoF = new System.Windows.Forms.TextBox();
            this.userNameF = new System.Windows.Forms.TextBox();
            this.passwdF = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.createUserBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(49, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(449, 75);
            this.title.TabIndex = 0;
            this.title.Text = "Create New User";
            // 
            // firstNameL
            // 
            this.firstNameL.AutoSize = true;
            this.firstNameL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameL.Location = new System.Drawing.Point(56, 112);
            this.firstNameL.Name = "firstNameL";
            this.firstNameL.Size = new System.Drawing.Size(181, 35);
            this.firstNameL.TabIndex = 1;
            this.firstNameL.Text = "First Name *";
            // 
            // usernameL
            // 
            this.usernameL.AutoSize = true;
            this.usernameL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameL.Location = new System.Drawing.Point(57, 238);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(164, 35);
            this.usernameL.TabIndex = 2;
            this.usernameL.Text = "Username *";
            // 
            // passwdL
            // 
            this.passwdL.AutoSize = true;
            this.passwdL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdL.Location = new System.Drawing.Point(57, 280);
            this.passwdL.Name = "passwdL";
            this.passwdL.Size = new System.Drawing.Size(154, 35);
            this.passwdL.TabIndex = 3;
            this.passwdL.Text = "Password *";
            // 
            // phoneNoL
            // 
            this.phoneNoL.AutoSize = true;
            this.phoneNoL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNoL.Location = new System.Drawing.Point(58, 196);
            this.phoneNoL.Name = "phoneNoL";
            this.phoneNoL.Size = new System.Drawing.Size(153, 35);
            this.phoneNoL.TabIndex = 4;
            this.phoneNoL.Text = "Phone No *";
            // 
            // lastNameL
            // 
            this.lastNameL.AutoSize = true;
            this.lastNameL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameL.Location = new System.Drawing.Point(56, 156);
            this.lastNameL.Name = "lastNameL";
            this.lastNameL.Size = new System.Drawing.Size(153, 35);
            this.lastNameL.TabIndex = 5;
            this.lastNameL.Text = "Last Name";
            // 
            // firstNameF
            // 
            this.firstNameF.Location = new System.Drawing.Point(243, 119);
            this.firstNameF.Name = "firstNameF";
            this.firstNameF.Size = new System.Drawing.Size(204, 22);
            this.firstNameF.TabIndex = 6;
            // 
            // lastNameF
            // 
            this.lastNameF.Location = new System.Drawing.Point(243, 163);
            this.lastNameF.Name = "lastNameF";
            this.lastNameF.Size = new System.Drawing.Size(204, 22);
            this.lastNameF.TabIndex = 7;
            // 
            // phoneNoF
            // 
            this.phoneNoF.Location = new System.Drawing.Point(243, 203);
            this.phoneNoF.Name = "phoneNoF";
            this.phoneNoF.Size = new System.Drawing.Size(204, 22);
            this.phoneNoF.TabIndex = 8;
            // 
            // userNameF
            // 
            this.userNameF.Location = new System.Drawing.Point(243, 245);
            this.userNameF.Name = "userNameF";
            this.userNameF.Size = new System.Drawing.Size(204, 22);
            this.userNameF.TabIndex = 9;
            // 
            // passwdF
            // 
            this.passwdF.Location = new System.Drawing.Point(243, 287);
            this.passwdF.Name = "passwdF";
            this.passwdF.PasswordChar = '*';
            this.passwdF.Size = new System.Drawing.Size(204, 22);
            this.passwdF.TabIndex = 10;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(283, 348);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(215, 42);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // createUserBtn
            // 
            this.createUserBtn.BackColor = System.Drawing.Color.Blue;
            this.createUserBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserBtn.Location = new System.Drawing.Point(44, 348);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(215, 42);
            this.createUserBtn.TabIndex = 12;
            this.createUserBtn.Text = "Create User";
            this.createUserBtn.UseVisualStyleBackColor = false;
            this.createUserBtn.Click += new System.EventHandler(this.CreateUserBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(519, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(53, 38);
            this.closeBtn.TabIndex = 26;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // FirstUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 419);
            this.ControlBox = false;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.createUserBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.passwdF);
            this.Controls.Add(this.userNameF);
            this.Controls.Add(this.phoneNoF);
            this.Controls.Add(this.lastNameF);
            this.Controls.Add(this.firstNameF);
            this.Controls.Add(this.lastNameL);
            this.Controls.Add(this.phoneNoL);
            this.Controls.Add(this.passwdL);
            this.Controls.Add(this.usernameL);
            this.Controls.Add(this.firstNameL);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FirstUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label firstNameL;
        private System.Windows.Forms.Label usernameL;
        private System.Windows.Forms.Label passwdL;
        private System.Windows.Forms.Label phoneNoL;
        private System.Windows.Forms.Label lastNameL;
        private System.Windows.Forms.TextBox firstNameF;
        private System.Windows.Forms.TextBox lastNameF;
        private System.Windows.Forms.TextBox phoneNoF;
        private System.Windows.Forms.TextBox userNameF;
        private System.Windows.Forms.TextBox passwdF;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button createUserBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}