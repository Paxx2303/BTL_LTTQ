namespace BTL
{
	partial class TraCuuThanhToan
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
			pbBienLai = new PictureBox();
			btnTimKiem = new Button();
			txtSoTienThanhToan = new TextBox();
			txtHinhThucThanhToan = new TextBox();
			txtMaHoSo = new TextBox();
			txtNhapMaHoSo = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pbBienLai).BeginInit();
			SuspendLayout();
			// 
			// pbBienLai
			// 
			pbBienLai.Location = new Point(412, 87);
			pbBienLai.Name = "pbBienLai";
			pbBienLai.Size = new Size(377, 339);
			pbBienLai.TabIndex = 21;
			pbBienLai.TabStop = false;
			// 
			// btnTimKiem
			// 
			btnTimKiem.Location = new Point(328, 25);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(94, 29);
			btnTimKiem.TabIndex = 20;
			btnTimKiem.Text = "Tìm kiếm";
			btnTimKiem.UseVisualStyleBackColor = true;
			btnTimKiem.Click += btnTimKiem_Click_1;
			// 
			// txtSoTienThanhToan
			// 
			txtSoTienThanhToan.Location = new Point(166, 288);
			txtSoTienThanhToan.Name = "txtSoTienThanhToan";
			txtSoTienThanhToan.Size = new Size(140, 27);
			txtSoTienThanhToan.TabIndex = 19;
			// 
			// txtHinhThucThanhToan
			// 
			txtHinhThucThanhToan.Location = new Point(166, 232);
			txtHinhThucThanhToan.Name = "txtHinhThucThanhToan";
			txtHinhThucThanhToan.Size = new Size(140, 27);
			txtHinhThucThanhToan.TabIndex = 18;
			// 
			// txtMaHoSo
			// 
			txtMaHoSo.Location = new Point(166, 176);
			txtMaHoSo.Name = "txtMaHoSo";
			txtMaHoSo.Size = new Size(140, 27);
			txtMaHoSo.TabIndex = 17;
			// 
			// txtNhapMaHoSo
			// 
			txtNhapMaHoSo.Location = new Point(166, 27);
			txtNhapMaHoSo.Name = "txtNhapMaHoSo";
			txtNhapMaHoSo.Size = new Size(140, 27);
			txtNhapMaHoSo.TabIndex = 16;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(580, 27);
			label5.Name = "label5";
			label5.Size = new Size(58, 20);
			label5.TabIndex = 15;
			label5.Text = "Biên lai";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 291);
			label4.Name = "label4";
			label4.Size = new Size(130, 20);
			label4.TabIndex = 14;
			label4.Text = "Số tiền thanh toán";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 239);
			label3.Name = "label3";
			label3.Size = new Size(148, 20);
			label3.TabIndex = 13;
			label3.Text = "Hình thức thanh toán";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 183);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 12;
			label2.Text = "Mã hồ sơ";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 27);
			label1.Name = "label1";
			label1.Size = new Size(110, 20);
			label1.TabIndex = 11;
			label1.Text = "Nhập mã hồ sơ";
			// 
			// TraCuuThanhToan
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(pbBienLai);
			Controls.Add(btnTimKiem);
			Controls.Add(txtSoTienThanhToan);
			Controls.Add(txtHinhThucThanhToan);
			Controls.Add(txtMaHoSo);
			Controls.Add(txtNhapMaHoSo);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "TraCuuThanhToan";
			Text = "TraCuuThanhToan";
			Load += TraCuuThanhToan_Load;
			((System.ComponentModel.ISupportInitialize)pbBienLai).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pbBienLai;
		private Button btnTimKiem;
		private TextBox txtSoTienThanhToan;
		private TextBox txtHinhThucThanhToan;
		private TextBox txtMaHoSo;
		private TextBox txtNhapMaHoSo;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
	}
}