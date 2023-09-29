using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.DTO
{
    public class Role
    {
        public int id { get; set; } = 0;
        public string name { get; set; } = "";
        public string permission { get; set; } = "";//ADMIN hoặc STAFF
        public bool deleted { get; set; } = false;
        public Role(DataRow dataRow) {
            this.id = (int)dataRow["id"];
            this.name = (string)dataRow["name"];
            this.permission = (string) dataRow["permission"];
            this.deleted = (bool)dataRow["deleted"];
        }
        public Role() { }

        public Role(int id, string name, string permission, bool deleted)
        {
            this.id = id;
            this.name = name;
            this.permission = permission;
            this.deleted = deleted;
        }

        public override bool Equals(object? obj)
        {
            return obj is Role role &&
                   id == role.id &&
                   name == role.name &&
                   permission == role.permission &&
                   deleted == role.deleted;
        }
    }
}
