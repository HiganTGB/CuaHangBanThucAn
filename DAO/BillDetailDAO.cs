using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.DAO
{
    /*
         bill_id int not null foreign key references Bill(id),
	    product_id int not null foreign key references Product(id),
	    price money not null,
	    discount float not null,
	    quantity int not null,
	    total money not null
     */
    public class BillDetailDAO : ICURD<BillDetail>
    {
        public BillDetail Create(BillDetail entity)
        {
            string floatvalue= Valid.castfloatSQL(entity.discount.ToString());
            
            string query = string.Format("insert into billdetail(bill_id,product_id,price,discount,quantity,total) values({0},{1},{2},{3},{4},{5})", entity.bill.id, entity.product.id, entity.price,floatvalue,entity.quantity,entity.total);
            int result = (int)DataProvider.ExecuteNonQuery(query);
            return entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BillDetail Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<BillDetail> Search(string keyword)
        {
            throw new NotImplementedException();
        }

        public List<BillDetail> SearchAll()
        {
            throw new NotImplementedException();
        }

        public void Update(BillDetail entity)
        {
            throw new NotImplementedException();
        }
        public List<BillDetail> ReadbyBill(Bill bill)
        {
            List<BillDetail> list = new List<BillDetail>();
            string query = string.Format("select * from billdetail where bill_id={0}", bill.id);
            DataTable data = DataProvider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BillDetail billDetail = new BillDetail(item);
                list.Add(billDetail);
            }
            return list;
        }
    }
}
