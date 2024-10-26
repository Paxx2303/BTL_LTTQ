using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
namespace BTL
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}
		private void label7_Click(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void button3_Click(object sender, EventArgs e)
		{
		
			Register register = new Register();
			register.ShowDialog();
		
		}
		Modify modify = new Modify();
		private void button2_Click(object sender, EventArgs e)
		{
			

			string tentk = textBox1.Text;
			string mk = textBox2.Text;
			if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
			if(mk.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu"); }
			else
			{
				string query = "Select * from Users where Account = '" + tentk + "'and Password = '" + mk + "'";
				if (modify.TaiKhoans(query).Count != 0) 
					{
					MessageBox.Show("Đăng nhập thành công!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Tài khoản hoặc mật khẩu không đúng vui lòng kiểm tra lại!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
	}
}
