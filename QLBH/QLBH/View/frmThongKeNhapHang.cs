using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH.Control;

namespace QLBH.View
{
    public partial class frmThongKeNhapHang : Form
    {
        DataTable dtNhap = new DataTable();
        DataTable dtCT = new DataTable();
        HoangCtrl tke = new HoangCtrl();
        private int slcu;
        private DateTime tungay, denngay;


        public frmThongKeNhapHang()
        {
            InitializeComponent();
        }

        
    }
}
