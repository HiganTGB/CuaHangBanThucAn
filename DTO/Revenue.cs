using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.DTO
{
    public class Revenue
    {
        public DateTime dateid { get; set; }
        public int billsell { get; set; } = 0;
        public int quantity { get; set; } = 0;
        public long total { get; set; } = 0;
        public Revenue() { }
        public Revenue(DataRow dataRow)
        {
            DateTime dateTime = (DateTime)dataRow["date"];
            this.billsell = (int)dataRow["billsale"];
            this.quantity = (int)dataRow["quantity"];
            this.total = (long)(decimal)dataRow["total"];
        }

        public Revenue(DateTime date, int billsell,int quantity, long total)
        {
            this.dateid = date;
            this.billsell = billsell;
            this.quantity = quantity;
            this.total = total;
        }
        
    }
}
