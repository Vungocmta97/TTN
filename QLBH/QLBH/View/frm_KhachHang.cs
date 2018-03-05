using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLBH.Model;
using QLBH.ObjectT;
using QLBH.Control;

namespace QLBH.View
{
    public partial class frm_KhachHang : Form
    {
        DataTable db = new DataTable();
        int fl = 0;
        KhachHangObjTH nccObj = new KhachHangObjTH();
        KhachHangCtrlTH nccCtrl = new KhachHangCtrlTH();
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            db = nccCtrl.GetData();
            dgv_KH.DataSource = db;
            dgv_KH.ReadOnly = true;
            bingding();
            ReadOnly(true);
            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;

            txt_TimKiem.ReadOnly = false;
        }
        public void bingding()
        {
            txt_makh.DataBindings.Clear();
            txt_makh.DataBindings.Add("Text", dgv_KH.DataSource, "MaKH");
            txt_tenkh.DataBindings.Clear();
            txt_tenkh.DataBindings.Add("Text", dgv_KH.DataSource, "TenKH");
            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", dgv_KH.DataSource, "DiaChi");
            txt_sdt.DataBindings.Clear();
            txt_sdt.DataBindings.Add("Text", dgv_KH.DataSource, "SDT");
            cb_GioiTinh.DataBindings.Clear();
            cb_GioiTinh.DataBindings.Add("Text", dgv_KH.DataSource, "GioiTinh");

        }
        public void ReadOnly(bool e)
        {
            txt_diachi.ReadOnly = e;
            txt_sdt.ReadOnly = e;
            txt_makh.ReadOnly = e;
            txt_tenkh.ReadOnly = e;



        }
        void ganDuLieu(KhachHangObjTH Obj)
        {
            Obj.makh = txt_makh.Text.Trim(); ;
            Obj.tenkh = txt_tenkh.Text.Trim();

            Obj.diachi = txt_diachi.Text.Trim();
            Obj.gioitinh = cb_GioiTinh.Text.Trim();
            Obj.sdt = txt_sdt.Text.Trim();

        }
        public void ClearDt()
        {
            txt_makh.Text = "";
            txt_tenkh.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";

        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            dgv_KH.Enabled = false;
            fl = 0;
            txt_TimKiem.ReadOnly = true;
            ClearDt();
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            ReadOnly(false);
            btn_Them.Enabled = false;
            btn_Huy.Enabled = true;
            btn_Luu.Enabled = true;

            db = nccCtrl.GetData();
            string a = "";
            if (db.Rows.Count <= 0)
            {
                a = "KH01";
            }
            else
            {
                int k;
                a = "KH";
                k = int.Parse(db.Rows[db.Rows.Count - 1][0].ToString().Trim().Substring(2, 2));
                k = k + 1;
                string tam = k.ToString();
                for (int i = 0; i < (2 - tam.Length); i++)
                {
                    a += "0";
                }
                a = a + k.ToString();
            }
            txt_makh.Text = a;
            this.txt_tenkh.Focus();

            string[] s = { "Nam", "Nữ" };
            cb_GioiTinh.DataSource = s;
            cb_GioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ReadOnly(false);

            fl = 1;
            txt_makh.ReadOnly = true;

            dgv_KH.Enabled = false;
            txt_tenkh.Focus();
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Huy.Enabled = true;
            txt_TimKiem.ReadOnly = true;
        }

        private void dgv_KH_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_KH.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            dgv_KH.Enabled = true;
            if (txt_sdt.Text == "" || txt_diachi.Text == "" || txt_makh.Text == "" || txt_tenkh.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin !");
                txt_tenkh.Focus();
            }
            else
            {

                ganDuLieu(nccObj);
                if (fl == 0)
                {

                    if (nccCtrl.addData(nccObj))
                    {

                        MessageBox.Show("Thêm thàng công !", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_KhachHang_Load(sender, e);
                    }

                    else
                        MessageBox.Show("Thêm mới không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_KhachHang_Load(sender, e);
                }
                else
                {
                    if (nccCtrl.upData(nccObj))
                    {

                        MessageBox.Show("Sửa thàng công !", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_KhachHang_Load(sender, e);
                    }

                    else

                        MessageBox.Show("Sửa không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_KhachHang_Load(sender, e);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ? ", "Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (dgv_check.Rows.Count == 1)
                {
                    if (nccCtrl.delData(txt_makh.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thàng công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    frm_KhachHang_Load(sender, e);
                }
                else
                {

                    KhachHangObjTH Obj = new KhachHangObjTH();
                    Obj.tenkh = txt_tenkh.Text.Trim();
                    MessageBox.Show("Không thể xóa vì tồn tại hóa đơn có khách hàng " + Obj.tenkh + " ");
                }
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string str = string.Format("TenKH like '%{0}%'", txt_TimKiem.Text);


            db.DefaultView.RowFilter = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = " ";
            this.txt_TimKiem.Focus();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            frm_KhachHang_Load(sender, e);
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable dt = new DataTable();
        private void txt_makh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = nccCtrl.getDataKH(txt_makh.Text.Trim());
                dgv_check.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        private void txt_TimKiem_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = "";
        }
    }
}
