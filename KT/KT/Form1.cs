using System;
using System.Windows.Forms;

namespace KT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnlogin.Click += Btnlogin_Click; // Gán s? ki?n cho nút ??ng nh?p
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            string username = textboxusername.Text.Trim();
            string password = textboxmatkhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("vui long nhap ten dn va mk", "C?nh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Dang nhap thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormSuccess successForm = new FormSuccess();
                successForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ten dang nhap khong dung!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("B?n v?a nh?p vào 'Tên ??ng nh?p'!");
        }
    }
}
