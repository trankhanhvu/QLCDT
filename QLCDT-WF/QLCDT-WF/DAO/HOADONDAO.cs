using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace QLCDT_WF.DAO
{
    class HOADONDAO
    {
        public static Array laydshd(string idsim)
        {
            var db = new QLCDTEntities2();
            var listhd = (from a in db.HOADONs     
                          where a.IDSIM == idsim
                          orderby a.THANG,a.NAM
                          select new
                          {
                              IDSIM = a.IDSIM,
                              THANG = a.THANG,
                              NAM = a.NAM,
                              TONGTIEN = a.TONGTIEN,
                              TRANGTHAI = a.TRANGTHAI,                          
                          }).ToArray();
            return listhd;
        }

        public static Array laydsthang(string idsim)
        {
            var db = new QLCDTEntities2();
            var listctsd = (from a in db.HOADONs
                            where a.IDSIM == idsim
                            orderby a.IDSIM
                            select new
                            {
                                THANG = a.THANG
                            }
                            ).Distinct().ToArray();
            return listctsd;
        }

        public static Array laydsnam(string idsim)
        {
            var db = new QLCDTEntities2();
            var listctsd = (from a in db.HOADONs
                            where a.IDSIM == idsim
                            orderby a.IDSIM
                            select new
                            {
                                NAM = a.NAM
                            }
                            ).Distinct().ToArray();
            return listctsd;
        }

        public static Array searchhd(string idsim,int thang,int nam)
        {
            var db = new QLCDTEntities2();
            var listhd = (from a in db.HOADONs
                          where a.IDSIM == idsim && a.THANG == thang && a.NAM == nam
                          select new
                          {
                              IDSIM = a.IDSIM,
                              THANG = a.THANG,
                              NAM = a.NAM,
                              TONGTIEN = a.TONGTIEN,
                              TRANGTHAI = a.TRANGTHAI,
                          }).ToArray();
            if (listhd == null)

                return null;

            else
                return listhd;
        }

        public static void updatehd(HOADON hd)
        {
            QLCDTEntities2 db = new QLCDTEntities2();
            var update = (from a in db.HOADONs
                          where a.IDSIM == hd.IDSIM && a.THANG == hd.THANG && a.NAM == hd.NAM
                          select a).Single();
            update.TONGTIEN = hd.TONGTIEN;
            update.TRANGTHAI = hd.TRANGTHAI;
            
            db.SaveChanges();
        }

        public static void sendmail()
        {
            QLCDTEntities2 db = new QLCDTEntities2();
            var dskhchuathanhtoan = (from a in db.HOADONs
                                     join b in db.SIMs on a.IDSIM equals b.IDSIM
                                     join c in db.KHACHHANGs on b.CMND equals c.CMND
                                     where a.TRANGTHAI == "Chưa thanh toán"
                                     select new
                                     {
                                         TENKH = c.TENKH,
                                         IDSIM = a.IDSIM,
                                         THANG = a.THANG,
                                         NAM = a.NAM,
                                         TONGTIEN = a.TONGTIEN
                                     }).Take(2).ToList();

            foreach(var data in dskhchuathanhtoan)
            {
                try
                {
                    string tb = @"Xin chào " + data.TENKH + "\n" + "Quý khách chưa thanh toán tiền cước tháng "
                                    + data.THANG + " năm " + data.NAM + " !!!\n"
                                    + "Tổng tiền là : " + data.TONGTIEN + "\n"
                                    + "Vui lòng thanh toán để không bị cắt số !!! Thân ái và quyết thắng";

                    SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                    mailclient.EnableSsl = true;
                    mailclient.Credentials = new NetworkCredential("vietvalo3@gmail.com","vietvalo0");

                    MailMessage message = new MailMessage("vietvalo3@gmail.com", "vietvalo3@gmail.com");
                    message.Subject = "Thông báo đề nghị đóng tiền cước !!!";
                    message.Body = tb;

                    mailclient.Send(message);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gủi mail thất bại !!!" +ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static void tongketthanghientai()
        {
            int thanghientai = DateTime.Now.Month;
            int namhientai = DateTime.Now.Year;

            QLCDTEntities2 db = new QLCDTEntities2();
            var ktractsd = (from a in db.CTSDs
                                     where  a.TGBD.Month == thanghientai && a.TGBD.Year == namhientai
                                     select a).ToList();

            if(ktractsd != null)
            {
                foreach(var data in ktractsd)
                {
                    HOADON ktranullhoadon = (from a in db.HOADONs
                                                              where a.IDSIM == data.IDSIM && a.THANG == data.TGBD.Month && a.NAM == data.TGBD.Year
                    select a).FirstOrDefault();

                    if(ktranullhoadon == null)
                    {
                        HOADON add = new HOADON();
                        add.IDSIM = data.IDSIM;
                        add.THANG = data.TGBD.Month;
                        add.NAM = data.TGBD.Year;
                        add.TONGTIEN = 50000;
                        add.TRANGTHAI = "Chưa thanh toán";
                        db.HOADONs.Add(add);
                        db.SaveChanges();
                    }

                    DateTime tgbd = new DateTime(data.TGBD.Year, data.TGBD.Month, data.TGBD.Day, data.TGBD.Hour, data.TGBD.Minute, data.TGBD.Second);

                    //string bd = string.Format("{0:HH:mm:ss}", tgbd);

                    DateTime tgkt = new DateTime(data.TGBD.Year, data.TGBD.Month, data.TGBD.Day, data.TGKT.Hour, data.TGKT.Minute, data.TGKT.Second);

                    //string kt = string.Format("{0:HH:mm:ss}", tgkt);

                    //string bd = data.TGBD.Hour + ":" + data.TGBD.Minute + ":" + data.TGBD.Second;
                    //string kt = data.TGKT.Hour + ":" + data.TGKT.Minute + ":" + data.TGKT.Second;
                    HOADON update = (from a in db.HOADONs
                                         where a.IDSIM == data.IDSIM && a.THANG == data.TGBD.Month && a.NAM == data.TGBD.Year
                                         select a).Single();
                        update.TONGTIEN = update.TONGTIEN + CTSDDAO.tinhphi(tgbd,tgkt);
                        db.SaveChanges();
                                                                
                }
            }
            MessageBox.Show("Thêm HD tháng " + DateTime.Now.Month  + " năm " + DateTime.Now.Year +  " thành công !!!");
        }
    }
}
