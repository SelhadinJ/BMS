namespace Boutique_Management_System
{
    partial class ChangePassword
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
            this.existingPasswdL = new System.Windows.Forms.Label();
            this.newPasswdL = new System.Windows.Forms.Label();
            this.confirmPasswdL = new System.Windows.Forms.Label();
            this.changePasswdBtn = new System.Windows.Forms.Button();
            this.existingPasswd = new System.Windows.Forms.TextBox();
            this.newPasswd = new System.Windows.Forms.TextBox();
            this.confirmPasswd = new System.Windows.Forms.TextBox();
            this.existingPasswdErr = new System.Windows.Forms.Label();
            this.confirmPasswdErr = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // existingPasswdL
            // 
            this.existingPasswdL.AutoSize = true;
            this.existingPasswdL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingPasswdL.Location = new System.Drawing.Point(12, 50);
            this.existingPasswdL.Name = "existingPasswdL";
            this.existingPasswdL.Size = new System.Drawing.Size(249, 35);
            this.existingPasswdL.TabIndex = 0;
            this.existingPasswdL.Text = "Existing Password";
            // 
            // newPasswdL
            // 
            this.newPasswdL.AutoSize = true;
            this.newPasswdL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswdL.Location = new System.Drawing.Point(12, 95);
            this.newPasswdL.Name = "newPasswdL";
            this.newPasswdL.Size = new System.Drawing.Size(190, 35);
            this.newPasswdL.TabIndex = 1;
            this.newPasswdL.Text = "New Password";
            // 
            // confirmPasswdL
            // 
            this.confirmPasswdL.AutoSize = true;
            this.confirmPasswdL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswdL.Location = new System.Drawing.Point(12, 141);
            this.confirmPasswdL.Name = "confirmPasswdL";
            this.confirmPasswdL.Size = new System.Drawing.Size(244, 35);
            this.confirmPasswdL.TabIndex = 2;
            this.confirmPasswdL.Text = "Confirm Password";
            // 
            // changePasswdBtn
            // 
            this.changePasswdBtn.BackColor = System.Drawing.Color.Blue;
            this.changePasswdBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswdBtn.Location = new System.Drawing.Point(104, 196);
            this.changePasswdBtn.Name = "changePasswdBtn";
            this.changePasswdBtn.Size = new System.Drawing.Size(308, 53);
            this.changePasswdBtn.TabIndex = 3;
            this.changePasswdBtn.Text = "Change Password";
            this.changePasswdBtn.UseVisualStyleBackColor = false;
            this.changePasswdBtn.Click += new System.EventHandler(this.ChangePasswdBtn_Click);
            // 
            // existingPasswd
            // 
            this.existingPasswd.Location = new System.Drawing.Point(296, 57);
            this.existingPasswd.Name = "existingPasswd";
            this.existingPasswd.Size = new System.Drawing.Size(213, 22);
            this.existingPasswd.TabIndex = 4;
            // 
            // newPasswd
            // 
            this.newPasswd.Location = new System.Drawing.Point(296, 102);
            this.newPasswd.Name = "newPasswd";
            this.newPasswd.PasswordChar = '*';
            this.newPasswd.Size = new System.Drawing.Size(213, 22);
            this.newPasswd.TabIndex = 5;
            // 
            // confirmPasswd
            // 
            this.confirmPasswd.Location = new System.Drawing.Point(296, 150);
            this.confirmPasswd.Name = "confirmPasswd";
            this.confirmPasswd.PasswordChar = '*';
            this.confirmPasswd.Size = new System.Drawing.Size(213, 22);
            this.confirmPasswd.TabIndex = 6;
            // 
            // existingPasswdErr
            // 
            this.existingPasswdErr.AutoSize = true;
            this.existingPasswdErr.ForeColor = System.Drawing.Color.Red;
            this.existingPasswdErr.Location = new System.Drawing.Point(294, 82);
            this.existingPasswdErr.Name = "existingPasswdErr";
            this.existingPasswdErr.Size = new System.Drawing.Size(123, 16);
            this.existingPasswdErr.TabIndex = 7;
            this.existingPasswdErr.Text = "incorrect password!";
            this.existingPasswdErr.Visible = false;
            // 
            // confirmPasswdErr
            // 
            this.confirmPasswdErr.AutoSize = true;
            this.confirmPasswdErr.ForeColor = System.Drawing.Color.Red;
            this.confirmPasswdErr.Location = new System.Drawing.Point(293, 175);
            this.confirmPasswdErr.Name = "confirmPasswdErr";
            this.confirmPasswdErr.Size = new System.Drawing.Size(155, 16);
            this.confirmPasswdErr.TabIndex = 9;
            this.confirmPasswdErr.Text = "password doesn\'t match!";
            this.confirmPasswdErr.Visible = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(456, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(53, 38);
            this.closeBtn.TabIndex = 26;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 261);
            this.ControlBox = false;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.confirmPasswdErr);
            this.Controls.Add(this.existingPasswdErr);
            this.Controls.Add(this.confirmPasswd);
            this.Controls.Add(this.newPasswd);
            this.Controls.Add(this.existingPasswd);
            this.Controls.Add(this.changePasswdBtn);
            this.Controls.Add(this.confirmPasswdL);
            this.Controls.Add(this.newPasswdL);
            this.Controls.Add(this.existingPasswdL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label existingPasswdL;
        private System.Windows.Forms.Label newPasswdL;
        private System.Windows.Forms.Label confirmPasswdL;
        private System.Windows.Forms.Button changePasswdBtn;
        private System.Windows.Forms.TextBox existingPasswd;
        private System.Windows.Forms.TextBox newPasswd;
        private System.Windows.Forms.TextBox confirmPasswd;
        private System.Windows.Forms.Label existingPasswdErr;
        private System.Windows.Forms.Label confirmPasswdErr;
        private System.Windows.Forms.Button closeBtn;
    }
}