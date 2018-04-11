using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH.Object;
using System.Data.SqlClient;
using System.Data;
namespace QLBH.Model
{
    class QuayHangModTr
    {
        public static DataTable GetListQuayHang()
        {
            return ConnectToSQLTr.GetData(" select * from QuayHang ");
        }
    }
}
