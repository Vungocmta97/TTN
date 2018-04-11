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
    class SanPhamModTr
    {
        public static DataTable GetListSanPham()
        {
            return ConnectToSQLTr.GetData(" select MaSp,TenSP,HangSX,DVT,GiaNhap,GiaBan,SoLuong,TenQuay from SanPham ,QuayHang where SanPham.MaQuay=QuayHang.MaQuay ");
        }
        public static int InsertSanPham(SanPhamObjTr ctd)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@masp",ctd.MaSP),
                 new SqlParameter("@tensp",ctd.TenSP),
                new SqlParameter("@hangsx", ctd.HangSX),
                new SqlParameter("@dvt ", ctd.DVT),
                new SqlParameter("@gianhap ", ctd.GiaNhap),
                new SqlParameter("@giaban", ctd.GiaBan),
                new SqlParameter("@soluong ", ctd.SoLuong),
                new SqlParameter("@maquay",ctd.MaQuay)


            };
            return ConnectToSQLTr.ExecuteNonQuery("ThemSanPham", para);
        }

        public static int UpdateSanPham(SanPhamObjTr ctd)
        {

            SqlParameter[] para = new SqlParameter[]
            {
                  new SqlParameter("@masp",ctd.MaSP),
                 new SqlParameter("@tensp",ctd.TenSP),
                new SqlParameter("@hangsx", ctd.HangSX),
                new SqlParameter("@dvt ", ctd.DVT),
                new SqlParameter("@gianhap ", ctd.GiaNhap),
                new SqlParameter("@giaban", ctd.GiaBan),
                new SqlParameter("@soluong ", ctd.SoLuong),
                new SqlParameter("@maquay",ctd.MaQuay)



            };
            return ConnectToSQLTr.ExecuteNonQuery("SuaSanPham", para);
        }

        public static int DeleteSanPham(SanPhamObjTr ctd)
        {
            SqlParameter[] para = new SqlParameter[]
            {


                 new SqlParameter("@masp",ctd.MaSP)
            };
            return ConnectToSQLTr.ExecuteNonQuery("XoaSanPham", para);

        }
    }
}
