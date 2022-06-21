using System;

namespace Boutique_Management_System
{
    partial class AuditFrame
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
            this.userIdL = new System.Windows.Forms.Label();
            this.userIdF = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.header = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.rangeL = new System.Windows.Forms.Label();
            this.rangeC = new System.Windows.Forms.ComboBox();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(152, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(212, 75);
            this.title.TabIndex = 0;
            this.title.Text = "Audits";
            // 
            // userIdL
            // 
            this.userIdL.AutoSize = true;
            this.userIdL.Font = new System.Drawing.Font("Bradley Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdL.Location = new System.Drawing.Point(80, 78);
            this.userIdL.Name = "userIdL";
            this.userIdL.Size = new System.Drawing.Size(198, 37);
            this.userIdL.TabIndex = 1;
            this.userIdL.Text = "Enter User ID";
            // 
            // userIdF
            // 
            this.userIdF.Location = new System.Drawing.Point(307, 87);
            this.userIdF.Name = "userIdF";
            this.userIdF.Size = new System.Drawing.Size(100, 22);
            this.userIdF.TabIndex = 5;
            this.userIdF.TextChanged += new System.EventHandler(this.UserIdF_TextChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(103, 178);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(151, 41);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Red;
            this.resetBtn.Font = new System.Drawing.Font("Bradley Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(276, 178);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(151, 41);
            this.resetBtn.TabIndex = 9;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.table);
            this.tablePanel.Controls.Add(this.header);
            this.tablePanel.Location = new System.Drawing.Point(0, 225);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(524, 347);
            this.tablePanel.TabIndex = 10;
            this.tablePanel.Visible = false;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table.BackgroundColor = System.Drawing.Color.White;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.table.GridColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 72);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(524, 275);
            this.table.TabIndex = 2;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Bradley Hand ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(92, 10);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(299, 59);
            this.header.TabIndex = 0;
            this.header.Text = "Audits Detail";
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(458, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(53, 38);
            this.closeBtn.TabIndex = 24;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // rangeL
            // 
            this.rangeL.AutoSize = true;
            this.rangeL.Font = new System.Drawing.Font("Bradley Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeL.Location = new System.Drawing.Point(81, 129);
            this.rangeL.Name = "rangeL";
            this.rangeL.Size = new System.Drawing.Size(98, 35);
            this.rangeL.TabIndex = 2;
            this.rangeL.Text = "Range";
            // 
            // rangeC
            // 
            this.rangeC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rangeC.FormattingEnabled = true;
            this.rangeC.Items.AddRange(new object[] {
            "Today",
            "Since Last Week",
            "Since Last 2 Week",
            "Since Last Month"});
            this.rangeC.Location = new System.Drawing.Point(209, 136);
            this.rangeC.Name = "rangeC";
            this.rangeC.Size = new System.Drawing.Size(198, 24);
            this.rangeC.TabIndex = 25;
            this.rangeC.SelectedIndexChanged += new System.EventHandler(this.RangeC_SelectedIndexChanged);
            // 
            // AuditFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 571);
            this.ControlBox = false;
            this.Controls.Add(this.rangeC);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.userIdF);
            this.Controls.Add(this.rangeL);
            this.Controls.Add(this.userIdL);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AuditFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audits";
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label userIdL;
        private System.Windows.Forms.TextBox userIdF;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label rangeL;
        private System.Windows.Forms.ComboBox rangeC;
    }
}