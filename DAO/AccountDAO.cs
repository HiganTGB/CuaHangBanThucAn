using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB.Error;
using iTextSharp.text;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CuaHangBanThucAn.DAO
{
    public class AccountDAO : ICURD<Account>
    {
        private static Role admindefault = new Role(-1, "admin", "ADMIN", false);
        private static Account admin = new Account(-1, "admin", string.Format("admin@gmail.com"), "admin", null, false);
        public AccountDAO() { }

        public Account Create(Account entity)
        {
            CheckEmail(entity.email, 0);
            string query = string.Format("insert into account(name,email,password,role_id) OUTPUT INSERTED.id values (N'{0}','{1}','{2}',{3})", entity.name,entity.email,entity.password,entity.role.id);
            int id = (int)DataProvider.ExecuteScalar(query);
            if (id == 0)
            {
                throw new AppException(104, "Email đã tồn tại");
            }
            
            return Read(id);
        }

        public void Delete(int id)
        {
            string query = string.Format("update account set deleted = 1 where deleted = 0 and id = {0}", id.ToString());
            int result = DataProvider.ExecuteNonQuery(query);
            if(result == 0)
            {
                throw new AppException(104, "Tài khoản không tồn tại");
            }
        }

        public void DeletebyRole(int role_id)
        {
            string query = string.Format("update account set deleted = 1 where deleted = 0 and role_id = {0}", role_id);
            int result = DataProvider.ExecuteNonQuery(query);
        }
        public Account Read(int id)
        {
            string query = string.Format("SELECT * FROM Account where id = {0}", id.ToString());
            DataTable dataTable = DataProvider.ExecuteQuery(query);
            if(dataTable.Columns.Count == 0)
            {
                throw new AppException(104, "Tài khoản không tồn tại");
            }
            Account result= new Account(dataTable.Rows[0]);
            return result;
          
        }

        public List<Account> Search(string keyword)
        {
            if (keyword.Length == 0) return SearchAll();
            if (keyword.Trim().Length == 0) return SearchAll();
            bool isnumber = int.TryParse(keyword, out int id);
            string query = string.Empty;
            if(isnumber)
            {
                query = string.Format("select a.id,a.name,a.email,a.password,a.deleted from Account a join Role r on a.role_id=r.id where a.deleted = 0 and (a.name like N'%{0}%' or email like '%{0}%' or r.name like N'%{0}%' or permission like '{0}' or a.id = {1}) ", keyword,id);
            }
            else
            {
                query = string.Format("select a.id,a.name,a.email,a.password,a.deleted from Account a join Role r on a.role_id=r.id where a.deleted = 0 and (a.name like N'%{0}%' or email like '%{0}%' or r.name like N'%{0}%' or permission like '{0}') ", keyword);
            }    
            DataTable data = DataProvider.ExecuteQuery(query);
            List < Account > list = new List<Account>();
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }
            return list;
        }

        public List<Account> SearchAll()
        {
            string query = string.Format("SELECT * FROM Account where deleted = 0");
            DataTable data = DataProvider.ExecuteQuery(query);
            List<Account> list = new List<Account>();
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }
            return list;
        }

        public void Update(Account entity)
        {
            CheckEmail(entity.email, entity.id);
            string query = string.Format("update account set name = N'{0}',email='{1}',password='{2}' where id = {3}", entity.name,entity.email,entity.password,entity.id);
            int result = DataProvider.ExecuteNonQuery(query);
            if (result == 0)
            {
                throw new AppException(104, "Tài khoản không tồn tại");
            }
        }
        private void CheckEmail(string email,int id)
        {
            string query = string.Format("SELECT * FROM Account where email = '{0}'and id != {1}",email,id);
            DataTable dataTable = DataProvider.ExecuteQuery(query);
            if (dataTable.Rows.Count!=0)
            {
                throw new AppException(104, "Email đã tồn tại");
            }
        }
        public Account Login(Account info)
        {
            checkAdmin();
            string query = string.Format("SELECT * FROM Account where email = '{0}'and password = '{1}' and deleted = 0", info.email, info.password);
            DataTable dataTable = DataProvider.ExecuteQuery(query);
            if (dataTable.Rows.Count == 0)
            {
                throw new AppException(104, "Email hoặc password không trùng khớp");
            }
            Account result = new Account(dataTable.Rows[0]);
            return result;
        }
        public void checkAdmin()
        {
            string query = string.Format("Select * from role where deleted = 0 and permission = 'ADMIN' ");
            DataTable dataTable = DataProvider.ExecuteQuery(query);//Không tồn tại role admin nào
            if (dataTable.Rows.Count == 0)
            {
                //Tạo mới 1 role
                RoleDAO roleDAO = new RoleDAO();
                admindefault=roleDAO.Create(admindefault);
                query = string.Format("Select * from account where email ='{0}'",admin.email);
                dataTable = DataProvider.ExecuteQuery(query);//Không tồn tại role admin nào
                if (dataTable.Rows.Count == 0)
                {
                    admin.role= admindefault;
                    Create(admin);
                    throw new AppException(102, "Không tồn tại role admin,đã tạo mới 1 role admin và thêm 1 tài khoản admin mặc định");
                }    
                else
                {
                    admin.deleted = false;
                    admin.role = admindefault;
                    Update(admin);
                    throw new AppException(102, "Không tồn tại role admin,đã tạo mới 1 role admin và khôi phục 1 tài khoản admin mặc định");
                }    
               
            }

        }
    }
}
