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
    public partial class QuanLyHoTro : Form
    {
        string connect = "Data Source=DESKTOP-I2D88HI\\SQLEXPRESS;Initial Catalog=BTL_LTTQ;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public void Loaddata()
        {
            con.Open();
            cmd = new SqlCommand("select * from HoTro", con);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public QuanLyHoTro()
        {
            InitializeComponent();
        }

        private void QuanLyHoTro_Load(object sender, EventArgs e)
        {
            button11.Enabled = false;
            con = new SqlConnection(connect);
            Loaddata();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button11.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ThemHoTro themhotro = new ThemHoTro();
            themhotro.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

                    // Lấy giá trị từ ô "MaHoSo"
                    object cellValue = dataGridView1.Rows[selectedRowIndex].Cells["MaHoSo"].Value;

                    if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                    {
                        string maHoSo = cellValue.ToString();

                        // Xác nhận xóa
                        DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa hồ sơ {maHoSo} không?",
                                                              "Xác nhận xóa",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            // Thực hiện kết nối cơ sở dữ liệu và xóa bản ghi
                            using (SqlConnection conn = new SqlConnection(connect))
                            {
                                string query = "DELETE FROM HoTro WHERE MaHoSo = @MaHoSo";
                                SqlCommand cmd = new SqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@MaHoSo", maHoSo);

                                conn.Open();
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Xóa thành công!", "Thông báo");
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy hồ sơ cần xóa.", "Thông báo");
                                }

                                // Tải lại dữ liệu sau khi xóa
                                Loaddata();
                                button11.Enabled=false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu ô MaHoSo không hợp lệ.", "Lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một ô hợp lệ.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }
        private void TimKiemHoSo(string maHoSo)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string query = "SELECT * FROM HoTro WHERE MaHoSo = @MaHoSo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHoSo", maHoSo);

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Hiển thị kết quả trong DataGridView
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hồ sơ.", "Thông báo");
                        dataGridView1.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                }
            }
        }



        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

                string maHoSo = row.Cells["MaHoSo"].Value.ToString();
                string thongTinYeuCau = row.Cells["ThongTinYeuCau"].Value.ToString();
                string thongTinHoTro = row.Cells["ThongTinHoTro"].Value.ToString();
                string hinhThucHoTro = row.Cells["HinhThucHoTro"].Value.ToString();

                SuaHoTro suaForm = new SuaHoTro(maHoSo, thongTinYeuCau, thongTinHoTro, hinhThucHoTro);
                suaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một ô để sửa.", "Thông báo");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string maHoSo = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(maHoSo))
            {
                MessageBox.Show("Vui lòng nhập mã hồ sơ.", "Thông báo");
                return;
            }

            TimKiemHoSo(maHoSo);
        }

        
    }
}
