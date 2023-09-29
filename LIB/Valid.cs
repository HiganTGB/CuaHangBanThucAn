using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.LIB
{
    public class Valid
    {
        public static bool isNumber(string str)
        {
            bool isNumber = int.TryParse(str, out int result);
            if(isNumber)
            {
                if(result < 0)
                    return false;
                return true;
            }
            return false;
        }
        public static bool isMoney(string str)
        {
            bool isNumber = decimal.TryParse(str, out decimal result);
            if (isNumber)
            {
                if (result < 0)
                    return false;
                if (result.ToString().Contains(".")||result.ToString().Contains(','))
                    return false;    
                return true;
            }
            return false;
        }
        public static bool isPercent(string str)
        {
            bool isNumber = float.TryParse(str, out float result);
            if (isNumber)
            {
                if (result < 0||result>100)
                    return false;
                return true;
            }
            return false;
        } 
        public static String castfloatSQL(string str)
        {
            return str.Replace(",", ".");
        }
    }
}
