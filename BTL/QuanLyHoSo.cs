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

namespace BTL
{

    public partial class QuanLyHoSo : Form
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM HoTro", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void DeleteHoSo(string MaHoSo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM HoSo WHERE MaHoSo = @MaHoSo";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa hồ sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra khi xóa hồ sơ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa hồ sơ từ cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Loaddata()
        {
            con.Open();
            cmd = new SqlCommand("select * from HoSo", con);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        public QuanLyHoSo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                string MaHoSo = selectedRow.Cells["MaHoSo"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hồ sơ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteHoSo(MaHoSo);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hồ sơ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void QuanLyHoSo_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connect);
            Loaddata();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ThemHoSo _themhoso = new ThemHoSo();
            _themhoso.ShowDialog();

        }
    }
}
