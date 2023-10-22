using CuaHangBanThucAn.DAO;
using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.BLL
{
    public class RevenueBLL
    {
       private RevenueDAO revenueDAO = new RevenueDAO();
       public RevenueBLL() { }

        public List<Revenue> GetRevenue(DateTime start,DateTime end)
        {
                List<Revenue> revenueDTOs = new List<Revenue>();
                Revenue revenuetemp = new Revenue();
                if (start.Date > end.Date)//Thòi gian lỗi
                {
                    throw new AppException(102, "Thời gian sau phải lớn hơn hoặc bằng thời gian trước");
                }
                if (start.Date == end.Date)//Hai thời gian bằng
                {
                    revenuetemp = revenueDAO.getRevenue(start);
                    revenueDTOs.Add(revenuetemp);
                    return revenueDTOs;
                }
                if (end.Date == DateTime.Now.Date)//Chỉ có thời gian sau là ngày hôm nay
                {
                    DateTime x = start;
                    while (x < end.AddDays(-1))
                    {
                        revenuetemp = revenueDAO.getRevenue(x);
                        revenueDTOs.Add(revenuetemp);
                        x = x.AddDays(1);
                    }
                    revenuetemp = revenueDAO.getRevenue(end);
                    revenuetemp.dateid = end;
                    revenueDTOs.Add(revenuetemp);
                    return revenueDTOs;
                }//Bình thường
                DateTime y = start;
                while (y <= end)
                {
                    revenuetemp = revenueDAO.getRevenue(y);
                    revenueDTOs.Add(revenuetemp);
                    y = y.AddDays(1);
                }
                return revenueDTOs;
        }
    }
}

