using CuaHangBanThucAn.DAO;
using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB.Error;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.BLL
{
    
    public class AccountBLL:ICURD<Account> 
    {
        public static string emailform = @"^([a-zA-Z0-9_\-]+@[a-zA-Z0-9_\-]+\.[a-zA-Z0-9]{2,6})$";
        AccountDAO accountDAO= new AccountDAO();
        public AccountBLL() { }

        public Account Create(Account entity)
        {
            if (entity.name.Length == 0)
            {
                throw new AppException(1, "Tên không được để trống");
            }
            if (entity.email.Length == 0)
            {
                throw new AppException(103, "Email không được để trống");
            }
            if(!Regex.IsMatch(entity.email, emailform))
            {
                throw new AppException(1, "Email không hợp lệ");
            }
            if (entity.password.Length == 0)
            {
                throw new AppException(103, "Mật khẩu không được để trống");
            }
            if(entity.role.id==-1)
            {
                throw new AppException(1, "Chức vụ không được để trống");
            }    
            return accountDAO.Create(entity);
        }

        public void Delete(int id)
        {

            accountDAO.Delete(id);
        }

        public Account Read(int id)
        {
           Account account =accountDAO.Read(id);
           RoleDAO roleDAO =new RoleDAO();
            account.role=roleDAO.Read(account.role.id);
            return account;
        }

        public List<Account> Search(string keyword)
        {
            List < Account > list=accountDAO.Search(keyword);
            RoleDAO roleDAO = new RoleDAO();
            foreach (Account account in list)
            {
                account.role = roleDAO.Read(account.role.id);
            }
            return list;
        }

        public List<Account> SearchAll()
        {
            return Search("");
        }

        public void Update(Account entity)//Không update password
        {
            if (entity.name.Length == 0)
            {
                throw new AppException(1, "Tên không được để trống");
            }
            if (entity.email.Length == 0)
            {
                throw new AppException(103, "Email không được để trống");
            }
            if (!Regex.IsMatch(entity.email, emailform))
            {
                throw new AppException(1, "Email không hợp lệ");
            }
            if (entity.role.id == -1)
            {
                throw new AppException(1, "Chức vụ không được để trống");
            }
            Account old = accountDAO.Read(entity.id);
            entity.password = old.password;
            if (old.Equals(entity))
            {
                throw new AppException(3, "Tài khoản không thay đổi dữ liệu");
            }
            accountDAO.Update(entity);
        }
        public void ChangePassword(Account account,string oldpass)
        {
            if(account.password.Length==0)
            {
                throw new AppException(103, "Password không được để trống");
            }
            Account old=accountDAO.Read(account.id);
            if(old.password!=oldpass) {
                throw new AppException(103, "Password không chính xác");
            }
            if(old.password==account.password)
            {
                throw new AppException(103, "Password không được giống như cũ");
            }
            old.password = account.password;
            accountDAO.Update(old);
        }
    }
}
