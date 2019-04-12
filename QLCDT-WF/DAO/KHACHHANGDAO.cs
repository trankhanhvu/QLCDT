using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLCDT_WF.DAO
{
    class KHACHHANGDAO
    {
        public static Array laydskh()
        {
            var db = new QLCDTEntities1();
            var listkh = (from a in db.KHACHHANGs
                          join b in db.SIMs on a.CMND equals b.CMND
                          orderby a.TENKH
                          select new
                          {
                              CMND = a.CMND,
                              TENKH = a.TENKH,
                              NGHENGHIEP = a.NGHENGHIEP,
                              CHUCVU = a.CHUCVU,
                              DIACHI = a.DIACHI,
                              EMAIL = a.EMAIL,
                              IDSIM = b.IDSIM,                            
                              TRANGTHAI = b.TRANGTHAI
                          }).ToArray();
            return listkh;
        }

        public static void updatekh(KHACHHANG kh)
        {
            QLCDTEntities1 db = new QLCDTEntities1();
            var update = (from a in db.KHACHHANGs
                          where a.CMND == kh.CMND
                          select a).Single();
            update.TENKH = kh.TENKH;
            update.NGHENGHIEP = kh.NGHENGHIEP;
            update.CHUCVU = kh.CHUCVU;
            update.DIACHI = kh.DIACHI;
            update.EMAIL = kh.EMAIL;
            db.SaveChanges();
        }

        public static void themkh(KHACHHANG kh,SIM sim)
        {
            QLCDTEntities1 db = new QLCDTEntities1();

            var checkcmnd = (from a in db.KHACHHANGs
                             where a.CMND == kh.CMND
                             select a).FirstOrDefault();

            var checkidsim = (from a in db.SIMs
                             where a.IDSIM == sim.IDSIM
                             select a).FirstOrDefault();
                       
            if (checkidsim != null) //tồn tại idsim
            {
                MessageBox.Show("Sim này đã được đăng kí !!!", "Thông báo !!!");
            }
            else
            if (checkcmnd != null) //tồn tại cmnd
            {
                db.SIMs.Add(sim);
                db.SaveChanges();
                MessageBox.Show("Thêm SIM thành công !!!", "Thông báo !!!");
            }
            else
            {
                db.KHACHHANGs.Add(kh);
                db.SIMs.Add(sim);
                db.SaveChanges();
                MessageBox.Show("Thêm khách hàng mới thành công !!!", "Thông báo !!!");
            }        
        }

        public static Array searchkh(string name)
        {
            var db = new QLCDTEntities1();
            var listkh = (from a in db.KHACHHANGs
                          join b in db.SIMs on a.CMND equals b.CMND
                          where a.TENKH.Contains(name)
                          select new
                          {
                              CMND = a.CMND,
                              TENKH = a.TENKH,
                              NGHENGHIEP = a.NGHENGHIEP,
                              CHUCVU = a.CHUCVU,
                              DIACHI = a.DIACHI,
                              IDSIM = b.IDSIM                             
                          }).ToArray();
            return listkh;
        }
    }
}
