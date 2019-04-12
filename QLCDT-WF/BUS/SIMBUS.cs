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
    class SIMBUS
    {
        public static void UpdateSIM(SIM sim)
        {
            SIMDAO.updatesim(sim);
        }
    }
}
