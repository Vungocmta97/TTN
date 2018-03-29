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


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            string s = "select * from HoaDonNhapHang where NgayNhap between '" + dtpTuNgay.Value.ToShortDateString() + "' and '" + dtpDenNgay.Value.ToShortDateString() + "'";
            dtNhap = tke.GetData(s);
            dgvPhieuNhap.DataSource = dtNhap;
            tungay = dtpTuNgay.Value;
            denngay = dtpDenNgay.Value;

            if (dgvPhieuNhap.Rows.Count == 0)
            {
                btnXoa.Enabled = false;
                btnXoaCT.Enabled = false;
                btnSua.Enabled = false;
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
            }


            txtMaPhieu.DataBindings.Clear();
            txtMaPhieu.DataBindings.Add("Text", dtNhap, "MaHDN");
            dtpNgayNhap.DataBindings.Clear();
            dtpNgayNhap.DataBindings.Add("Text", dtNhap, "NgayNhap");

            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dtNhap, "TongTien");
        }

        private void frmThongKeNhapHang_Load(object sender, EventArgs e)
        {

            dtpDenNgay.Value = DateTime.Today;
            btnXoa.Enabled = false;
            btnXoaCT.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            nudSoLuong.Enabled = false;
            nudDonGia.Enabled = false;
            txtThanhTien.Enabled = false;
        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {
            cmbNhanVien.DataSource = tke.GetData("select HoaDonNhapHang.MaNV, TenNV from NhanVien, HoaDonNhapHang where HoaDonNhapHang.MaNV = NhanVien.MaNV and MaHDN = '" + txtMaPhieu.Text.Trim() + "'");
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";

            cmbNhaCC.DataSource = tke.GetData("select HoaDonNhapHang.MaNCC, TenNCC from NhaCC, HoaDonNhapHang where HoaDonNhapHang.MaNCC = NhaCC.MaNCC and MaHDN = '" + txtMaPhieu.Text.Trim() + "'");
            cmbNhaCC.DisplayMember = "TenNCC";
            cmbNhaCC.ValueMember = "MaNCC";

            //chi tiet
            dtCT = tke.GetData("select SanPham.MaSP, TenSP, ChiTietNhapHang.SoLuong, ChiTietNhapHang.GiaNhap, ThanhTien from SanPham, ChiTietNhapHang where SanPham.MaSP = ChiTietNhapHang.MaSP and MaHDN = '" + txtMaPhieu.Text.Trim() + "'");
            dgvChiTiet.DataSource = dtCT;

            if (dgvChiTiet.Rows.Count > 0)
            {
                btnXoaCT.Enabled = true;
                btnSua.Enabled = true;
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
            }
            else
            {
                btnXoaCT.Enabled = false;
                btnSua.Enabled = false;
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
            }

            txtMaSP.DataBindings.Clear();
            txtMaSP.DataBindings.Add("Text", dtCT, "MaSP");
            txtTenSP.DataBindings.Clear();
            txtTenSP.DataBindings.Add("Text", dtCT, "TenSP");
            nudSoLuong.DataBindings.Clear();
            nudSoLuong.DataBindings.Add("Text", dtCT, "SoLuong");
            nudDonGia.DataBindings.Clear();
            nudDonGia.DataBindings.Add("Text", dtCT, "GiaNhap");
            txtThanhTien.DataBindings.Clear();
            txtThanhTien.DataBindings.Add("Text", dtCT, "ThanhTien");
        }



    }
}
