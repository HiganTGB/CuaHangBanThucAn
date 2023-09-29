using CuaHangBanThucAn.DAO;
using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB.Error;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.BLL
{
    public class SellBLL
    {
        public SellBLL() { }
        public Bill addProduct(Bill bill,int id,int quantity)
        {
            ProductDAO productDAO = new ProductDAO();
            BillDetail billDetail=new BillDetail();
            Product product = productDAO.Read(id);
            if(quantity < 0)
            {
                throw new AppException(4, "Số lượng không được nhỏ hơn 0");
            }
            if(quantity > product.stock)
            {
                throw new AppException(4, "Số lượng mua vượt quá số lượng đang có");
            }    
            billDetail.setProduct(product, quantity);
            bill.add(billDetail);
            return bill;
        }
        public Bill removeDetail(Bill bill,int id) {
                bill.remove(id);
            return bill;
        }
        public Bill cancelBill(Bill bill)
        {
            bill=new Bill();
            return bill;
        }
        public Bill doneBill(Bill bill)
        {
            if(bill.pay<bill.total)
            {
                throw new AppException(5, "Chưa thanh toán đầy đủ hoá đơn");
            }    
            if(bill.billDetails.Count==0)
            {
                throw new AppException(4, "Hoá đơn trống");
            }
            bill.account.id = LoginBLL.UserLogin.id;
            bill.account.name = LoginBLL.UserLogin.name;
            BillDAO billDAO = new BillDAO();
            BillDetailDAO billDetailDAO = new BillDetailDAO();
            bill= billDAO.Create(bill);
            ProductDAO productDAO = new ProductDAO();
            foreach(BillDetail billDetail in bill.billDetails)
            {
                billDetailDAO.Create(billDetail);
                productDAO.Buy(billDetail);
            }
            Bill billdate = billDAO.Read(bill.id);
            bill.date = billdate.date;
            return bill;
        }
        public Bill addPayBill(Bill bill,long pay)
        {
            bill.addPay(pay);
            return bill;
        }
        public void printBill(Bill bill) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save PDF File";
            saveFileDialog.FileName = String.Format("bill_{0}", bill.id);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn và tên file
                string fileName = saveFileDialog.FileName;

                // Tạo một document mới
                Document document = new Document();


                // Ghi dữ liệu vào file PDF
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));

                document.Open();
                // Thêm dữ liệu vào document
                document.Add(new Paragraph(bill.toPrint()));
                writer.Flush();
                document.Close();
            }
        }
    }
}
