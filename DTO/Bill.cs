using CuaHangBanThucAn.DAO;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CuaHangBanThucAn.DTO
{
    public class Bill
    {
        /*
         id int identity not null primary key,
     total money not null,
     pay money not null,
     change money not null,
     account_id int not null foreign key references account(id),
     date datetime not null default Getdate(),
         */
        public int id { get; set; } = -1;
        public long total { get; set; } = 0;
        public long pay { get; set; } = 0;
        public long change { get; set; } = 0;
        public Account account { get; set; } = new Account();
        public DateTime date { get; set; }

        public List<BillDetail> billDetails { get; set; } = new List<BillDetail> { };
        public Bill() { }
        public Bill(DataRow dataRow)
        {
            this.id = (int)dataRow["id"];
            decimal money = (decimal)dataRow["total"];
            this.total = (long) money;
            money = (decimal)dataRow["pay"];
            this.pay = (long)money;
            money = (decimal)dataRow["change"];
            this.change = (long)money;
            this.account.id = (int)dataRow["account_id"];
            this.date = (DateTime)dataRow["date"];
        }

        public Bill(int id, long total, long pay, long change, Account account, DateTime date,List<BillDetail> billDetails)
        {
            this.id = id;
            this.total = total;
            this.pay = pay;
            this.change = change;
            this.account = account;
            this.date = date;
            this.billDetails = billDetails;
        }
        public void add(BillDetail detail)
        {
            int index = billDetails.FindIndex(x => x.product.id == detail.product.id);
            if (index != -1)
            {
                billDetails[index].addMore(detail.quantity);
            }
            else
            {
                billDetails.Add(detail);
                //detail.bill = this;
            }
            calcTotal();
        }
        public void remove(BillDetail detail)
        {
            billDetails.Remove(detail);
           ///detail.bill = null;
            calcTotal();
        }
        public void remove(int id)
        {
            int index = billDetails.FindIndex(x => x.product.id == id);
            if (index != -1)
            {
                remove(billDetails[index]);      
            }
            else
            {
                return;
            }
            calcTotal();
        }
        public int getQuantity(int product_id)
        {
            int index = billDetails.FindIndex(x => x.product.id == product_id);
            if (index != -1)
            {
                return billDetails[index].quantity;
            }
            return 0;
        }
        private void calcTotal()
        {
            this.total = 0;
            foreach (BillDetail detail in billDetails)
            {
                this.total += detail.total;
            }
        }
        public void addPay(long pay)
        {
            this.pay = pay;
            this.change = pay-total;   
        }
        public String toPrint()
        {
            string content = String.Format("Mã hoá đơn :{0} \n",this.id.ToString());
            content+= String.Format("Ngày lập :{0} \n", this.date.ToString("dd/MM/yyyy HH:mm:ss"));
            content += String.Format("Nhân viên: {0} - Mã số {1}\n", this.account.id, this.account.name);
            content += String.Format("       Sản phẩm        | Số lượng |         Đơn giá    | Thành tiền\n");
            content += String.Format("-----------------------|----------|--------------------|-----------\n");
            foreach(BillDetail detail in billDetails)
            {
                content += detail.toprint();
            }
            content += String.Format("-----------------------|----------|--------------------|-----------\n");
            content += String.Format("                                            Thành tiền : {0}\n",this.total);
            content += String.Format("                                            Khách trả  : {0}\n", this.pay);
            content += String.Format("                                            Tiền thừa  : {0}\n", this.change);
            return content;
        }
    }
}
