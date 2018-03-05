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
    public partial class frm_NhaCC : Form
    {
        DataTable db = new DataTable();
        int fl = 0;
        NhaCCObjTH nccObj = new NhaCCObjTH();
        NhaCCCtrlTH nccCtrl = new NhaCCCtrlTH();
        public frm_NhaCC()
        {
            InitializeComponent();
        }

        private void frm_NhaCC_Load(object sender, EventArgs e)
        {

            db = nccCtrl.GetData();
            dgv_NhaCC.DataSource = db;
            dgv_NhaCC.ReadOnly = true;
            bingding();
            ReadOnly(true);
            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            
            txt_TimKiem.ReadOnly = false;
        }
        public void bingding()
        {
            txt_mancc.DataBindings.Clear();
            txt_mancc.DataBindings.Add("Text", dgv_NhaCC.DataSource, "MaNCC");
            txt_tenncc.DataBindings.Clear();
            txt_tenncc.DataBindings.Add("Text", dgv_NhaCC.DataSource, "TenNCC");
            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", dgv_NhaCC.DataSource, "DiaChi");
            txt_sdt.DataBindings.Clear();
            txt_sdt.DataBindings.Add("Text", dgv_NhaCC.DataSource, "SDT");

        }
        public void ReadOnly(bool e)
        {
            txt_diachi.ReadOnly = e;
            txt_sdt.ReadOnly = e;
            txt_mancc.ReadOnly = e;
            txt_tenncc.ReadOnly = e;



        }
        void ganDuLieu(NhaCCObjTH Obj)
        {
            Obj.mancc = txt_mancc.Text.Trim(); ;
            Obj.tenncc = txt_tenncc.Text.Trim();

            Obj.diachi = txt_diachi.Text.Trim();

            Obj.sdt = txt_sdt.Text.Trim();

        }
        public void ClearDt()
        {
            txt_mancc.Text = "";
            txt_tenncc.Text = "";
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
            dgv_NhaCC.Enabled = false;
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
                a = "CC01";
            }
            else
            {
                int k;
                a = "CC";
                k = int.Parse(db.Rows[db.Rows.Count - 1][0].ToString().Trim().Substring(2, 2));
                k = k + 1;
                string tam = k.ToString();
                for (int i = 0; i < (2 - tam.Length); i++)
                {
                    a += "0";
                }
                a = a + k.ToString();
            }
            txt_mancc.Text = a;
            this.txt_tenncc.Focus();
        }

        private void dgv_NhaCC_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_NhaCC.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            dgv_NhaCC.Enabled = true;
            if (txt_sdt.Text == "" || txt_diachi.Text == "" || txt_mancc.Text == "" || txt_tenncc.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin !");
                txt_tenncc.Focus();
            }
            else
            {

                ganDuLieu(nccObj);
                if (fl == 0)
                {

                    if (nccCtrl.addData(nccObj))
                    {

                        MessageBox.Show("Thêm thàng công !", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_NhaCC_Load(sender, e);
                    }

                    else
                        MessageBox.Show("Thêm mới không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_NhaCC_Load(sender, e);
                }
                else
                {
                    if (nccCtrl.upData(nccObj))
                    {

                        MessageBox.Show("Sửa thàng công !", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_NhaCC_Load(sender, e);
                    }

                    else

                        MessageBox.Show("Sửa không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_NhaCC_Load(sender, e);
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ReadOnly(false);
           
            fl = 1;
            txt_mancc.ReadOnly = true;
            
            dgv_NhaCC.Enabled = false;
            txt_tenncc.Focus();
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Huy.Enabled = true;
            txt_TimKiem.ReadOnly = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ? ", "Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (dgv_check.Rows.Count == 1)
                {
                    if (nccCtrl.delData(txt_mancc.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thàng công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    frm_NhaCC_Load(sender, e);
                }
                else
                {

                    NhaCCObjTH Obj = new NhaCCObjTH();
                    Obj.tenncc = txt_tenncc.Text.Trim();
                    MessageBox.Show("Không thể xóa vì tồn tại hóa đơn có nhà cung cấp " + Obj.tenncc + " ");
                }

            }
              
             
            
           
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string str = string.Format("TenNCC like '%{0}%'", txt_TimKiem.Text);


            db.DefaultView.RowFilter = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = " ";
            this.txt_TimKiem.Focus();
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            frm_NhaCC_Load(sender, e);
        }
        private void txt_TimKiem_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = "";
        }


        DataTable dt = new DataTable();
            private void txt_mancc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = nccCtrl.getDataNCC(txt_mancc.Text.Trim());
                dgv_check.DataSource = dt;
            }
            catch (Exception ex) { }
        }
    }
}
