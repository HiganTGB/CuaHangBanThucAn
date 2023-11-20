using CuaHangBanThucAn.BLL;
using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB.Error;
using iTextSharp.text.pdf.parser.clipper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanThucAn.GUI.AccountManager
{
    public partial class UCRole : UserControl
    {
        public UCRole()
        {
            InitializeComponent();
            cbDRole.Items.Add("");
            cbDRole.Items.Add("ADMIN");
            cbDRole.Items.Add("STAFF");
            cbRole.Items.Add("");
            cbRole.Items.Add("ADMIN");
            cbRole.Items.Add("STAFF");
            
            refresh();
            lvType.ReadOnly = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            try
            {
                RoleBLL bLL = new RoleBLL();
                showlist(bLL.SearchAll());
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void showlist(List<Role> list)
        {
            lvType.Columns.Clear();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Tên", typeof(string));
            dataTable.Columns.Add("Quyền", typeof(string));
            foreach (Role type in list)
            {
                dataTable.Rows.Add(type.id, type.name, type.permission);
            }
            lvType.DataSource = dataTable;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                RoleBLL roleBLL = new RoleBLL();
                showlist(roleBLL.Search(txtSearch.Text));
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Length == 0)
                {
                    throw new AppException(1, "Tên không được để trống");
                }
                if (cbRole.Text.Length == 0)
                {
                    throw new AppException(1, "Vui lòng chọn quyền");
                }
                RoleBLL roleBLL = new RoleBLL();
                roleBLL.Create(new Role(-1, txtName.Text, cbRole.Text, false));
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                refresh();
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
                    throw new AppException(1, "Vui lòng chọn chức vụ");
                }
                if (txtDName.Text.Length == 0)
                {
                    throw new AppException(1, "Tên không được để trống");
                }
                if (cbDRole.Text.Length == 0)
                {
                    throw new AppException(1, "Vui lòng chọn quyền");
                }
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thay đổi không?", "Xác nhận thay đổi", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    RoleBLL roleBLL = new RoleBLL();
                    roleBLL.Update(new Role(int.Parse(txtDID.Text), txtDName.Text, cbDRole.Text, false));
                    MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK);
                    refresh();
                }

            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void show(int id)
        {
            try
            {
                RoleBLL roleBLL = new RoleBLL();
                Role role = roleBLL.Read(id);
                txtDID.Text = role.id.ToString();
                txtDName.Text = role.name.ToString();
                cbDRole.SelectedIndex = cbDRole.Items.IndexOf(role.permission);
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void lvType_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            lvType.Rows[e.RowIndex].Selected = true;
            DataGridViewRow row = lvType.Rows[e.RowIndex];
            if (row != null)
            {
                if (row.Cells[0].Value != null)
                {
                    int value = int.Parse(row.Cells[0].Value.ToString());
                    show(value);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDID.Text.Length == 0)
                {
                    throw new AppException(1, "Vui lòng chọn chức vụ");
                }
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?\nXoá sẽ khiến cho tất cả tài khoản liên quan đều bị xoá theo", "Xác nhận xóa", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    RoleBLL roleBLL = new RoleBLL();
                    roleBLL.Delete(txtDID.Text.Length);
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK);
                    refresh();
                }
              
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void lvType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
