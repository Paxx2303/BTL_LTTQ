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
    public partial class SuaHoTro : Form
    {

        string connect = "Data Source=DESKTOP-I2D88HI\\SQLEXPRESS;Initial Catalog=BTL_LTTQ;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public SuaHoTro(string mahoso, string thongtinyeucau, string thongtinhotro, string hinhthuc)
        {
            InitializeComponent();
            label5.Text = mahoso;
            textBox2.Text = thongtinyeucau;
            textBox3.Text = thongtinhotro;
            textBox4.Text = hinhthuc;

        }

        private void SuaHoTro_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connect);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mahoso = label5.Text;
            string thongtinyeucau = textBox2.Text;
            string thongtinhotro = textBox3.Text;
            string hinhthuc = textBox4.Text;
            string query = "UPDATE HoTro " +
                       "SET ThongTinYeuCau = @ThongTinYeuCau, " +
                       "ThongTinHoTro = @ThongTinHoTro, " +
                       "HinhThucHoTro = @HinhThucHoTro " +
                       "WHERE MaHoSo = @MaHoSo";

            SqlCommand cmd = new SqlCommand(query, con);

            // Thêm tham số vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@MaHoSo", mahoso);
            cmd.Parameters.AddWithValue("@ThongTinYeuCau", thongtinyeucau);
            cmd.Parameters.AddWithValue("@ThongTinHoTro", thongtinhotro);
            cmd.Parameters.AddWithValue("@HinhThucHoTro", hinhthuc);

            try
            {
                // Mở kết nối
                con.Open();

                // Thực hiện câu lệnh SQL và kiểm tra số hàng được cập nhật
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không có thay đổi nào được thực hiện hoặc mã hồ sơ không tồn tại.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show($"Lỗi khi cập nhật thông tin: {ex.Message}", "Lỗi");
            }
        }
    }
    
}
