using CuaHangBanThucAn.BLL;
using CuaHangBanThucAn.DAO;
using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB;
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

namespace CuaHangBanThucAn.GUI.Sale
{
    public partial class UCSell : UserControl
    {
        private Bill bill = new Bill();
        private SellBLL sellBLL = new SellBLL();
        public UCSell()
        {
            InitializeComponent();
            init();
            lvBill.ReadOnly = true;
            lvProduct.ReadOnly = true;
        }
        private void init()
        {
            DataTable dataTable = new DataTable();

              dataTable.Columns.Add("STT", typeof(int));
                dataTable.Columns.Add("Tên", typeof(string));
                dataTable.Columns.Add("Giá bán", typeof(string));
                dataTable.Columns.Add("Số lượng", typeof(int));
                dataTable.Columns.Add("Thành tiền", typeof(string));
                dataTable.Columns.Add("ID", typeof(int));
            lvBill.DataSource= dataTable;
            search("");
        }
        private void show(Bill bill)
        {
            lvBill.Columns.Clear();
            DataTable dataTable = new DataTable();
            {
                dataTable.Columns.Add("STT", typeof(int));
                dataTable.Columns.Add("Tên", typeof(string));
                dataTable.Columns.Add("Giá bán", typeof(string));
                dataTable.Columns.Add("Số lượng", typeof(int));
                dataTable.Columns.Add("Thành tiền", typeof(string));
                dataTable.Columns.Add("ID", typeof(int));
            }
            int i = 0;
            foreach (BillDetail billDetail in bill.billDetails)
            {
                dataTable.Rows.Add(++i, billDetail.product.name, billDetail.price.ToString(), billDetail.quantity, billDetail.total.ToString(), billDetail.product.id);
            }
            lvBill.DataSource = dataTable;
            txtTotalPrice.Text = bill.total.ToString();
            txtChange.Text = bill.change.ToString();
        }

        private void show(int id)
        {
            try
            {
                ProductBLL productBLL = new ProductBLL();
                Product product = productBLL.Read(id);
                if (product.id == -1)
                {
                    return;
                }
                txtID.Text = product.id.ToString();
                txtName.Text = product.name.ToString();
                txtQuantity.Maximum = product.stock - bill.getQuantity(product.id);
                txtPrice.Text = product.LastPrice().ToString();

            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void showlist(List<Product> products)
        {
            lvProduct.Columns.Clear();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Tên", typeof(string));
            dataTable.Columns.Add("Giá bán", typeof(string));
            dataTable.Columns.Add("Loại", typeof(string));
            dataTable.Columns.Add("Số lượng", typeof(int));
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Giá bán gốc", typeof(string));
            dataTable.Columns.Add("Giảm giá(%)", typeof(float));

            foreach (Product product in products)
            {
                dataTable.Rows.Add(product.name, product.LastPrice().ToString(), product.typeProduct.name, product.stock - bill.getQuantity(product.id), product.id, product.price.ToString(), product.discount);
            }
            lvProduct.DataSource = dataTable;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            search(txtSearch.Text);
        }
        private void search(String str)
        {
            try
            {
                ProductBLL productBLL = new ProductBLL();
                showlist(productBLL.Search(str));
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search(txtSearch.Text);
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            calcProduct();
        }
        private void calcProduct()
        {
            long price = long.Parse(txtPrice.Text) * (int)txtQuantity.Value;
            txtTotalProductprice.Text = price.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (txtID.Text.Length == 0)
                {
                    throw new AppException(1, "Vui lòng chọn thực đơn");
                }
                if (txtQuantity.Value > txtQuantity.Maximum)
                {
                    throw new AppException(1, "Số lượng vượt quá số lượng hiện có");
                }
                if (txtQuantity.Value == 0)
                {
                    throw new AppException(1, "Vui lòng nhập số lượng lớn hơn 0");
                }
                bill = sellBLL.addProduct(bill, int.Parse(txtID.Text), (int)txtQuantity.Value);
                show(bill);
                search("");
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
                    throw new AppException(1, "Vui lòng chọn chi tiết muốn xoá");
                }
                bill = sellBLL.removeDetail(bill, int.Parse(txtDID.Text));
                show(bill);
                search("");
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPay.Text.Length == 0)
                {
                    throw new AppException(3, "Khách chưa trả tiền");
                }    
                if (bill.billDetails.Count == 0)
                {
                    throw new AppException(3, "Hoá đơn trống");
                }
                if (long.Parse(txtPay.Text) < long.Parse(txtTotalPrice.Text))
                {
                    throw new AppException(3, "Chưa thanh toán đủ");
                }
                if (cbPrint.Checked)
                {
                    bill = sellBLL.doneBill(bill);
                    sellBLL.printBill(bill);
                }
                else
                {
                    bill = sellBLL.doneBill(bill);
                }
                bill=sellBLL.cancelBill(bill);
                show(bill);
                search("");
                txtPay.Text ="";
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void lvProduct_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            lvProduct.Rows[e.RowIndex].Selected = true;
            DataGridViewRow row = lvProduct.Rows[e.RowIndex];
            if (row != null)
            {
                if (row.Cells[4].Value != null)
                {
                    int value = int.Parse(row.Cells[4].Value.ToString());
                    show(value);
                }
            }
        }

        private void lvBill_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            lvBill.Rows[e.RowIndex].Selected = true;
            DataGridViewRow row = lvBill.Rows[e.RowIndex];
            if (row != null)
            {
                if (row.Cells[5].Value != null)
                {
                    int value = int.Parse(row.Cells[5].Value.ToString());
                    txtDID.Text = value.ToString();
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            search("");
        }

        private void lvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            calcProduct();
        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {

            if (txtPay.Text.Contains(',') || txtPay.Text.Contains('.'))
                txtPay.Text = string.Empty;
            if (Valid.isMoney(txtPay.Text))
            {
                sellBLL.addPayBill(bill, long.Parse(txtPay.Text));
                show(bill);
            }
            else
            {
                txtPay.Text = string.Empty;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SellBLL sellBLL = new SellBLL();
            bill=sellBLL.cancelBill(bill);
            show(bill);
            txtPay.Text = string.Empty;
            Refresh();
        }
    }
}
