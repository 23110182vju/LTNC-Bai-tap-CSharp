namespace Bai3_TH1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtSo;
        private ComboBox cboSo;
        private ListBox lstTinh;
        private Button btnCapNhat;
        private Button btnTong;
        private Button btnChan;
        private Button btnNguyenTo;
        private Label lblSo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtSo = new TextBox();
            this.cboSo = new ComboBox();
            this.lstTinh = new ListBox();
            this.btnCapNhat = new Button();
            this.btnTong = new Button();
            this.btnChan = new Button();
            this.btnNguyenTo = new Button();
            this.lblSo = new Label();
            this.SuspendLayout();
            this.lblSo.Text = "Nhập số:";
            this.lblSo.Location = new System.Drawing.Point(20, 20);
            this.txtSo.Location = new System.Drawing.Point(100, 20);
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Location = new System.Drawing.Point(220, 20);
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            this.cboSo.Location = new System.Drawing.Point(100, 60);
            this.cboSo.SelectedIndexChanged += new System.EventHandler(this.cboSo_SelectedIndexChanged);
            this.lstTinh.Location = new System.Drawing.Point(220, 60);
            this.lstTinh.Size = new System.Drawing.Size(180, 150);
            this.btnTong.Text = "Tổng ước số";
            this.btnTong.Location = new System.Drawing.Point(20, 230);
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            this.btnChan.Text = "Đếm ước chẵn";
            this.btnChan.Location = new System.Drawing.Point(140, 230);
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            this.btnNguyenTo.Text = "Đếm nguyên tố";
            this.btnNguyenTo.Location = new System.Drawing.Point(260, 230);
            this.btnNguyenTo.Click += new System.EventHandler(this.btnNguyenTo_Click);
            this.ClientSize = new System.Drawing.Size(420, 280);
            this.Controls.AddRange(new Control[] { lblSo, txtSo, btnCapNhat, cboSo, lstTinh, btnTong, btnChan, btnNguyenTo });
            this.Text = "Tính toán ước số";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
