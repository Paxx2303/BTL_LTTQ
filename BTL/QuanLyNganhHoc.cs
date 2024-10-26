using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
	public partial class QuanLyNganhHoc : Form
	{
		string str = "Data Source=KHABANH\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
		SqlCommand command;
		SqlConnection connection;
		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable table = new DataTable();
		public QuanLyNganhHoc()
		{
			InitializeComponent();
		}
		public void form_load(object sender, EventArgs e)
		{
			connection = new SqlConnection(str);
			connection.Open();
			command = connection.CreateCommand();
			command.CommandText = "SELECT * FROM Nganh";
			adapter.SelectCommand = command;
			table.Clear();
			adapter.Fill(table);
			dataGridView1.DataSource = table;
		}
		private void btnQuanLyHoSo_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyHoSo register = new QuanLyHoSo();
			register.ShowDialog();
			this.Close();
		}

		private void btnQuanLyThanhToan_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyThanhToan register = new QuanLyThanhToan();
			register.ShowDialog();
			this.Close();
		}

		private void btnQuanLyChiTieuNganh_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyChiTieuNganh register = new QuanLyChiTieuNganh();
			register.ShowDialog();
			this.Close();
		}
		private void btnQuanLyHoTro_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyHoTro register = new QuanLyHoTro();
			register.ShowDialog();
			this.Close();
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			if (e.RowIndex >= 0) // Đảm bảo RowIndex không âm
			{
				textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNganh"].Value?.ToString(); // Lấy giá trị từ cột 0                                                                          // Nếu bạn muốn lấy giá trị từ cột 1, bạn có thể thêm dòng sau
				textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["MoTa"].Value?.ToString(); // Lấy giá trị từ cột 1 													 // Lấy đường dẫn ảnh từ cột "ImagePath" (thay tên cột nếu khác)
				string imagePath = dataGridView1.Rows[e.RowIndex].Cells["AnhNganh"].Value?.ToString();

				// Hiển thị ảnh trong PictureBox nếu đường dẫn không rỗng
				if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
				{
					pictureBox1.ImageLocation = imagePath;
				}
				else
				{
					pictureBox1.Image = null; // Xóa ảnh nếu đường dẫn không hợp lệ
				}
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{

		}
		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Mã ngành không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(textBox2.Text))
			{
				MessageBox.Show("Mô tả không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(pictureBox1.ImageLocation))
			{
				MessageBox.Show("Ảnh không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			command = connection.CreateCommand();
			command.CommandText = "SELECT COUNT(*) FROM Nganh WHERE MaNganh = @manganh";
			command.Parameters.AddWithValue("@manganh", textBox1.Text);
			int count = (int)command.ExecuteScalar();
			if (count > 0)
			{
				MessageBox.Show("Mã ngành đã tồn tại, vui lòng chọn mã ngành khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm ngành không?",
											   "Xác nhận thêm",
											   MessageBoxButtons.YesNo,
											   MessageBoxIcon.Question);
			// Nếu người dùng chọn "Yes", thực hiện cập nhật
			if (result == DialogResult.Yes)
			{
				// Khởi tạo câu lệnh SQL UPDATE
				command = connection.CreateCommand();
				command.CommandText = "SET IDENTITY_INSERT Nganh ON; " +
									  "INSERT INTO Nganh (MaNganh, MoTa, AnhNganh) " +
									  "VALUES (@manganh, @mota, @anh)";
				// Thêm các tham số vào câu lệnh SQL 
				command.Parameters.AddWithValue("@manganh", textBox1.Text);
				command.Parameters.AddWithValue("@mota", textBox2.Text);
				command.Parameters.AddWithValue("@anh", pictureBox1.ImageLocation);
				command.ExecuteNonQuery();
				command = connection.CreateCommand();
				command.CommandText = "SELECT * FROM Nganh";
				adapter.SelectCommand = command;
				table.Clear();
				adapter.Fill(table);
				dataGridView1.DataSource = table;
			}
		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			// Khởi tạo OpenFileDialog
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
				Title = "Select an Image"
			};

			// Mở hộp thoại chọn file
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Hiển thị hình ảnh đã chọn trong PictureBox
				pictureBox1.ImageLocation = openFileDialog.FileName;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Mã ngành không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			// Khởi tạo câu lệnh SQL DELETE
			command = connection.CreateCommand();

			// Sử dụng tham số truy vấn an toàn
			command.CommandText = "DELETE FROM Nganh WHERE MaNganh = @MaNganh";

			// Gán giá trị từ TextBox vào tham số SQL
			command.Parameters.AddWithValue("@MaNganh", textBox1.Text);

			try
			{
				// Thực thi câu lệnh
				command.ExecuteNonQuery();
				MessageBox.Show("Xóa thành công!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
			finally
			{
				command.ExecuteNonQuery();
				command = connection.CreateCommand();
				command.CommandText = "SELECT * FROM Nganh";
				adapter.SelectCommand = command;
				table.Clear();
				adapter.Fill(table);
				dataGridView1.DataSource = table; // Cập nhật lại DataGridView sau khi xóa
			}// Khởi tạo câu lệnh SQL DELETE
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Mã ngành không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(textBox2.Text))
			{
				MessageBox.Show("Mô tả không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(pictureBox1.ImageLocation))
			{
				MessageBox.Show("Ảnh không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin không?",
											   "Xác nhận sửa",
											   MessageBoxButtons.YesNo,
											   MessageBoxIcon.Question);
			// Nếu người dùng chọn "Yes", thực hiện cập nhật
			if (result == DialogResult.Yes)
			{
				// Khởi tạo câu lệnh SQL UPDATE
				command = connection.CreateCommand();
				command.CommandText = "UPDATE Nganh SET MoTa=@mota, AnhNganh=@anh WHERE MaNganh=@manganh";
				// Thêm các tham số vào câu lệnh SQL 
				command.Parameters.AddWithValue("@manganh", textBox1.Text);
				command.Parameters.AddWithValue("@mota", textBox2.Text);
				command.Parameters.AddWithValue("@anh", pictureBox1.ImageLocation);
				command.ExecuteNonQuery();
				command = connection.CreateCommand();
				command.CommandText = "SELECT * FROM Nganh";
				adapter.SelectCommand = command;
				table.Clear();
				adapter.Fill(table);
				dataGridView1.DataSource = table;
			}
		}
	}
}
