namespace TTDL_AMO
{
    partial class frmTrangChu
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
            this.components = new System.ComponentModel.Container();
            this.mnuQLTV = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhiếuMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ảnhCơQuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ảnhCơQuanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nộiQuyKhoTưLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monLichNam = new System.Windows.Forms.MonthCalendar();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrChayChu = new System.Windows.Forms.Timer(this.components);
            this.lblNhan = new System.Windows.Forms.Label();
            this.grpCongCu = new System.Windows.Forms.GroupBox();
            this.sttThongtin = new System.Windows.Forms.StatusStrip();
            this.stlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.grp = new System.Windows.Forms.GroupBox();
            this.picThuVien = new System.Windows.Forms.PictureBox();
            this.mnuQLTV.SuspendLayout();
            this.grpCongCu.SuspendLayout();
            this.sttThongtin.SuspendLayout();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThuVien)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuQLTV
            // 
            this.mnuQLTV.AutoSize = false;
            this.mnuQLTV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuQLTV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQLTV.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnuQLTV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMucToolStripMenuItem,
            this.ảnhCơQuanToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem});
            this.mnuQLTV.Location = new System.Drawing.Point(0, 0);
            this.mnuQLTV.Name = "mnuQLTV";
            this.mnuQLTV.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuQLTV.Size = new System.Drawing.Size(1132, 32);
            this.mnuQLTV.TabIndex = 0;
            this.mnuQLTV.Text = "Menu Quản Lý Thư Viện";
            this.mnuQLTV.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuQLTV_ItemClicked);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.AutoSize = false;
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 36);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.AutoSize = false;
            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSáchToolStripMenuItem,
            this.quảnLýĐộcGiảToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýPhiếuMượnToolStripMenuItem,
            this.quảnToolStripMenuItem});
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(135, 36);
            this.danhMucToolStripMenuItem.Text = "Danh Mục Quản Lý";
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.quảnLýSáchToolStripMenuItem.Text = "Tài liệu";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // quảnLýĐộcGiảToolStripMenuItem
            // 
            this.quảnLýĐộcGiảToolStripMenuItem.Name = "quảnLýĐộcGiảToolStripMenuItem";
            this.quảnLýĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.quảnLýĐộcGiảToolStripMenuItem.Text = "Độc giả";
            this.quảnLýĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐộcGiảToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýPhiếuMượnToolStripMenuItem
            // 
            this.quảnLýPhiếuMượnToolStripMenuItem.Name = "quảnLýPhiếuMượnToolStripMenuItem";
            this.quảnLýPhiếuMượnToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.quảnLýPhiếuMượnToolStripMenuItem.Text = "Phiếu mượn";
            this.quảnLýPhiếuMượnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhiếuMượnToolStripMenuItem_Click);
            // 
            // quảnToolStripMenuItem
            // 
            this.quảnToolStripMenuItem.Name = "quảnToolStripMenuItem";
            this.quảnToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.quảnToolStripMenuItem.Text = "Nhà xuất bản";
            this.quảnToolStripMenuItem.Click += new System.EventHandler(this.quảnToolStripMenuItem_Click);
            // 
            // ảnhCơQuanToolStripMenuItem
            // 
            this.ảnhCơQuanToolStripMenuItem.AutoSize = false;
            this.ảnhCơQuanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ảnhCơQuanToolStripMenuItem1});
            this.ảnhCơQuanToolStripMenuItem.Name = "ảnhCơQuanToolStripMenuItem";
            this.ảnhCơQuanToolStripMenuItem.Size = new System.Drawing.Size(94, 35);
            this.ảnhCơQuanToolStripMenuItem.Text = "Thư Viện Ảnh";
            // 
            // ảnhCơQuanToolStripMenuItem1
            // 
            this.ảnhCơQuanToolStripMenuItem1.Name = "ảnhCơQuanToolStripMenuItem1";
            this.ảnhCơQuanToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.ảnhCơQuanToolStripMenuItem1.Text = "Ảnh Cơ Quan";
            this.ảnhCơQuanToolStripMenuItem1.Click += new System.EventHandler(this.ảnhCơQuanToolStripMenuItem1_Click);
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.AutoSize = false;
            this.giớiThiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giớiThiệuToolStripMenuItem1,
            this.nộiQuyKhoTưLiệuToolStripMenuItem});
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(150, 35);
            this.giớiThiệuToolStripMenuItem.Text = "Thông Tin Phần Mềm";
            this.giớiThiệuToolStripMenuItem.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            // 
            // giớiThiệuToolStripMenuItem1
            // 
            this.giớiThiệuToolStripMenuItem1.Name = "giớiThiệuToolStripMenuItem1";
            this.giớiThiệuToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.giớiThiệuToolStripMenuItem1.Text = "Giới thiệu phần mềm";
            this.giớiThiệuToolStripMenuItem1.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem1_Click);
            // 
            // nộiQuyKhoTưLiệuToolStripMenuItem
            // 
            this.nộiQuyKhoTưLiệuToolStripMenuItem.Name = "nộiQuyKhoTưLiệuToolStripMenuItem";
            this.nộiQuyKhoTưLiệuToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.nộiQuyKhoTưLiệuToolStripMenuItem.Text = "Nội quy kho tư liệu";
            // 
            // monLichNam
            // 
            this.monLichNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monLichNam.Location = new System.Drawing.Point(22, 63);
            this.monLichNam.Name = "monLichNam";
            this.monLichNam.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTime.Location = new System.Drawing.Point(19, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 16);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Thời Gian : ";
            // 
            // tmrChayChu
            // 
            this.tmrChayChu.Enabled = true;
            this.tmrChayChu.Interval = 20;
            this.tmrChayChu.Tick += new System.EventHandler(this.tmrChayChu_Tick);
            // 
            // lblNhan
            // 
            this.lblNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNhan.AutoSize = true;
            this.lblNhan.BackColor = System.Drawing.SystemColors.Control;
            this.lblNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhan.ForeColor = System.Drawing.Color.Navy;
            this.lblNhan.Location = new System.Drawing.Point(221, 27);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(682, 29);
            this.lblNhan.TabIndex = 3;
            this.lblNhan.Text = "PHẦN MỀM QUẢN LÝ TƯ LIỆU ĐÀI KHÍ TƯỢNG CAO KHÔNG";
            this.lblNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCongCu
            // 
            this.grpCongCu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpCongCu.Controls.Add(this.monLichNam);
            this.grpCongCu.Controls.Add(this.lblTime);
            this.grpCongCu.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpCongCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCongCu.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpCongCu.Location = new System.Drawing.Point(867, 32);
            this.grpCongCu.Name = "grpCongCu";
            this.grpCongCu.Size = new System.Drawing.Size(265, 550);
            this.grpCongCu.TabIndex = 4;
            this.grpCongCu.TabStop = false;
            this.grpCongCu.Text = "Tiện ích";
            // 
            // sttThongtin
            // 
            this.sttThongtin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlabel});
            this.sttThongtin.Location = new System.Drawing.Point(0, 557);
            this.sttThongtin.Name = "sttThongtin";
            this.sttThongtin.Size = new System.Drawing.Size(867, 25);
            this.sttThongtin.TabIndex = 5;
            // 
            // stlabel
            // 
            this.stlabel.BackColor = System.Drawing.SystemColors.Control;
            this.stlabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.stlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stlabel.Name = "stlabel";
            this.stlabel.Size = new System.Drawing.Size(168, 20);
            this.stlabel.Text = "Sản phẩm Demo. Ver 01";
            // 
            // grp
            // 
            this.grp.Controls.Add(this.lblNhan);
            this.grp.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp.Location = new System.Drawing.Point(0, 32);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(867, 76);
            this.grp.TabIndex = 7;
            this.grp.TabStop = false;
            this.grp.Text = " ";
            // 
            // picThuVien
            // 
            this.picThuVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picThuVien.Image = global::TTDL_AMO.Properties.Resources.thu_viện;
            this.picThuVien.Location = new System.Drawing.Point(0, 108);
            this.picThuVien.Name = "picThuVien";
            this.picThuVien.Size = new System.Drawing.Size(867, 449);
            this.picThuVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThuVien.TabIndex = 8;
            this.picThuVien.TabStop = false;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 582);
            this.Controls.Add(this.picThuVien);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.sttThongtin);
            this.Controls.Add(this.grpCongCu);
            this.Controls.Add(this.mnuQLTV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuQLTV;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTrangChu";
            this.Text = "Phần Mềm Quản Lý Tư Liệu _ Đài Khí Tượng Cao Không";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.mnuQLTV.ResumeLayout(false);
            this.mnuQLTV.PerformLayout();
            this.grpCongCu.ResumeLayout(false);
            this.grpCongCu.PerformLayout();
            this.sttThongtin.ResumeLayout(false);
            this.sttThongtin.PerformLayout();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThuVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuQLTV;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhiếuMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monLichNam;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrChayChu;
        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.GroupBox grpCongCu;
        private System.Windows.Forms.StatusStrip sttThongtin;
        private System.Windows.Forms.ToolStripStatusLabel stlabel;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nộiQuyKhoTưLiệuToolStripMenuItem;
        private System.Windows.Forms.PictureBox picThuVien;
        private System.Windows.Forms.ToolStripMenuItem ảnhCơQuanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ảnhCơQuanToolStripMenuItem1;
    }
}