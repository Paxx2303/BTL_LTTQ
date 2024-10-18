namespace BTL
{
    partial class Dangnhap
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
            pbLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTenDN = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMK = new TextBox();
            txtEmail = new TextBox();
            btnDangNhap = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.pepe;
            pbLogo.Location = new Point(264, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(254, 161);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 11;
            pbLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 220);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 12;
            label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 258);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 13;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 302);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 14;
            label3.Text = "Xác nhận mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 332);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 15;
            label4.Text = "Email";
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(350, 220);
            txtTenDN.Multiline = true;
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(168, 27);
            txtTenDN.TabIndex = 16;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(350, 258);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(168, 27);
            txtMatKhau.TabIndex = 17;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(350, 299);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.Size = new Size(168, 27);
            txtXacNhanMK.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(350, 332);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 27);
            txtEmail.TabIndex = 19;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.AppWorkspace;
            btnDangNhap.ForeColor = SystemColors.ActiveCaptionText;
            btnDangNhap.Location = new Point(307, 394);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(135, 44);
            btnDangNhap.TabIndex = 20;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangNhap);
            Controls.Add(txtEmail);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbLogo);
            Name = "Dangnhap";
            Text = "Dangnhap";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTenDN;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMK;
        private TextBox txtEmail;
        private Button btnDangNhap;
    }
}