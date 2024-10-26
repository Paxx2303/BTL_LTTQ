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
    public partial class ThemHoTro : Form
    {
        string connect = "Data Source=DESKTOP-I2D88HI\\SQLEXPRESS;Initial Catalog=BTL_LTTQ;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public ThemHoTro()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThemHoTro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các ô nhập
            string mahoso = textBox1.Text.Trim();
            string thongtinyeucau = textBox2.Text.Trim();
            string thongtinhotro = textBox3.Text.Trim();
            string hinhthuchotro = textBox4.Text.Trim();

            // Kiểm tra các điều kiện
            if (string.IsNullOrEmpty(mahoso))
            {
                MessageBox.Show("Mã hồ sơ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(thongtinyeucau))
            {
                MessageBox.Show("Thông tin yêu cầu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }

            if (string.IsNullOrEmpty(thongtinhotro))
            {
                MessageBox.Show("Thông tin hỗ trợ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
                return;
            }

            if (string.IsNullOrEmpty(hinhthuchotro))
            {
                MessageBox.Show("Hình thức hỗ trợ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
                return;
            }

            // Hiển thị hộp thoại xác nhận thêm dữ liệu
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thêm yêu cầu hỗ trợ này không?",
                "Xác nhận thêm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)  // Nếu người dùng chọn Yes
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connect))
                    {
                        string query = "INSERT INTO HoTro (MaHoSo, ThongTinYeuCau, ThongTinHoTro, HinhThucHoTro) " +
                                       "VALUES (@MaHoSo, @ThongTinYeuCau, @ThongTinHoTro, @HinhThucHoTro)";
                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@MaHoSo", mahoso);
                        cmd.Parameters.AddWithValue("@ThongTinYeuCau", thongtinyeucau);
                        cmd.Parameters.AddWithValue("@ThongTinHoTro", thongtinhotro);
                        cmd.Parameters.AddWithValue("@HinhThucHoTro", hinhthuchotro);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         
                      
                        this.Hide();

                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thêm mới đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
