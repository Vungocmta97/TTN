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
using QLBH.Model;
using QLBH.Object;
using System.Data.SqlClient;

namespace QLBH.View
{
    public partial class frm_NhanVien : Form
    {
        int check;
        DataTable dt1;
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataQuay();
        }
        public void LoadData()
        {
            dt1 = new DataTable();
            dt1 = NhanVienCtrl.GetData();
            dgvNhanVien.DataSource = dt1;
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtLuong.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTimKiem.Enabled = true;
            cboGioiTinh.Enabled = false;
            cboTenQuay.Enabled = false;
            DTPNgaySinh.Enabled = false;
            txtDT.Enabled = false;
            BtnHuy.Enabled = false;
            BtnLuu.Enabled = false;
            BtnThem.Enabled = true;
            BtnSua.Enabled = true;
            BtnXoa.Enabled = true;

        }

        public void LoadDataQuay()
        {

            cboTenQuay.DataSource = NhanVienCtrl.GetDataQuay();
            cboTenQuay.ValueMember = "MaQuay";
            cboTenQuay.DisplayMember = "TenQuay";
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaNV"].Value);
                txtTenNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenNV"].Value);

                txtLuong.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["Luong"].Value);
                txtDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["SDT"].Value);
                txtDiaChi.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DiaChi"].Value);
                cboGioiTinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value);
                cboTenQuay.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenQuay"].Value);
                DTPNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);
            }
        }

        private void dgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string str = string.Format("MaNV like '%{0}%' or TenNV like '%{0}%' or TenQuay like '%{0}%' or SDT like '%{0}%'  ", txtTimKiem.Text);
            dt1.DefaultView.RowFilter = str;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            DataTable db = new DataTable();
            db = NhanVienCtrl.GetData();
            string a = "";
            if (db.Rows.Count <= 0)
            {
                a = "NV01";
            }
            else
            {
                int k;
                a = "NV";
                k = int.Parse(db.Rows[db.Rows.Count - 1][0].ToString().Trim().Substring(2, 2));
                k = k + 1;
                string tam = k.ToString();
                for (int i = 0; i < (2 - tam.Length); i++)
                {
                    a += "0";
                }
                a = a + k.ToString();
            }
            txtMaNV.Text = a;
            this.txtTenNV.Focus();

            check = 1;
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = true;
            txtLuong.Enabled = true;
            txtDiaChi.Enabled = true;
            txtTimKiem.Enabled = false;
            cboTenQuay.Enabled = true;
            cboGioiTinh.Enabled = true;
            DTPNgaySinh.Enabled = true;
            txtDT.Enabled = true;

            BtnHuy.Enabled = true;
            BtnThem.Enabled = false;
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            BtnLuu.Enabled = true;

            dgvNhanVien.Enabled = false;

            txtMaNV.Text = a;
            txtTenNV.Text = "";
            txtLuong.Text = "";
            txtDiaChi.Text = "";
            txtDT.Text = "";
            cboGioiTinh.Text = "";
            cboTenQuay.Text = "";
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            check = 2;
            if (txtMaNV.Text == "")
                MessageBox.Show("Bạn cần chọn Giáo Viên để sửa !", "Thông Báo");
            else
            {
                txtMaNV.Enabled = false;
                txtTenNV.Enabled = true;
                txtLuong.Enabled = true;
                txtDiaChi.Enabled = true;
                txtTimKiem.Enabled = false;
                cboTenQuay.Enabled = true;
                cboGioiTinh.Enabled = true;
                DTPNgaySinh.Enabled = true;
                txtDT.Enabled = true;

                dgvNhanVien.Enabled = false;
                BtnHuy.Enabled = true;
                BtnThem.Enabled = false;
                BtnSua.Enabled = false;
                BtnXoa.Enabled = false;
                BtnLuu.Enabled = true;
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
                MessageBox.Show("Bạn cần chọn Nhân Viên để xóa !", "Thông Báo");
            else
              if (MessageBox.Show("Bạn có chắc chắn muốn xóa Nhân Viên " + txtTenNV.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhanVienObj qh = new NhanVienObj();
                qh.MaNV = txtMaNV.Text;
                if (NhanVienCtrl.DeleteProfile(qh) > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    frm_NhanVien_Load(sender, e);



                }
                else MessageBox.Show("Không thể Xóa");
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDT.Text == "" || txtDiaChi.Text == "" || DTPNgaySinh.Text == "" || cboTenQuay.Text == "")
            {
                MessageBox.Show("Bạn Cần Điền Đầy Đủ Thông Tin Trước Khi Lưu", "Thông Báo");
            }
            else
                if (check == 1)
            {
                NhanVienObj qh = new NhanVienObj();
                qh.MaNV = txtMaNV.Text;
                qh.TenNV = txtTenNV.Text;
                qh.GioiTinh = cboGioiTinh.Text;
                qh.MaQuay = cboTenQuay.SelectedValue.ToString();
                qh.NgaySinh = DateTime.Parse(DTPNgaySinh.Text);
                qh.Luong = float.Parse(txtLuong.Text);
                qh.DiaChi = txtDiaChi.Text;
                qh.SDT = txtDT.Text;
                if (NhanVienCtrl.InsertProfile(qh) > 0)
                {
                    MessageBox.Show("Thêm mới thành công");
                    frm_NhanVien_Load(sender, e);
                    dgvNhanVien.Enabled = true;

                }
                else MessageBox.Show("Không thể thêm mới");

            }

            else
            {
                NhanVienObj qh = new NhanVienObj();
                qh.MaNV = txtMaNV.Text;
                qh.TenNV = txtTenNV.Text;
                qh.GioiTinh = cboGioiTinh.Text;
                qh.MaQuay = cboTenQuay.SelectedValue.ToString();
                qh.NgaySinh = DateTime.Parse(DTPNgaySinh.Text);
                qh.Luong = float.Parse(txtLuong.Text);
                qh.DiaChi = txtDiaChi.Text;
                qh.SDT = txtDT.Text;
                if (NhanVienCtrl.UpdateProfile(qh) > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    frm_NhanVien_Load(sender, e);
                    dgvNhanVien.Enabled = true;

                }
                else MessageBox.Show("Không thể Sửa");

            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtLuong.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTimKiem.Enabled = true;
            cboGioiTinh.Enabled = false;
            cboTenQuay.Enabled = false;
            DTPNgaySinh.Enabled = false;
            txtDT.Enabled = false;

            BtnHuy.Enabled = false;
            BtnThem.Enabled = true;
            BtnSua.Enabled = true;
            BtnXoa.Enabled = true;
            BtnLuu.Enabled = false;

            dgvNhanVien.Enabled = true;

            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtLuong.Text = "";
            txtDiaChi.Text = "";
            txtDT.Text = "";
            cboTenQuay.Text = "";
            cboGioiTinh.Text = "";
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
