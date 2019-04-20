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
    class HOADONBUS
    {
        public static Array LayDSHD(string idsim)
        {
            return HOADONDAO.laydshd(idsim);
        }

        public static Array SeachHD(string idsim,int thang,int nam)
        {
            return HOADONDAO.searchhd(idsim,thang,nam);
        }

        public static void UpdateHD(HOADON hd)
        {
            HOADONDAO.updatehd(hd);
        }

        public static void SendMailTB()
        {
            HOADONDAO.sendmail();
        }

        public static Array LaydsThang(string idsim)
        {
            return HOADONDAO.laydsthang(idsim);
        }

        public static Array LaydsNam(string idsim)
        {
            return HOADONDAO.laydsnam(idsim);
        }

        public static void Tongketthanghientai()
        {
            HOADONDAO.tongketthanghientai();
            
        }
    }
}
