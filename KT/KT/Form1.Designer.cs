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
            textboxusername = new TextBox();
            label2 = new Label();
            textboxmatkhau = new TextBox();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 70);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            label1.Click += label1_Click;
            // 
            // textboxusername
            // 
            textboxusername.Location = new Point(317, 63);
            textboxusername.Name = "textboxusername";
            textboxusername.Size = new Size(125, 27);
            textboxusername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 136);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // textboxmatkhau
            // 
            textboxmatkhau.Location = new Point(327, 135);
            textboxmatkhau.Margin = new Padding(2);
            textboxmatkhau.Name = "textboxmatkhau";
            textboxmatkhau.Size = new Size(121, 27);
            textboxmatkhau.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(338, 238);
            btnlogin.Margin = new Padding(4);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(109, 48);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "dang nhap";
            btnlogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin);
            Controls.Add(textboxmatkhau);
            Controls.Add(label2);
            Controls.Add(textboxusername);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textboxusername;
        private Label label2;
        private TextBox textboxmatkhau;
        private Button btnlogin;
    }
}
