namespace Bai2_TH1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtHoTen;
        private TextBox txtKQ;
        private RadioButton radThuong;
        private RadioButton radHoa;
        private Button btnKQ;
        private Button btnXoa;
        private Button btnDung;
        private Label lblNhap;
        private Label lblKQ;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtHoTen = new TextBox();
            this.txtKQ = new TextBox();
            this.radThuong = new RadioButton();
            this.radHoa = new RadioButton();
            this.btnKQ = new Button();
            this.btnXoa = new Button();
            this.btnDung = new Button();
            this.lblNhap = new Label();
            this.lblKQ = new Label();
            this.SuspendLayout();
            this.lblNhap.Text = "Họ và tên:";
            this.lblNhap.Location = new System.Drawing.Point(20, 20);
            this.txtHoTen.Location = new System.Drawing.Point(120, 20);
            this.radThuong.Text = "chữ thường";
            this.radThuong.Location = new System.Drawing.Point(120, 60);
            this.radThuong.Checked = true;
            this.radHoa.Text = "CHỮ HOA";
            this.radHoa.Location = new System.Drawing.Point(220, 60);
            this.lblKQ.Text = "Kết quả:";
            this.lblKQ.Location = new System.Drawing.Point(20, 100);
            this.txtKQ.Location = new System.Drawing.Point(120, 100);
            this.btnKQ.Text = "Kết quả";
            this.btnKQ.Location = new System.Drawing.Point(20, 150);
            this.btnKQ.Click += new System.EventHandler(this.btnKQ_Click);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(120, 150);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnDung.Text = "Dừng";
            this.btnDung.Location = new System.Drawing.Point(220, 150);
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.AddRange(new Control[] { lblNhap, txtHoTen, radThuong, radHoa, lblKQ, txtKQ, btnKQ, btnXoa, btnDung });
            this.Text = "Đổi kiểu chữ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
