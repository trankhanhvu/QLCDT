using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLCDT_WF.DAO;

namespace QLCDT_WF.BUS
{
    class KHACHHANGBUS
    {
        public static Array LayDSKH()
        {
            return KHACHHANGDAO.laydskh();
        }

        public static void UpdateKH(KHACHHANG kh)
        {
            KHACHHANGDAO.updatekh(kh);
        }

        public static void ThemKH(KHACHHANG kh,SIM sim)
        {
            KHACHHANGDAO.themkh(kh,sim);          
        }

        public static Array SearchKH(string name)
        {
            return KHACHHANGDAO.searchkh(name);
        }
		// hello
    }
}
