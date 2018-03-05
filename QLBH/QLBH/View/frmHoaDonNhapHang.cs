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
    public partial class frmHoaDonNhapHang : Form
    {
        HoangCtrl hoadon = new HoangCtrl();
        DataTable dtHang = new DataTable();
        public frmHoaDonNhapHang()
        {
            InitializeComponent();
        }

        private void frmHoaDonNhapHang_Load(object sender, EventArgs e)
        {
            dtHang = hoadon.GetData("select MaSP, TenSP, HangSX, GiaBan, MaQuay, SoLuong, GiaNhap from SanPham");
            dgvDSHH.DataSource = dtHang;
            cmbNhanVien.DataSource = hoadon.GetData("select MaNV, TenNV from NhanVien");
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";

            cmbNCCC.DataSource = hoadon.GetData("select TenNCC, MaNCC from NhaCC");
            cmbNCCC.DisplayMember = "TenNCC";
            cmbNCCC.ValueMember = "MaNCC";

            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            dgvMain.Rows.Clear();

            txtSoLuong.Text = "1";
            txtMaHang.Clear();
            txtDonGia.Clear();

            DataTable dtHd = new DataTable();
            dtHd = hoadon.GetData("select MaHDN from HoaDonNhapHang");
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

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            string str = string.Format("MaSP like '%{0}%' or TenSP like '%{1}%'", txtMaHang.Text, txtMaHang.Text);
            dtHang.DefaultView.RowFilter = str;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmHoaDonNhapHang_Load(sender, e);
        }

        private void dgvDSHH_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDSHH.Rows.Count > 0)
            {
                txtMaHang.Text = dgvDSHH.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txtDonGia.Text = string.Format("{0:0,0}", float.Parse(dgvDSHH.SelectedRows[0].Cells[3].Value.ToString().Trim()));
                txtSoLuong.Select();
            }
            else
            {
                MessageBox.Show("Không tồn tại hàng " + txtMaHang.Text + " .", "Thông báo");
            }
        }

        private void txtMaHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dgvDSHH_DoubleClick(sender, e);
            }
        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnDuaXuong_Click(sender, e);
            }
        }

        private void dgvDSHH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMaHang.Text = dgvDSHH.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txtDonGia.Text = dgvDSHH.SelectedRows[0].Cells[3].Value.ToString().Trim();
                txtSoLuong.Select();
            }
        }

        private void txtDonGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnDuaXuong_Click(sender, e);
            }
        }

        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            if (txtDonGia.Text != "")
            {
                try
                {
                    float f = float.Parse(txtDonGia.Text.Trim()) * 1;

                }
                catch
                {
                    MessageBox.Show("Đơn giá không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDonGia.Text = dgvDSHH.SelectedRows[0].Cells[3].Value.ToString().Trim();
                    txtDonGia.Select();
                }
            }
        }

        private void txtMaHang_Leave(object sender, EventArgs e)
        {
            if (dgvDSHH.Rows.Count == 0)
            {
                MessageBox.Show("Không tồn tại giá trị hàng " + txtMaHang.Text + " .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Clear();
                txtMaHang.Select();
            }
        }

        private void btnDuaXuong_Click(object sender, EventArgs e)
        {
            try
            {
                
                btnLuu.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                if ((txtSoLuong.Text == "" || txtSoLuong.Text == null) || (txtDonGia.Text == "" || txtDonGia.Text == null))
                {
                    MessageBox.Show("Số lượng và đơn giá không được để trống.", "Thông báo");
                    txtSoLuong.Select();
                    return;
                }

                float tongtien = 0;
                int soluong = int.Parse(txtSoLuong.Text.Trim());
                if (dgvDSHH.Rows.Count == 0)
                {
                    MessageBox.Show("Không tồn tại giá trị hàng " + txtMaHang.Text + " .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //coppy 2 datagridview
                    if (dgvMain.Rows.Count == 0)
                    {
                        int n = dgvMain.Rows.Add();
                        if (txtDonGia.Text == "" || txtDonGia.Text == null)
                        {
                            dgvMain.Rows[n].Cells[3].Value = string.Format("{0:0,0}", dgvDSHH.SelectedRows[0].Cells[3].Value);
                        }
                        else
                        {

                            dgvMain.Rows[n].Cells[3].Value = string.Format("{0:0,0}", float.Parse(txtDonGia.Text.Trim()));
                        }
                        dgvMain.Rows[n].Cells[0].Value = dgvDSHH.SelectedRows[0].Cells[0].Value;
                        dgvMain.Rows[n].Cells[1].Value = dgvDSHH.SelectedRows[0].Cells[1].Value;
                        dgvMain.Rows[n].Cells[2].Value = txtSoLuong.Text;
                        dgvMain.Rows[n].Cells[4].Value = string.Format("{0:0,0}", float.Parse(dgvMain.Rows[n].Cells[3].Value.ToString()) * soluong);
                    }
                    else
                    {
                        int check = 0, save = 0;
                        for (int i = 0; i < dgvMain.Rows.Count; i++)
                        {
                            if (dgvDSHH.SelectedRows[0].Cells[0].Value.ToString() == dgvMain.Rows[i].Cells[0].Value.ToString())
                            {
                                save = i;
                                check++;
                            }
                        }
                        if (check != 0)     //them moi bi trung
                        {
                            if (txtDonGia.Text == "" || txtDonGia.Text == null)
                            {
                                dgvMain.Rows[save].Cells[3].Value = string.Format("{0:0,0}", dgvDSHH.SelectedRows[0].Cells[3].Value);
                            }
                            else
                            {

                                dgvMain.Rows[save].Cells[3].Value = string.Format("{0:0,0}", float.Parse(txtDonGia.Text.Trim()));
                            }
                            dgvMain.Rows[save].Cells[2].Value = soluong + int.Parse(dgvMain.Rows[save].Cells[2].Value.ToString());
                            dgvMain.Rows[save].Cells[4].Value = string.Format("{0:0,0}", float.Parse(dgvMain.Rows[save].Cells[3].Value.ToString()) * float.Parse(dgvMain.Rows[save].Cells[2].Value.ToString()));
                           
                        }
                        else            //them moi 1 hang
                        {
                            int n = dgvMain.Rows.Add();
                            if (txtDonGia.Text == "" || txtDonGia.Text == null)
                            {
                                dgvMain.Rows[n].Cells[3].Value = string.Format("{0:0,0}", dgvDSHH.SelectedRows[0].Cells[3].Value);
                            }
                            else
                            {

                                dgvMain.Rows[n].Cells[3].Value = string.Format("{0:0,0}", float.Parse(txtDonGia.Text.Trim()));
                            }
                            dgvMain.Rows[n].Cells[0].Value = dgvDSHH.SelectedRows[0].Cells[0].Value;
                            dgvMain.Rows[n].Cells[1].Value = dgvDSHH.SelectedRows[0].Cells[1].Value;
                            dgvMain.Rows[n].Cells[2].Value = txtSoLuong.Text;
                            dgvMain.Rows[n].Cells[4].Value = string.Format("{0:0,0}", float.Parse(dgvMain.Rows[n].Cells[3].Value.ToString()) * soluong);
                            //dgvMain.Rows[n].Cells[6].Value = (float.Parse(dgvDSHH.SelectedRows[0].Cells[4].Value.ToString()) * soluong).ToString();
                            //dgvMain.Rows[n].Cells[7].Value = (float.Parse(dgvDSHH.SelectedRows[0].Cells[3].Value.ToString()) * soluong).ToString();
                        }
                    }

                }


                for (int k = 0; k < dgvMain.Rows.Count; k++)
                {
                    tongtien += float.Parse(dgvMain.Rows[k].Cells[4].Value.ToString());
                }
                lblTongTien.Text = string.Format("{0:0,0}", tongtien);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtSoLuong.Text = "1";
            txtMaHang.Clear();
            txtDonGia.Clear();
            txtMaHang.Select();
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(txtSoLuong.Text.Trim()) * 1;

            }
            catch
            {
                MessageBox.Show("Số lượng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Text = "1";
                txtSoLuong.Select();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMain.Rows.Count != 0)
            {
                dgvMain.Rows.Remove(dgvMain.SelectedRows[0]);
                float tongtien = 0;
                for (int k = 0; k < dgvMain.Rows.Count; k++)
                {
                    tongtien += float.Parse(dgvMain.Rows[k].Cells[4].Value.ToString());
                }
                lblTongTien.Text = string.Format("{0:0,0}", tongtien);
            }
            if (dgvMain.Rows.Count == 0)
            {
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
            }
            txtMaHang.Select();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            txtMaHang.Text = dgvMain.SelectedRows[0].Cells[0].Value.ToString().Trim();
            txtDonGia.Text = dgvMain.SelectedRows[0].Cells[3].Value.ToString().Trim();
            txtSoLuong.Text = dgvMain.SelectedRows[0].Cells[2].Value.ToString().Trim();
            dgvMain.Rows.Remove(dgvMain.SelectedRows[0]);
            txtSoLuong.Select();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (hoadon.ThucHienLenh("insert into hoadonnhaphang values ('" + txtHoaDon.Text.Trim() + "','" + DateTime.Today.Date + "','" + cmbNhanVien.SelectedValue.ToString().Trim() + "', " + cmbNCCC.SelectedValue.ToString().Trim() + "," + float.Parse(lblTongTien.Text) + " ) "))
            {
                for (int i = 0; i < dgvMain.Rows.Count; i++)
                {
                    hoadon.ThucHienLenh("insert into ChiTietNhapHang values ('" + txtHoaDon.Text.Trim() + "','" + dgvMain.Rows[i].Cells[0].Value.ToString().Trim() + "',  " + int.Parse(dgvMain.Rows[i].Cells[2].Value.ToString()) + ", " + float.Parse(dgvMain.Rows[i].Cells[3].Value.ToString()) + ", " + float.Parse(dgvMain.Rows[i].Cells[4].Value.ToString()) + ")");
                    hoadon.ThucHienLenh("update SanPham set SoLuong = SoLuong + "+ int.Parse(dgvMain.Rows[i].Cells[2].Value.ToString()) + " where MaSP = '"+ int.Parse(dgvMain.Rows[i].Cells[0].Value.ToString()) + "'");
                }
                MessageBox.Show("Thêm hóa đơn thành công.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                dgvMain.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Thêm thât bại.", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            frmHoaDonNhapHang_Load(sender, e);
        }
    }
}
