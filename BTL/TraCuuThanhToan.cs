using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BTL
{
	public partial class TraCuuThanhToan : Form
	{
		SqlConnection connection;
		SqlCommand command;

		string str = "Data Source=LAPTOP-GLB1HFJ9\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable table = new DataTable();

		public void LoadData()
		{
			if (connection.State == ConnectionState.Open)
			{
				command = connection.CreateCommand();
				command.CommandText = "SELECT * FROM ThanhToan";
				try
				{
					adapter.SelectCommand = command;
					table.Clear();
					adapter.Fill(table);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Kết nối cơ sở dữ liệu chưa được mở.");
			}
		}

		public TraCuuThanhToan()
		{
			InitializeComponent();
			connection = new SqlConnection(str);
			try
			{
				connection.Open();
				LoadData();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi mở kết nối: " + ex.Message);
			}
		}

		private void TraCuuThanhToan_Load(object sender, EventArgs e)
		{

		}

		// Sự kiện click nút Tìm kiếm
		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			
		}

		private void txtMaHoSo_TextChanged(object sender, EventArgs e)
		{
			// Logic xử lý khi nội dung TextBox MaHoSo thay đổi (nếu cần)
		}

		private void txtSoTienThanhToan_TextChanged(object sender, EventArgs e)
		{
			// Logic xử lý khi nội dung TextBox SoTienThanhToan thay đổi (nếu cần)
		}

		private void txtHinhThucThanhToan_TextChanged(object sender, EventArgs e)
		{
			// Logic xử lý khi nội dung TextBox HinhThucThanhToan thay đổi (nếu cần)
		}

		private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Bỏ qua sự kiện này nếu không cần
		}

		private void btnTimKiem_Click_1(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtNhapMaHoSo.Text))
			{
				MessageBox.Show("Vui lòng nhập mã hồ sơ để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtNhapMaHoSo.Focus();
				return;
			}

			try
			{
				using (SqlConnection connection = new SqlConnection(str))
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand("SELECT MaHoSo, HinhThucThanhToan, SoTienThanhToan, BienLai FROM ThanhToan WHERE MaHoSo = @maHoSo", connection))
					{
						// Sử dụng txtNhapMaHoSo.Text ở đây
						command.Parameters.AddWithValue("@maHoSo", Convert.ToInt32(txtNhapMaHoSo.Text)); // Chuyển đổi nếu cần

						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read()) // Nếu tìm thấy bản ghi
							{
								// Hiển thị kết quả lên TextBox
								txtMaHoSo.Text = reader["MaHoSo"].ToString();
								txtHinhThucThanhToan.Text = reader["HinhThucThanhToan"].ToString();
								txtSoTienThanhToan.Text = reader["SoTienThanhToan"].ToString();

								// Xử lý ảnh biên lai
								string imagePath = reader["BienLai"].ToString();
								try
								{
									if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
									{
										pbBienLai.Image = Image.FromFile(imagePath); // Hiển thị ảnh từ đường dẫn
									}
									else
									{
										pbBienLai.Image = null; // Nếu không có ảnh, đặt PictureBox về null
										MessageBox.Show("Không tìm thấy tệp ảnh hoặc đường dẫn không hợp lệ.");
									}
								}
								catch (Exception ex)
								{
									MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
									pbBienLai.Image = null; // Đặt về null nếu có lỗi
								}
							}
							else
							{
								MessageBox.Show("Không tìm thấy mã hồ sơ trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


	}
}
