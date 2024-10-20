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
    public partial class ThongTinVeNguyenVong : Form
    {
        string str = "Data Source=KHABANH\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
        SqlCommand command;
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public ThongTinVeNguyenVong()
        {
            InitializeComponent();
        }
        private void ThongTinVeNguyenVong_Load(object sender, EventArgs e)
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
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.ShowDialog();
            this.Close();
        }
        private void button9_Click(object sender, EventArgs e)
        {

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
