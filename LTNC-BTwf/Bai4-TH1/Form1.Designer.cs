namespace Bai4_TH1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private TextBox txtKQ;
        private RadioButton radCong;
        private RadioButton radTru;
        private RadioButton radNhan;
        private RadioButton radChia;
        private Button btnTinh;
        private Label lblSo1;
        private Label lblSo2;
        private Label lblKQ;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtSo1 = new TextBox();
            this.txtSo2 = new TextBox();
            this.txtKQ = new TextBox();
            this.radCong = new RadioButton();
            this.radTru = new RadioButton();
            this.radNhan = new RadioButton();
            this.radChia = new RadioButton();
            this.btnTinh = new Button();
            this.lblSo1 = new Label();
            this.lblSo2 = new Label();
            this.lblKQ = new Label();
            this.SuspendLayout();
            this.lblSo1.Text = "Số 1:";
            this.lblSo1.Location = new System.Drawing.Point(20, 20);
            this.txtSo1.Location = new System.Drawing.Point(120, 20);
            this.lblSo2.Text = "Số 2:";
            this.lblSo2.Location = new System.Drawing.Point(20, 60);
            this.txtSo2.Location = new System.Drawing.Point(120, 60);
            this.radCong.Text = "Cộng";
            this.radCong.Location = new System.Drawing.Point(20, 100);
            this.radCong.Checked = true;
            this.radTru.Text = "Trừ";
            this.radTru.Location = new System.Drawing.Point(100, 100);
            this.radNhan.Text = "Nhân";
            this.radNhan.Location = new System.Drawing.Point(180, 100);
            this.radChia.Text = "Chia";
            this.radChia.Location = new System.Drawing.Point(260, 100);
            this.lblKQ.Text = "Kết quả:";
            this.lblKQ.Location = new System.Drawing.Point(20, 140);
            this.txtKQ.Location = new System.Drawing.Point(120, 140);
            this.btnTinh.Text = "Tính";
            this.btnTinh.Location = new System.Drawing.Point(150, 180);
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            this.ClientSize = new System.Drawing.Size(380, 230);
            this.Controls.AddRange(new Control[] { lblSo1, txtSo1, lblSo2, txtSo2, radCong, radTru, radNhan, radChia, lblKQ, txtKQ, btnTinh });
            this.Text = "Máy tính đơn giản";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
