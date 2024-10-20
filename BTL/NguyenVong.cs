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
    public partial class NguyenVong : Form
    {
        public NguyenVong()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInterface HoSo = new UserInterface();
            HoSo.ShowDialog();
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
            this.Close();
            
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.ShowDialog();
            this.Close();
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
