﻿namespace KT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            txtpassword = new TextBox();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 88);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Ten dang nhap";
            label1.Click += label1_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(396, 79);
            txtUserName.Margin = new Padding(4, 4, 4, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(155, 31);
            txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 170);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Mat khau";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(409, 169);
            txtpassword.Margin = new Padding(2);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(150, 31);
            txtpassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(416, 305);
            btnlogin.Margin = new Padding(4, 4, 4, 4);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(136, 60);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private Label label2;
        private TextBox txtpassword;
        private Button btnlogin;
    }
}
