using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{ 
    public partial class QuanLyNganhHoc : Form
    {
      
        public QuanLyNganhHoc()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyHoSo_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHoSo register = new QuanLyHoSo();
            register.ShowDialog();
            this.Close();
        }

        private void btnQuanLyThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyThanhToan register = new QuanLyThanhToan();
            register.ShowDialog();
            this.Close();
        }

        private void btnQuanLyChiTieuNganh_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyChiTieuNganh register = new QuanLyChiTieuNganh();
            register.ShowDialog();
            this.Close();
        }

        private void btnQuanLyHoTro_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHoTro register = new QuanLyHoTro();
            register.ShowDialog();
            this.Close();
        }
    }
}
