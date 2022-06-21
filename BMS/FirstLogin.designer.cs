namespace Boutique_Management_System
{
    partial class FirstLogin
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwdErr = new System.Windows.Forms.Label();
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
            this.firstHalfPanel.Location = new System.Drawing.Point(-4, -2);
            this.firstHalfPanel.Name = "firstHalfPanel";
            this.firstHalfPanel.Size = new System.Drawing.Size(639, 179);
            this.firstHalfPanel.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(572, 14);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(53, 38);
            this.closeBtn.TabIndex = 26;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Arial Black", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.ForeColor = System.Drawing.Color.White;
            this.title2.Location = new System.Drawing.Point(253, 89);
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
            this.title1.Location = new System.Drawing.Point(116, 11);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(420, 67);
            this.title1.TabIndex = 0;
            this.title1.Text = "Eldorado Men\'s";
            // 
            // secondHalfPanel
            // 
            this.secondHalfPanel.Controls.Add(this.cancelBtn);
            this.secondHalfPanel.Controls.Add(this.loginBtn);
            this.secondHalfPanel.Controls.Add(this.passwdErr);
            this.secondHalfPanel.Controls.Add(this.passwdF);
            this.secondHalfPanel.Controls.Add(this.userNameF);
            this.secondHalfPanel.Controls.Add(this.passwdL);
            this.secondHalfPanel.Controls.Add(this.userNameL);
            this.secondHalfPanel.Location = new System.Drawing.Point(-4, 174);
            this.secondHalfPanel.Name = "secondHalfPanel";
            this.secondHalfPanel.Size = new System.Drawing.Size(639, 192);
            this.secondHalfPanel.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(337, 109);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(166, 44);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Blue;
            this.loginBtn.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(152, 109);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(179, 44);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Let me in.";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // passwdErr
            // 
            this.passwdErr.AutoSize = true;
            this.passwdErr.ForeColor = System.Drawing.Color.Red;
            this.passwdErr.Location = new System.Drawing.Point(308, 90);
            this.passwdErr.Name = "passwdErr";
            this.passwdErr.Size = new System.Drawing.Size(159, 16);
            this.passwdErr.TabIndex = 5;
            this.passwdErr.Text = "password can\'t be empty!";
            this.passwdErr.Visible = false;
            // 
            // passwdF
            // 
            this.passwdF.Location = new System.Drawing.Point(310, 62);
            this.passwdF.Name = "passwdF";
            this.passwdF.PasswordChar = '*';
            this.passwdF.Size = new System.Drawing.Size(193, 22);
            this.passwdF.TabIndex = 3;
            // 
            // userNameF
            // 
            this.userNameF.Enabled = false;
            this.userNameF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameF.Location = new System.Drawing.Point(311, 23);
            this.userNameF.Name = "userNameF";
            this.userNameF.Size = new System.Drawing.Size(193, 27);
            this.userNameF.TabIndex = 2;
            // 
            // passwdL
            // 
            this.passwdL.AutoSize = true;
            this.passwdL.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdL.Location = new System.Drawing.Point(149, 65);
            this.passwdL.Name = "passwdL";
            this.passwdL.Size = new System.Drawing.Size(136, 32);
            this.passwdL.TabIndex = 1;
            this.passwdL.Text = "Password";
            // 
            // userNameL
            // 
            this.userNameL.AutoSize = true;
            this.userNameL.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameL.Location = new System.Drawing.Point(149, 18);
            this.userNameL.Name = "userNameL";
            this.userNameL.Size = new System.Drawing.Size(141, 32);
            this.userNameL.TabIndex = 0;
            this.userNameL.Text = "Username";
            // 
            // FirstLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 361);
            this.ControlBox = false;
            this.Controls.Add(this.secondHalfPanel);
            this.Controls.Add(this.firstHalfPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FirstLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Login";
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
        private System.Windows.Forms.Label passwdL;
        private System.Windows.Forms.Label userNameL;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label passwdErr;
        private System.Windows.Forms.TextBox passwdF;
        private System.Windows.Forms.TextBox userNameF;
        private System.Windows.Forms.Button closeBtn;
    }
}