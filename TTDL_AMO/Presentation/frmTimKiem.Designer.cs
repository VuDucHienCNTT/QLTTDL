namespace TTDL_AMO
{
    partial class frmTimKiem
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
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.lbltukhoa = new System.Windows.Forms.Label();
            this.lbltimkiem = new System.Windows.Forms.Label();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.lblNhan = new System.Windows.Forms.Label();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.lblLuaChon = new System.Windows.Forms.Label();
            this.cboMaTen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Tài Liệu",
            "Độc Giả",
            "Nhân Viên",
            "Phiếu Mượn",
            "Nhà Xuất Bản"});
            this.cboTimKiem.Location = new System.Drawing.Point(359, 68);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(133, 21);
            this.cboTimKiem.TabIndex = 1;
            this.cboTimKiem.SelectedIndexChanged += new System.EventHandler(this.cboTimKiem_SelectedIndexChanged);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(579, 69);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(177, 20);
            this.txtTuKhoa.TabIndex = 2;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // lbltukhoa
            // 
            this.lbltukhoa.AutoSize = true;
            this.lbltukhoa.Location = new System.Drawing.Point(520, 74);
            this.lbltukhoa.Name = "lbltukhoa";
            this.lbltukhoa.Size = new System.Drawing.Size(53, 13);
            this.lbltukhoa.TabIndex = 2;
            this.lbltukhoa.Text = "Từ khóa :";
            // 
            // lbltimkiem
            // 
            this.lbltimkiem.AutoSize = true;
            this.lbltimkiem.Location = new System.Drawing.Point(289, 74);
            this.lbltimkiem.Name = "lbltimkiem";
            this.lbltimkiem.Size = new System.Drawing.Size(55, 13);
            this.lbltimkiem.TabIndex = 3;
            this.lbltimkiem.Text = "Tìm kiếm :";
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.AllowUserToAddRows = false;
            this.dgvTimKiem.AllowUserToDeleteRows = false;
            this.dgvTimKiem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTimKiem.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTimKiem.Location = new System.Drawing.Point(0, 110);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.ReadOnly = true;
            this.dgvTimKiem.Size = new System.Drawing.Size(936, 365);
            this.dgvTimKiem.TabIndex = 4;
            // 
            // lblNhan
            // 
            this.lblNhan.BackColor = System.Drawing.Color.Silver;
            this.lblNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhan.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNhan.Location = new System.Drawing.Point(0, 0);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(936, 42);
            this.lblNhan.TabIndex = 5;
            this.lblNhan.Text = "Tìm Kiếm Thông Tin";
            this.lblNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Location = new System.Drawing.Point(786, 66);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(75, 23);
            this.btnTrangChu.TabIndex = 4;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // lblLuaChon
            // 
            this.lblLuaChon.AutoSize = true;
            this.lblLuaChon.Location = new System.Drawing.Point(62, 74);
            this.lblLuaChon.Name = "lblLuaChon";
            this.lblLuaChon.Size = new System.Drawing.Size(58, 13);
            this.lblLuaChon.TabIndex = 9;
            this.lblLuaChon.Text = "Lựa chọn :";
            // 
            // cboMaTen
            // 
            this.cboMaTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaTen.FormattingEnabled = true;
            this.cboMaTen.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.cboMaTen.Location = new System.Drawing.Point(126, 68);
            this.cboMaTen.Name = "cboMaTen";
            this.cboMaTen.Size = new System.Drawing.Size(133, 21);
            this.cboMaTen.TabIndex = 0;
            this.cboMaTen.SelectedIndexChanged += new System.EventHandler(this.cboMaTen_SelectedIndexChanged);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 475);
            this.Controls.Add(this.lblLuaChon);
            this.Controls.Add(this.cboMaTen);
            this.Controls.Add(this.btnTrangChu);
            this.Controls.Add(this.lblNhan);
            this.Controls.Add(this.dgvTimKiem);
            this.Controls.Add(this.lbltimkiem);
            this.Controls.Add(this.lbltukhoa);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.cboTimKiem);
            this.Name = "frmTimKiem";
            this.Text = "Tìm Kiếm Thông Tin";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label lbltukhoa;
        private System.Windows.Forms.Label lbltimkiem;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Label lblLuaChon;
        private System.Windows.Forms.ComboBox cboMaTen;
    }
}