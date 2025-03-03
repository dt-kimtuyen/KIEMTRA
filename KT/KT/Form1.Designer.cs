using System.Drawing;
using System.Windows.Forms;

namespace KT
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox textboxusername;
        private Label label2;
        private TextBox textboxmatkhau;
        private Button btnlogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.textboxusername = new TextBox();
            this.label2 = new Label();
            this.textboxmatkhau = new TextBox();
            this.btnlogin = new Button();
            this.SuspendLayout();

            // Label 1 - Tên đăng nhập
            this.label1.AutoSize = true;
            this.label1.Location = new Point(166, 70);
            this.label1.Name = "label1";
            this.label1.Size = new Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";

            // Textbox Username
            this.textboxusername.Location = new Point(317, 63);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new Size(125, 27);
            this.textboxusername.TabIndex = 1;

            // Label 2 - Mật khẩu
            this.label2.AutoSize = true;
            this.label2.Location = new Point(182, 136);
            this.label2.Name = "label2";
            this.label2.Size = new Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";

            // Textbox Password
            this.textboxmatkhau.Location = new Point(327, 135);
            this.textboxmatkhau.Name = "textboxmatkhau";
            this.textboxmatkhau.Size = new Size(121, 27);
            this.textboxmatkhau.TabIndex = 3;
            this.textboxmatkhau.PasswordChar = '*';

            // Button Đăng nhập
            this.btnlogin.Location = new Point(338, 238);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new Size(109, 48);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.UseVisualStyleBackColor = true;

            // Form1
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.textboxmatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
