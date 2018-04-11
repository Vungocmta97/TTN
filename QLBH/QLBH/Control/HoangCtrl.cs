using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH.Model;
using System.Data;

namespace QLBH.Control
{
    class HoangCtrl
    {
        Hoang tk = new Hoang();
        public DataTable GetData(string s)
        {
            return tk.GetData(s);
        }
        public bool ThucHienLenh(string s)
        {
            return tk.ThucHienLenh(s);
        }
    }
}
