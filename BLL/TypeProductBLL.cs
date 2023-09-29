using CuaHangBanThucAn.DAO;
using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB.Error;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.BLL
{
    public class TypeProductBLL:ICURD<TypeProduct>
    {
        TypeProductDAO typeProductDAO= new TypeProductDAO();
        public TypeProductBLL() { }

        public TypeProduct Create(TypeProduct entity)
        {
            return typeProductDAO.Create(entity);
        }

        public void Delete(int id)
        {
            typeProductDAO.Delete(id);
            ProductDAO productsDAO = new ProductDAO();
            productsDAO.DeleteByType(id);
        }

        public TypeProduct Read(int id)
        {
            return typeProductDAO.Read(id);
        }

        public List<TypeProduct> Search(string keyword)
        {
            return typeProductDAO.Search(keyword);
            
        }

        public List<TypeProduct> SearchAll()
        {
            return typeProductDAO.Search("");
        }

        public void Update(TypeProduct entity)
        {
            TypeProduct old = typeProductDAO.Read(entity.id);
            if(old.Equals(entity))
            {
                throw new AppException(3, "Loại không thay đổi dữ liệu");
            }
            typeProductDAO.Update(entity);
        }
    }
}
