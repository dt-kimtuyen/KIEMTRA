using System;
using System.Drawing;
using System.Windows.Forms;

namespace KT
{
    public partial class FormSuccess : Form
    {
        public FormSuccess()
        {
            this.Load += FormSuccess_Load;
        }

        private void FormSuccess_Load(object sender, EventArgs e)
        {
            this.Text = "dang nhap thanh cong";
            this.Size = new Size(400, 200);

            Label successLabel = new Label();
            successLabel.Text = "dang nhap thanh cong!";
            successLabel.AutoSize = true;
            successLabel.Location = new Point(50, 50);
            this.Controls.Add(successLabel);
        }
    }
}
