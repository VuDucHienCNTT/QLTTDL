namespace TTDL_AMO
{
    partial class frmImageCoQuan
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
            this.dgvDSImage = new System.Windows.Forms.DataGridView();
            this.lblAnh = new System.Windows.Forms.Label();
            this.lblTenAnh = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChonTep = new System.Windows.Forms.Button();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.txtTenAnh = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LableImg = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSImage
            // 
            this.dgvDSImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDSImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvDSImage.Location = new System.Drawing.Point(34, 103);
            this.dgvDSImage.Name = "dgvDSImage";
            this.dgvDSImage.Size = new System.Drawing.Size(451, 364);
            this.dgvDSImage.TabIndex = 23;
            this.dgvDSImage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSImage_CellClick);
            this.dgvDSImage.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSImage_RowEnter);
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnh.Location = new System.Drawing.Point(31, 65);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(81, 15);
            this.lblAnh.TabIndex = 21;
            this.lblAnh.Text = "Ảnh cơ quan :";
            // 
            // lblTenAnh
            // 
            this.lblTenAnh.AutoSize = true;
            this.lblTenAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenAnh.Location = new System.Drawing.Point(31, 30);
            this.lblTenAnh.Name = "lblTenAnh";
            this.lblTenAnh.Size = new System.Drawing.Size(58, 15);
            this.lblTenAnh.TabIndex = 20;
            this.lblTenAnh.Text = "Tên ảnh :";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(408, 61);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 24);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm Ảnh";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChonTep
            // 
            this.btnChonTep.Location = new System.Drawing.Point(408, 26);
            this.btnChonTep.Name = "btnChonTep";
            this.btnChonTep.Size = new System.Drawing.Size(77, 24);
            this.btnChonTep.TabIndex = 18;
            this.btnChonTep.Text = "Chọn Tệp ...";
            this.btnChonTep.UseVisualStyleBackColor = true;
            this.btnChonTep.Click += new System.EventHandler(this.btnChonTep_Click);
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(118, 62);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(284, 20);
            this.txtDuongDan.TabIndex = 17;
            // 
            // txtTenAnh
            // 
            this.txtTenAnh.Location = new System.Drawing.Point(118, 29);
            this.txtTenAnh.Name = "txtTenAnh";
            this.txtTenAnh.Size = new System.Drawing.Size(284, 20);
            this.txtTenAnh.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(520, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // LableImg
            // 
            this.LableImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LableImg.AutoSize = true;
            this.LableImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableImg.Location = new System.Drawing.Point(721, 44);
            this.LableImg.Name = "LableImg";
            this.LableImg.Size = new System.Drawing.Size(76, 20);
            this.LableImg.TabIndex = 25;
            this.LableImg.Text = "Tên Ảnh";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TENANH";
            this.Column1.HeaderText = "Tên Ảnh";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "ANH";
            this.Column2.HeaderText = "Đường Dẫn Ảnh";
            this.Column2.Name = "Column2";
            // 
            // frmImageCoQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 497);
            this.Controls.Add(this.LableImg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvDSImage);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.lblTenAnh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnChonTep);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.txtTenAnh);
            this.Name = "frmImageCoQuan";
            this.Text = "Ảnh Cơ Quan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImageCoQuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSImage;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.Label lblTenAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChonTep;
        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.TextBox txtTenAnh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LableImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}