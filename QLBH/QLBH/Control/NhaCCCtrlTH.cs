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
    class NhaCCCtrlTH
    {
        NhaCCModTH nccMod = new NhaCCModTH();
        public DataTable GetData()
        {
            return nccMod.GetData();
        }
        public bool addData(NhaCCObjTH nccObj)
        {
            return nccMod.AddData(nccObj);
        }
        public bool upData(NhaCCObjTH nccObj)
        {
            return nccMod.UpDate(nccObj);
        }
        public bool delData(string ma)
        {
            return nccMod.DelData(ma);
        }
        public DataTable getDataNCC(string mancc)
        {
            return nccMod.GetDataNCC(mancc);
        }
    }
}
