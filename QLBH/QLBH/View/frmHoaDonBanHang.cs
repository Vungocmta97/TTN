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
    public partial class frmHoaDonBanHang : Form
    {
        HoangCtrl hoadon = new HoangCtrl();
        DataTable dtHang = new DataTable();
        DataTable dtKH = new DataTable();
        public frmHoaDonBanHang()
        {
            InitializeComponent();
        }


        private void frmHoaDonBanHang_Load(object sender, EventArgs e)
        {
            dtHang = hoadon.GetData("select MaSP, TenSP, HangSX, GiaBan, MaQuay, SoLuong, GiaNhap from SanPham");
            dgvDSHH.DataSource = dtHang;
            cmbNhanVien.DataSource = hoadon.GetData("select MaNV, TenNV from NhanVien");
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";
            txtKhachHang.Clear();

            dtKH = hoadon.GetData("select MaKH, TenKH, DiaChi, SDT from KhachHang");
            dgvKhachHang.DataSource = dtKH;

            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            dgvMain.Rows.Clear();

            txtSoLuong.Text = "1";
            txtMaHang.Clear();
            txtDonGia.Clear();

            DataTable dtHd = new DataTable();
            dtHd = hoadon.GetData("select MaHDB from HoaDonBanHang");
            string s = "";
            if (dtHd.Rows.Count <= 0)
            {
                s = "0";
            }
            else
            {
                int k;
                k = int.Parse(dtHd.Rows[dtHd.Rows.Count - 1][0].ToString());
                k = k + 1;
                s = k.ToString();
            }
            txtHoaDon.Text = s;

            txtMaHang.Select();
        }

        private void txtKhachHang_TextChanged(object sender, EventArgs e)
        {
            dgvKhachHang.Visible = true;
            string str = string.Format("MaKH like '%{0}%' or TenKH like '%{1}%' or SDT like '%{2}%'  ", txtKhachHang.Text, txtKhachHang.Text, txtKhachHang.Text);
            dtKH.DefaultView.RowFilter = str;
        }

        private void txtKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                dgvKhachHang.Visible = false;
                txtKhachHang.Clear();
            }
            if (dgvKhachHang.Visible == true)
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (dgvKhachHang.Rows.Count > 0)
                    {
                        txtKhachHang.Text = dgvKhachHang.SelectedRows[0].Cells[1].Value.ToString();
                        dgvKhachHang.Visible = false;
                    }
                    else
                    {
                        dgvKhachHang.Visible = false;
                        txtKhachHang.Clear();
                    }
                }
            }

        }

        private void txtKhachHang_Leave(object sender, EventArgs e)
        {
            dgvKhachHang.Select();
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKhachHang.Text = dgvKhachHang.SelectedRows[0].Cells[1].Value.ToString();
            dgvKhachHang.Visible = false;
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvKhachHang.Rows.Count > 0)
            {
                if (e.KeyData == Keys.Enter)
                {
                    txtKhachHang.Text = dgvKhachHang.SelectedRows[0].Cells[1].Value.ToString();
                    dgvKhachHang.Visible = false;
                }
            }

        }


    }
}
