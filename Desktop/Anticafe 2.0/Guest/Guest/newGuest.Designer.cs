﻿namespace Guest
{
    partial class newGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newGuest));
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Flayer = new System.Windows.Forms.CheckBox();
            this.tax = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Invite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FirstName.Location = new System.Drawing.Point(293, 25);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(319, 59);
            this.FirstName.TabIndex = 1;
            this.FirstName.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Flayer
            // 
            this.Flayer.AutoSize = true;
            this.Flayer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Flayer.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Flayer.Location = new System.Drawing.Point(47, 166);
            this.Flayer.Margin = new System.Windows.Forms.Padding(4);
            this.Flayer.Name = "Flayer";
            this.Flayer.Size = new System.Drawing.Size(270, 56);
            this.Flayer.TabIndex = 35;
            this.Flayer.Text = "Флаер         ";
            this.Flayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Flayer.UseVisualStyleBackColor = true;
            // 
            // tax
            // 
            this.tax.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tax.FormattingEnabled = true;
            this.tax.Items.AddRange(new object[] {
            "Обычный",
            "Студенческий",
            "Детский"});
            this.tax.Location = new System.Drawing.Point(293, 92);
            this.tax.Margin = new System.Windows.Forms.Padding(4);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(319, 60);
            this.tax.TabIndex = 3;
            this.tax.SelectionChangeCommitted += new System.EventHandler(this.tax_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(47, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 52);
            this.label3.TabIndex = 33;
            this.label3.Text = "Тариф:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 52);
            this.label1.TabIndex = 31;
            this.label1.Text = "Имя:";
            // 
            // Invite
            // 
            this.Invite.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Invite.Location = new System.Drawing.Point(147, 246);
            this.Invite.Margin = new System.Windows.Forms.Padding(4);
            this.Invite.Name = "Invite";
            this.Invite.Size = new System.Drawing.Size(360, 123);
            this.Invite.TabIndex = 4;
            this.Invite.Text = "Уряя!! Новый гость :-) ";
            this.Invite.UseVisualStyleBackColor = true;
            this.Invite.Click += new System.EventHandler(this.Invite_Click);
            // 
            // newGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(659, 396);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Flayer);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Invite);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый Гость";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.newGuest_FormClosed);
            this.Load += new System.EventHandler(this.newGuest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.CheckBox Flayer;
        private System.Windows.Forms.ComboBox tax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Invite;

    }
}