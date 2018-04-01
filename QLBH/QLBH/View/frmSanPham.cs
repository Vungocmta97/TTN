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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        string m_chucnang = "";
        private void frmSanPham_Load(object sender, EventArgs e)
        {

            dtvSanPham.ReadOnly = true;

            cmbQuayHang.DataSource = QuayHangCtrlTr.GetListQuayHang();
            cmbQuayHang.DisplayMember = "TenQuay";
            cmbQuayHang.ValueMember = "MaQuay";
        
            dt = SanPhamCtrlTr.GetListSanPham();
            dtvSanPham.DataSource = dt;
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.txtTenSP.Enabled = true;
            this.txtGiaBan.Enabled = true;
            this.txtGiaNhap.Enabled = true;
            this.cmbDVT.Enabled = true;
            this.cmbQuayHang.Enabled = true;
            this.txtHangSX.Enabled = true;
            this.btnLuu.Visible = true;
            this.btnHuy.Visible = true;
            this.btnThem.Visible = false;
            this.btnSua.Visible = false;
            this.btnXoa.Visible = false;          
            this.btnThoat.Visible = false;
            m_chucnang = "them";
            DataTable dtpn = new DataTable();
            dtpn = SanPhamCtrlTr.GetListSanPham();
            string s = "";
            if (dtpn.Rows.Count <= 0)
            {
                s = "0";
            }
            else
            {
                s = "HBL";
                s = (int.Parse(dtpn.Rows[dtpn.Rows.Count - 1][0].ToString().Trim()) + 1).ToString();
            }
            lalMaSP.Text = s;

            txtTenSP.Text = "";
            txtHangSX.Text = "";
            cmbDVT.Text = "";
            cmbQuayHang.ResetText();
            txtGiaNhap.Text = "VNĐ";
            txtGiaBan.Text = "VNĐ";
            nudSoLuong.Value = 0;

        }

        private void txtGiaNhap_MouseClick(object sender, MouseEventArgs e)
        {
         
                txtGiaNhap.Text = "";
         
           
        }

        private void txtGiaBan_MouseClick(object sender, MouseEventArgs e)
        {
          
                txtGiaBan.Text = "";
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.txtTenSP.Enabled = true;
            this.txtGiaBan.Enabled = true;
            this.txtGiaNhap.Enabled = true;
            this.cmbDVT.Enabled = true;
            this.cmbQuayHang.Enabled = true;
            this.txtHangSX.Enabled = true;
            this.btnLuu.Visible = true;
            this.btnHuy.Visible = true;
            this.btnThem.Visible = false;
            this.btnSua.Visible = false;
            this.btnXoa.Visible = false;
         
            this.btnThoat.Visible = false;
            m_chucnang = "sua";
            cmbQuayHang.Focus();
            cmbDVT.Focus();
            lalMaSP.Focus();
          


            // cmbSoLuong.ResetText();
            //txtGiaNhap.ResetText();

            if (txtTenSP.Text == "" ||cmbQuayHang.Text == "" ||lalMaSP.Text=="")
            {
                MessageBox.Show("Chưa chọn thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.txtTenSP.Enabled = false;
                this.txtGiaBan.Enabled = false;
                this.txtGiaNhap.Enabled = false;
                this.cmbDVT.Enabled = false;
                this.cmbQuayHang.Enabled = false;
                this.txtHangSX.Enabled = false;
                this.btnLuu.Visible = false;
                this.btnHuy.Visible = false;
                this.btnThem.Visible = true;
                this.btnSua.Visible = true;
                this.btnXoa.Visible = true;
              
                this.btnThoat.Visible = true;
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtTenSP.Text == "" || cmbQuayHang.Text == "" || lalMaSP.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
         SanPhamObjTr ctdObj = new SanPhamObjTr();
            ctdObj.MaSP = lalMaSP.Text.Trim();
          
            //nv.Luong = int.Parse(txtLuong.Text);
            //nv.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            //nv.NgaySinh = dtpNgaySinh.Value;
            //nv.MaPhongBan = cmbMaPhongBan.SelectedText;
            if (MessageBox.Show(string.Format("Xóa Sản Phẩm : {0}", txtTenSP.Text), "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (SanPhamCtrlTr.DeleteSanPham(ctdObj) > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmSanPham_Load(sender, e);

                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_chucnang == "them")
                {
                    if (txtTenSP.Text == "" || cmbQuayHang.Text == "" || lalMaSP.Text == "")
                    {
                        MessageBox.Show("Chưa chọn thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                       
                        
                        SanPhamObjTr ctdObj = new SanPhamObjTr();
                        ctdObj.MaSP = lalMaSP.Text;
                        ctdObj.TenSP = txtTenSP.Text.Trim();
                        ctdObj.HangSX = txtHangSX.Text.Trim();
                        ctdObj.DVT = cmbDVT.Text.Trim();
                            ctdObj.GiaNhap = float.Parse(txtGiaNhap.Text.Trim());
                            ctdObj.GiaBan = float.Parse(txtGiaBan.Text.Trim());
                        ctdObj.SoLuong = int.Parse(nudSoLuong.Value.ToString()) ;
                        ctdObj.MaQuay = cmbQuayHang.SelectedValue.ToString();

                        if (MessageBox.Show(string.Format("Thêm  sản phẩm :{0}",txtTenSP.Text), "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                if (SanPhamCtrlTr.InsertSanPham(ctdObj) > 0)
                                {
                                    MessageBox.Show("Thêm mới thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    frmSanPham_Load(sender, e);
                                    this.txtTenSP.Enabled = false;
                                    this.txtGiaBan.Enabled = false;
                                    this.txtGiaNhap.Enabled = false;
                                    this.cmbDVT.Enabled = false;
                                    this.cmbQuayHang.Enabled = false;
                                    this.txtHangSX.Enabled = false;
                                    this.btnLuu.Visible = false;
                                    this.btnHuy.Visible = false;
                                    this.btnThem.Visible = true;
                                    this.btnSua.Visible = true;
                                    this.btnXoa.Visible = true;

                                    this.btnThoat.Visible = true;

                                }
                                else MessageBox.Show("Nhập đầy đủ thông tin Vui Lòng Nhập Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        
                        else
                        {
                            MessageBox.Show(" Vui Lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (m_chucnang == "sua")
                {
                    if (txtTenSP.Text == "" || cmbQuayHang.Text == "" || lalMaSP.Text == "")
                    {
                        MessageBox.Show("Chưa chọn thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {

                        SanPhamObjTr ctdObj = new SanPhamObjTr();
                        ctdObj.MaSP = lalMaSP.Text;
                        ctdObj.TenSP = txtTenSP.Text.Trim();
                        ctdObj.HangSX = txtHangSX.Text.Trim();
                        ctdObj.DVT = cmbDVT.Text.Trim();
                        ctdObj.GiaNhap = float.Parse(txtGiaNhap.Text.Trim());
                        ctdObj.GiaBan = float.Parse(txtGiaBan.Text.Trim());
                        ctdObj.SoLuong = int.Parse(nudSoLuong.Value.ToString());
                        ctdObj.MaQuay = cmbQuayHang.SelectedValue.ToString();

                        if (MessageBox.Show(string.Format("Sửa sản phẩm :{0}", txtTenSP.Text), "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                if (SanPhamCtrlTr.UpdateSanPham(ctdObj) > 0)
                                {
                                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    frmSanPham_Load(sender, e);
                                    this.txtTenSP.Enabled = false;
                                    this.txtGiaBan.Enabled = false;
                                    this.txtGiaNhap.Enabled = false;
                                    this.cmbDVT.Enabled = false;
                                    this.cmbQuayHang.Enabled = false;
                                    this.txtHangSX.Enabled = false;
                                    this.btnLuu.Visible = false;
                                    this.btnHuy.Visible = false;
                                    this.btnThem.Visible = true;
                                    this.btnSua.Visible = true;
                                    this.btnXoa.Visible = true;

                                    this.btnThoat.Visible = true;


                                }
                                else MessageBox.Show("Không Sửa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                        }
                        else
                        {
                            MessageBox.Show("Vui Lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Xảy Ra!", "Thông Báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtTenSP.Enabled = false;
            this.txtGiaBan.Enabled = false;
            this.txtGiaNhap.Enabled = false;
            this.cmbDVT.Enabled = false;
            this.cmbQuayHang.Enabled = false;
            this.txtHangSX.Enabled = false;
            this.btnLuu.Visible = false;
            this.btnHuy.Visible = false;
            this.btnThem.Visible = true;
            this.btnSua.Visible = true;
            this.btnXoa.Visible = true;

            this.btnThoat.Visible = true;
        }

        private void dtvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lalMaSP.Text = dtvSanPham.CurrentRow.Cells["masp"].Value.ToString();
            txtTenSP.Text = dtvSanPham.CurrentRow.Cells["tensp"].Value.ToString();
            txtHangSX.Text = dtvSanPham.CurrentRow.Cells["hangsx"].Value.ToString();
            cmbDVT.Text = dtvSanPham.CurrentRow.Cells["dvt"].Value.ToString();
            txtGiaNhap.Text = dtvSanPham.CurrentRow.Cells["gianhap"].Value.ToString();
            txtGiaBan.Text = dtvSanPham.CurrentRow.Cells["giaban"].Value.ToString();
            nudSoLuong.Text = dtvSanPham.CurrentRow.Cells["soluong"].Value.ToString();
            cmbQuayHang.Text = dtvSanPham.CurrentRow.Cells["quayhang"].Value.ToString();
        }

        private void dtvSanPham_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dtvSanPham.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
        }
    }
}
