namespace Bai1_TH1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUser;
        private TextBox txtPass;
        private CheckBox chkNho;
        private Button btnDangNhap;
        private Button btnXoa;
        private Button btnDung;
        private Label lblUser;
        private Label lblPass;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUser = new TextBox();
            this.txtPass = new TextBox();
            this.chkNho = new CheckBox();
            this.btnDangNhap = new Button();
            this.btnXoa = new Button();
            this.btnDung = new Button();
            this.lblUser = new Label();
            this.lblPass = new Label();
            this.SuspendLayout();
            // 
            this.lblUser.Text = "Tên đăng nhập:";
            this.lblUser.Location = new System.Drawing.Point(20, 20);
            this.txtUser.Location = new System.Drawing.Point(120, 20);
            this.lblPass.Text = "Mật khẩu:";
            this.lblPass.Location = new System.Drawing.Point(20, 60);
            this.txtPass.Location = new System.Drawing.Point(120, 60);
            this.txtPass.UseSystemPasswordChar = true;
            this.chkNho.Text = "Ghi nhớ";
            this.chkNho.Location = new System.Drawing.Point(120, 100);
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Location = new System.Drawing.Point(20, 150);
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(120, 150);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnDung.Text = "Dừng";
            this.btnDung.Location = new System.Drawing.Point(220, 150);
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.AddRange(new Control[] { lblUser, txtUser, lblPass, txtPass, chkNho, btnDangNhap, btnXoa, btnDung });
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
