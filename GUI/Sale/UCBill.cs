using CuaHangBanThucAn.BLL;
using CuaHangBanThucAn.DTO;
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
    public partial class UCBill : UserControl
    {
        public UCBill()
        {
            InitializeComponent();
            refresh();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void showlist(List<Bill> bills)
        {
            lvList.Columns.Clear();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Tổng hoá đơn", typeof(string));
            dataTable.Columns.Add("Ngày lập", typeof(string));
            dataTable.Columns.Add("Người lập", typeof(string));
            foreach (Bill bill in bills)
            {
                dataTable.Rows.Add(bill.id, bill.total, bill.date.ToString("dd/MM/yyyy"), bill.account.name);
            }
            lvList.DataSource = dataTable;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BillBLL billBLL = new BillBLL();
            showlist(billBLL.Search(txtSearch.Text));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            BillBLL billBLL = new BillBLL();
            showlist(billBLL.SearchAll());
        }
        private void show(int id)
        {
            BillBLL billBLL = new BillBLL();
            Bill bill = billBLL.Read(id);
            lvDetail.Columns.Clear();
            DataTable dataTable = new DataTable();
            {
                dataTable.Columns.Add("Tên", typeof(string));
                dataTable.Columns.Add("Giá bán", typeof(string));
                dataTable.Columns.Add("Số lượng", typeof(int));
                dataTable.Columns.Add("Thành tiền", typeof(string));
            }
            foreach (BillDetail billDetail in bill.billDetails)
            {
                dataTable.Rows.Add(billDetail.product.name, billDetail.price.ToString(), billDetail.quantity, billDetail.total.ToString());
            }
            lvDetail.DataSource = dataTable;
            txtID.Text = bill.id.ToString();
            txtName.Text = bill.account.name;
            txtDate.Text = bill.date.ToString("dd/MM/yyyy HH:mm:ss");
            txtTotal.Text = bill.total.ToString();
            txtChange.Text = bill.change.ToString();
            txtPay.Text = bill.pay.ToString();
        }
        private void lvList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            lvList.Rows[e.RowIndex].Selected = true;
            DataGridViewRow row = lvList.Rows[e.RowIndex];
            if (row != null)
            {
                if (row.Cells[0].Value != null)
                {
                    int value = int.Parse(row.Cells[0].Value.ToString());
                    show(value);
                }
            }
        }

        private void lvDetail_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
