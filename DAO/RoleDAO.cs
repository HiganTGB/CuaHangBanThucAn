using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB.Error;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.DAO
{
    public class RoleDAO :ICURD<Role> 
    {
        public RoleDAO() { }

        public Role Create(Role entity)
        {
            string query = string.Format("insert into role(name,permission) OUTPUT INSERTED.id values (N'{0}','{1}')", entity.name, entity.permission);
            int id = (int)DataProvider.ExecuteScalar(query);
            if (id == 0)
            {
                throw new AppException(104, "Thêm không thành công");
            }

            return Read(id);
        }

        public void Delete(int id)
        {
            string query = string.Format("update role set deleted = 1 where deleted = 0 and id = {0}", id.ToString());
            int result = DataProvider.ExecuteNonQuery(query);
            if (result == 0)
            {
                throw new AppException(104, "Chức vụ không tồn tại");
            }
        }

        public Role Read(int id)
        {
            string query = string.Format("SELECT * FROM Role where deleted = 0 and id = {0}", id);
            DataTable dataTable = DataProvider.ExecuteQuery(query);
            if (dataTable.Rows.Count==0)
            {
                throw new AppException(104, "Chức vụ không tồn tại");
            }
            return new Role(dataTable.Rows[0]);
        }

        public List<Role> Search(string keyword)
        {
            if (keyword.Length == 0) return SearchAll();
            if (keyword.Trim().Length == 0) return SearchAll();
            bool isnumber = int.TryParse(keyword, out int id);
            string query;
            if(isnumber)
            {
                query = string.Format("SELECT * FROM Role where deleted = 0 or id ={1} and name like N'%{0}%'or permission like '{0}'", keyword,id);
            }
            query = string.Format("SELECT * FROM Role where deleted = 0 and name like N'%{0}%'or permission like '{0}'",keyword);
            return DataProvider.ExecuteQuery(query)
               .AsEnumerable()
               .Select(row => new Role(row))
               .ToList();
        }

        public List<Role> SearchAll()
        {
            string query = string.Format("SELECT * FROM Role where deleted = 0");
            return DataProvider.ExecuteQuery(query)
               .AsEnumerable()
               .Select(row => new Role(row))
               .ToList();
        }

        public void Update(Role entity)
        {
            string query = string.Format("update role set name = N'{0}',permission = '{1}'where id = {2}", entity.name, entity.permission, entity.id);
            int result = DataProvider.ExecuteNonQuery(query);
            if (result == 0)
            {
                throw new AppException(104, "Chức vụ không tồn tại");
            }
        }
    }
}
