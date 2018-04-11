using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH.Model;
using QLBH.Object;
using System.Data;


namespace QLBH.Control
{
    class NhanVienCtrl
    {
       
            public static DataTable GetData()
            {
                return NhanVienMod.GetData();
            }
            public static DataTable GetDataQuay()
            {
                return NhanVienMod.GetDataQuay();
            }

            public static int InsertProfile(NhanVienObj qh)
            {
                return NhanVienMod.InsertProfile(qh);
            }

            public static int UpdateProfile(NhanVienObj qh)
            {
                return NhanVienMod.UpdateProfile(qh);
            }

            public static int DeleteProfile(NhanVienObj qh)
            {
                return NhanVienMod.DeleteProfile(qh);
            }
        }
    }

