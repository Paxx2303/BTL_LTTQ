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
	public partial class ThemThanhToan : Form
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
					dgvThongTin.DataSource = table;

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
		private void Form1_Load(object sender, EventArgs e)
		{
			connection = new SqlConnection(str);
			connection.Open();
			LoadData();
		}
		public ThemThanhToan()
		{
			InitializeComponent();
		}

		private void ThemThanhToan_Load(object sender, EventArgs e)
		{

		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			// Kiểm tra thông tin nhập
			if (string.IsNullOrWhiteSpace(txtMaHoSo.Text))
			{
				MessageBox.Show("Vui lòng nhập mã hồ sơ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMaHoSo.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(txtHinhThucThanhToan.Text))
			{
				MessageBox.Show("Vui lòng nhập hình thức thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtHinhThucThanhToan.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(txtSoTienThanhToan.Text))
			{
				MessageBox.Show("Vui lòng nhập số tiền thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtSoTienThanhToan.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(txtBienLai.Text))
			{
				MessageBox.Show("Vui lòng nhập biên lai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtBienLai.Focus();
				return;
			}

			// Kiểm tra xem MaHoSo nhập vào có khác với MaHoSo đã có trong bảng ThanhToan không
			try
			{
				connection = new SqlConnection(str);
				connection.Open();

				// Kiểm tra xem MaHoSo đã có trong bảng ThanhToan không
				command = new SqlCommand("SELECT COUNT(*) FROM ThanhToan WHERE MaHoSo = @maHoSo", connection);
				command.Parameters.AddWithValue("@maHoSo", txtMaHoSo.Text);

				int count = (int)command.ExecuteScalar(); // Lấy số lượng bản ghi

				if (count > 0)
				{
					MessageBox.Show("Mã hồ sơ đã tồn tại trong bảng ThanhToan. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtMaHoSo.Focus();
					return;
				}

				// Thêm dữ liệu vào cơ sở dữ liệu
				command = new SqlCommand("INSERT INTO ThanhToan (MaHoSo, HinhThucThanhToan, SoTienThanhToan, BienLai) VALUES (@maHoSo, @hinhThuc, @soTien, @bienLai)", connection);
				command.Parameters.AddWithValue("@maHoSo", txtMaHoSo.Text);
				command.Parameters.AddWithValue("@hinhThuc", txtHinhThucThanhToan.Text);
				command.Parameters.AddWithValue("@soTien", decimal.Parse(txtSoTienThanhToan.Text));
				command.Parameters.AddWithValue("@bienLai", txtBienLai.Text);

				int rowsAffected = command.ExecuteNonQuery(); // Thực hiện câu lệnh thêm

				if (rowsAffected > 0)
				{
					MessageBox.Show("Thêm thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadData(); // Gọi lại hàm LoadData để làm mới dữ liệu trên DataGridView
				}
				else
				{
					MessageBox.Show("Thêm thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thêm thông tin: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (connection.State == ConnectionState.Open)
				{
					connection.Close(); // Đóng kết nối
				}
			}
		}

		private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void txtMaHoSo_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtHinhThucThanhToan_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtSoTienThanhToan_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtBienLai_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
