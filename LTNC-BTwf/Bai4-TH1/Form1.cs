using System;
using System.Windows.Forms;

namespace Bai4_TH1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a, b, kq = 0;
            if (!double.TryParse(txtSo1.Text, out a) || !double.TryParse(txtSo2.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
                return;
            }

            if (radCong.Checked) kq = a + b;
            if (radTru.Checked) kq = a - b;
            if (radNhan.Checked) kq = a * b;
            if (radChia.Checked)
            {
                if (b == 0)
                {
                    MessageBox.Show("Không thể chia cho 0!");
                    return;
                }
                kq = a / b;
            }
            txtKQ.Text = kq.ToString();
        }
    }
}
