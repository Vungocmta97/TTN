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
using QLBH.Object;
namespace QLBH.View
{
    public partial class frmThongKeSoLuongHang : Form
    {
		public frmThongKeSoLuongHang()
        {
            InitializeComponent();
        }

        private void dtvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            lalMaSP.Text = dtvSanPham.CurrentRow.Cells["masp"].Value.ToString();
           lalTenSP.Text = dtvSanPham.CurrentRow.Cells["tensp"].Value.ToString();
            lalHangSX.Text = dtvSanPham.CurrentRow.Cells["hangsx"].Value.ToString();
           lalDVT.Text = dtvSanPham.CurrentRow.Cells["dvt"].Value.ToString();
            lalGiaNhap.Text = dtvSanPham.CurrentRow.Cells["gianhap"].Value.ToString();
            lalGiaBan.Text = dtvSanPham.CurrentRow.Cells["giaban"].Value.ToString();
            lalSoLuong.Text = dtvSanPham.CurrentRow.Cells["soluong"].Value.ToString();
            lalQuayHang.Text = dtvSanPham.CurrentRow.Cells["quayhang"].Value.ToString();
            if (int.Parse(lalSoLuong.Text) == 0)
            {
                lalhang.Text = "Hết Sản Phẩm";
            }
            else
            {
                lalhang.Text = "Sản Phẩm Còn";
            }
            //txtTimKiem.Text = "Nhập Tên Sản Phẩm hoặc Mã Sản Phẩm hoặc Quầy Hàng hoặc Hãng";
            //dt = SanPhamCtrlTr.GetListSanPham();
            //dtvSanPham.DataSource = dt;
        }

        private void dtvSanPham_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dtvSanPham.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
        }
        DataTable dt = new DataTable();
        private void frmThongKeSoLuongHang_Load(object sender, EventArgs e)
        {
            dt = SanPhamCtrlTr.GetListSanPham();
            dtvSanPham.DataSource = dt;
        }

        private void lalGiaBan_TextChanged(object sender, EventArgs e)
        {
            lalGiaBan.Text = string.Format("{0:0,0 }", (float.Parse(lalGiaBan.Text)) );
        }

        private void lalGiaNhap_TextChanged(object sender, EventArgs e)
        {
            lalGiaNhap.Text = string.Format("{0:0,0 }" , (float.Parse(lalGiaNhap.Text)));
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
          
                string str = string.Format("MaSP like '%{0}%' or TenSP like '%{0}%'  or TenQuay like '%{0}%' or HangSX like '%{0}%'  ", txtTimKiem.Text);
                dt.DefaultView.RowFilter = str;
            
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void lalhang_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
	}
}
