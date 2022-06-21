namespace Boutique_Management_System
{
    partial class NotFirstLogin
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
            this.firstHalfPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.title2 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.secondHalfPanel = new System.Windows.Forms.Panel();
            this.userTypeErr = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userType = new System.Windows.Forms.ComboBox();
            this.loginAsL = new System.Windows.Forms.Label();
            this.passwdErr = new System.Windows.Forms.Label();
            this.userNameErr = new System.Windows.Forms.Label();
            this.passwdF = new System.Windows.Forms.TextBox();
            this.userNameF = new System.Windows.Forms.TextBox();
            this.passwdL = new System.Windows.Forms.Label();
            this.userNameL = new System.Windows.Forms.Label();
            this.firstHalfPanel.SuspendLayout();
            this.secondHalfPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstHalfPanel
            // 
            this.firstHalfPanel.BackColor = System.Drawing.Color.Black;
            this.firstHalfPanel.Controls.Add(this.closeBtn);
            this.firstHalfPanel.Controls.Add(this.title2);
            this.firstHalfPanel.Controls.Add(this.title1);
            this.firstHalfPanel.Location = new System.Drawing.Point(-6, -2);
            this.firstHalfPanel.Name = "firstHalfPanel";
            this.firstHalfPanel.Size = new System.Drawing.Size(656, 192);
            this.firstHalfPanel.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(578, 20);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(53, 38);
            this.closeBtn.TabIndex = 27;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Arial Black", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.ForeColor = System.Drawing.Color.White;
            this.title2.Location = new System.Drawing.Point(251, 106);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(169, 67);
            this.title2.TabIndex = 1;
            this.title2.Text = "Login";
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Arial Black", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(117, 20);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(420, 67);
            this.title1.TabIndex = 0;
            this.title1.Text = "Eldorado Men\'s";
            // 
            // secondHalfPanel
            // 
            this.secondHalfPanel.Controls.Add(this.userTypeErr);
            this.secondHalfPanel.Controls.Add(this.cancelBtn);
            this.secondHalfPanel.Controls.Add(this.loginBtn);
            this.secondHalfPanel.Controls.Add(this.userType);
            this.secondHalfPanel.Controls.Add(this.loginAsL);
            this.secondHalfPanel.Controls.Add(this.passwdErr);
            this.secondHalfPanel.Controls.Add(this.userNameErr);
            this.secondHalfPanel.Controls.Add(this.passwdF);
            this.secondHalfPanel.Controls.Add(this.userNameF);
            this.secondHalfPanel.Controls.Add(this.passwdL);
            this.secondHalfPanel.Controls.Add(this.userNameL);
            this.secondHalfPanel.Location = new System.Drawing.Point(-6, 190);
            this.secondHalfPanel.Name = "secondHalfPanel";
            this.secondHalfPanel.Size = new System.Drawing.Size(656, 217);
            this.secondHalfPanel.TabIndex = 1;
            // 
            // userTypeErr
            // 
            this.userTypeErr.AutoSize = true;
            this.userTypeErr.ForeColor = System.Drawing.Color.Red;
            this.userTypeErr.Location = new System.Drawing.Point(309, 132);
            this.userTypeErr.Name = "userTypeErr";
            this.userTypeErr.Size = new System.Drawing.Size(138, 16);
            this.userTypeErr.TabIndex = 19;
            this.userTypeErr.Text = "usertype not selected!";
            this.userTypeErr.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(341, 155);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(166, 44);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Blue;
            this.loginBtn.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(156, 155);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(179, 44);
            this.loginBtn.TabIndex = 17;
            this.loginBtn.Text = "Let me in.";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // userType
            // 
            this.userType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userType.FormattingEnabled = true;
            this.userType.Items.AddRange(new object[] {
            "Sales Person",
            "Admin",
            "Super Admin"});
            this.userType.Location = new System.Drawing.Point(311, 105);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(195, 24);
            this.userType.TabIndex = 16;
            // 
            // loginAsL
            // 
            this.loginAsL.AutoSize = true;
            this.loginAsL.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAsL.Location = new System.Drawing.Point(150, 105);
            this.loginAsL.Name = "loginAsL";
            this.loginAsL.Size = new System.Drawing.Size(122, 32);
            this.loginAsL.TabIndex = 15;
            this.loginAsL.Text = "Login As";
            // 
            // passwdErr
            // 
            this.passwdErr.AutoSize = true;
            this.passwdErr.ForeColor = System.Drawing.Color.Red;
            this.passwdErr.Location = new System.Drawing.Point(309, 86);
            this.passwdErr.Name = "passwdErr";
            this.passwdErr.Size = new System.Drawing.Size(159, 16);
            this.passwdErr.TabIndex = 12;
            this.passwdErr.Text = "password can\'t be empty!";
            this.passwdErr.Visible = false;
            // 
            // userNameErr
            // 
            this.userNameErr.AutoSize = true;
            this.userNameErr.ForeColor = System.Drawing.Color.Red;
            this.userNameErr.Location = new System.Drawing.Point(308, 42);
            this.userNameErr.Name = "userNameErr";
            this.userNameErr.Size = new System.Drawing.Size(160, 16);
            this.userNameErr.TabIndex = 9;
            this.userNameErr.Text = "username can\'t be empty!";
            this.userNameErr.Visible = false;
            // 
            // passwdF
            // 
            this.passwdF.Location = new System.Drawing.Point(311, 61);
            this.passwdF.Name = "passwdF";
            this.passwdF.PasswordChar = '*';
            this.passwdF.Size = new System.Drawing.Size(196, 22);
            this.passwdF.TabIndex = 8;
            // 
            // userNameF
            // 
            this.userNameF.Location = new System.Drawing.Point(311, 17);
            this.userNameF.Name = "userNameF";
            this.userNameF.Size = new System.Drawing.Size(196, 22);
            this.userNameF.TabIndex = 7;
            // 
            // passwdL
            // 
            this.passwdL.AutoSize = true;
            this.passwdL.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdL.Location = new System.Drawing.Point(150, 64);
            this.passwdL.Name = "passwdL";
            this.passwdL.Size = new System.Drawing.Size(136, 32);
            this.passwdL.TabIndex = 6;
            this.passwdL.Text = "Password";
            // 
            // userNameL
            // 
            this.userNameL.AutoSize = true;
            this.userNameL.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameL.Location = new System.Drawing.Point(150, 17);
            this.userNameL.Name = "userNameL";
            this.userNameL.Size = new System.Drawing.Size(141, 32);
            this.userNameL.TabIndex = 5;
            this.userNameL.Text = "Username";
            // 
            // NotFirstLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 401);
            this.ControlBox = false;
            this.Controls.Add(this.secondHalfPanel);
            this.Controls.Add(this.firstHalfPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "NotFirstLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotFirstLogin";
            this.firstHalfPanel.ResumeLayout(false);
            this.firstHalfPanel.PerformLayout();
            this.secondHalfPanel.ResumeLayout(false);
            this.secondHalfPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel firstHalfPanel;
        private System.Windows.Forms.Panel secondHalfPanel;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Label userNameErr;
        private System.Windows.Forms.TextBox passwdF;
        private System.Windows.Forms.TextBox userNameF;
        private System.Windows.Forms.Label passwdL;
        private System.Windows.Forms.Label userNameL;
        private System.Windows.Forms.ComboBox userType;
        private System.Windows.Forms.Label loginAsL;
        private System.Windows.Forms.Label passwdErr;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label userTypeErr;
        private System.Windows.Forms.Button closeBtn;
    }
}