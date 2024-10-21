namespace BTL
{
	partial class ThemThanhToan
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
			dgvThongTin = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			txtMaHoSo = new TextBox();
			txtHinhThucThanhToan = new TextBox();
			txtSoTienThanhToan = new TextBox();
			txtBienLai = new TextBox();
			btnThem = new Button();
			((System.ComponentModel.ISupportInitialize)dgvThongTin).BeginInit();
			SuspendLayout();
			// 
			// dgvThongTin
			// 
			dgvThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvThongTin.Location = new Point(332, 2);
			dgvThongTin.Name = "dgvThongTin";
			dgvThongTin.RowHeadersWidth = 51;
			dgvThongTin.Size = new Size(573, 446);
			dgvThongTin.TabIndex = 0;
			dgvThongTin.CellContentClick += dgvThongTin_CellContentClick;
			dgvThongTin.VisibleChanged += Form1_Load;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 55);
			label1.Name = "label1";
			label1.Size = new Size(70, 20);
			label1.TabIndex = 1;
			label1.Text = "Mã hồ sơ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(2, 111);
			label2.Name = "label2";
			label2.Size = new Size(148, 20);
			label2.TabIndex = 2;
			label2.Text = "Hình thức thanh toán";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(2, 165);
			label3.Name = "label3";
			label3.Size = new Size(130, 20);
			label3.TabIndex = 3;
			label3.Text = "Số tiền thanh toán";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 225);
			label4.Name = "label4";
			label4.Size = new Size(58, 20);
			label4.TabIndex = 4;
			label4.Text = "Biên lai";
			// 
			// txtMaHoSo
			// 
			txtMaHoSo.Location = new Point(156, 55);
			txtMaHoSo.Name = "txtMaHoSo";
			txtMaHoSo.Size = new Size(170, 27);
			txtMaHoSo.TabIndex = 5;
			txtMaHoSo.TextChanged += txtMaHoSo_TextChanged;
			// 
			// txtHinhThucThanhToan
			// 
			txtHinhThucThanhToan.Location = new Point(156, 108);
			txtHinhThucThanhToan.Name = "txtHinhThucThanhToan";
			txtHinhThucThanhToan.Size = new Size(170, 27);
			txtHinhThucThanhToan.TabIndex = 6;
			txtHinhThucThanhToan.TextChanged += txtHinhThucThanhToan_TextChanged;
			// 
			// txtSoTienThanhToan
			// 
			txtSoTienThanhToan.Location = new Point(156, 165);
			txtSoTienThanhToan.Name = "txtSoTienThanhToan";
			txtSoTienThanhToan.Size = new Size(170, 27);
			txtSoTienThanhToan.TabIndex = 7;
			txtSoTienThanhToan.TextChanged += txtSoTienThanhToan_TextChanged;
			// 
			// txtBienLai
			// 
			txtBienLai.Location = new Point(156, 225);
			txtBienLai.Name = "txtBienLai";
			txtBienLai.Size = new Size(170, 27);
			txtBienLai.TabIndex = 8;
			txtBienLai.TextChanged += txtBienLai_TextChanged;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(92, 315);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(106, 43);
			btnThem.TabIndex = 9;
			btnThem.Text = "Thêm ";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// ThemThanhToan
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(917, 450);
			Controls.Add(btnThem);
			Controls.Add(txtBienLai);
			Controls.Add(txtSoTienThanhToan);
			Controls.Add(txtHinhThucThanhToan);
			Controls.Add(txtMaHoSo);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dgvThongTin);
			Name = "ThemThanhToan";
			Text = "ThemThanhToan";
			Load += ThemThanhToan_Load;
			((System.ComponentModel.ISupportInitialize)dgvThongTin).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvThongTin;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox txtMaHoSo;
		private TextBox txtHinhThucThanhToan;
		private TextBox txtSoTienThanhToan;
		private TextBox txtBienLai;
		private Button btnThem;
	}
}