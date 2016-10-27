namespace TTDL_AMO
{
    partial class frmNXB
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
            this.lblNXB = new System.Windows.Forms.Label();
            this.grpTTNXB = new System.Windows.Forms.GroupBox();
            this.cboTenNXB = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.lblWeb = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenNXB = new System.Windows.Forms.Label();
            this.lblMaNXB = new System.Windows.Forms.Label();
            this.grpTuyChon = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnXoaNXB = new System.Windows.Forms.Button();
            this.btnSuaNXB = new System.Windows.Forms.Button();
            this.btnThemNXB = new System.Windows.Forms.Button();
            this.grpCTNXB = new System.Windows.Forms.GroupBox();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNhaXuatBan = new System.Windows.Forms.TabControl();
            this.tabNhap = new System.Windows.Forms.TabPage();
            this.tabTimKiem = new System.Windows.Forms.TabPage();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.cboMahayTen = new System.Windows.Forms.ComboBox();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.labTimKiem = new System.Windows.Forms.Label();
            this.grpTTNXB.SuspendLayout();
            this.grpTuyChon.SuspendLayout();
            this.grpCTNXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.tabNhaXuatBan.SuspendLayout();
            this.tabNhap.SuspendLayout();
            this.tabTimKiem.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNXB
            // 
            this.lblNXB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNXB.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNXB.Location = new System.Drawing.Point(0, 0);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(1053, 49);
            this.lblNXB.TabIndex = 0;
            this.lblNXB.Text = "Thông Tin Nhà Xuất Bản";
            this.lblNXB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTTNXB
            // 
            this.grpTTNXB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpTTNXB.Controls.Add(this.cboTenNXB);
            this.grpTTNXB.Controls.Add(this.txtSDT);
            this.grpTTNXB.Controls.Add(this.lblSdt);
            this.grpTTNXB.Controls.Add(this.txtWeb);
            this.grpTTNXB.Controls.Add(this.txtDiaChi);
            this.grpTTNXB.Controls.Add(this.txtMaNXB);
            this.grpTTNXB.Controls.Add(this.lblWeb);
            this.grpTTNXB.Controls.Add(this.lblDiaChi);
            this.grpTTNXB.Controls.Add(this.lblTenNXB);
            this.grpTTNXB.Controls.Add(this.lblMaNXB);
            this.grpTTNXB.Controls.Add(this.grpTuyChon);
            this.grpTTNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTTNXB.Location = new System.Drawing.Point(3, 3);
            this.grpTTNXB.Name = "grpTTNXB";
            this.grpTTNXB.Size = new System.Drawing.Size(255, 490);
            this.grpTTNXB.TabIndex = 1;
            this.grpTTNXB.TabStop = false;
            this.grpTTNXB.Text = "Nhập thông tin nhà xuất bản";
            // 
            // cboTenNXB
            // 
            this.cboTenNXB.FormattingEnabled = true;
            this.cboTenNXB.Items.AddRange(new object[] {
            "Đại học Quốc gia Hà Nội",
            "Đại học Quốc gia TP. HCM",
            "Bách khoa Hà Nội",
            "Đại học Sư phạm Hà Nội",
            "Đại học sư phạm TP.Hồ Chí Minh",
            "Đai học Thái Nguyên",
            "Đại học Nông Nghiệp",
            "Chính trị Quốc Gia",
            "Kim Đồng",
            "Thông tin và Truyền thông",
            "Đại học Kinh tế Quốc dân",
            "Giáo dục Việt Nam",
            "Khoa học và kỹ thuật",
            "Văn hóa - thông tin",
            "Hàng Hải",
            "Xây dựng",
            "Khoa học Tự nhiên và Công nghệ",
            "Tài nguyên - Môi trường",
            "Thể dục thể thao"});
            this.cboTenNXB.Location = new System.Drawing.Point(111, 73);
            this.cboTenNXB.Name = "cboTenNXB";
            this.cboTenNXB.Size = new System.Drawing.Size(139, 21);
            this.cboTenNXB.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(111, 144);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(139, 20);
            this.txtSDT.TabIndex = 3;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(22, 147);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(70, 13);
            this.lblSdt.TabIndex = 8;
            this.lblSdt.Text = "Số điện thoại";
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(111, 184);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(139, 20);
            this.txtWeb.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(111, 109);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(139, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(111, 38);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(139, 20);
            this.txtMaNXB.TabIndex = 0;
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(23, 187);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(76, 13);
            this.lblWeb.TabIndex = 6;
            this.lblWeb.Text = "Website/Email";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(22, 112);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblTenNXB
            // 
            this.lblTenNXB.AutoSize = true;
            this.lblTenNXB.Location = new System.Drawing.Point(22, 77);
            this.lblTenNXB.Name = "lblTenNXB";
            this.lblTenNXB.Size = new System.Drawing.Size(51, 13);
            this.lblTenNXB.TabIndex = 4;
            this.lblTenNXB.Text = "Tên NXB";
            // 
            // lblMaNXB
            // 
            this.lblMaNXB.AutoSize = true;
            this.lblMaNXB.Location = new System.Drawing.Point(22, 41);
            this.lblMaNXB.Name = "lblMaNXB";
            this.lblMaNXB.Size = new System.Drawing.Size(47, 13);
            this.lblMaNXB.TabIndex = 3;
            this.lblMaNXB.Text = "Mã NXB";
            // 
            // grpTuyChon
            // 
            this.grpTuyChon.Controls.Add(this.btnLamMoi);
            this.grpTuyChon.Controls.Add(this.btnTrangChu);
            this.grpTuyChon.Controls.Add(this.btnXoaNXB);
            this.grpTuyChon.Controls.Add(this.btnSuaNXB);
            this.grpTuyChon.Controls.Add(this.btnThemNXB);
            this.grpTuyChon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpTuyChon.Location = new System.Drawing.Point(3, 318);
            this.grpTuyChon.Name = "grpTuyChon";
            this.grpTuyChon.Size = new System.Drawing.Size(249, 169);
            this.grpTuyChon.TabIndex = 2;
            this.grpTuyChon.TabStop = false;
            this.grpTuyChon.Text = "Tùy Chọn";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(144, 73);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(84, 31);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Location = new System.Drawing.Point(94, 109);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(84, 31);
            this.btnTrangChu.TabIndex = 4;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaNXB
            // 
            this.btnXoaNXB.Location = new System.Drawing.Point(56, 72);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(84, 31);
            this.btnXoaNXB.TabIndex = 2;
            this.btnXoaNXB.Text = "Xóa NXB";
            this.btnXoaNXB.UseVisualStyleBackColor = true;
            this.btnXoaNXB.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaNXB
            // 
            this.btnSuaNXB.Location = new System.Drawing.Point(144, 36);
            this.btnSuaNXB.Name = "btnSuaNXB";
            this.btnSuaNXB.Size = new System.Drawing.Size(84, 31);
            this.btnSuaNXB.TabIndex = 1;
            this.btnSuaNXB.Text = "Sửa NXB";
            this.btnSuaNXB.UseVisualStyleBackColor = true;
            this.btnSuaNXB.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.Location = new System.Drawing.Point(56, 36);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(84, 31);
            this.btnThemNXB.TabIndex = 0;
            this.btnThemNXB.Text = "Thêm NXB";
            this.btnThemNXB.UseVisualStyleBackColor = true;
            this.btnThemNXB.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grpCTNXB
            // 
            this.grpCTNXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCTNXB.Controls.Add(this.dgvNXB);
            this.grpCTNXB.Location = new System.Drawing.Point(272, 52);
            this.grpCTNXB.Name = "grpCTNXB";
            this.grpCTNXB.Size = new System.Drawing.Size(781, 518);
            this.grpCTNXB.TabIndex = 2;
            this.grpCTNXB.TabStop = false;
            this.grpCTNXB.Text = "Chi tiết thông tin nhà xuất bản";
            this.grpCTNXB.Enter += new System.EventHandler(this.grpCTNXB_Enter);
            // 
            // dgvNXB
            // 
            this.dgvNXB.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.column2,
            this.column3,
            this.column4,
            this.column5});
            this.dgvNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNXB.Location = new System.Drawing.Point(3, 16);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.Size = new System.Drawing.Size(775, 499);
            this.dgvNXB.TabIndex = 0;
            this.dgvNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNXB_CellClick);
            // 
            // column1
            // 
            this.column1.DataPropertyName = "MANXB";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.column1.HeaderText = "Mã NXB";
            this.column1.Name = "column1";
            this.column1.Width = 70;
            // 
            // column2
            // 
            this.column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column2.DataPropertyName = "TenNXB";
            this.column2.HeaderText = "Tên NXB";
            this.column2.Name = "column2";
            // 
            // column3
            // 
            this.column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column3.DataPropertyName = "DIACHINXB";
            this.column3.HeaderText = "Địa Chỉ NXB";
            this.column3.Name = "column3";
            // 
            // column4
            // 
            this.column4.DataPropertyName = "SDT";
            this.column4.HeaderText = "Số Điện Thoại";
            this.column4.Name = "column4";
            this.column4.Width = 120;
            // 
            // column5
            // 
            this.column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column5.DataPropertyName = "WEBSITE";
            this.column5.HeaderText = "Website/Email";
            this.column5.Name = "column5";
            // 
            // tabNhaXuatBan
            // 
            this.tabNhaXuatBan.Controls.Add(this.tabNhap);
            this.tabNhaXuatBan.Controls.Add(this.tabTimKiem);
            this.tabNhaXuatBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabNhaXuatBan.Location = new System.Drawing.Point(0, 49);
            this.tabNhaXuatBan.Name = "tabNhaXuatBan";
            this.tabNhaXuatBan.SelectedIndex = 0;
            this.tabNhaXuatBan.Size = new System.Drawing.Size(269, 522);
            this.tabNhaXuatBan.TabIndex = 1;
            // 
            // tabNhap
            // 
            this.tabNhap.Controls.Add(this.grpTTNXB);
            this.tabNhap.Location = new System.Drawing.Point(4, 22);
            this.tabNhap.Name = "tabNhap";
            this.tabNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhap.Size = new System.Drawing.Size(261, 496);
            this.tabNhap.TabIndex = 0;
            this.tabNhap.Text = "Nhập Nhà Xuất Bản";
            this.tabNhap.UseVisualStyleBackColor = true;
            // 
            // tabTimKiem
            // 
            this.tabTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabTimKiem.Controls.Add(this.grpTimKiem);
            this.tabTimKiem.Location = new System.Drawing.Point(4, 22);
            this.tabTimKiem.Name = "tabTimKiem";
            this.tabTimKiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimKiem.Size = new System.Drawing.Size(261, 479);
            this.tabTimKiem.TabIndex = 1;
            this.tabTimKiem.Text = "Tìm Kiếm Nhà Xuất Bản";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.cboMahayTen);
            this.grpTimKiem.Controls.Add(this.txtTuKhoa);
            this.grpTimKiem.Controls.Add(this.btnQuayLai);
            this.grpTimKiem.Controls.Add(this.lblTuKhoa);
            this.grpTimKiem.Controls.Add(this.labTimKiem);
            this.grpTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTimKiem.Location = new System.Drawing.Point(3, 3);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(255, 473);
            this.grpTimKiem.TabIndex = 0;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm nhà xuất bản";
            // 
            // cboMahayTen
            // 
            this.cboMahayTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMahayTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMahayTen.FormattingEnabled = true;
            this.cboMahayTen.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.cboMahayTen.Location = new System.Drawing.Point(119, 38);
            this.cboMahayTen.Name = "cboMahayTen";
            this.cboMahayTen.Size = new System.Drawing.Size(121, 24);
            this.cboMahayTen.TabIndex = 4;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.Location = new System.Drawing.Point(81, 80);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(159, 22);
            this.txtTuKhoa.TabIndex = 3;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(81, 122);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(81, 28);
            this.btnQuayLai.TabIndex = 2;
            this.btnQuayLai.Text = "Trang Chủ";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuKhoa.Location = new System.Drawing.Point(17, 83);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(63, 16);
            this.lblTuKhoa.TabIndex = 1;
            this.lblTuKhoa.Text = "Từ khóa :";
            // 
            // labTimKiem
            // 
            this.labTimKiem.AutoSize = true;
            this.labTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimKiem.Location = new System.Drawing.Point(17, 41);
            this.labTimKiem.Name = "labTimKiem";
            this.labTimKiem.Size = new System.Drawing.Size(98, 16);
            this.labTimKiem.TabIndex = 0;
            this.labTimKiem.Text = "Tìm kiếm theo :";
            // 
            // frmNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 571);
            this.Controls.Add(this.tabNhaXuatBan);
            this.Controls.Add(this.grpCTNXB);
            this.Controls.Add(this.lblNXB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNXB";
            this.Text = "Thông Tin Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.frmNXB_Load);
            this.grpTTNXB.ResumeLayout(false);
            this.grpTTNXB.PerformLayout();
            this.grpTuyChon.ResumeLayout(false);
            this.grpCTNXB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.tabNhaXuatBan.ResumeLayout(false);
            this.tabNhap.ResumeLayout(false);
            this.tabTimKiem.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNXB;
        private System.Windows.Forms.GroupBox grpTTNXB;
        private System.Windows.Forms.GroupBox grpTuyChon;
        private System.Windows.Forms.GroupBox grpCTNXB;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenNXB;
        private System.Windows.Forms.Label lblMaNXB;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnXoaNXB;
        private System.Windows.Forms.Button btnSuaNXB;
        private System.Windows.Forms.Button btnThemNXB;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column5;
        private System.Windows.Forms.ComboBox cboTenNXB;
        private System.Windows.Forms.TabControl tabNhaXuatBan;
        private System.Windows.Forms.TabPage tabNhap;
        private System.Windows.Forms.TabPage tabTimKiem;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.ComboBox cboMahayTen;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.Label labTimKiem;
    }
}