using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH.Model;
using QLBH.ObjectT;
using System.Data;

namespace QLBH.Control
{
    class KhachHangCtrlTH
    {
       KhachHangModTH nccMod = new KhachHangModTH();
        public DataTable GetData()
        {
            return nccMod.GetData();
        }
        public bool addData(KhachHangObjTH nccObj)
        {
            return nccMod.AddData(nccObj);
        }
        public bool upData(KhachHangObjTH nccObj)
        {
            return nccMod.UpDate(nccObj);
        }
        public bool delData(string ma)
        {
            return nccMod.DelData(ma);
        }
        public DataTable getDataKH(string mancc)
        {
            return nccMod.GetDataKH(mancc);
        }
    }
}
