using CuaHangBanThucAn.DAO;
using CuaHangBanThucAn.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.BLL
{
    public class BillBLL:ICURD<Bill>
    {
        public BillBLL() { }

        public Bill Create(Bill entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Bill Read(int id)
        {
            BillDAO billDAO = new BillDAO();
            Bill bill= billDAO.Read(id);
            AccountDAO accountDAO = new AccountDAO();
            bill.account= accountDAO.Read(bill.account.id);
            BillDetailDAO billDetailDAO = new BillDetailDAO();
            bill.billDetails = billDetailDAO.ReadbyBill(bill);
            ProductDAO productDAO = new ProductDAO();
            foreach(BillDetail detail in bill.billDetails)
            {
                detail.product = productDAO.Read(detail.product.id);
            }    
            return bill;
        }

        public List<Bill> Search(string keyword)
        {
            BillDAO billDAO = new BillDAO();
            List<Bill> bills = billDAO.Search(keyword);
            AccountDAO accountDAO = new AccountDAO();
            foreach (Bill bill in bills)
            {
                bill.account = accountDAO.Read(bill.account.id);
            }
            return bills;
        }

        public List<Bill> SearchAll()
        {
            return Search("");
        }

        public void Update(Bill entity)
        {
            throw new NotImplementedException();
        }
    }
}
