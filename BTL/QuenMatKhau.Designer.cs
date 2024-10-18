namespace BTL
{
    partial class QuenMatKhau
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
            txtTenDN = new TextBox();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 262);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 25;
            label2.Text = "Kết quả:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 212);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 24;
            label1.Text = "Email đăng ký:";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.AppWorkspace;
            btnDangNhap.ForeColor = SystemColors.ActiveCaptionText;
            btnDangNhap.Location = new Point(339, 337);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(135, 44);
            btnDangNhap.TabIndex = 23;
            btnDangNhap.Text = "Lấy lại mật khẩu";
            btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(359, 212);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(205, 27);
            txtTenDN.TabIndex = 19;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.pepe;
            pbLogo.Location = new Point(310, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(254, 161);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 18;
            pbLogo.TabStop = false;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDangNhap);
            Controls.Add(txtTenDN);
            Controls.Add(pbLogo);
            Name = "QuenMatKhau";
            Text = "QuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnDangNhap;
        private TextBox txtTenDN;
        private PictureBox pbLogo;
    }
}