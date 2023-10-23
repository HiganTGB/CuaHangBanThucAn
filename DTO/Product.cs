using CuaHangBanThucAn.LIB;
using CuaHangBanThucAn.LIB.Error;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CuaHangBanThucAn.DTO
{
    public class Product
    {
        /*
         id int identity not null primary key,
	    name nvarchar(max) not null,
	    type_id int not null foreign key references  TypeProduct(id),
	    price money not null,
	    discount float not null check (discount >= 0 and discount <=100),
	    stock int not null,
	    deleted bit default 0 not null
         */
        public int id { get; set; } = -1;
        public string name { get; set; } = "";
        public TypeProduct typeProduct { get; set; } = new TypeProduct();
        public long price { get; set; } = 0;
        public float discount { get; set; } = 0;
        public int stock { get; set; } = 0;
        [System.ComponentModel.Browsable(false)]
        public bool deleted { get; set; } = false;
        public Product() { }
        public Product(DataRow dataRow)
        {
            this.id = (int)dataRow["id"];
            this.name = (string)dataRow["name"];
            this.typeProduct.id = (int)dataRow["type_id"];
            decimal money =(decimal)dataRow["price"];
            this.price = (long)money;
            double discount = (double)dataRow["discount"];
            this.discount = (float)discount;
            this.stock = (int)dataRow["stock"];
            this.deleted = (bool)dataRow["deleted"];
        }

        public Product(int id, string name, TypeProduct typeProduct, long price, float discount, int stock, bool deleted)
        {
            this.id = id;
            this.name = name;
            this.typeProduct = typeProduct;
            this.price = price;
            this.discount = discount;
            this.stock = stock;
            this.deleted = deleted;
        }
        public long LastPrice()
        {
            float result = (this.price * this.discount) / 100;
            return this.price - (long)result;
        }
        public static long LastPrice(long price,float discount)
        {
            float result = (price * discount) / 100;
            return price - (long)result;
        }

        public override bool Equals(object? obj)
        {
            return obj is Product product &&
                   id == product.id &&
                   name == product.name &&
                   typeProduct.id==product.typeProduct.id &&
                   price == product.price &&
                   discount == product.discount &&
                   stock == product.stock &&
                   deleted == product.deleted;
        }
        public void check()
        {
            if(this.name == null||this.name.Trim().Length==0)
            {
                throw new AppException(1, "Tên không được để trống");
            }
            if(this.typeProduct.id==-1)
            {
                throw new AppException(1, "Loại sản phẩm không được để trống");

            }   
            if(this.price<0||this.price.ToString().Length==0||!Valid.isMoney(this.price.ToString()))
            {
                throw new AppException(1, "Giá tiền phải là kiểu số và phải lớn hơn bằng 0");
            }    
            if(this.stock<0||this.stock.ToString().Length==0||!Valid.isNumber(this.stock.ToString()))
            {
                throw new AppException(1, "Số lượng phải là kiểu số và lớn hơn bằng 0");
            }
            if(this.discount.ToString().Length==0|| this.discount.ToString().Length == 0||!Valid.isPercent(this.discount.ToString()))
            {
                throw new AppException(1, "Giảm giá phải là kiểu thập phân và lớn hơn bằng 0");
            }    
        }
    }
}
