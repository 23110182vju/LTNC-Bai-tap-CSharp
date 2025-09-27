using System;
using System.Windows.Forms;

namespace Bai1_TH1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string thongbao = "Tên đăng nhập là: " + txtUser.Text;
            thongbao += "\nMật khẩu là: " + txtPass.Text;
            if (chkNho.Checked)
                thongbao += "\nBạn có ghi nhớ.";
            MessageBox.Show(thongbao, "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
