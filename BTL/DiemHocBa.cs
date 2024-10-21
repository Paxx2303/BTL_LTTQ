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
    public partial class DiemHocBa : Form
    {
        string str = "Data Source=KHABANH\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
        SqlCommand command;
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public DiemHocBa()
        {
            InitializeComponent();
        }
        public string GetMaHoSo()
        {
            return "1";
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
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
            this.Close();
        }
        private bool ValidateScore(string scoreText)
        {
            if (double.TryParse(scoreText, out double score))
            {
                return score >= 0 && score <= 10;
            }
            return false;
        }
        public string GetHanhKiem()
        {
            string diem = "";
            string maHoSo = GetMaHoSo();
            using (SqlConnection connection = new SqlConnection(str))
            {
                try
                {
                    connection.Open();
                    // Câu lệnh SQL để lấy điểm xét tuyển
                    string sql = "SELECT HanhKiemCap3 FROM HocBa WHERE MaHoSo = @MaHoSo";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                    // Thực thi câu lệnh và lấy dữ liệu
                    object result = command.ExecuteScalar();
                    diem = (string)result;
                    // Sử dụng ExecuteScalar() vì chỉ lấy một giá trị
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }
                return diem;
            }
        }
        public void txt101_Load(object sender, EventArgs e)
        {
            string maHoSo = GetMaHoSo();
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                // Câu lệnh SQL để lấy điểm xét tuyển
                string sql = "SELECT DiemKi1Lop10 FROM HocBa WHERE MaHoSo = @MaHoSo";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                // Thực thi câu lệnh và lấy dữ liệu
                object result = Convert.ToString(command.ExecuteScalar());
                txt101.Text = (string)result;
            }
        }
        public void txt102_Load(object sender, EventArgs e)
        {
            string maHoSo = GetMaHoSo();
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                // Câu lệnh SQL để lấy điểm xét tuyển
                string sql = "SELECT DiemKi2Lop10 FROM HocBa WHERE MaHoSo = @MaHoSo";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                // Thực thi câu lệnh và lấy dữ liệu
                object result = Convert.ToString(command.ExecuteScalar());
                txt102.Text = (string)result;
            }
        }
        public void txt111_Load(object sender, EventArgs e)
        {
            string maHoSo = GetMaHoSo();
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                // Câu lệnh SQL để lấy điểm xét tuyển
                string sql = "SELECT DiemKi1Lop11 FROM HocBa WHERE MaHoSo = @MaHoSo";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                // Thực thi câu lệnh và lấy dữ liệu
                object result = Convert.ToString(command.ExecuteScalar());
                txt111.Text = (string)result;
            }
        }
        public void txt112_Load(object sender, EventArgs e)
        {
            string maHoSo = GetMaHoSo();
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                // Câu lệnh SQL để lấy điểm xét tuyển
                string sql = "SELECT DiemKi2Lop11 FROM HocBa WHERE MaHoSo = @MaHoSo";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                // Thực thi câu lệnh và lấy dữ liệu
                object result = Convert.ToString(command.ExecuteScalar());
                txt112.Text = (string)result;
            }
        }
        public void txt121_Load(object sender, EventArgs e)
        {
            string maHoSo = GetMaHoSo();
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                // Câu lệnh SQL để lấy điểm xét tuyển
                string sql = "SELECT DiemKi1Lop12 FROM HocBa WHERE MaHoSo = @MaHoSo";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                // Thực thi câu lệnh và lấy dữ liệu
                object result = Convert.ToString(command.ExecuteScalar());
                txt121.Text = (string)result;
            }
        }
        public void txt122_Load(object sender, EventArgs e)
        {
            string maHoSo = GetMaHoSo();
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                // Câu lệnh SQL để lấy điểm xét tuyển
                string sql = "SELECT DiemKi2Lop12 FROM HocBa WHERE MaHoSo = @MaHoSo";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                // Thực thi câu lệnh và lấy dữ liệu
                object result = Convert.ToString(command.ExecuteScalar());
                txt122.Text = (string)result;
            }
        }
        public void txtDiemThi_Load(object sender, EventArgs e)
        {
            string maHoSo = GetMaHoSo();
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                // Câu lệnh SQL để lấy điểm xét tuyển
                string sql = "SELECT DiemXetTuyen FROM HocBa WHERE MaHoSo = @MaHoSo";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                // Thực thi câu lệnh và lấy dữ liệu
                object result = Convert.ToString(command.ExecuteScalar());
                txtDiemThi.Text = (string)result;
            }
        }
        public void txtHanhKiem_Load(object sender, EventArgs e)
        {
            string a = GetHanhKiem();
            txtHanhKiem.Text = a.ToString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            if (!ValidateScore(txt101.Text) || !ValidateScore(txt102.Text) ||
               !ValidateScore(txt111.Text) || !ValidateScore(txt112.Text) ||
               !ValidateScore(txt121.Text) || !ValidateScore(txt122.Text))
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string mahoso = GetMaHoSo();
            if (string.IsNullOrWhiteSpace(txt101.Text)
                || string.IsNullOrWhiteSpace(txt102.Text)
                || string.IsNullOrWhiteSpace(txt111.Text)
                || string.IsNullOrWhiteSpace(txt112.Text)
                || string.IsNullOrWhiteSpace(txt121.Text)
                || string.IsNullOrWhiteSpace(txt121.Text))
            {
                MessageBox.Show("Điểm không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Khởi tạo câu lệnh SQL UPDATE
            command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM HocBa WHERE MaHoSo = @mahoso";
            command.Parameters.AddWithValue("@mahoso", GetMaHoSo());
            int count = (int)command.ExecuteScalar();
            if (count > 0)
            {
               if (!ValidateScore(txt101.Text) || !ValidateScore(txt102.Text) ||
              !ValidateScore(txt111.Text) || !ValidateScore(txt112.Text) ||
              !ValidateScore(txt121.Text) || !ValidateScore(txt122.Text))
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật điểm không?",
                                               "Xác nhận cập nhật",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

                // Nếu người dùng chọn "Yes", thực hiện cập nhật
                if (result == DialogResult.Yes)
                {
                    // Khởi tạo câu lệnh SQL UPDATE
                    command = connection.CreateCommand();
                    command.CommandText = "UPDATE HocBa SET DiemKi1Lop10 = @101, DiemKi2Lop10 = @102, DiemKi1Lop11 = @111, DiemKi2Lop11 = @112, DiemKi1Lop12 = @121, DiemKi2Lop12 = @122, DiemXetTuyen = @dxt, HanhKiemCap3 = @hanhkiem" +
                                          " " + "WHERE MaHoSo = @mahoso";
                    // Thêm các tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@mahoso", mahoso);
                    command.Parameters.AddWithValue("@101", txt101.Text);
                    command.Parameters.AddWithValue("@102", txt102.Text);
                    command.Parameters.AddWithValue("@111", txt111.Text);
                    command.Parameters.AddWithValue("@112", txt112.Text);
                    command.Parameters.AddWithValue("@121", txt121.Text);
                    command.Parameters.AddWithValue("@122", txt122.Text);
                    command.Parameters.AddWithValue("@dxt", txtDiemThi.Text);
                    command.Parameters.AddWithValue("@hanhkiem", txtHanhKiem.Text);
                    command.ExecuteNonQuery();
                }
                else
                {
                    command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO HocBa (MaHoSo, DiemKi1Lop10, DiemKi2Lop10, DiemKi1Lop11, DiemKi2Lop11, DiemKi1Lop12, DiemKi2Lop12, HanhKiemCap3, DiemXetTuyen )" +
                                          "VALUES (@mahoso, @101, @102, @111, @112, @121, @122, @hanhkiem, @Dxt)";
                    // Thêm các tham số vào câu lệnh SQL 
                    command.Parameters.AddWithValue("@mahoso", mahoso);
                    command.Parameters.AddWithValue("@101", txt101.Text);
                    command.Parameters.AddWithValue("@102", txt102.Text);
                    command.Parameters.AddWithValue("@111", txt111.Text);
                    command.Parameters.AddWithValue("@112", txt112.Text);
                    command.Parameters.AddWithValue("@121", txt121.Text);
                    command.Parameters.AddWithValue("@122", txt122.Text);
                    command.Parameters.AddWithValue("@Dxt", txtDiemThi.Text);
                    command.Parameters.AddWithValue("@hanhkiem", txtHanhKiem.Text);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInterface userInterface = new UserInterface();
            userInterface.ShowDialog();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            NguyenVong nguyenVong = new NguyenVong();
            nguyenVong.ShowDialog();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.ShowDialog();
            this.Close();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
