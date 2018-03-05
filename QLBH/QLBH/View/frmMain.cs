using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_KhachHang().ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_NhaCC().ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_NhanVien().ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSanPham().ShowDialog();
        }

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmHoaDonNhapHang().ShowDialog();
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmHoaDonBanHang().ShowDialog();
        }

        private void thốngKêNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmThongKeNhapHang().ShowDialog();
        }

        private void thốngKêBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmThongKeBanHang().ShowDialog();
        }

        private void thốngKêSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmThongKeSoLuongHang().ShowDialog();
        }
    }
}
