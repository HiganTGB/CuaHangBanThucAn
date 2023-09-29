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
    public class RoleBLL:ICURD<Role>
    {
        private RoleDAO RoleDAO = new RoleDAO();
        public RoleBLL() { }
        
        public Role Create(Role entity)
        {
            if (entity.name.Length == 0)
            {
                throw new AppException(1, "Tên không được để trống");
            }
            if (entity.permission != "ADMIN" && entity.permission != "STAFF")
            {
                throw new AppException(1, "Phân quyền phải thuộc ADMIN hoặc STAFF");
            }
            return RoleDAO.Create(entity);
        }

        public void Delete(int id)
        {
            if (id == -1)
            {
                throw new AppException(1, "Vui lòng chọn chức vụ");
            }
            RoleDAO.Delete(id);
            AccountDAO accountDAO = new AccountDAO();
            accountDAO.DeletebyRole(id);
        }

        public Role Read(int id)
        {
            return RoleDAO.Read(id);
        }

        public List<Role> Search(string keyword)
        {
            return RoleDAO.Search(keyword);
        }

        public List<Role> SearchAll()
        {
            return RoleDAO.SearchAll();
        }

        public void Update(Role entity)
        {
            if(entity.id==-1)
            {
                throw new AppException(1, "Vui lòng chọn chức vụ");
            }
            if(entity.name.Length== 0)
            {
                throw new AppException(1, "Tên không được để trống");
            }
            if(entity.permission!="ADMIN"&&entity.permission!="STAFF")
            {
                throw new AppException(1, "Phân quyền phải thuộc ADMIN hoặc STAFF");
            }
            Role old =  RoleDAO.Read(entity.id);
            if(old.Equals(entity)) {
                throw new AppException(3, "Dữ liệu không thay đổi");
            }
            Update(entity);
        }
    }
}
