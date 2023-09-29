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

namespace CuaHangBanThucAn.GUI.Food
{
    public partial class UCTypeProduct : UserControl
    {
        public UCTypeProduct()
        {
            InitializeComponent();
            lvType.ReadOnly = true;
            refresh();
        }
        private void showlist(List<TypeProduct> types)
        {
            lvType.Columns.Clear();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Tên", typeof(string));
            foreach (TypeProduct type in types)
            {
                dataTable.Rows.Add(type.id, type.name);
            }
            lvType.DataSource = dataTable;
        }
        private void show(int id)
        {
            try
            {
                TypeProductBLL typeBLL = new TypeProductBLL();
                TypeProduct type = typeBLL.Read(id);
                txtDID.Text = type.id.ToString();
                txtDName.Text = type.name;
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
                TypeProductBLL typeProductBLL = new TypeProductBLL();
                typeProductBLL.Create(new TypeProduct(-1, txtName.Text, false));
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                try
                {
                    TypeProductBLL bLL = new TypeProductBLL();
                    showlist(bLL.Search(txtSearch.Text));
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
                TypeProductBLL bLL = new TypeProductBLL();
                showlist(bLL.Search(txtSearch.Text));
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            try
            {
                TypeProductBLL bLL = new TypeProductBLL();
                showlist(bLL.SearchAll());
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDID.Text.Length == 0)
                {
                    throw new AppException(1, "Vui lòng chọn loại");
                }
                if (txtDName.Text.Length == 0)
                {
                    throw new AppException(1, "Tên không được để trống");
                }
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thay đổi không?", "Xác nhận thay đổi", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    TypeProductBLL typeProductBLL = new TypeProductBLL();
                    typeProductBLL.Update(new TypeProduct(int.Parse(txtDID.Text), txtDName.Text, false));
                    MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK);
                }
              
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
                    throw new AppException(1, "Vui lòng chọn loại");
                }
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?\nXoá sẽ khiến cho tất cả thực đơn thuộc loại này bị xoá theo", "Xác nhận xóa", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    TypeProductBLL typeProductBLL = new TypeProductBLL();
                    typeProductBLL.Delete(int.Parse(txtDID.Text));
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK);
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
