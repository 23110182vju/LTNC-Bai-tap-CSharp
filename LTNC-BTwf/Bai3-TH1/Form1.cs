using System;
using System.Windows.Forms;

namespace Bai3_TH1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int so;
            if (int.TryParse(txtSo.Text, out so))
            {
                cboSo.Items.Add(so);
                txtSo.Clear();
                txtSo.Focus();
            }
            else
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi");
        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTinh.Items.Clear();
            int so = int.Parse(cboSo.SelectedItem.ToString());
            for (int i = 1; i <= so; i++)
                if (so % i == 0) lstTinh.Items.Add(i);
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (int x in lstTinh.Items) tong += x;
            MessageBox.Show("Tổng các ước số = " + tong);
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int x in lstTinh.Items) if (x % 2 == 0) dem++;
            MessageBox.Show("Số lượng ước số chẵn = " + dem);
        }

        private void btnNguyenTo_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int x in lstTinh.Items) if (LaNguyenTo(x)) dem++;
            MessageBox.Show("Số lượng ước số nguyên tố = " + dem);
        }

        private bool LaNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }
    }
}
