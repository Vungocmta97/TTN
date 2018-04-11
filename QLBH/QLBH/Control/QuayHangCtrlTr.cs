using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH.Object;
using QLBH.Model;
using System.Data.SqlClient;
using System.Data;
namespace QLBH.Control
{
    class QuayHangCtrlTr
    {
        public static DataTable GetListQuayHang()
        {
            return QuayHangModTr.GetListQuayHang();

        }
    }

}
