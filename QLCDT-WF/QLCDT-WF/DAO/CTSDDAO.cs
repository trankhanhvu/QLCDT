using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace QLCDT_WF.DAO
{
    class CTSDDAO
    {

        public static void taofilesim()
        {           
            // lấy danh sách sim để ghi vào file sim
            QLCDTEntities2 db = new QLCDTEntities2();
            var dssim = (from a in db.SIMs
                         where a.TRANGTHAI == "Đã kích hoạt"
                         select new { a.IDSIM }).ToList();

            StreamWriter write = new StreamWriter("sim.txt");
            foreach (var data in dssim)
            {

                string idsim = data.IDSIM;
                write.WriteLine(idsim);
            }
            write.Close();
        }

        public static string randtgbd()
        {
            Random rd = new Random(Guid.NewGuid().GetHashCode());
            int h = rd.Next(0, 24);
            int m = rd.Next(0, 29);
            int s = rd.Next(0, 29);

            DateTime tgbd = new DateTime(2000, 12, 25, h, m, s);

            string temp = string.Format("{0:HH:mm:ss}", tgbd);
            return temp;
        }

        public static string randtgkt(string tgbd)
        {
            Random rd = new Random(Guid.NewGuid().GetHashCode());
            int[] x = { 0, 0, 0, 0, 0, 0, 0, 0 };

            string gio = tgbd.Substring(0, 2);
            int h = x[rd.Next(0, 7)] + int.Parse(gio);
            if (h > 23)
                h = h - 24;

            string phut = tgbd.Substring(3, 2);
            int m = rd.Next(0, 20) + int.Parse(phut);
            string giay = tgbd.Substring(6, 2);
            int s = rd.Next(0, 20) + int.Parse(giay);

            DateTime tgkt = new DateTime(2000, 12, 25, h, m, s);

            string temp = string.Format("{0:HH:mm:ss}", tgkt);
            return temp;
        }

        public static string randngay()
        {
            looprand:
            int ngayhientai = DateTime.Now.Day;
            int namhientai = DateTime.Now.Year;
            int thanghientai = DateTime.Now.Month;

            Random rd = new Random(Guid.NewGuid().GetHashCode());
            int[] days = { 30, 27, 30, 29, 30, 29, 30, 30, 31, 30, 29, 30 };
            int[] year = { namhientai - 1, namhientai - 1, namhientai, namhientai, namhientai, namhientai, namhientai - 1, namhientai - 1 };

            int y = year[rd.Next(0, 7)];
            int m = rd.Next(1, 12);
            int d = rd.Next(1, days[m - 1]);

            if (y < namhientai || (y == namhientai && m < thanghientai))
            {
                DateTime ngay = new DateTime(y, m, d);
                string temp = String.Format("{0:yyyy/MM/dd}", ngay);
                return temp;

            }
            else
            if(y == namhientai && m == thanghientai && d <= ngayhientai )
            {
                DateTime ngay = new DateTime(y, m, d);
                string temp = String.Format("{0:yyyy/MM/dd}", ngay);
                return temp;
            }
            else
                goto looprand;
            
        }

        //file ctsd
        public static void taofilelog()
        {
            Random rd = new Random(Guid.NewGuid().GetHashCode());
            StreamWriter write = new StreamWriter("log.txt");
            QLCDTEntities2 db = new QLCDTEntities2();
            int ngayhientai = DateTime.Now.Day;
            int thanghientai = DateTime.Now.Month;
            int namhientai = DateTime.Now.Year;

            for (int i=0; i<100;i++)
            {                         
                StreamReader read = new StreamReader("sim.txt");

                int dodai = 0;
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    dodai++;
                }

                read.Close();

                StreamReader read2 = new StreamReader("sim.txt");
                string[] dssim = new string[dodai];

                for (int a=0; a < dodai ; a++ )
                {                 
                    dssim[a] = read2.ReadLine();                                    
                }
                read2.Close();
               
                string idsim = dssim[rd.Next(0, dodai)];
                string ngaybd = randngay();
                string ngaykt = ngaybd;
                string tgbd = randtgbd();
                string tgkt = randtgkt(tgbd);

                write.Write(idsim + "\t" + ngaybd + " " + tgbd + "\t" + ngaykt + " " + tgkt + "\n");
                
                
                

                // if (int.Parse(ngaybd.Substring(0,4)) < namhientai || ( int.Parse(ngaybd.Substring(0, 4)) == namhientai && int.Parse(ngaybd.Substring(5,2)) < thanghientai ))
                
                    CTSD ct = new CTSD();
                    ct.IDSIM = idsim;
                    ct.TGBD = Convert.ToDateTime(ngaybd + " " + tgbd);
                    ct.TGKT = Convert.ToDateTime(ngaykt + " " + tgkt);
                    ct.THANHTIEN = tinhphi(ct.TGBD, ct.TGKT);

                    
                    db.CTSDs.Add(ct);
                    db.SaveChanges();
                
                              
                //kiểm tra xem tồn tại trong HD chưa
                

                int thang = int.Parse(ngaybd.Substring(5, 2));
                int nam = int.Parse(ngaybd.Substring(0, 4));

                HOADON ktranullhoadon = (from a in db.HOADONs
                                      where a.IDSIM == idsim && a.THANG == thang  && a.NAM == nam
                                      select a).FirstOrDefault();
                //chưa thì add
                if(ktranullhoadon == null && (nam < namhientai || ( nam == namhientai && thang < thanghientai)))
                {
                    HOADON hd = new HOADON();
                    hd.IDSIM = idsim;
                    hd.THANG = thang;
                    hd.NAM = nam;
                    hd.TONGTIEN = 50000;
                    hd.TRANGTHAI = "Đã thanh toán";
                    db.HOADONs.Add(hd);
                    db.SaveChanges();
                }
                
                if(nam < namhientai || (nam == namhientai && thang < thanghientai))
                {
                    HOADON update = (from a in db.HOADONs
                                     where a.IDSIM == idsim && a.THANG == thang && a.NAM == nam
                                     select a).Single();
                    update.TONGTIEN = update.TONGTIEN + tinhphi(ct.TGBD, ct.TGKT);
                    db.SaveChanges();
                }
                                                                  
            }
            
            //thêm vào những tháng không có ctsd phí hòa mạng 50k
            var them = (from a in db.HOADONs
                        select new
                        {
                            IDSIM = a.IDSIM,
                            NAM = a.NAM
                        }).Distinct().ToList();

            foreach (var data in them)
            {
                if (data.NAM < namhientai)
                {
                    var danhsachthangchuaco = (from a in db.HOADONs
                                               where a.IDSIM == data.IDSIM && a.NAM == data.NAM
                                               select a).ToList();

                    for (int i = 1; i <= 12; i++)
                    {
                        int dem = 0;
                        foreach(var data2 in danhsachthangchuaco)
                        {
                            if (i == data2.THANG)
                            { dem++; break; }

                        }
                        if(dem==0)
                        {
                            HOADON hd = new HOADON();
                            hd.IDSIM = data.IDSIM;
                            hd.THANG = i;
                            hd.NAM = data.NAM;
                            hd.TONGTIEN = 50000;
                            hd.TRANGTHAI = "Đã thanh toán";
                            db.HOADONs.Add(hd);
                            db.SaveChanges();
                        }
                            
                    }
                }

                if (data.NAM == namhientai)
                {
                    var danhsachthangchuaco = (from a in db.HOADONs
                                               where a.IDSIM == data.IDSIM && a.NAM == data.NAM
                                               select a).ToList();

                    for (int i = 1; i < thanghientai; i++)
                    {
                        int dem = 0;
                        foreach (var data2 in danhsachthangchuaco)
                        {
                            if (i == data2.THANG)
                            { dem++; break; }

                        }
                        if (dem == 0)
                        {
                            HOADON hd = new HOADON();
                            hd.IDSIM = data.IDSIM;
                            hd.THANG = i;
                            hd.NAM = data.NAM;
                            hd.TONGTIEN = 50000;
                            hd.TRANGTHAI = "Đã thanh toán";
                            db.HOADONs.Add(hd);
                            db.SaveChanges();
                        }

                    }
                }

            }
            

            write.Close();
        }

        public static double tinhphi(DateTime tgbd, DateTime tgkt)
        {
            QLCDTEntities2 db = new QLCDTEntities2();
            var cuoc = from a in db.CUOCs
                       select a;

            int[] bd = new int[2];
            int[] kt = new int[2];
            double[] phi = new double[2];

            int i = 0;
            foreach(var data in cuoc)
            {
                bd[i] = data.GIOBD;
                kt[i] = data.GIOKT;
                phi[i] = Convert.ToDouble(data.PHI);
                i++;
            }

            /*
            
            int giobd = int.Parse(tgbd.Substring(0, 2));
            int phutbd = int.Parse(tgbd.Substring(3, 2));

            int giokt = int.Parse(tgkt.Substring(0, 2));
            int phutkt = int.Parse(tgkt.Substring(3, 2));
                   
            // khoảng 7 -> 17h
            if(giobd >= bd[0] && giokt <= kt[0])
            {
                int gio = giokt - giobd;
                int phut = phutkt - phutbd;
                double thanhtien = (gio * 60 + phut) * phi[0];
                return thanhtien;
            }        
            else
            
            // khoảng 17h -> 7h
            if(giobd >= bd[1] && giokt <= 23)
            {
                int gio = giokt - giobd;
                int phut = phutkt - phutbd;
                double thanhtien = (gio * 60 + phut) * phi[1];
                return thanhtien;
            }
            else
            if(giobd >= 0 && giokt <= kt[1])
            {
                int gio = giokt - giobd;
                int phut = phutkt - phutbd;
                double thanhtien = (gio * 60 + phut) * phi[1];
                return thanhtien;
            }

            /*
            else
            if( (giobd >= bd[0] && giobd <= kt[0]) && giokt > kt[0])
            {
                int gio1 = kt[0] - giobd;
                int gio2 = giokt - kt[0];
                int phut = phutkt - phutbd;
                double thanhtien = gio1 * 60 * phi[0] + gio2 * 60 * phi[1] + phut * phi[0];
                return thanhtien;
            }
            
            else
            if (giobd >= bd[1] && giokt > kt[1])
            {
                int gio1 = 24 + kt[1] - giobd;
                int gio2 = giokt - kt[1];
                int phut = phutkt - phutbd;
                double thanhtien = gio1 * 60 * phi[1] + gio2 * 60 * phi[0] + phut * phi[1];
                return thanhtien;
            }
            //
            else
                return 0;
                */
            DateTime tam = new DateTime();
            tam = tgbd;
            double thanhtien = 0;

            while(DateTime.Compare(tam,tgkt) <= 0)
            {
                tam = tam.AddMinutes(1);
                if (tam.Hour <= kt[0] && tam.Hour >= bd[0])
                    thanhtien = thanhtien + phi[0] * 1.0;
                else thanhtien = thanhtien + phi[1] * 1.0;
            }
            return thanhtien;

        }

        public static Array laydsctsd(string idsim)
        {
            var db = new QLCDTEntities2();
            var listctsd = (from a in db.CTSDs
                            where a.IDSIM == idsim
                            orderby a.TGBD
                            select new
                            {
                                IDSIM = a.IDSIM,
                                TGBD = a.TGBD,
                                TGKT = a.TGKT,
                                THANHTIEN = a.THANHTIEN
                            }
                            ).ToArray();
            return listctsd;
        }

        public static Array laydsthang(string idsim)
        {
            var db = new QLCDTEntities2();
            var listctsd = (from a in db.CTSDs    
                            where a.IDSIM == idsim
                            orderby a.TGBD
                            select new
                            {
                               THANG = a.TGBD.Month
                            }
                            ).Distinct().ToArray();
            return listctsd;
        }

        public static Array laydsnam(string idsim)
        {
            var db = new QLCDTEntities2();
            var listctsd = (from a in db.CTSDs
                            where a.IDSIM == idsim
                            orderby a.TGBD
                            select new
                            {
                                NAM = a.TGBD.Year
                            }
                            ).Distinct().ToArray();
            return listctsd;
        }

        public static Array searchctsd(int month,int year,string idsim)
        {
            var db = new QLCDTEntities2();
            var listctsd = (from a in db.CTSDs
                            where a.TGBD.Month == month && a.TGBD.Year == year && a.IDSIM == idsim
                            select new
                            {
                                IDSIM = a.IDSIM,
                                TGBD = a.TGBD,
                                TGKT = a.TGKT,
                                THANHTIEN = a.THANHTIEN
                            }
                            ).ToArray();
            if(listctsd == null)
            
            return null;
            
            else
            return listctsd;
        }

        public static void updatectsd(CTSD ctsd)
        {
            var db = new QLCDTEntities2();
            var update = (from a in db.CTSDs
                          where a.IDSIM == ctsd.IDSIM && a.TGBD == ctsd.TGBD && a.TGKT == ctsd.TGKT
                          select a).Single() ;

            update.THANHTIEN = ctsd.THANHTIEN;
            db.SaveChanges();
        }

        public static void doclaifilelog()
        {
            QLCDTEntities2 db = new QLCDTEntities2();
            StreamReader read = new StreamReader("log.txt");
            string line;
            while((line=read.ReadLine()) != null)
            {
                char[] kitudexoa = new char[] { '\t', ' ' };
                string[] parts = line.Split(kitudexoa,
                                 StringSplitOptions.RemoveEmptyEntries);

                string idsim = parts[0];
                DateTime tgbd = Convert.ToDateTime(parts[1] + " " + parts[2]);
                DateTime tgkt = Convert.ToDateTime(parts[3] + " " + parts[4]);

                CTSD ktctsdnull = (from a in db.CTSDs
                             where a.TGBD == tgbd && a.TGKT == tgkt && a.IDSIM == idsim
                             select a).FirstOrDefault();

                if(ktctsdnull == null)
                {
                    CTSD ct = new CTSD();
                    ct.IDSIM = idsim;
                    ct.TGBD = tgbd;
                    ct.TGKT = tgkt;
                    ct.THANHTIEN = tinhphi(ct.TGBD, ct.TGKT);

                    db.CTSDs.Add(ct);
                    db.SaveChanges();


                    //kiểm tra xem tồn tại trong HD chưa

                    int thanghientai = DateTime.Now.Month;
                    int namhientai = DateTime.Now.Year;

                    int thang = tgbd.Month;
                    int nam = tgbd.Year;

                    HOADON ktranullhoadon = (from a in db.HOADONs
                                             where a.IDSIM == idsim && a.THANG == thang && a.NAM == nam
                                             select a).FirstOrDefault();
                    //chưa thì add
                    if (ktranullhoadon == null && (nam < namhientai || (nam == namhientai && thang < thanghientai)))
                    {
                        HOADON hd = new HOADON();
                        hd.IDSIM = idsim;
                        hd.THANG = thang;
                        hd.NAM = nam;
                        hd.TONGTIEN = 50000;
                        hd.TRANGTHAI = "Đã thanh toán";
                        db.HOADONs.Add(hd);
                        db.SaveChanges();
                    }

                    if (nam < namhientai || (nam == namhientai && thang < thanghientai))
                    {
                        HOADON update = (from a in db.HOADONs
                                         where a.IDSIM == idsim && a.THANG == thang && a.NAM == nam
                                         select a).Single();
                        update.TONGTIEN = update.TONGTIEN + tinhphi(ct.TGBD, ct.TGKT);
                        db.SaveChanges();
                    }
                }
              
            }
        }
    }
}
