using QLCDT1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace QLCDT1.Controllers
{
    public class HomeController : Controller
    {
        QLCDTEntities db = new QLCDTEntities();
        public ActionResult Index(string searching, int? i, int? j, string month, string year)
        {
            ViewBag.Searching = searching;
            ViewBag.month = month;
            ViewBag.year = year;
            var ListHD = (from a in db.SIMs
                          join b in db.KHACHHANGs on a.CMND equals b.CMND
                          join c in db.HOADONs on a.IDSIM equals c.IDSIM
                          where a.IDSIM == searching
                          select new SIMHD()
                          {
                              CMND = a.CMND,
                              TENKH = b.TENKH,
                              IDSIM = a.IDSIM,
                              TRANGTHAISIM = a.TRANGTHAI,
                              THANG = c.THANG,
                              NAM = c.NAM,
                              TONGTIEN = c.TONGTIEN,
                              TRANGTHAI = c.TRANGTHAI
                          }).ToList().ToPagedList(i ?? 1, 10);
            ViewBag.PageListHD = i;
            var ListCTSD = (from a in db.SIMs
                            join b in db.KHACHHANGs on a.CMND equals b.CMND
                            join c in db.CTSDs on a.IDSIM equals c.IDSIM
                            where a.IDSIM == searching && c.TGBD.Month.ToString() == month && c.TGBD.Year.ToString() == year
                            select new SIMCTSD()
                            {
                                CMND = a.CMND,
                                TENKH = b.TENKH,
                                IDSIM = a.IDSIM,
                                TGBD = c.TGBD,
                                TGKT = c.TGKT,
                                THANHTIEN = c.THANHTIEN
                            }).ToList().ToPagedList(j ?? 1, 3);
            var ListKH = (from a in db.SIMs
                          join b in db.KHACHHANGs on a.CMND equals b.CMND
                          where a.IDSIM == searching
                          select new SIMKH()
                          {
                              CMND = a.CMND,
                              TENKH = b.TENKH,
                              IDSIM = a.IDSIM,
                              TRANGTHAISIM = a.TRANGTHAI
                          }).ToList().ToPagedList(1,10);
            ViewBag.PageListCTSD = j;
            MyViewModel model = new MyViewModel();
            model.ListHD = ListHD;
            model.ListCTSD = ListCTSD;
            model.ListKH = ListKH;
            return View(model);
        }
        public ActionResult Index2(string searching, int? i)
        {
            var ListHD = (from a in db.SIMs
                         join b in db.KHACHHANGs on a.CMND equals b.CMND
                         where a.CMND == searching
                         select new SIMHD()
                         {
                             CMND = a.CMND,
                             TENKH = b.TENKH,
                             IDSIM = a.IDSIM,
                         }).ToList().ToPagedList(i ?? 1, 10);
            MyViewModel model = new MyViewModel();
            model.ListHD = ListHD;

            return View(model);
        }
    }
}