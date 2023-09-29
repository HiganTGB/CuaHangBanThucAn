using CuaHangBanThucAn.BLL;
using CuaHangBanThucAn.GUI.Sale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanThucAn.GUI
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            init();
            btnGo(0);
        }
        private void init()
        {

            lbName.Text = LoginBLL.UserLogin.name;
            lbRole.Text = LoginBLL.UserLogin.role.name;
            if (LoginBLL.UserLogin.role.permission == "ADMIN")
            {
                btnSell.Hide();
            }

            if (LoginBLL.UserLogin.role.permission == "STAFF")
            {
                btnRole.Hide();
                btnType.Hide();
                btnAccount.Hide();
                btnStatistic.Hide();
            }

        }
        private void reset()
        {
            ucAccount1.Hide();
            ucFood1.Hide();
            ucHome1.Hide();
            ucRole1.Hide();
            ucRole1.Hide();
            ucTypeProduct1.Hide();
            ucSell1.Hide();
            ucBill1.Hide();
            ucRevenue1.Hide();
        }
        private void btnGo(int i)
        {
            reset();
            switch (i)
            {
                case 0:
                    ucHome1.Show();
                    break;
                case 1:
                    ucFood1.Show();
                    break;
                case 2:
                    ucAccount1.Show();
                    break;
                case 3:
                    ucRole1.Show();
                    break;
                case 4:
                    ucTypeProduct1.Show();
                    break;
                case 5:
                    ucSell1.Show();
                    break;
                case 6:
                    ucBill1.Show();
                    break;
                case 7:
                    ucRevenue1.Show();
                    break;
            }
        }
        private void panel_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnGo(0);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            btnGo(5);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            btnGo(1);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            btnGo(6);
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            btnGo(4);
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            btnGo(3);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            btnGo(2);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            btnGo(7);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            ChangePassword password = new ChangePassword(LoginBLL.UserLogin.id);
            password.Show();
        }
    }
}
