using CuaHangBanThucAn.BLL;
using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB.Error;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanThucAn.GUI
{
    public partial class LoginForm : Form
    {
        public static string emailpattern = @"^([a-zA-Z0-9_\-]+@[a-zA-Z0-9_\-]+\.[a-zA-Z0-9]{2,6})$";
        public bool had_login = false;
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }


        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length == 0) lbError.Visible = false;
            lbError.Visible = (Regex.IsMatch(txtEmail.Text, emailpattern)) ? false : true;
        }

        private void ckboxShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = (ckboxShow.Checked) ? false : true;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!had_login)
            {
                var result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            Application.Exit();
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                txtPassword.Focus();
            }

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                txtEmail.Focus();
            }

        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Thực hiện đăng nhập
                login();
            }
        }
        private void login()
        {
            try
            {
                if (txtEmail.Text.Length == 0)
                {
                    throw new AppException(101, "Email không được để trống");
                }
                if (txtPassword.Text.Length == 0)
                {
                    throw new AppException(101, "Password không được để trống");
                }
                if (!Regex.IsMatch(txtEmail.Text, emailpattern))
                {
                    throw new AppException(101, "Email không hợp lệ");
                }
                LoginBLL loginBLL = new LoginBLL();
                Account account = new Account(txtEmail.Text, txtPassword.Text);
                account = loginBLL.LoginAccount(account);
                if (account.id == -1)
                {
                    throw new AppException(101, "Email hoặc password không chính xác");
                }
                had_login = true;
                this.Hide();
                HomeForm homeForm = new HomeForm();
                homeForm.Show();

            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
