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
    public partial class ThemHoSo : Form
    {
        string connect = "Data Source=KHABANH\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM HoSo", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
               
            }
        }
        private void AddHoSo()
        {
            string MaHoSo = textBox1.Text;
            string HoTen = textBox2.Text;
            string DiaChi = textBox3.Text;
            string SDT = textBox4.Text;
            string GioiTinh = textBox5.Text;
            string NgaySinh = textBox6.Text;
            string AnhHoSo = textBox7.Text;

            if (DateTime.TryParseExact(NgaySinh, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime NgaySinhDate))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connect))
                    {
                        connection.Open();

                        string insertQuery = "SET IDENTITY_INSERT HoSo ON; " +
                                             "INSERT INTO HoSo (MaHoSo, HoTen, DiaChi, SoDienThoai, GioiTinh, NgaySinh, AnhHoSo) " +
                                             "VALUES (@MaHoSo, @HoTen, @DiaChi, @SoDienThoai, @GioiTinh, @NgaySinh, @AnhHoSo)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
                            cmd.Parameters.AddWithValue("@HoTen", HoTen);
                            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                            cmd.Parameters.AddWithValue("@SoDienThoai", SDT);
                            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinhDate);
                            cmd.Parameters.AddWithValue("@AnhHoSo", AnhHoSo);

                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Thêm hồ sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();
                                textBox4.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                                textBox7.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi xảy ra khi thêm hồ sơ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm hồ sơ vào cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Định dạng ngày sinh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public ThemHoSo()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            // Kiểm tra nếu người dùng chọn file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file ảnh
                string imagePath = openFileDialog.FileName;
                textBox7.Text = imagePath;
                // Gán ảnh vào PictureBox
                pictureBox1.Image = new System.Drawing.Bitmap(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Đặt chế độ hiển thị ảnh vừa với PictureBox
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MaHoSo = textBox1.Text;
            string HoTen = textBox2.Text;
            string DiaChi = textBox3.Text;
            string SDT = textBox4.Text;
            string GioiTinh = textBox5.Text;
            string NgaySinh = textBox6.Text;
            string AnhHoSo = textBox7.Text;

            try
            {
                // Chuỗi kết nối tới SQL Server
                SqlConnection connection = new SqlConnection(connect);

                // Sử dụng "using" để đảm bảo kết nối được đóng khi kết thúc
                using (connection)
                {
                    connection.Open();

                    // Câu truy vấn kiểm tra mã hồ sơ
                    string query = "SELECT COUNT(*) FROM HoSo WHERE MaHoSo = @MaHoSo";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);

                    // Thực thi câu lệnh và nhận kết quả
                    int count = (int)cmd.ExecuteScalar();

                    // Kiểm tra kết quả
                    if (count > 0)
                    {
                        MessageBox.Show("Đã tồn tại mã hồ sơ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Clear();
                        textBox1.Focus(); 
                    }
                    else
                    {
                        AddHoSo();
                    }
                }
            }
            catch (Exception ex)
            {
                // Bắt lỗi và hiển thị thông báo
                MessageBox.Show("Lỗi khi kiểm tra mã hồ sơ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ThemHoSo_Load(object sender, EventArgs e)
        {
        }
    }
}
