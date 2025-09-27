using System;
using System.Windows.Forms;

namespace Bai2_TH1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text.Trim();
            if (radThuong.Checked)
                txtKQ.Text = hoten.ToLower();
            if (radHoa.Checked)
                txtKQ.Text = hoten.ToUpper();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtKQ.Clear();
            radThuong.Checked = true;
            txtHoTen.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
