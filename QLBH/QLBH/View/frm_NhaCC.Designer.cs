namespace QLBH.View
{
    partial class frm_NhaCC
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_tenncc = new System.Windows.Forms.TextBox();
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_NhaCC = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_check = new System.Windows.Forms.DataGridView();
            this.mahdn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mancc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_check)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(26, 98);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(598, 22);
            this.txt_TimKiem.TabIndex = 14;
            this.txt_TimKiem.Text = "Nhập Tên Nhà Cung Cấp Cần Tìm...";
            this.txt_TimKiem.Click += new System.EventHandler(this.txt_TimKiem_Click);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.Location = new System.Drawing.Point(639, 140);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(108, 55);
            this.btn_TroVe.TabIndex = 13;
            this.btn_TroVe.Text = "Trở Về";
            this.btn_TroVe.UseVisualStyleBackColor = true;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(516, 140);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(108, 55);
            this.btn_Huy.TabIndex = 12;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(393, 140);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(108, 55);
            this.btn_Luu.TabIndex = 11;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(273, 140);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(108, 55);
            this.btn_Xoa.TabIndex = 10;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(146, 140);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(108, 55);
            this.btn_Sua.TabIndex = 9;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(26, 140);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(108, 55);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(507, 25);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(240, 22);
            this.txt_diachi.TabIndex = 6;
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenncc.Location = new System.Drawing.Point(146, 60);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(218, 22);
            this.txt_tenncc.TabIndex = 5;
            // 
            // txt_mancc
            // 
            this.txt_mancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mancc.Location = new System.Drawing.Point(146, 25);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(218, 22);
            this.txt_mancc.TabIndex = 4;
            this.txt_mancc.TextChanged += new System.EventHandler(this.txt_mancc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhà Cung Cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhà Cung Cấp";
            // 
            // dgv_NhaCC
            // 
            this.dgv_NhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.mancc,
            this.tenncc,
            this.diachi,
            this.sdt});
            this.dgv_NhaCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NhaCC.Location = new System.Drawing.Point(3, 22);
            this.dgv_NhaCC.Name = "dgv_NhaCC";
            this.dgv_NhaCC.Size = new System.Drawing.Size(770, 176);
            this.dgv_NhaCC.TabIndex = 0;
            this.dgv_NhaCC.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_NhaCC_RowPrePaint);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 95;
            // 
            // mancc
            // 
            this.mancc.DataPropertyName = "MaNCC";
            this.mancc.HeaderText = "Mã Cung Cấp";
            this.mancc.Name = "mancc";
            // 
            // tenncc
            // 
            this.tenncc.DataPropertyName = "TenNCC";
            this.tenncc.HeaderText = "Tên Nhà Cung Cấp";
            this.tenncc.Name = "tenncc";
            this.tenncc.Width = 170;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "DiaChi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            this.diachi.Width = 200;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SDT";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.Width = 160;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_NhaCC);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 201);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(507, 60);
            this.txt_sdt.MaxLength = 11;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(240, 22);
            this.txt_sdt.TabIndex = 7;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_check);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_TimKiem);
            this.groupBox1.Controls.Add(this.btn_TroVe);
            this.groupBox1.Controls.Add(this.btn_Huy);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_tenncc);
            this.groupBox1.Controls.Add(this.txt_mancc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 201);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Nhà Cung Cấp";
            // 
            // dgv_check
            // 
            this.dgv_check.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_check.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdn,
            this.mancc1});
            this.dgv_check.Location = new System.Drawing.Point(218, 22);
            this.dgv_check.Name = "dgv_check";
            this.dgv_check.Size = new System.Drawing.Size(315, 150);
            this.dgv_check.TabIndex = 4;
            this.dgv_check.Visible = false;
            // 
            // mahdn
            // 
            this.mahdn.DataPropertyName = "MaHDN";
            this.mahdn.HeaderText = "mahdn";
            this.mahdn.Name = "mahdn";
            // 
            // mancc1
            // 
            this.mancc1.DataPropertyName = "MaNCC";
            this.mancc1.HeaderText = "ãm nhà cung cấo";
            this.mancc1.Name = "mancc1";
            this.mancc1.ToolTipText = "MaNCC";
            // 
            // frm_NhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_NhaCC";
            this.Text = "frm_NhaCC";
            this.Load += new System.EventHandler(this.frm_NhaCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_check)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_tenncc;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_NhaCC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridView dgv_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc1;
    }
}