using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB;
using CuaHangBanThucAn.LIB.Error;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.DAO
{
    public class ProductDAO : ICURD<Product>
    {
        /*
         id int identity not null primary key,
	    name nvarchar(max) not null,
	    type_id int not null foreign key references  TypeProduct(id),
	    price money not null,
	    discount float not null check (discount >= 0 and discount <=100),
	    stock int not null,
	    deleted bit default 0 not null
         */
        public Product Create(Product entity)
        {
            string query = string.Format("insert into product(name,type_id,price,discount,stock) OUTPUT INSERTED.id values (N'{0}',{1},{2},{3},{4})", entity.name, entity.typeProduct.id, entity.price.ToString(), Valid.castfloatSQL(entity.discount.ToString()),entity.stock);
            int id = (int)DataProvider.ExecuteScalar(query);
            if (id == 0)
            {
                throw new AppException(104, "Thêm không thành công");
            }

            return Read(id);
        }

        public void Delete(int id)
        {
            string query = string.Format("update product set deleted = 1 where deleted = 0 and id = {0}", id.ToString());
            int result = DataProvider.ExecuteNonQuery(query);
            if (result == 0)
            {
                throw new AppException(104, "Sản phẩm không tồn tại");
            }
        }
        public void DeleteByType(int type_id)
        {
            string query = string.Format("update product set deleted = 1 where deleted = 0 and type_id = {0}", type_id.ToString());
            int result = DataProvider.ExecuteNonQuery(query);
        }
        public Product Read(int id)
        {
            string query = string.Format("SELECT * FROM product where id = {0}", id.ToString());
            DataTable dataTable = DataProvider.ExecuteQuery(query);
            if (dataTable.Rows.Count == 0)
            {
                throw new AppException(104, "Sản phẩm có id không tồn tại");
            }
            Product result =new Product(dataTable.Rows[0]);
            return result;
        }

        public List<Product> Search(string keyword)
        {
            if (keyword.Length == 0) return SearchAll();
            if (keyword.Trim().Length == 0) return SearchAll();
            bool isnumber = int.TryParse(keyword,out int number);
            string query = string.Empty;
            if (isnumber)
            {
                query=string.Format("select p.id,p.name,p.type_id,price,discount,stock,p.deleted from product p join typeproduct t on p.type_id=t.id where p.deleted = 0 and (p.id = {0} or p.name like N'%{1}%' or t.name like N'{1}')",number,keyword);
            }else
            {
                query = string.Format("select p.id,p.name,p.type_id,price,discount,stock,p.deleted from product p join typeproduct t on p.type_id=t.id where p.deleted = 0 and (p.name like N'%{0}%' or t.name like N'{0}')", keyword);
            }    
            DataTable data = DataProvider.ExecuteQuery(query);
            List<Product> list = new List<Product>();
            foreach (DataRow item in data.Rows)
            {
                Product x = new Product(item);
                list.Add(x);
            }
            return list;
        }
        public List<Product> SearchAll()
        {
            string query = string.Format("SELECT * FROM Product where deleted = 0");
            DataTable data = DataProvider.ExecuteQuery(query);
            List<Product> list = new List<Product>();
            foreach (DataRow item in data.Rows)
            {
                Product x = new Product(item);
                list.Add(x);
            }
            return list;
        }

        public void Update(Product entity)
        {
            string query = string.Format("update product set name=N'{0}',type_id = {1},price={2},discount=({3}),stock={4} where deleted = 0 and id = {5}",entity.name,entity.typeProduct.id,entity.price, Valid.castfloatSQL(entity.discount.ToString()),entity.stock,entity.id);
            int result = DataProvider.ExecuteNonQuery(query);
            if (result == 0)
            {
                throw new AppException(104, "Sản phẩm không tồn tại");
            }
        }
        public void Buy(BillDetail billDetail)
        {
            string query = string.Format("update product set stock-={0} where deleted = 0 and id = {1}",billDetail.quantity,billDetail.product.id);
            int result = DataProvider.ExecuteNonQuery(query);
            if (result == 0)
            {
                throw new AppException(104, "Sản phẩm không tồn tại");
            }
        }
    }
}
