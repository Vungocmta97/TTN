using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLBH.Object;

namespace QLBH.Model
{
    class NhanVienMod
    {
        public static SqlConnection conn;
        public static DataTable GetData()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = " select MaNV,TenNV,GioiTinh,DiaChi,SDT,NgaySinh,Luong,TenQuay from NhanVien n left join QuayHang q on n.MaQuay=q.MaQuay";
                conn = ConnectToSQL_Datvd.Connect();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }
        public static DataTable GetDataQuay()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = " select * from QuayHang";
                conn = ConnectToSQL_Datvd.Connect();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }


        public static int InsertProfile(NhanVienObj qh)
        {
            SqlParameter[] para = new SqlParameter[]
             {
                new SqlParameter("@ma", qh.MaNV),
                new SqlParameter("@gioitinh",qh.GioiTinh),
                new SqlParameter("@ten",qh.TenNV),
                 new SqlParameter("@maquay", qh.MaQuay),
                new SqlParameter("@ngay",qh.NgaySinh),
                new SqlParameter("@luong",qh.Luong),
                new SqlParameter("@diachi",qh.DiaChi),
                new SqlParameter(@"sdt",qh.SDT)

             };

            return ConnectToSQL_Datvd.Execute_NonQuery("ThemNhanVien", para);
        }
    
        public static int UpdateProfile(NhanVienObj qh)
        {
            SqlParameter[] para = new SqlParameter[]
            { new SqlParameter("@ma", qh.MaNV),
                new SqlParameter("@gioitinh",qh.GioiTinh),
                new SqlParameter("@ten",qh.TenNV),
                 new SqlParameter("@maquay", qh.MaQuay),
                new SqlParameter("@ngay",qh.NgaySinh),
                new SqlParameter("@luong",qh.Luong),
                new SqlParameter("@diachi",qh.DiaChi),
                new SqlParameter(@"sdt",qh.SDT)
            };

            return ConnectToSQL_Datvd.Execute_NonQuery("SuaNhanVien", para);
        }
        public static int DeleteProfile(NhanVienObj qh)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", qh.MaNV)

            };

            return ConnectToSQL_Datvd.Execute_NonQuery("XoaNhanVien", para);
        }
    }
}
