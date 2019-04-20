using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLCDT_WF.DAO
{
    class SIMDAO
    {
        public static void updatesim(SIM sim)
        {
            QLCDTEntities2 db = new QLCDTEntities2();
            var update = (from a in db.SIMs
                          where a.IDSIM == sim.IDSIM
                          select a).Single();
            update.TRANGTHAI = sim.TRANGTHAI;          
            db.SaveChanges();
        }
    }
}
