using CuaHangBanThucAn.DAO;
using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB.Error;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace CuaHangBanThucAn.BLL
{
    public class ProductBLL:ICURD<Product>
    {
        private ProductDAO ProductDAO = new ProductDAO();
        private TypeProductDAO TypeProductDAO = new TypeProductDAO();
        public ProductBLL() { }
         public Product Create(Product entity)
        {
            entity.typeProduct = TypeProductDAO.Read(entity.typeProduct.id);
            return ProductDAO.Create(entity);
        }

        public Product Read(int id)
        {
            return ProductDAO.Read(id);
        }

        public void Update(Product entity)
        {
            entity.typeProduct = TypeProductDAO.Read(entity.typeProduct.id);
            Product old =ProductDAO.Read(entity.id);
            if(old.Equals(entity))
            {
                throw new AppException(11,"Không thay đổi dữ liệu");
            }
            ProductDAO.Update(entity);
        }

        public void Delete(int id)
        {
            ProductDAO.Delete(id);
        }

        public List<Product> Search(string keyword)
        {
           List<Product> list= ProductDAO.Search(keyword);
           foreach(Product product in list)
            {
                product.typeProduct = TypeProductDAO.Read(product.typeProduct.id);
            }  
           return list;
        }

        public List<Product> SearchAll()
        {
            List<Product> list = ProductDAO.Search("");
            foreach (Product product in list)
            {
                product.typeProduct = TypeProductDAO.Read(product.typeProduct.id);
            }
            return list;
        }
    }
}
