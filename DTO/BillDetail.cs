using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.DTO
{
    public class BillDetail
    {
        /*
         bill_id int not null foreign key references Bill(id),
	    product_id int not null foreign key references Product(id),
	    price money not null,
	    discount int not null,
	    quantity int not null,
	    total money not null
         */
        public Bill bill { get; set; } = new Bill();
        public Product product { get; set; }=new Product();
        public long price { get; set; } = 0;
        public float discount { get; set; } = 0;
        public int quantity { get; set; } = 0;  
        public long total {get; set; } = 0;
        public BillDetail(DataRow dataRow)
        {
            this.bill.id = (int)dataRow["bill_id"];
            this.product.id = (int)dataRow["product_id"];
            decimal money = (decimal)dataRow["price"];
            this.price = (long)money;
            double discount = (double)dataRow["discount"];
            this.discount=(float) discount;
            this.quantity = (int)dataRow["quantity"];
            money = (decimal)dataRow["total"];
            this.total = (long)money;
        }
        public BillDetail() { }

        public BillDetail(Bill bill, Product product, long price, float discount, int quantity, long total)
        {
            this.bill = bill;
            this.product = product;
            this.price = price;
            this.discount = discount;
            this.quantity = quantity;
            this.total = total;
        }
        public void setProduct(Product product,int quantity)
        {
            this.product=product;
            this.price=product.price;
            this.discount = product.discount;
            this.quantity = quantity;
            float result = (price- (price * discount / 100)) * quantity;
            this.total = (long) result;
        }
        public void addMore(int quantity)
        {
            this.quantity += quantity;
            float result = (price - (price * discount / 100)) * quantity;
            this.total = (long)result;

        }
        public String toprint()
        {
            return string.Format("{0}|{1}|{2}|{3}\n", this.product.name, this.quantity, price - (long)((price* (long)discount) / 100),this.total);
        }
    }

}
