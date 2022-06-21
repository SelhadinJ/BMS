namespace Boutique_Management_System
{
    partial class Format
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
            this.passwdF = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.formatBtn = new System.Windows.Forms.Button();
            this.passFieldErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwdF
            // 
            this.passwdF.Location = new System.Drawing.Point(156, 99);
            this.passwdF.Name = "passwdF";
            this.passwdF.PasswordChar = '*';
            this.passwdF.Size = new System.Drawing.Size(171, 22);
            this.passwdF.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(403, 7);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(53, 38);
            this.closeBtn.TabIndex = 26;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(20, 48);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(448, 35);
            this.label.TabIndex = 27;
            this.label.Text = "Super Administrator\'s Password *";
            // 
            // formatBtn
            // 
            this.formatBtn.BackColor = System.Drawing.Color.Red;
            this.formatBtn.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatBtn.ForeColor = System.Drawing.Color.Black;
            this.formatBtn.Location = new System.Drawing.Point(156, 154);
            this.formatBtn.Name = "formatBtn";
            this.formatBtn.Size = new System.Drawing.Size(171, 44);
            this.formatBtn.TabIndex = 28;
            this.formatBtn.Text = "Format";
            this.formatBtn.UseVisualStyleBackColor = false;
            this.formatBtn.Click += new System.EventHandler(this.FormatBtn_Click);
            // 
            // passFieldErr
            // 
            this.passFieldErr.AutoSize = true;
            this.passFieldErr.ForeColor = System.Drawing.Color.Red;
            this.passFieldErr.Location = new System.Drawing.Point(144, 124);
            this.passFieldErr.Name = "passFieldErr";
            this.passFieldErr.Size = new System.Drawing.Size(0, 16);
            this.passFieldErr.TabIndex = 29;
            this.passFieldErr.Visible = false;
            // 
            // Format
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 210);
            this.ControlBox = false;
            this.Controls.Add(this.passFieldErr);
            this.Controls.Add(this.formatBtn);
            this.Controls.Add(this.label);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.passwdF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Format";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Format";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwdF;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button formatBtn;
        private System.Windows.Forms.Label passFieldErr;
    }
}