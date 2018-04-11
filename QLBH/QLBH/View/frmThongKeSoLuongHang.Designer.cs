namespace QLBH.View
{
    partial class frmThongKeSoLuongHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtvSanPham = new System.Windows.Forms.DataGridView();
            this.lalbbb = new System.Windows.Forms.GroupBox();
            this.lalMaSP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lalTenSP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lalHangSX = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lalGiaNhap = new System.Windows.Forms.Label();
            this.lalGiaBan = new System.Windows.Forms.Label();
            this.lalSoLuong = new System.Windows.Forms.Label();
            this.lalDVT = new System.Windows.Forms.Label();
            this.lalQuayHang = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quayhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lalhang = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvSanPham)).BeginInit();
            this.lalbbb.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.lalbbb);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 557);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Số Lượng Hàng Hóa Còn ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtvSanPham);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 228);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(859, 326);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // dtvSanPham
            // 
            this.dtvSanPham.AllowUserToAddRows = false;
            this.dtvSanPham.AllowUserToDeleteRows = false;
            this.dtvSanPham.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.masp,
            this.tensp,
            this.hangsx,
            this.dvt,
            this.gianhap,
            this.giaban,
            this.soluong,
            this.quayhang});
            this.dtvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtvSanPham.GridColor = System.Drawing.SystemColors.ControlText;
            this.dtvSanPham.Location = new System.Drawing.Point(3, 16);
            this.dtvSanPham.Name = "dtvSanPham";
            this.dtvSanPham.ReadOnly = true;
            this.dtvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvSanPham.Size = new System.Drawing.Size(853, 307);
            this.dtvSanPham.TabIndex = 1;
            this.dtvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvSanPham_CellClick);
            this.dtvSanPham.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dtvSanPham_RowPrePaint);
            // 
            // lalbbb
            // 
            this.lalbbb.BackColor = System.Drawing.Color.LemonChiffon;
            this.lalbbb.Controls.Add(this.groupBox3);
            this.lalbbb.Controls.Add(this.label8);
            this.lalbbb.Controls.Add(this.lalhang);
            this.lalbbb.Controls.Add(this.groupBox2);
            this.lalbbb.Controls.Add(this.lalMaSP);
            this.lalbbb.Controls.Add(this.label2);
            this.lalbbb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lalbbb.Location = new System.Drawing.Point(3, 16);
            this.lalbbb.Name = "lalbbb";
            this.lalbbb.Size = new System.Drawing.Size(859, 212);
            this.lalbbb.TabIndex = 0;
            this.lalbbb.TabStop = false;
            // 
            // lalMaSP
            // 
            this.lalMaSP.AutoSize = true;
            this.lalMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalMaSP.Location = new System.Drawing.Point(73, 17);
            this.lalMaSP.Name = "lalMaSP";
            this.lalMaSP.Size = new System.Drawing.Size(16, 16);
            this.lalMaSP.TabIndex = 5;
            this.lalMaSP.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã SP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sản Phẩm :";
            // 
            // lalTenSP
            // 
            this.lalTenSP.AutoSize = true;
            this.lalTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalTenSP.Location = new System.Drawing.Point(115, 36);
            this.lalTenSP.Name = "lalTenSP";
            this.lalTenSP.Size = new System.Drawing.Size(16, 16);
            this.lalTenSP.TabIndex = 7;
            this.lalTenSP.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hãng Sản Xuất :";
            // 
            // lalHangSX
            // 
            this.lalHangSX.AutoSize = true;
            this.lalHangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalHangSX.Location = new System.Drawing.Point(331, 34);
            this.lalHangSX.Name = "lalHangSX";
            this.lalHangSX.Size = new System.Drawing.Size(16, 16);
            this.lalHangSX.TabIndex = 12;
            this.lalHangSX.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Quầy Hàng :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(398, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Giá Bán    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(607, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Số Lượng Còn :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(398, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Giá Nhập  :";
            // 
            // lalGiaNhap
            // 
            this.lalGiaNhap.AutoSize = true;
            this.lalGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalGiaNhap.Location = new System.Drawing.Point(487, 34);
            this.lalGiaNhap.Name = "lalGiaNhap";
            this.lalGiaNhap.Size = new System.Drawing.Size(16, 16);
            this.lalGiaNhap.TabIndex = 21;
            this.lalGiaNhap.Text = "0";
            this.lalGiaNhap.TextChanged += new System.EventHandler(this.lalGiaNhap_TextChanged);
            // 
            // lalGiaBan
            // 
            this.lalGiaBan.AutoSize = true;
            this.lalGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalGiaBan.Location = new System.Drawing.Point(487, 80);
            this.lalGiaBan.Name = "lalGiaBan";
            this.lalGiaBan.Size = new System.Drawing.Size(16, 16);
            this.lalGiaBan.TabIndex = 22;
            this.lalGiaBan.Text = "0";
            this.lalGiaBan.TextChanged += new System.EventHandler(this.lalGiaBan_TextChanged);
            // 
            // lalSoLuong
            // 
            this.lalSoLuong.AutoSize = true;
            this.lalSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalSoLuong.Location = new System.Drawing.Point(725, 34);
            this.lalSoLuong.Name = "lalSoLuong";
            this.lalSoLuong.Size = new System.Drawing.Size(16, 16);
            this.lalSoLuong.TabIndex = 23;
            this.lalSoLuong.Text = "0";
            // 
            // lalDVT
            // 
            this.lalDVT.AutoSize = true;
            this.lalDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalDVT.Location = new System.Drawing.Point(331, 80);
            this.lalDVT.Name = "lalDVT";
            this.lalDVT.Size = new System.Drawing.Size(16, 16);
            this.lalDVT.TabIndex = 24;
            this.lalDVT.Text = "0";
            // 
            // lalQuayHang
            // 
            this.lalQuayHang.AutoSize = true;
            this.lalQuayHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalQuayHang.Location = new System.Drawing.Point(115, 80);
            this.lalQuayHang.Name = "lalQuayHang";
            this.lalQuayHang.Size = new System.Drawing.Size(16, 16);
            this.lalQuayHang.TabIndex = 25;
            this.lalQuayHang.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(206, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Đơn Vị Tính    :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 47);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Tìm Kiếm :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTimKiem);
            this.groupBox4.Location = new System.Drawing.Point(90, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(735, 44);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(3, 16);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(729, 22);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "Nhập Tên Sản Phẩm hoặc Mã Sản Phẩm hoặc Quầy Hàng hoặc Hãng";
            this.txtTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseClick);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "VNĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "VNĐ";
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 50;
            // 
            // masp
            // 
            this.masp.DataPropertyName = "MaSP";
            this.masp.HeaderText = "Mã SP";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            this.masp.Width = 50;
            // 
            // tensp
            // 
            this.tensp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tensp.DataPropertyName = "TenSP";
            this.tensp.HeaderText = "Sản Phẩm";
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // hangsx
            // 
            this.hangsx.DataPropertyName = "HangSX";
            this.hangsx.HeaderText = "Hãng Sản Xuất";
            this.hangsx.Name = "hangsx";
            this.hangsx.ReadOnly = true;
            // 
            // dvt
            // 
            this.dvt.DataPropertyName = "DVT";
            this.dvt.HeaderText = "Đơn Vị Tính";
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            // 
            // gianhap
            // 
            this.gianhap.DataPropertyName = "GiaNhap";
            this.gianhap.HeaderText = "Giá Nhập";
            this.gianhap.Name = "gianhap";
            this.gianhap.ReadOnly = true;
            // 
            // giaban
            // 
            this.giaban.DataPropertyName = "GiaBan";
            this.giaban.HeaderText = "Giá Bán";
            this.giaban.Name = "giaban";
            this.giaban.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "SoLuong";
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Width = 110;
            // 
            // quayhang
            // 
            this.quayhang.DataPropertyName = "TenQuay";
            this.quayhang.HeaderText = "Quầy Hàng";
            this.quayhang.Name = "quayhang";
            this.quayhang.ReadOnly = true;
            // 
            // lalhang
            // 
            this.lalhang.AutoSize = true;
            this.lalhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalhang.ForeColor = System.Drawing.Color.Red;
            this.lalhang.Location = new System.Drawing.Point(92, 144);
            this.lalhang.Name = "lalhang";
            this.lalhang.Size = new System.Drawing.Size(19, 20);
            this.lalhang.TabIndex = 30;
            this.lalhang.Text = "0";
            this.lalhang.TextChanged += new System.EventHandler(this.lalhang_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Ghi Chú :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lalQuayHang);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lalSoLuong);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lalGiaNhap);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lalDVT);
            this.groupBox3.Controls.Add(this.lalHangSX);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lalTenSP);
            this.groupBox3.Controls.Add(this.lalGiaBan);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(96, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(757, 117);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // frmThongKeSoLuongHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 557);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongKeSoLuongHang";
            this.Text = "frmThongKeSoLuongHang";
            this.Load += new System.EventHandler(this.frmThongKeSoLuongHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvSanPham)).EndInit();
            this.lalbbb.ResumeLayout(false);
            this.lalbbb.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox lalbbb;
        private System.Windows.Forms.DataGridView dtvSanPham;
        private System.Windows.Forms.Label lalMaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lalTenSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lalHangSX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lalQuayHang;
        private System.Windows.Forms.Label lalDVT;
        private System.Windows.Forms.Label lalSoLuong;
        private System.Windows.Forms.Label lalGiaBan;
        private System.Windows.Forms.Label lalGiaNhap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn quayhang;
        private System.Windows.Forms.Label lalhang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}