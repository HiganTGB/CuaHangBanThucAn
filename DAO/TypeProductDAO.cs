using CuaHangBanThucAn.DTO;
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
    public class TypeProductDAO : ICURD<TypeProduct>
    {
        public TypeProductDAO() { }
        public TypeProduct Create(TypeProduct entity)
        {
            string query = string.Format("insert into typeProduct(name) OUTPUT INSERTED.id values (N'{0}')", entity.name);
            int id = (int)DataProvider.ExecuteScalar(query);
            if (id == 0)
            {
                throw new AppException(104, "Thêm không thành công");
            }

            return Read(id);
        }

        public void Delete(int id)
        {
            string query = string.Format("update TypeProduct set deleted = 1 where deleted = 0 and id = {0}", id.ToString());
            int result = DataProvider.ExecuteNonQuery(query);
            if (result == 0)
            {
                throw new AppException(104, "Loại không tồn tại");
            }
        }

        public TypeProduct Read(int id)
        {
            string query = string.Format("SELECT * FROM typeProduct where deleted = 0 and id = {0}", id.ToString());
            DataTable dataTable = DataProvider.ExecuteQuery(query);
            if (dataTable.Rows.Count == 0)
            {
                throw new AppException(104, "Loại không tồn tại");
            }
            return new TypeProduct(dataTable.Rows[0]);
        }

        public List<TypeProduct> Search(string keyword)
        {
            if (keyword.Length == 0) return SearchAll();
            if (keyword.Trim().Length == 0) return SearchAll();
            bool isnumber= int.TryParse(keyword, out int number);
            string query = string.Empty;
            if (isnumber)
            {
               query = string.Format("SELECT * FROM typeProduct where deleted = 0 and id ={1} or name like N'%{0}%'", keyword,number);
            }
            query = string.Format("SELECT * FROM typeProduct where deleted = 0 and name like N'%{0}%'", keyword);
            return DataProvider.ExecuteQuery(query)
               .AsEnumerable()
               .Select(row => new TypeProduct(row))
               .ToList();
        }

        public List<TypeProduct> SearchAll()
        {
            string query = string.Format("SELECT * FROM typeProduct where deleted = 0");
            return DataProvider.ExecuteQuery(query)
               .AsEnumerable()
               .Select(row => new TypeProduct(row))
               .ToList();
        }

        public void Update(TypeProduct entity)
        {
            string query = string.Format("update TypeProduct set name = N'{0}' where id = {1}", entity.name, entity.id);
            int result = DataProvider.ExecuteNonQuery(query);
            if (result == 0)
            {
                throw new AppException(104, "Loại không tồn tại");
            }
        }
    }
}
