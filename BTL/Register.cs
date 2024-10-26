using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BTL
{
	public partial class Register : Form
	{
		public Register()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		public bool	CheckAccount(string ac)
		{
			return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
		}
		Modify modify = new Modify();
		private void button3_Click(object sender, EventArgs e)
		{
			string tentk = txt1.Text;
			string mk1 = txt2.Text;
			string mk2 = txt3.Text;

			if (!CheckAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoan dài 6 - 24 ký tự");return; }

			if(!CheckAccount(mk1)) { MessageBox.Show("Vui lòng nhập tên mật khẩu dài 6 - 24 ký tự"); return; }
			if (!CheckAccount(mk2)) { MessageBox.Show("Vui lòng xác nhận mật khẩu"); return; }
			try
			{
				string query = " Insert into Users values ( '" + tentk + "','" + mk1 + "')";
				modify.Command(query);
				if (MessageBox.Show("Đăng kí thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
				{
					this.Close();
				}
			}
			catch
			{
				MessageBox.Show("Tài khoản này đã được đăng kí vui lòng đăng kí tài khoản khác!");
			}
		}
	}
}
