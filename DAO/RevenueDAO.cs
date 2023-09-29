using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB.Error;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.DAO
{
    public class RevenueDAO
    {
        public RevenueDAO() { }
        public Revenue getRevenue(DateTime date)
        {
            string query = String.Format("SELECT * from func_Revenue('{0}')", date.ToString("yyyy-MM-dd"));
            DataTable data = DataProvider.ExecuteQuery(query);
            if (data.Rows.Count == 0)
            {
                return new Revenue(date,0,0,0);
            }
            return new Revenue(data.Rows[0]);
        }
    }
}
