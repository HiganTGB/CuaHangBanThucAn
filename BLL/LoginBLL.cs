using CuaHangBanThucAn.DAO;
using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.BLL
{
    public class LoginBLL
    {
        public static Account UserLogin = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private RoleDAO roleDAO = new RoleDAO();
        public LoginBLL() { }
        public Account LoginAccount(Account info)
        {
            if (info.email.Length == 0)
            {
                throw new AppException(103, "Email không được để trống");
            }
            if (info.password.Length == 0)
            {
                throw new AppException(103, "Mật khẩu không được để trống");
            }
            Account result = accountDAO.Login(info);
            if (result.id == -1)
            {
                throw new AppException(106, "Email hoặc mật khẩu không chính xác");
            }
            result.role = roleDAO.Read(result.role.id);
            result.password = "";
            UserLogin = result;
            return UserLogin;
        }
        public void Logout()
        {
            UserLogin= new Account();
        }
    }
}
