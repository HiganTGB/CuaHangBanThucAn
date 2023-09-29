using CuaHangBanThucAn.BLL;
using CuaHangBanThucAn.DAO;
using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB.Error;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanThucAn.GUI.Sale
{
    public partial class UCRevenue : UserControl
    {
        public UCRevenue()
        {
            InitializeComponent();
            checkdate();
        }
        private void checkdate()
        {
            DateTime now = DateTime.Now;
            dPEnd.MaxDate = now;
            dPStart.MaxDate = now;
        }
        private void startRevenue()
        {
            try
            {
                DateTime start = dPStart.Value;
                DateTime end = dPEnd.Value;
                RevenueBLL revenueBLL = new RevenueBLL();
                List<Revenue> revenueDTOs = revenueBLL.GetRevenue(start, end);
                lvRevenue.Columns.Clear();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Ngày", typeof(string));
                dataTable.Columns.Add("Số lượng hoá đơn", typeof(long));
                dataTable.Columns.Add("Số lượng đã bán", typeof(long));
                dataTable.Columns.Add("Tổng doanh thu", typeof(long));
                txtBillSell.Text = "";
                txtTotal.Text = "";
                int billsell = 0;
                long total = 0;
                int quantity = 0;
                foreach (Revenue dto in revenueDTOs)
                {
                    dataTable.Rows.Add(dto.dateid, dto.billsell, dto.quantity, dto.total);

                    billsell += dto.billsell;
                    total += dto.total;
                    quantity += dto.quantity;
                }
                lvRevenue.DataSource = dataTable;
                txtBillSell.Text = billsell.ToString();
                txtTotal.Text = total.ToString();
                txtTotalQuantity.Text = quantity.ToString();
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message);
            }
        }

        private void btnStartEnd_Click(object sender, EventArgs e)
        {
            startRevenue();
        }
    }
}
