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
    class SanPhamCtrlTr
    {
        public static DataTable GetListSanPham()
        {
            return SanPhamModTr.GetListSanPham();

        }
        public static int InsertSanPham(SanPhamObjTr ctd)
        {
            return SanPhamModTr.InsertSanPham(ctd);
        }

        public static int UpdateSanPham(SanPhamObjTr ctd)
        {
            return SanPhamModTr.UpdateSanPham(ctd);

        }

        public static int DeleteSanPham(SanPhamObjTr ctd)
        {
            return SanPhamModTr.DeleteSanPham(ctd);

        }
    }
}
