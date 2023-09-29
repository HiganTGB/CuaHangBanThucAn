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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanThucAn.GUI.Sale
{
    public partial class ChangePassword : Form
    {
        public ChangePassword(int id)
        {
            AccountBLL accountBLL = new AccountBLL();
            Account account = accountBLL.Read(id);
            InitializeComponent();
            txtName.Text = account.name;
            txtID.Text = account.id.ToString();
            txtRole.Text = account.role.name.ToString();
            txtEmail.Text = account.email;
            txtPass.UseSystemPasswordChar = true;
            txtConfirm.UseSystemPasswordChar = true;
            txtNewPass.UseSystemPasswordChar = true;
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                txtNewPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text.Length == 0)
                {
                    throw new AppException(1, "Mật khẩu không được để trống");
                }
                if (txtNewPass.Text.Length == 0)
                {
                    throw new AppException(1, "Mật khẩu mới không được để trống");
                }
                if (txtConfirm.Text.Length == 0)
                {
                    throw new AppException(2, "Xác nhận mật khẩu không được để trống");
                }
                if (txtNewPass.Text != txtConfirm.Text)
                {
                    throw new AppException(2, "Xác nhận mật khẩu không chính xác");
                }
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đổi mật khẩu không?", "Xác nhận đổi", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    Account account = new Account();
                    account.id = int.Parse(txtID.Text);
                    account.password = txtConfirm.Text;
                    AccountBLL accountBLL = new AccountBLL();
                    accountBLL.ChangePassword(account, txtPass.Text);
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }

        }
    }
}
