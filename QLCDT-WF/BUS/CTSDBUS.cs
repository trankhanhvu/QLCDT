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
    class CTSDBUS
    {
        public static void TaoFileSIM()
        {
            CTSDDAO.taofilesim();
        }

        public static void TaoFileLog()
        {
            CTSDDAO.taofilelog();
        }

        public static Array LayDSCTSD(string idsim)
        {
            return CTSDDAO.laydsctsd(idsim);
        }

        public static Array SearchCTSD(int month,int year,string idsim)
        {
            return CTSDDAO.searchctsd(month,year, idsim);
        }

        public static void UpdateCTSD(CTSD ctsd)
        {
            CTSDDAO.updatectsd(ctsd);
        }

        public static Array LaydsThang(string idsim)
        {
            return CTSDDAO.laydsthang(idsim);
        }

        public static Array LaydsNam(string idsim)
        {
            return CTSDDAO.laydsnam(idsim);
        }
    }
}
