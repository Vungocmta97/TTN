namespace QLBH.View
{
    partial class frmSanPham
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtvSanPham = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quayhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grobox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lalMaSP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtHangSX = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.cmbQuayHang = new System.Windows.Forms.ComboBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cmbDVT = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvSanPham)).BeginInit();
            this.grobox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.grobox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtvSanPham);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(843, 244);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
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
            this.dtvSanPham.Size = new System.Drawing.Size(837, 225);
            this.dtvSanPham.TabIndex = 0;
            this.dtvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvSanPham_CellClick);
            this.dtvSanPham.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dtvSanPham_RowPrePaint);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 40;
            // 
            // masp
            // 
            this.masp.DataPropertyName = "MaSP";
            this.masp.HeaderText = "Mã Sản Phẩm";
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
            this.soluong.Width = 80;
            // 
            // quayhang
            // 
            this.quayhang.DataPropertyName = "TenQuay";
            this.quayhang.HeaderText = "Quầy Hàng";
            this.quayhang.Name = "quayhang";
            this.quayhang.ReadOnly = true;
            // 
            // grobox
            // 
            this.grobox.Controls.Add(this.cmbDVT);
            this.grobox.Controls.Add(this.comboBox2);
            this.grobox.Controls.Add(this.nudSoLuong);
            this.grobox.Controls.Add(this.cmbQuayHang);
            this.grobox.Controls.Add(this.numericUpDown1);
            this.grobox.Controls.Add(this.comboBox1);
            this.grobox.Controls.Add(this.txtGiaBan);
            this.grobox.Controls.Add(this.label10);
            this.grobox.Controls.Add(this.textBox6);
            this.grobox.Controls.Add(this.label9);
            this.grobox.Controls.Add(this.txtHangSX);
            this.grobox.Controls.Add(this.label8);
            this.grobox.Controls.Add(this.textBox4);
            this.grobox.Controls.Add(this.label7);
            this.grobox.Controls.Add(this.txtGiaNhap);
            this.grobox.Controls.Add(this.label6);
            this.grobox.Controls.Add(this.textBox2);
            this.grobox.Controls.Add(this.txtTenSP);
            this.grobox.Controls.Add(this.label5);
            this.grobox.Controls.Add(this.textBox1);
            this.grobox.Controls.Add(this.label4);
            this.grobox.Controls.Add(this.lalMaSP);
            this.grobox.Controls.Add(this.label2);
            this.grobox.Controls.Add(this.groupBox4);
            this.grobox.Controls.Add(this.label1);
            this.grobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.grobox.Location = new System.Drawing.Point(3, 16);
            this.grobox.Name = "grobox";
            this.grobox.Size = new System.Drawing.Size(843, 240);
            this.grobox.TabIndex = 0;
            this.grobox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sản Phẩm :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnThoat);
            this.groupBox4.Controls.Add(this.btnHuy);
            this.groupBox4.Controls.Add(this.btnLuu);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(743, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(97, 221);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(341, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản Phẩm";
            // 
            // lalMaSP
            // 
            this.lalMaSP.AutoSize = true;
            this.lalMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalMaSP.Location = new System.Drawing.Point(187, 52);
            this.lalMaSP.Name = "lalMaSP";
            this.lalMaSP.Size = new System.Drawing.Size(16, 16);
            this.lalMaSP.TabIndex = 3;
            this.lalMaSP.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Sản Phẩm :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(190, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(190, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "VNĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giá Nhập          :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số Lượng          :";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(549, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(172, 22);
            this.textBox4.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(407, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hãng Sản Xuất :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(407, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Đơn Vị Tính       :";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(549, 137);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(172, 22);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "VNĐ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(407, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Giá Bán             :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(407, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Quầy Hàng        :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(549, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(190, 181);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(172, 22);
            this.numericUpDown1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Cái ",
            "Chiếc ",
            "Gói ",
            "Hộp",
            "Bình",
            "Thùng ",
            "Két"});
            this.comboBox2.Location = new System.Drawing.Point(549, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 24);
            this.comboBox2.TabIndex = 19;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Enabled = false;
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(190, 88);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(172, 22);
            this.txtTenSP.TabIndex = 5;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Enabled = false;
            this.txtGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(190, 134);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(172, 22);
            this.txtGiaNhap.TabIndex = 7;
            this.txtGiaNhap.Text = "VNĐ";
            this.txtGiaNhap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtGiaNhap_MouseClick);
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // txtHangSX
            // 
            this.txtHangSX.Enabled = false;
            this.txtHangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHangSX.Location = new System.Drawing.Point(549, 52);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Size = new System.Drawing.Size(172, 22);
            this.txtHangSX.TabIndex = 11;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(549, 137);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(172, 22);
            this.txtGiaBan.TabIndex = 15;
            this.txtGiaBan.Text = "VNĐ";
            this.txtGiaBan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtGiaBan_MouseClick);
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // cmbQuayHang
            // 
            this.cmbQuayHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuayHang.Enabled = false;
            this.cmbQuayHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuayHang.FormattingEnabled = true;
            this.cmbQuayHang.Location = new System.Drawing.Point(549, 184);
            this.cmbQuayHang.Name = "cmbQuayHang";
            this.cmbQuayHang.Size = new System.Drawing.Size(172, 24);
            this.cmbQuayHang.TabIndex = 17;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Enabled = false;
            this.nudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(190, 181);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(172, 22);
            this.nudSoLuong.TabIndex = 18;
            // 
            // cmbDVT
            // 
            this.cmbDVT.Enabled = false;
            this.cmbDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDVT.Items.AddRange(new object[] {
            "Cái ",
            "Chiếc ",
            "Gói ",
            "Hộp",
            "Bình",
            "Thùng ",
            "Két"});
            this.cmbDVT.Location = new System.Drawing.Point(549, 94);
            this.cmbDVT.Name = "cmbDVT";
            this.cmbDVT.Size = new System.Drawing.Size(172, 24);
            this.cmbDVT.TabIndex = 19;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(6, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 50);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(6, 62);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 50);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(6, 111);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 50);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(6, 160);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 50);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(6, 62);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 50);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(6, 111);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 50);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 503);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvSanPham)).EndInit();
            this.grobox.ResumeLayout(false);
            this.grobox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn quayhang;
        private System.Windows.Forms.GroupBox grobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lalMaSP;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cmbDVT;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cmbQuayHang;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtHangSX;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
    }
}