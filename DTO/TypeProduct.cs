using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.DTO
{
    public class TypeProduct
    {
        public int id { get; set; } = -1;
        public string name { get; set; } = "";
        public bool deleted { get; set; } = false;

        public TypeProduct(int id, string name, bool deleted)
        {
            this.id = id;
            this.name = name;
            this.deleted = deleted;
        }
        public TypeProduct(DataRow dataRow)
        {
            this.id = (int)dataRow["id"];
            this.name = (string)dataRow["name"];
            this.deleted = (bool)dataRow["deleted"];
        }
        public TypeProduct()
        {

        }
        public override bool Equals(object? obj)
        {
            return obj is TypeProduct product &&
                   id == product.id &&
                   name == product.name &&
                   deleted == product.deleted;
        }
    }
}
