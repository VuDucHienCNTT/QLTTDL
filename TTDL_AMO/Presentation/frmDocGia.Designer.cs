namespace TTDL_AMO
{
    partial class frmDocGia
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
            this.lblDocGia = new System.Windows.Forms.Label();
            this.grpTTDG = new System.Windows.Forms.GroupBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.grpTuyChon = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTenDG = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblHoTenDG = new System.Windows.Forms.Label();
            this.lblMaDG = new System.Windows.Forms.Label();
            this.grpCTDG = new System.Windows.Forms.GroupBox();
            this.dgvDG = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDocGia = new System.Windows.Forms.TabControl();
            this.tabNhap = new System.Windows.Forms.TabPage();
            this.tabTimKiem = new System.Windows.Forms.TabPage();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.cboMahayTen = new System.Windows.Forms.ComboBox();
            this.grpTTDG.SuspendLayout();
            this.grpTuyChon.SuspendLayout();
            this.grpCTDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDG)).BeginInit();
            this.tabDocGia.SuspendLayout();
            this.tabNhap.SuspendLayout();
            this.tabTimKiem.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDocGia
            // 
            this.lblDocGia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDocGia.Location = new System.Drawing.Point(0, 0);
            this.lblDocGia.Name = "lblDocGia";
            this.lblDocGia.Size = new System.Drawing.Size(1051, 45);
            this.lblDocGia.TabIndex = 0;
            this.lblDocGia.Text = "Thông Tin Độc Giả";
            this.lblDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTTDG
            // 
            this.grpTTDG.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpTTDG.Controls.Add(this.cboGioiTinh);
            this.grpTTDG.Controls.Add(this.grpTuyChon);
            this.grpTTDG.Controls.Add(this.txtEmail);
            this.grpTTDG.Controls.Add(this.txtSDT);
            this.grpTTDG.Controls.Add(this.txtDiaChi);
            this.grpTTDG.Controls.Add(this.txtHoTenDG);
            this.grpTTDG.Controls.Add(this.txtMaDG);
            this.grpTTDG.Controls.Add(this.lblEmail);
            this.grpTTDG.Controls.Add(this.lblSDT);
            this.grpTTDG.Controls.Add(this.lblDiaChi);
            this.grpTTDG.Controls.Add(this.lblGioiTinh);
            this.grpTTDG.Controls.Add(this.lblHoTenDG);
            this.grpTTDG.Controls.Add(this.lblMaDG);
            this.grpTTDG.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpTTDG.Location = new System.Drawing.Point(3, 3);
            this.grpTTDG.Name = "grpTTDG";
            this.grpTTDG.Size = new System.Drawing.Size(277, 438);
            this.grpTTDG.TabIndex = 0;
            this.grpTTDG.TabStop = false;
            this.grpTTDG.Text = "Nhập thông tin độc giả";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(114, 113);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(137, 21);
            this.cboGioiTinh.TabIndex = 2;
            // 
            // grpTuyChon
            // 
            this.grpTuyChon.Controls.Add(this.btnLamMoi);
            this.grpTuyChon.Controls.Add(this.btnTrangChu);
            this.grpTuyChon.Controls.Add(this.btnXoa);
            this.grpTuyChon.Controls.Add(this.btnSua);
            this.grpTuyChon.Controls.Add(this.btnThem);
            this.grpTuyChon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpTuyChon.Location = new System.Drawing.Point(3, 293);
            this.grpTuyChon.Name = "grpTuyChon";
            this.grpTuyChon.Size = new System.Drawing.Size(271, 142);
            this.grpTuyChon.TabIndex = 12;
            this.grpTuyChon.TabStop = false;
            this.grpTuyChon.Text = "Tùy Chọn";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(153, 61);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(89, 26);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Location = new System.Drawing.Point(111, 90);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(79, 29);
            this.btnTrangChu.TabIndex = 3;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(55, 61);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 25);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa Độc Giả";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(153, 24);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 27);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa Độc Giả";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(55, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 27);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm Độc Giả";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 234);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(137, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(114, 195);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(137, 20);
            this.txtSDT.TabIndex = 4;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(114, 155);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(137, 20);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtHoTenDG
            // 
            this.txtHoTenDG.Location = new System.Drawing.Point(114, 74);
            this.txtHoTenDG.Name = "txtHoTenDG";
            this.txtHoTenDG.Size = new System.Drawing.Size(137, 20);
            this.txtHoTenDG.TabIndex = 1;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(114, 33);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(137, 20);
            this.txtMaDG.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 237);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(12, 198);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(70, 13);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(12, 158);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(12, 116);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblHoTenDG
            // 
            this.lblHoTenDG.AutoSize = true;
            this.lblHoTenDG.Location = new System.Drawing.Point(12, 77);
            this.lblHoTenDG.Name = "lblHoTenDG";
            this.lblHoTenDG.Size = new System.Drawing.Size(78, 13);
            this.lblHoTenDG.TabIndex = 1;
            this.lblHoTenDG.Text = "Họ tên độc giả";
            // 
            // lblMaDG
            // 
            this.lblMaDG.AutoSize = true;
            this.lblMaDG.Location = new System.Drawing.Point(12, 36);
            this.lblMaDG.Name = "lblMaDG";
            this.lblMaDG.Size = new System.Drawing.Size(61, 13);
            this.lblMaDG.TabIndex = 0;
            this.lblMaDG.Text = "Mã độc giả";
            // 
            // grpCTDG
            // 
            this.grpCTDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCTDG.Controls.Add(this.dgvDG);
            this.grpCTDG.Location = new System.Drawing.Point(291, 48);
            this.grpCTDG.Name = "grpCTDG";
            this.grpCTDG.Size = new System.Drawing.Size(760, 470);
            this.grpCTDG.TabIndex = 2;
            this.grpCTDG.TabStop = false;
            this.grpCTDG.Text = "Chi tiết thông tin độc giả";
            // 
            // dgvDG
            // 
            this.dgvDG.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDG.Location = new System.Drawing.Point(3, 16);
            this.dgvDG.Name = "dgvDG";
            this.dgvDG.Size = new System.Drawing.Size(754, 451);
            this.dgvDG.TabIndex = 0;
            this.dgvDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDG_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MADG";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Mã Độc Giả";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "HOTENDG";
            this.Column2.HeaderText = "Họ Tên Độc Giả";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GIOITINH";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "DIACHIDG";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "Số Điện Thoại";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "EMAIL";
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            // 
            // tabDocGia
            // 
            this.tabDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabDocGia.Controls.Add(this.tabNhap);
            this.tabDocGia.Controls.Add(this.tabTimKiem);
            this.tabDocGia.Location = new System.Drawing.Point(0, 48);
            this.tabDocGia.Name = "tabDocGia";
            this.tabDocGia.SelectedIndex = 0;
            this.tabDocGia.Size = new System.Drawing.Size(288, 470);
            this.tabDocGia.TabIndex = 1;
            // 
            // tabNhap
            // 
            this.tabNhap.Controls.Add(this.grpTTDG);
            this.tabNhap.Location = new System.Drawing.Point(4, 22);
            this.tabNhap.Name = "tabNhap";
            this.tabNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhap.Size = new System.Drawing.Size(280, 444);
            this.tabNhap.TabIndex = 0;
            this.tabNhap.Text = "Nhập Độc Giả";
            this.tabNhap.UseVisualStyleBackColor = true;
            // 
            // tabTimKiem
            // 
            this.tabTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabTimKiem.Controls.Add(this.grpTimKiem);
            this.tabTimKiem.Location = new System.Drawing.Point(4, 22);
            this.tabTimKiem.Name = "tabTimKiem";
            this.tabTimKiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimKiem.Size = new System.Drawing.Size(280, 431);
            this.tabTimKiem.TabIndex = 1;
            this.tabTimKiem.Text = "Tìm Kiếm Độc Giả";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.btnQuayLai);
            this.grpTimKiem.Controls.Add(this.lblTimKiem);
            this.grpTimKiem.Controls.Add(this.txtTuKhoa);
            this.grpTimKiem.Controls.Add(this.lblTuKhoa);
            this.grpTimKiem.Controls.Add(this.cboMahayTen);
            this.grpTimKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpTimKiem.Location = new System.Drawing.Point(3, 3);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(277, 425);
            this.grpTimKiem.TabIndex = 5;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm độc giả";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(91, 114);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(80, 28);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.Text = "Trang Chủ";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(16, 32);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(98, 16);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm kiếm theo :";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.Location = new System.Drawing.Point(84, 73);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(182, 22);
            this.txtTuKhoa.TabIndex = 3;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuKhoa.Location = new System.Drawing.Point(14, 76);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(63, 16);
            this.lblTuKhoa.TabIndex = 1;
            this.lblTuKhoa.Text = "Từ khóa :";
            // 
            // cboMahayTen
            // 
            this.cboMahayTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMahayTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMahayTen.FormattingEnabled = true;
            this.cboMahayTen.Items.AddRange(new object[] {
            "Mã",
            "Họ Tên"});
            this.cboMahayTen.Location = new System.Drawing.Point(143, 29);
            this.cboMahayTen.Name = "cboMahayTen";
            this.cboMahayTen.Size = new System.Drawing.Size(122, 24);
            this.cboMahayTen.TabIndex = 2;
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1051, 518);
            this.Controls.Add(this.tabDocGia);
            this.Controls.Add(this.grpCTDG);
            this.Controls.Add(this.lblDocGia);
            this.Name = "frmDocGia";
            this.Text = "Thông Tin Độc Giả";
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            this.grpTTDG.ResumeLayout(false);
            this.grpTTDG.PerformLayout();
            this.grpTuyChon.ResumeLayout(false);
            this.grpCTDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDG)).EndInit();
            this.tabDocGia.ResumeLayout(false);
            this.tabNhap.ResumeLayout(false);
            this.tabTimKiem.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDocGia;
        private System.Windows.Forms.GroupBox grpTTDG;
        private System.Windows.Forms.GroupBox grpCTDG;
        private System.Windows.Forms.DataGridView dgvDG;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTenDG;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblHoTenDG;
        private System.Windows.Forms.Label lblMaDG;
        private System.Windows.Forms.GroupBox grpTuyChon;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabControl tabDocGia;
        private System.Windows.Forms.TabPage tabNhap;
        private System.Windows.Forms.TabPage tabTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.ComboBox cboMahayTen;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Button btnQuayLai;
    }
}