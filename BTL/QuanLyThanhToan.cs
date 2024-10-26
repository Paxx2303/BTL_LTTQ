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
    public partial class QuanLyThanhToan : Form
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
                    dgvThanhToan.DataSource = table;

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
        public QuanLyThanhToan()
        {
            InitializeComponent();

        }

        private void btnMaHoSo_Click(object sender, EventArgs e)
        {

        }

        private void btnHinhThucThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btnSoTienThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btnBienLai_Click(object sender, EventArgs e)
        {

        }

        private void dgvThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //anh Long
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            TraCuuThanhToan traCuuForm = new TraCuuThanhToan();
            traCuuForm.ShowDialog(); // Hiển thị form
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView hay không
            if (dgvThanhToan.SelectedRows.Count > 0)
            {
                // Lấy mã hồ sơ từ dòng được chọn
                string maHoSo = dgvThanhToan.SelectedRows[0].Cells["MaHoSo"].Value.ToString(); // Thay đổi tên cột nếu cần

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show($"Có muốn xóa hồ sơ có mã {maHoSo} không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                // Nếu người dùng chọn Yes
                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa hồ sơ trong cơ sở dữ liệu
                    try
                    {
                        command = new SqlCommand("DELETE FROM ThanhToan WHERE MaHoSo = @maHoSo", connection);
                        command.Parameters.AddWithValue("@maHoSo", maHoSo);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Xóa hồ sơ có mã {maHoSo} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Tải lại dữ liệu để cập nhật bảng
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hồ sơ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa hồ sơ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Nếu người dùng chọn No, không làm gì cả
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hồ sơ cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemThanhToan themThanhToanForm = new ThemThanhToan();

            // Hiển thị form ThemThanhToan
            themThanhToanForm.ShowDialog();
        }

        private void QuanLyThanhToan_Load(object sender, EventArgs e)
        {

        }
    }
}
