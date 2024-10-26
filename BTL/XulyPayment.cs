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
    public partial class XulyPayment : Form
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

                    // Đảm bảo DataTable có cấu trúc đúng với bảng ThanhToan
                    if (table.Columns.Count == 0)
                    {
                        table.Columns.Add("MaHoSo", typeof(string));
                        table.Columns.Add("SoTienThanhToan", typeof(decimal));
                        table.Columns.Add("HinhThucThanhToan", typeof(string));
                        table.Columns.Add("BienLai", typeof(string));
                    }

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
            try
            {
                connection = new SqlConnection(str);
                connection.Open();
                MessageBox.Show("Kết nối thành công!"); // Thông báo khi kết nối thành công
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở kết nối: " + ex.Message); // Bắt lỗi nếu kết nối không thành công
            }
        }
        private string _hinhThucThanhToan;

        public XulyPayment()
        {
            InitializeComponent();

        }

        public XulyPayment(string hinhThucThanhToan)
        {
            InitializeComponent();
            _hinhThucThanhToan = hinhThucThanhToan;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void XulyPayment_Load(object sender, EventArgs e)
        {
            txtHinhThucThanhToan.Text = _hinhThucThanhToan;
        }

        private void txtMaHoSo_TextChanged(object sender, EventArgs e)
        {
            string maHoSo = txtMaHoSo.Text;
            // Kiểm tra có ký tự đặc biệt hay không (không bao gồm chữ cái, số, dấu gạch ngang và dấu gạch dưới)
            if (System.Text.RegularExpressions.Regex.IsMatch(maHoSo, @"[^a-zA-Z0-9_-]"))
            {
                MessageBox.Show("Mã hồ sơ không được chứa ký tự đặc biệt như .,;@.");
                txtMaHoSo.Focus(); // Trả focus về textbox mã hồ sơ
                txtMaHoSo.SelectAll(); // Chọn toàn bộ văn bản để người dùng có thể nhập lại
            }
        }

        private void txtHinhThucThanhToan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoTienThanhToan_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtSoTienThanhToan.Text, out double soTienThanhToan))
            {
                if (soTienThanhToan < 0)
                {
                    MessageBox.Show("Số tiền thanh toán không được là số âm.");
                    txtSoTienThanhToan.Focus(); // Trả focus về textbox
                    txtSoTienThanhToan.SelectAll(); // Chọn toàn bộ văn bản để người dùng có thể nhập lại
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường dữ liệu bắt buộc
            if (string.IsNullOrEmpty(txtMaHoSo.Text))
            {
                MessageBox.Show("Bạn phải nhập mã hồ sơ.");
                txtMaHoSo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSoTienThanhToan.Text) || !double.TryParse(txtSoTienThanhToan.Text, out double soTienThanhToan) || soTienThanhToan < 0)
            {
                MessageBox.Show("Bạn phải nhập số tiền thanh toán hợp lệ.");
                txtSoTienThanhToan.Focus();
                return;
            }

            // Kiểm tra nếu ảnh biên lai chưa được chọn
            if (connection == null || connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open(); // Cố gắng mở kết nối lại nếu bị đóng
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở kết nối trước khi lưu: " + ex.Message);
                    return; // Dừng lại nếu không thể mở kết nối
                }
            }

            // Đảm bảo kết nối đã mở
            if (connection == null || connection.State != ConnectionState.Open) // Đã thêm kiểm tra kết nối trước khi lưu
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu chưa được mở.");
                return;
            }

            // Chèn dữ liệu vào cơ sở dữ liệu
            try
            {
                // Khởi tạo command với câu lệnh SQL
                command = new SqlCommand("INSERT INTO ThanhToan (MaHoSo, SoTienThanhToan, HinhThucThanhToan, BienLai) VALUES (@MaHoSo, @SoTienThanhToan, @HinhThucThanhToan, @BienLai)", connection);

                // Thêm tham số cho lệnh SQL
                command.Parameters.AddWithValue("@MaHoSo", txtMaHoSo.Text);
                command.Parameters.AddWithValue("@SoTienThanhToan", soTienThanhToan);
                command.Parameters.AddWithValue("@HinhThucThanhToan", txtHinhThucThanhToan.Text);
                command.Parameters.AddWithValue("@BienLai", pbBienLai.Tag.ToString()); // Đường dẫn ảnh

                command.ExecuteNonQuery(); // Thực thi câu lệnh SQL

                MessageBox.Show("Dữ liệu đã được lưu thành công!");

                // Sau khi lưu, tải lại dữ liệu vào DataGridView
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        private void pbBienLai_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Chọn ảnh biên lai";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị đường dẫn ảnh đã chọn lên biên lai
                    pbBienLai.Image = Image.FromFile(openFileDialog.FileName);
                    pbBienLai.Tag = openFileDialog.FileName; // Lưu đường dẫn ảnh vào tag của PictureBox để dùng sau
                }
            }
        }

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
