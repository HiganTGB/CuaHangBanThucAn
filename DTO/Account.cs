using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CuaHangBanThucAn.DTO
{
    public class Account
    {
        public int id { get; set; } = -1;
        public string name { get; set; } = "";
        
        public string email { get; set; } = "";
        
        public string password { get; set; } = "";
        public Role role { get; set; } = new Role();
        public Boolean deleted { get; set; }//Đã xoá hay chưa
        public Account(DataRow dataRow)
        {
            this.id = (int)dataRow["id"];
            this.name = (string)dataRow["name"];
            this.email = (string)dataRow["email"];
            this.password = (string)dataRow["password"];
            this.role.id = (int)dataRow["role_id"];
            this.deleted = (bool)dataRow["deleted"];
            /*
             id int identity not null primary key,
            name nvarchar(max) not null,
            email nvarchar(max) not null,
            password nvarchar(max) not null,
            deleted bit default 0 not null,
            role_id int not null foreign key references Role(id)
             */
        }

        public Account(int id, string name, string email, string password, Role role, bool deleted)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
            this.deleted = deleted;
        }
        public Account() { }
        public Account(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public override bool Equals(object? obj)
        {
            return obj is Account account &&
                   id == account.id &&
                   name == account.name &&
                   email == account.email &&
                   password == account.password &&
                   role.id == account.role.id &&
                   deleted == account.deleted;
        }
    }
}
