using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace BTL
{
    public partial class NguyenVong : Form
    {
        string str = "Data Source=DESKTOP-I2D88HI\\SQLEXPRESS;Initial Catalog=BTL_LTTQ;Integrated Security=True;"; SqlCommand command;
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public NguyenVong()
        {
            InitializeComponent();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInterface HoSo = new UserInterface();
            HoSo.ShowDialog();
            this.Close();
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
            this.Close();

        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.ShowDialog();
            this.Close();
        }
        private void btnSupport_Click(object sender, EventArgs e)
        {

        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
        private void btnPreferences_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void NguyenVong_Load(object sender, EventArgs e)
        {
            string mahoso = GetMaHoSo();
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT MaNganh, DiemXetTuyen FROM XetTuyen WHERE MaHoSo='" + mahoso + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNganh.Text))
            {
                MessageBox.Show("Mã ngành không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Hiển thị hộp thoại xác nhận xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa nguyện vọng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Nếu người dùng chọn Yes, thực hiện lệnh xóa
                command = connection.CreateCommand();

                // Sử dụng tham số truy vấn an toàn
                command.CommandText = "DELETE FROM XetTuyen WHERE MaNganh = @MaNganh";

                // Gán giá trị từ TextBox vào tham số SQL
                command.Parameters.AddWithValue("@MaNganh", txtMaNganh.Text);
                try
                {
                    // Thực thi câu lệnh
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa nguyện vọng thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    // Cập nhật lại DataGridView sau khi xóa
                    command = connection.CreateCommand();
                    command.CommandText = "SELECT MaNganh, DiemXetTuyen FROM XetTuyen";
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            else
            {
                // Nếu người dùng chọn No, không thực hiện xóa
                MessageBox.Show("Xóa nguyện vọng đã bị hủy.");
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo RowIndex không âm
            {
                int i = e.RowIndex; // Lấy chỉ số hàng
                txtMaNganh.Text = dataGridView1.Rows[i].Cells[0].Value.ToString(); // Lấy giá trị từ cột 0
                                                                                   // Nếu bạn muốn lấy giá trị từ cột 1, bạn có thể thêm dòng sau
                string tenNganh = dataGridView1.Rows[i].Cells[1].Value.ToString(); // Lấy giá trị từ cột 1
                                                                                   // Bạn có thể hiển thị tenNganh trong một TextBox hoặc xử lý nó theo cách bạn muốn
            }
        }
        public string GetMaHoSo()
        {
            return "1";
        }
        public float GetDiemXetTuyen()
        {
            float diemXetTuyen = 0;
            string maHoSo = GetMaHoSo();
            using (SqlConnection connection = new SqlConnection(str))
            {
                try
                {
                    connection.Open();

                    // Câu lệnh SQL để lấy điểm xét tuyển
                    string sql = "SELECT DiemXetTuyen FROM HocBa WHERE MaHoSo = @MaHoSo";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaHoSo", maHoSo);

                    // Thực thi câu lệnh và lấy dữ liệu
                    object result = command.ExecuteScalar(); // Sử dụng ExecuteScalar() vì chỉ lấy một giá trị

                    if (result != null)
                    {
                        diemXetTuyen = Convert.ToSingle(result); // Chuyển đổi kết quả sang float
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }
            }
            return diemXetTuyen;
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string mahoso = GetMaHoSo();
            float dxt = GetDiemXetTuyen();
            if (string.IsNullOrWhiteSpace(txtMaNganh.Text))
            {
                MessageBox.Show("Mã ngành không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM XetTuyen WHERE MaNganh = @manganh";
            command.Parameters.AddWithValue("@manganh", txtMaNganh.Text);
            int count = (int)command.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Mã ngành đã tồn tại, vui lòng chọn mã ngành khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm nguyện vọng không?",
                                               "Xác nhận thêm nguyện vọng",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
            // Nếu người dùng chọn "Yes", thực hiện cập nhật
            if (result == DialogResult.Yes)
            {
                // Khởi tạo câu lệnh SQL UPDATE
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO XetTuyen (MaHoSo, MaNganh, DiemXetTuyen) " +
                                  "VALUES (@mahoso,@manganh, @dxt)";
                // Thêm các tham số vào câu lệnh SQL 
                command.Parameters.AddWithValue("@mahoso", mahoso);
                command.Parameters.AddWithValue("@dxt", dxt);
                command.Parameters.AddWithValue("@manganh", txtMaNganh.Text);
                command.ExecuteNonQuery();
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaNganh, DiemXetTuyen FROM XetTuyen";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinVeNguyenVong tt = new ThongTinVeNguyenVong();
            tt.ShowDialog();
            this.Close();
        }
        public string GetHoTen()
        {
            string hoten = "";
            string maHoSo = GetMaHoSo();
            using (SqlConnection connection = new SqlConnection(str))
            {
                try
                {
                    connection.Open();
                    // Câu lệnh SQL để lấy điểm xét tuyển
                    string sql = "SELECT HoTen FROM HoSo WHERE MaHoSo = @MaHoSo";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                    // Thực thi câu lệnh và lấy dữ liệu
                    object result = command.ExecuteScalar();
                    hoten = (string)result;
                    // Sử dụng ExecuteScalar() vì chỉ lấy một giá trị
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }
            }
            return hoten;
        }
        private void lblTen_Load(object sender, EventArgs e)
        {
            string hoten = GetHoTen();
            label1.Text = hoten; // Hiển thị với 2 chữ số thập phân
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
