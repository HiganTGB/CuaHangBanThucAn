using CuaHangBanThucAn.BLL;
using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB.Error;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanThucAn.GUI.AccountManager
{
    public partial class UCAccount : UserControl
    {
        public static string emailpattern = @"^([a-zA-Z0-9_\-]+@[a-zA-Z0-9_\-]+\.[a-zA-Z0-9]{2,6})$";
        public UCAccount()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
            lvAccount.ReadOnly = true;
            lbDError.Visible=false;
            lbError.Visible=false;
            refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void show(int id)
        {
            try
            {
                AccountBLL AccountBLL = new AccountBLL();
                Account account = AccountBLL.Read(id);
                txtDID.Text = account.id.ToString();
                txtDName.Text = account.name;
                txtDEmail.Text = account.email;
                cbDType.SelectedIndex = cbDType.Items.Cast<Role>().ToList().FindIndex(a => a.id == account.role.id);
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void showlist(List<Account> accounts)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Tên", typeof(string));
            dataTable.Columns.Add("Chức vụ", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            foreach (Account account in accounts)
            {
                dataTable.Rows.Add(account.id, account.name, account.role.name, account.email);
            }
            lvAccount.DataSource = dataTable;
        }
        private void refresh()
        {

            cbType.DisplayMember = "name";
            cbType.ValueMember = "id";
            cbDType.DisplayMember = "name";
            cbDType.ValueMember = "id";
            RoleBLL typeProductBLL = new RoleBLL();
            cbType.DataSource = typeProductBLL.SearchAll();
            cbDType.DataSource = typeProductBLL.SearchAll();
            AccountBLL accountBLL = new AccountBLL();
            showlist(accountBLL.SearchAll());
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Role role = (Role)cbType.SelectedItem;
            txtRole.Text = role.permission;
        }

        private void cbDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Role role = (Role)cbDType.SelectedItem;
            txtDRole.Text = role.permission;
        }

        private void lvAccount_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            lvAccount.Rows[e.RowIndex].Selected = true;
            DataGridViewRow row = lvAccount.Rows[e.RowIndex];
            if (row != null)
            {
                if (row.Cells[0].Value != null)
                {
                    int value = int.Parse(row.Cells[0].Value.ToString());
                    show(value);
                }
            }
        }

        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShow.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length == 0) lbDError.Visible = false;
            lbError.Visible = (!Regex.IsMatch(txtEmail.Text, emailpattern)) ? true : false;
        }

        private void txtDEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtDEmail.Text.Length == 0) lbDError.Visible = false;
            lbDError.Visible = (!Regex.IsMatch(txtDEmail.Text, emailpattern)) ? true : false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Length == 0)
                {
                    throw new AppException(1, "Tên không được để trống");
                }
                if (txtEmail.Text.Length == 0)
                {
                    throw new AppException(1, "Email không được để trống");
                }
                if (!Regex.IsMatch(txtEmail.Text, emailpattern))
                {
                    throw new AppException(1, "Email không hợp lệ");
                }
                if (txtRole.Text.Length == 0)
                {
                    throw new AppException(1, "Vui lòng chọn chức vụ");
                }
                if (txtPass.Text.Length == 0)
                {
                    throw new AppException(1, "Password không được để trống");
                }
                Account account = new Account(-1, txtName.Text, txtEmail.Text, txtPass.Text, (Role)cbType.SelectedItem, false);
                AccountBLL accountBLL = new AccountBLL();
                accountBLL.Create(account);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDID.Text.Length == 0)
                {
                    throw new AppException(1, "Vui lòng chọn tài khoản");
                }
                if (txtDName.Text.Length == 0)
                {
                    throw new AppException(1, "Tên không được để trống");
                }
                if (txtDEmail.Text.Length == 0)
                {
                    throw new AppException(1, "Email không được để trống");
                }
                if (!Regex.IsMatch(txtDEmail.Text, emailpattern))
                {
                    throw new AppException(1, "Email không hợp lệ");
                }
                if (txtDRole.Text.Length == 0)
                {
                    throw new AppException(1, "Vui lòng chọn chức vụ");
                }
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thay đổi không?", "Xác nhận thay đổi", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    Account account = new Account(int.Parse(txtDID.Text), txtDName.Text, txtDEmail.Text, "", (Role)cbDType.SelectedItem, false);
                    AccountBLL accountBLL = new AccountBLL();
                    accountBLL.Update(account);
                }
                MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDID.Text.Length == 0)
                {
                    throw new AppException(1, "Vui lòng chọn tài khoản");
                }
                if(LoginBLL.UserLogin.id==int.Parse(txtDID.Text))
                {
                    throw new AppException(2, "Không được xoá tài khoản chính mình");
                }
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    AccountBLL accountBLL = new AccountBLL();
                    accountBLL.Delete(int.Parse(txtDID.Text));
                }
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                AccountBLL accountBL = new AccountBLL();
                showlist(accountBL.Search(txtSearch.Text));
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void lvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
