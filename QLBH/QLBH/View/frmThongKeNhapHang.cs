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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (dtNhap.Rows.Count > 0)
            {
                string str = string.Format("MaHDN like '%{0}%'", txtTimKiem.Text);
                dtNhap.DefaultView.RowFilter = str;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXoaCT.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            dgvChiTiet.Enabled = true;
            dgvPhieuNhap.Enabled = true;
            nudSoLuong.Enabled = false;
            nudDonGia.Enabled = false;
            dtCT = tke.GetData("select SanPham.MaSP, TenSP, ChiTietNhapHang.SoLuong, ChiTietNhapHang.GiaNhap, ThanhTien from SanPham, ChiTietNhapHang where SanPham.MaSP = ChiTietNhapHang.MaSP and MaHDN = '" + txtMaPhieu.Text.Trim() + "'");
            dgvChiTiet.DataSource = dtCT;
            txtMaPhieu.Clear();
            btnTimKiem_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa phiếu nhập "+txtMaPhieu.Text.Trim()+" ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                for (int i = 0; i < dgvChiTiet.Rows.Count; i++)
                {
                    tke.ThucHienLenh("update SanPham set SoLuong = SoLuong - '" + dgvChiTiet.Rows[i].Cells[2].Value.ToString() + "' where MaSP = '" + dgvChiTiet.Rows[i].Cells[0].Value.ToString() + "'");
                }
                if (tke.ThucHienLenh("delete ChiTietNhapHang where MaHDN = '" + txtMaPhieu.Text.Trim() + "'") == true)
                {
                    if (tke.ThucHienLenh("delete HoaDonNhapHang where MaHDN = '" + txtMaPhieu.Text.Trim() + "'") == true)
                    {
                        MessageBox.Show("Xóa thành công");
                        btnTimKiem_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int slmoi = int.Parse(nudSoLuong.Value.ToString());
            float thanhtien = float.Parse(txtThanhTien.Text);
            txtThanhTien.Text = (float.Parse(nudDonGia.Value.ToString()) * float.Parse(nudSoLuong.Value.ToString())).ToString();
            string s = "update ChiTietNhapHang set SoLuong =" + nudSoLuong.Value.ToString() + " , ThanhTien =" + txtThanhTien.Text + " , GiaNhap=" + nudDonGia.Value.ToString() + " where MaHDN = '" + txtMaPhieu.Text.Trim() + "' and MaSP = '" + txtMaSP.Text.Trim() + "' ";
            if (tke.ThucHienLenh(s) == true)
            {
                MessageBox.Show("Sửa thành công");

                tke.ThucHienLenh("update SanPham set SoLuong = SoLuong - " + slcu + " + " + slmoi + " where MaSP = '" + txtMaSP.Text.Trim() + "'");
                txtTongTien.Text = (float.Parse(txtTongTien.Text) - thanhtien + float.Parse(txtThanhTien.Text)).ToString();
                tke.ThucHienLenh("update HoaDonNhapHang set TongTien = " + txtTongTien.Text + " where MaHDN = '" + txtMaPhieu.Text.Trim() + "'");
                dgvChiTiet.Enabled = true;
                dgvPhieuNhap.Enabled = true;
                btnHuy_Click(sender, e);
                btnTimKiem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thất bại ");
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(nudSoLuong.Value.ToString());
            if (MessageBox.Show("Xóa sản phẩm ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                float thanhtien = float.Parse(txtThanhTien.Text);
                if (tke.ThucHienLenh("delete ChiTietNhapHang where MaSP = '" + txtMaSP.Text.Trim() + "' and MaHDN = '" + txtMaPhieu.Text.Trim() + "'") == true)
                {
                    tke.ThucHienLenh("update SanPham set SoLuong = SoLuong - " + sl + " where MaSP = '" + txtMaSP.Text.Trim() + "'");
                    MessageBox.Show("Xóa thành công");
                    txtTongTien.Text = string.Format("{0:0,0}", (float.Parse(txtTongTien.Text) - thanhtien));
                    tke.ThucHienLenh("update HoaDonNhapHang set tongtien = " + float.Parse(txtTongTien.Text) + " where MaHDN = '" + txtMaPhieu.Text.Trim() + "'");

                    DataTable dttemp = new DataTable();
                    dttemp = tke.GetData("select * from ChiTietNhapHang where MaHDN = '" + txtMaPhieu.Text.Trim() + "'");
                    if (dttemp.Rows.Count == 0)
                    {
                        tke.ThucHienLenh("delete HoaDonNhapHang where MaHDN = '" + txtMaPhieu.Text.Trim() + "'");
                    }
                    btnHuy_Click(sender, e);
                    btnTimKiem_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            slcu = int.Parse(nudSoLuong.Value.ToString());
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnXoaCT.Enabled = false;
            btnLuu.Enabled = true;
            dgvChiTiet.Enabled = false;
            dgvPhieuNhap.Enabled = false;
            nudSoLuong.Enabled = true;
            nudDonGia.Enabled = true;
            nudSoLuong.Select();
        }

        
    }
}
