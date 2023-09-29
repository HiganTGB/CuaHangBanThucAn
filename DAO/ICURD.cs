using CuaHangBanThucAn.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.DAO
{
    
    interface ICURD<T>
    {
        T Create(T entity);
        T Read(int id);
        void Update(T entity);
        void Delete(int id);
        List<T> Search(string keyword);

        List<T> SearchAll();
    }
}
