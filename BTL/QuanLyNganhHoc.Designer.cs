namespace BTL
{
    partial class QuanLyNganhHoc
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
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			button5 = new Button();
			button4 = new Button();
			button3 = new Button();
			button1 = new Button();
			dataGridView1 = new DataGridView();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label2 = new Label();
			label1 = new Label();
			panel4 = new Panel();
			btnQuanLyHoSo = new Button();
			btnQuanLyHoTro = new Button();
			button2 = new Button();
			btnQuanLyChiTieuNganh = new Button();
			btnQuanLyThanhToan = new Button();
			panel2 = new Panel();
			button7 = new Button();
			button6 = new Button();
			panel3 = new Panel();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panel4.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Window;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(button5);
			panel1.Controls.Add(button4);
			panel1.Controls.Add(button3);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(dataGridView1);
			panel1.Controls.Add(textBox2);
			panel1.Controls.Add(textBox1);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(panel4);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 5);
			panel1.Name = "panel1";
			panel1.Size = new Size(1197, 643);
			panel1.TabIndex = 11;
			panel1.Paint += panel1_Paint;
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(961, 113);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(197, 128);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 29;
			pictureBox1.TabStop = false;
			// 
			// button5
			// 
			button5.Location = new Point(961, 247);
			button5.Name = "button5";
			button5.Size = new Size(197, 57);
			button5.TabIndex = 28;
			button5.Text = "Chọn ảnh";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button4
			// 
			button4.Location = new Point(961, 408);
			button4.Name = "button4";
			button4.Size = new Size(197, 57);
			button4.TabIndex = 27;
			button4.Text = "Sửa";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.Location = new Point(961, 491);
			button3.Name = "button3";
			button3.Size = new Size(197, 57);
			button3.TabIndex = 26;
			button3.Text = "Xoá";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button1
			// 
			button1.Location = new Point(961, 328);
			button1.Name = "button1";
			button1.Size = new Size(197, 57);
			button1.TabIndex = 25;
			button1.Text = "Thêm";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click_1;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(457, 223);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(481, 344);
			dataGridView1.TabIndex = 24;
			dataGridView1.CellClick += dataGridView1_CellContentClick;
			dataGridView1.RowEnter += dataGridView1_CellContentClick_1;
			dataGridView1.VisibleChanged += form_load;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(550, 168);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(388, 29);
			textBox2.TabIndex = 22;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(550, 122);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(388, 29);
			textBox1.TabIndex = 21;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(461, 168);
			label2.Name = "label2";
			label2.Size = new Size(53, 20);
			label2.TabIndex = 19;
			label2.Text = "Mô tả:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(461, 122);
			label1.Name = "label1";
			label1.Size = new Size(83, 20);
			label1.TabIndex = 18;
			label1.Text = "Mã ngành:";
			// 
			// panel4
			// 
			panel4.BackColor = SystemColors.Window;
			panel4.BorderStyle = BorderStyle.FixedSingle;
			panel4.Controls.Add(btnQuanLyHoSo);
			panel4.Controls.Add(btnQuanLyHoTro);
			panel4.Controls.Add(button2);
			panel4.Controls.Add(btnQuanLyChiTieuNganh);
			panel4.Controls.Add(btnQuanLyThanhToan);
			panel4.Dock = DockStyle.Left;
			panel4.Location = new Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(413, 641);
			panel4.TabIndex = 11;
			// 
			// btnQuanLyHoSo
			// 
			btnQuanLyHoSo.FlatAppearance.BorderSize = 0;
			btnQuanLyHoSo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnQuanLyHoSo.ForeColor = Color.Black;
			btnQuanLyHoSo.Image = Properties.Resources.icons8_manager_60;
			btnQuanLyHoSo.ImageAlign = ContentAlignment.MiddleLeft;
			btnQuanLyHoSo.Location = new Point(10, 83);
			btnQuanLyHoSo.Name = "btnQuanLyHoSo";
			btnQuanLyHoSo.Size = new Size(384, 77);
			btnQuanLyHoSo.TabIndex = 11;
			btnQuanLyHoSo.Text = "                Quản lý hồ sơ";
			btnQuanLyHoSo.TextAlign = ContentAlignment.MiddleLeft;
			btnQuanLyHoSo.UseVisualStyleBackColor = true;
			btnQuanLyHoSo.Click += btnQuanLyHoSo_Click;
			// 
			// btnQuanLyHoTro
			// 
			btnQuanLyHoTro.FlatAppearance.BorderSize = 0;
			btnQuanLyHoTro.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnQuanLyHoTro.ForeColor = Color.Black;
			btnQuanLyHoTro.Image = Properties.Resources.icons8_support_50;
			btnQuanLyHoTro.ImageAlign = ContentAlignment.MiddleLeft;
			btnQuanLyHoTro.Location = new Point(9, 535);
			btnQuanLyHoTro.Name = "btnQuanLyHoTro";
			btnQuanLyHoTro.Size = new Size(383, 77);
			btnQuanLyHoTro.TabIndex = 15;
			btnQuanLyHoTro.Text = "              Quản lý hỗ trợ";
			btnQuanLyHoTro.TextAlign = ContentAlignment.MiddleLeft;
			btnQuanLyHoTro.UseVisualStyleBackColor = true;
			btnQuanLyHoTro.Click += btnQuanLyHoTro_Click;
			// 
			// button2
			// 
			button2.FlatAppearance.BorderSize = 0;
			button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.Black;
			button2.Image = Properties.Resources.icons8_device_manager_64;
			button2.ImageAlign = ContentAlignment.MiddleLeft;
			button2.Location = new Point(10, 194);
			button2.Name = "button2";
			button2.Size = new Size(384, 77);
			button2.TabIndex = 12;
			button2.Text = "                Quản lý ngành học";
			button2.TextAlign = ContentAlignment.MiddleLeft;
			button2.UseVisualStyleBackColor = true;
			// 
			// btnQuanLyChiTieuNganh
			// 
			btnQuanLyChiTieuNganh.FlatAppearance.BorderSize = 0;
			btnQuanLyChiTieuNganh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnQuanLyChiTieuNganh.ForeColor = Color.Black;
			btnQuanLyChiTieuNganh.Image = Properties.Resources.icons8_exam_64;
			btnQuanLyChiTieuNganh.ImageAlign = ContentAlignment.MiddleLeft;
			btnQuanLyChiTieuNganh.Location = new Point(9, 423);
			btnQuanLyChiTieuNganh.Name = "btnQuanLyChiTieuNganh";
			btnQuanLyChiTieuNganh.Size = new Size(383, 77);
			btnQuanLyChiTieuNganh.TabIndex = 14;
			btnQuanLyChiTieuNganh.Text = "                Quản lý chỉ tiêu ngành";
			btnQuanLyChiTieuNganh.TextAlign = ContentAlignment.MiddleLeft;
			btnQuanLyChiTieuNganh.UseVisualStyleBackColor = true;
			btnQuanLyChiTieuNganh.Click += btnQuanLyChiTieuNganh_Click;
			// 
			// btnQuanLyThanhToan
			// 
			btnQuanLyThanhToan.FlatAppearance.BorderSize = 0;
			btnQuanLyThanhToan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnQuanLyThanhToan.ForeColor = Color.Black;
			btnQuanLyThanhToan.Image = Properties.Resources.icons8_payment_64;
			btnQuanLyThanhToan.ImageAlign = ContentAlignment.MiddleLeft;
			btnQuanLyThanhToan.Location = new Point(11, 307);
			btnQuanLyThanhToan.Name = "btnQuanLyThanhToan";
			btnQuanLyThanhToan.Size = new Size(383, 77);
			btnQuanLyThanhToan.TabIndex = 13;
			btnQuanLyThanhToan.Text = "                Quản lý thanh toán";
			btnQuanLyThanhToan.TextAlign = ContentAlignment.MiddleLeft;
			btnQuanLyThanhToan.UseVisualStyleBackColor = true;
			btnQuanLyThanhToan.Click += btnQuanLyThanhToan_Click;
			// 
			// panel2
			// 
			panel2.BackColor = Color.RoyalBlue;
			panel2.Controls.Add(button7);
			panel2.Controls.Add(button6);
			panel2.Controls.Add(panel3);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1197, 67);
			panel2.TabIndex = 12;
			// 
			// button7
			// 
			button7.FlatAppearance.BorderSize = 0;
			button7.FlatStyle = FlatStyle.Flat;
			button7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button7.ForeColor = SystemColors.ControlLightLight;
			button7.Image = Properties.Resources.icons8_menu_32;
			button7.ImageAlign = ContentAlignment.MiddleLeft;
			button7.Location = new Point(1, 1);
			button7.Margin = new Padding(4);
			button7.Name = "button7";
			button7.Size = new Size(259, 62);
			button7.TabIndex = 13;
			button7.Text = "      ADMIN BOARD";
			button7.TextAlign = ContentAlignment.MiddleLeft;
			button7.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			button6.FlatAppearance.BorderSize = 0;
			button6.FlatStyle = FlatStyle.Flat;
			button6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button6.ForeColor = SystemColors.ControlLightLight;
			button6.Image = Properties.Resources.icons8_exit_48;
			button6.ImageAlign = ContentAlignment.MiddleLeft;
			button6.Location = new Point(1057, 1);
			button6.Margin = new Padding(4);
			button6.Name = "button6";
			button6.Size = new Size(135, 62);
			button6.TabIndex = 12;
			button6.Text = "        Sign Out";
			button6.TextAlign = ContentAlignment.MiddleLeft;
			button6.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			panel3.Location = new Point(0, 63);
			panel3.Name = "panel3";
			panel3.Size = new Size(371, 491);
			panel3.TabIndex = 11;
			// 
			// QuanLyNganhHoc
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(54, 75, 109);
			ClientSize = new Size(1197, 648);
			Controls.Add(panel2);
			Controls.Add(panel1);
			MaximizeBox = false;
			Name = "QuanLyNganhHoc";
			Text = "AdminInterface";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel4.ResumeLayout(false);
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Button button6;
        private Button button7;
        private Button btnQuanLyHoSo;
        private Button btnQuanLyHoTro;
        private Button button2;
        private Button btnQuanLyChiTieuNganh;
        private Button btnQuanLyThanhToan;
		private TextBox textBox1;
		private Label label2;
		private Label label1;
		private TextBox textBox2;
		private PictureBox pictureBox1;
		private Button button5;
		private Button button4;
		private Button button3;
		private Button button1;
		private DataGridView dataGridView1;
	}
}