using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB;
using CuaHangBanThucAn.LIB.Error;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.DAO
{
    public class BillDAO : ICURD<Bill>
    {
        private static string dateformat = "dd/MM/yyyy";
        /*
         id int identity not null primary key,
     total money not null,
     pay money not null,
     change money not null,
     account_id int not null foreign key references account(id),
     date datetime not null default Getdate(),
         */
        public Bill Create(Bill entity)
        {
            string query = string.Format("insert into bill(total,pay,change,account_id) OUTPUT INSERTED.[id] values({0},{1},{2},{3})", entity.total, entity.pay, entity.change, entity.account.id);
            int id = (int)DataProvider.ExecuteScalar(query);
            entity.id=id;
            foreach(BillDetail d in entity.billDetails)
            {
                d.bill.id= id;
            }
            return entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Bill Read(int id)
        {
            string query = string.Format("SELECT * FROM Bill where id = {0}", id.ToString());
            DataTable dataTable = DataProvider.ExecuteQuery(query);
            if (dataTable.Columns.Count == 0)
            {
                throw new AppException(104, "Hoá đơn không tồn tại");
            }
            Bill result = new Bill(dataTable.Rows[0]);
            return result;
        }

        public List<Bill> Search(string keyword)
        {
            if (keyword.Length == 0) return SearchAll();
            if (keyword.Trim().Length == 0) return SearchAll();
            List<Bill> list = new List<Bill>();
            string query = string.Format("SELECT b.id,b.total,b.pay,b.change,b.account_id,b.date From Bill b join account a on b.account_id=a.id where a.name like '%{0}%' ",keyword);
            if (DateTime.TryParseExact(keyword,dateformat, null, DateTimeStyles.None, out DateTime date))
            {
                query = String.Format("SELECT * FROM Bill where CAST(date AS date) = '{0}'", date.ToString("yyyy-MM-dd"));
            }
            if (int.TryParse(keyword, out int id))
            {
                query = String.Format("SELECT * FROM Bill where id = {0} or account_id = {0}", id);
            }

            DataTable data = DataProvider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Bill x = new Bill(item);
                list.Add(x);
            }
            return list;
        }

        public List<Bill> SearchAll()
        {
            List<Bill> list = new List<Bill>();
            string query = string.Format("select * from bill");
            DataTable data = DataProvider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Bill x = new Bill(item);
                list.Add(x);
            }
            return list;
        }

        public void Update(Bill entity)
        {
            throw new NotImplementedException();
        }
    }
}
