using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;
using PagedList;

namespace QLCDT1.Models
{
    public class MyViewModel
    {
        public IPagedList<SIMHD> ListHD { get; set; }
        public IPagedList<SIMCTSD> ListCTSD { get; set; }
        public IPagedList<SIMKH> ListKH { get; set; }
    }
}