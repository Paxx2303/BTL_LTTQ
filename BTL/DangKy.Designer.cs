namespace BTL
{
    partial class DangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            btnDangNhap = new Button();
            linkDangKy = new LinkLabel();
            linkQuenMK = new LinkLabel();
            txtMatKhau = new TextBox();
            txtTenDN = new TextBox();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 262);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 17;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 212);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 16;
            label1.Text = "Tên đăng nhập";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.AppWorkspace;
            btnDangNhap.ForeColor = SystemColors.ActiveCaptionText;
            btnDangNhap.Location = new Point(333, 394);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(135, 44);
            btnDangNhap.TabIndex = 15;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // linkDangKy
            // 
            linkDangKy.AutoSize = true;
            linkDangKy.Location = new Point(435, 349);
            linkDangKy.Name = "linkDangKy";
            linkDangKy.Size = new Size(63, 20);
            linkDangKy.TabIndex = 14;
            linkDangKy.TabStop = true;
            linkDangKy.Text = "Đăng ký";
            // 
            // linkQuenMK
            // 
            linkQuenMK.AutoSize = true;
            linkQuenMK.Location = new Point(249, 349);
            linkQuenMK.Name = "linkQuenMK";
            linkQuenMK.Size = new Size(109, 20);
            linkQuenMK.TabIndex = 13;
            linkQuenMK.TabStop = true;
            linkQuenMK.Text = "Quên mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(346, 262);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(205, 27);
            txtMatKhau.TabIndex = 12;
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(346, 212);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(205, 27);
            txtTenDN.TabIndex = 11;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.pepe;
            pbLogo.Location = new Point(297, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(254, 161);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 10;
            pbLogo.TabStop = false;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(872, 484);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDangNhap);
            Controls.Add(linkDangKy);
            Controls.Add(linkQuenMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDN);
            Controls.Add(pbLogo);
            Name = "DangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangKy";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnDangNhap;
        private LinkLabel linkDangKy;
        private LinkLabel linkQuenMK;
        private TextBox txtMatKhau;
        private TextBox txtTenDN;
        private PictureBox pbLogo;
    }
}