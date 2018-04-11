namespace QLBH.View
{
    partial class frm_NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboTenQuay = new System.Windows.Forms.ComboBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.DTPNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.lblDT = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnHuy = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbLop = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.CbLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTenQuay
            // 
            this.cboTenQuay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenQuay.FormattingEnabled = true;
            this.cboTenQuay.Location = new System.Drawing.Point(595, 199);
            this.cboTenQuay.Name = "cboTenQuay";
            this.cboTenQuay.Size = new System.Drawing.Size(149, 28);
            this.cboTenQuay.TabIndex = 25;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(139, 138);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(149, 28);
            this.cboGioiTinh.TabIndex = 24;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(252, 269);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(371, 26);
            this.txtTimKiem.TabIndex = 23;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(159, 272);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(73, 20);
            this.lblTimKiem.TabIndex = 22;
            this.lblTimKiem.Text = "Tìm Kiếm";
            // 
            // DTPNgaySinh
            // 
            this.DTPNgaySinh.Location = new System.Drawing.Point(139, 202);
            this.DTPNgaySinh.Name = "DTPNgaySinh";
            this.DTPNgaySinh.Size = new System.Drawing.Size(276, 26);
            this.DTPNgaySinh.TabIndex = 17;
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(479, 210);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(77, 20);
            this.lblTenLop.TabIndex = 15;
            this.lblTenLop.Text = "Tên Quầy";
            // 
            // lblTenMH
            // 
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Location = new System.Drawing.Point(12, 146);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(71, 20);
            this.lblTenMH.TabIndex = 13;
            this.lblTenMH.Text = "Giới Tính";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(595, 84);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(264, 26);
            this.txtDiaChi.TabIndex = 12;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(479, 87);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(60, 20);
            this.lblDiaChi.TabIndex = 11;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(595, 140);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(149, 26);
            this.txtLuong.TabIndex = 10;
            this.txtLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDT_KeyPress);
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(485, 146);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(54, 20);
            this.lblLuong.TabIndex = 9;
            this.lblLuong.Text = "Lương";
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(595, 33);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(186, 26);
            this.txtDT.TabIndex = 8;
            this.txtDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDT_KeyPress);
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Location = new System.Drawing.Point(479, 36);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(85, 20);
            this.lblDT.TabIndex = 7;
            this.lblDT.Text = "Điện Thoại";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(12, 207);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(81, 20);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(139, 84);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(186, 26);
            this.txtTenNV.TabIndex = 4;
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Location = new System.Drawing.Point(12, 84);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(114, 20);
            this.lblTenGV.TabIndex = 3;
            this.lblTenGV.Text = "Tên Nhân Viên";
            // 
            // BtnLuu
            // 
            this.BtnLuu.Location = new System.Drawing.Point(1008, 202);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(85, 37);
            this.BtnLuu.TabIndex = 15;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.UseVisualStyleBackColor = true;
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(139, 27);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(110, 26);
            this.txtMaNV.TabIndex = 2;
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(1008, 325);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(85, 37);
            this.BtnThoat.TabIndex = 13;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnHuy
            // 
            this.BtnHuy.Location = new System.Drawing.Point(1008, 268);
            this.BtnHuy.Name = "BtnHuy";
            this.BtnHuy.Size = new System.Drawing.Size(85, 37);
            this.BtnHuy.TabIndex = 12;
            this.BtnHuy.Text = "Hủy";
            this.BtnHuy.UseVisualStyleBackColor = true;
            this.BtnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(1008, 142);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(85, 37);
            this.BtnXoa.TabIndex = 11;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(1008, 87);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(85, 37);
            this.BtnSua.TabIndex = 10;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(1008, 34);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(85, 37);
            this.BtnThem.TabIndex = 9;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(12, 30);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(109, 20);
            this.lblMaGV.TabIndex = 1;
            this.lblMaGV.Text = "Mã Nhân Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(221, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(8, 8);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNV,
            this.TenNV,
            this.GioiTinh,
            this.NgaySinh,
            this.SDT,
            this.DiaChi,
            this.Luong,
            this.TenQuay});
            this.dgvNhanVien.GridColor = System.Drawing.SystemColors.Control;
            this.dgvNhanVien.Location = new System.Drawing.Point(45, 383);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1048, 282);
            this.dgvNhanVien.TabIndex = 14;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvNhanVien_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 80;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 80;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Điện Thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 120;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 180;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            this.Luong.ReadOnly = true;
            this.Luong.Width = 130;
            // 
            // TenQuay
            // 
            this.TenQuay.DataPropertyName = "TenQuay";
            this.TenQuay.HeaderText = "Tên Quầy";
            this.TenQuay.Name = "TenQuay";
            this.TenQuay.ReadOnly = true;
            this.TenQuay.Width = 120;
            // 
            // CbLop
            // 
            this.CbLop.BackColor = System.Drawing.SystemColors.Window;
            this.CbLop.Controls.Add(this.cboTenQuay);
            this.CbLop.Controls.Add(this.cboGioiTinh);
            this.CbLop.Controls.Add(this.txtTimKiem);
            this.CbLop.Controls.Add(this.lblTimKiem);
            this.CbLop.Controls.Add(this.DTPNgaySinh);
            this.CbLop.Controls.Add(this.lblTenLop);
            this.CbLop.Controls.Add(this.lblTenMH);
            this.CbLop.Controls.Add(this.txtDiaChi);
            this.CbLop.Controls.Add(this.lblDiaChi);
            this.CbLop.Controls.Add(this.txtLuong);
            this.CbLop.Controls.Add(this.lblLuong);
            this.CbLop.Controls.Add(this.txtDT);
            this.CbLop.Controls.Add(this.lblDT);
            this.CbLop.Controls.Add(this.lblNgaySinh);
            this.CbLop.Controls.Add(this.txtTenNV);
            this.CbLop.Controls.Add(this.lblTenGV);
            this.CbLop.Controls.Add(this.txtMaNV);
            this.CbLop.Controls.Add(this.lblMaGV);
            this.CbLop.Controls.Add(this.groupBox2);
            this.CbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbLop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CbLop.Location = new System.Drawing.Point(45, 34);
            this.CbLop.Name = "CbLop";
            this.CbLop.Size = new System.Drawing.Size(894, 328);
            this.CbLop.TabIndex = 8;
            this.CbLop.TabStop = false;
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 698);
            this.Controls.Add(this.BtnLuu);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnHuy);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.CbLop);
            this.Name = "frm_NhanVien";
            this.Text = "frm_NhanVien";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.CbLop.ResumeLayout(false);
            this.CbLop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboTenQuay;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.DateTimePicker DTPNgaySinh;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Button BtnLuu;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnHuy;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox CbLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuay;
    }
}