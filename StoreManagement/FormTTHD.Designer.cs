﻿namespace StoreManagement
{
    partial class FormTTHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTTHD));
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnHuyHD = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThemGioHang = new System.Windows.Forms.Button();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.dtpkNgayBan = new System.Windows.Forms.DateTimePicker();
            this.tbxThanhTien = new System.Windows.Forms.TextBox();
            this.tbxGiamGia = new System.Windows.Forms.TextBox();
            this.tbxDonGia = new System.Windows.Forms.TextBox();
            this.tbxMaHD = new System.Windows.Forms.TextBox();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.tbxTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pnlDSSP = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.pPDHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.pDHoaDon = new System.Drawing.Printing.PrintDocument();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.pnlDSSP.SuspendLayout();
            this.gbxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButton.Controls.Add(this.btnHuyHD);
            this.pnlButton.Controls.Add(this.btnThanhToan);
            this.pnlButton.Controls.Add(this.btnThemGioHang);
            this.pnlButton.Location = new System.Drawing.Point(0, 423);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(972, 52);
            this.pnlButton.TabIndex = 0;
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyHD.AutoSize = true;
            this.btnHuyHD.Location = new System.Drawing.Point(816, 12);
            this.btnHuyHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyHD.Name = "btnHuyHD";
            this.btnHuyHD.Size = new System.Drawing.Size(136, 26);
            this.btnHuyHD.TabIndex = 34;
            this.btnHuyHD.Text = "Hủy hóa đơn";
            this.btnHuyHD.UseVisualStyleBackColor = true;
            this.btnHuyHD.Click += new System.EventHandler(this.btnHuyHD_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThanhToan.AutoSize = true;
            this.btnThanhToan.Location = new System.Drawing.Point(618, 12);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(136, 26);
            this.btnThanhToan.TabIndex = 35;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThemGioHang
            // 
            this.btnThemGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemGioHang.AutoSize = true;
            this.btnThemGioHang.Location = new System.Drawing.Point(445, 15);
            this.btnThemGioHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemGioHang.Name = "btnThemGioHang";
            this.btnThemGioHang.Size = new System.Drawing.Size(136, 26);
            this.btnThemGioHang.TabIndex = 32;
            this.btnThemGioHang.Text = "Thêm vào giỏ hàng";
            this.btnThemGioHang.UseVisualStyleBackColor = true;
            this.btnThemGioHang.Click += new System.EventHandler(this.btnThemGioHang_Click);
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTaoHoaDon.AutoSize = true;
            this.btnTaoHoaDon.Location = new System.Drawing.Point(155, 183);
            this.btnTaoHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(136, 26);
            this.btnTaoHoaDon.TabIndex = 37;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn mới";
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(11, 36);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.RowTemplate.Height = 62;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(505, 380);
            this.dgvSanPham.TabIndex = 1;
            this.dgvSanPham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellDoubleClick);
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(9, 212);
            this.dgvGioHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.RowHeadersWidth = 62;
            this.dgvGioHang.RowTemplate.Height = 28;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(416, 204);
            this.dgvGioHang.TabIndex = 2;
            // 
            // dtpkNgayBan
            // 
            this.dtpkNgayBan.Location = new System.Drawing.Point(97, 51);
            this.dtpkNgayBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkNgayBan.Name = "dtpkNgayBan";
            this.dtpkNgayBan.Size = new System.Drawing.Size(325, 22);
            this.dtpkNgayBan.TabIndex = 29;
            // 
            // tbxThanhTien
            // 
            this.tbxThanhTien.Location = new System.Drawing.Point(97, 145);
            this.tbxThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxThanhTien.Name = "tbxThanhTien";
            this.tbxThanhTien.ReadOnly = true;
            this.tbxThanhTien.Size = new System.Drawing.Size(325, 22);
            this.tbxThanhTien.TabIndex = 28;
            // 
            // tbxGiamGia
            // 
            this.tbxGiamGia.Location = new System.Drawing.Point(97, 114);
            this.tbxGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxGiamGia.Name = "tbxGiamGia";
            this.tbxGiamGia.Size = new System.Drawing.Size(325, 22);
            this.tbxGiamGia.TabIndex = 27;
            this.tbxGiamGia.TextChanged += new System.EventHandler(this.tbxGiamGia_TextChanged);
            // 
            // tbxDonGia
            // 
            this.tbxDonGia.Location = new System.Drawing.Point(97, 82);
            this.tbxDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDonGia.Name = "tbxDonGia";
            this.tbxDonGia.ReadOnly = true;
            this.tbxDonGia.Size = new System.Drawing.Size(325, 22);
            this.tbxDonGia.TabIndex = 26;
            // 
            // tbxMaHD
            // 
            this.tbxMaHD.Enabled = false;
            this.tbxMaHD.Location = new System.Drawing.Point(97, 22);
            this.tbxMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMaHD.Name = "tbxMaHD";
            this.tbxMaHD.ReadOnly = true;
            this.tbxMaHD.Size = new System.Drawing.Size(325, 22);
            this.tbxMaHD.TabIndex = 25;
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Location = new System.Drawing.Point(5, 56);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(69, 16);
            this.lblNgayBan.TabIndex = 24;
            this.lblNgayBan.Text = "Ngày bán:";
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(5, 118);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(64, 16);
            this.lblGiamGia.TabIndex = 23;
            this.lblGiamGia.Text = "Giảm giá:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(5, 150);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(72, 16);
            this.lblThanhTien.TabIndex = 22;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(5, 87);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(56, 16);
            this.lblDonGia.TabIndex = 21;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(5, 25);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(81, 16);
            this.lblMaHD.TabIndex = 20;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTimKiem.Location = new System.Drawing.Point(11, 9);
            this.tbxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(314, 22);
            this.tbxTimKiem.TabIndex = 30;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Location = new System.Drawing.Point(345, 7);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(72, 26);
            this.btnTimKiem.TabIndex = 31;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // pnlDSSP
            // 
            this.pnlDSSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDSSP.Controls.Add(this.btnRefresh);
            this.pnlDSSP.Controls.Add(this.tbxTimKiem);
            this.pnlDSSP.Controls.Add(this.dgvSanPham);
            this.pnlDSSP.Controls.Add(this.btnTimKiem);
            this.pnlDSSP.Location = new System.Drawing.Point(0, 1);
            this.pnlDSSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDSSP.Name = "pnlDSSP";
            this.pnlDSSP.Size = new System.Drawing.Size(529, 421);
            this.pnlDSSP.TabIndex = 33;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Location = new System.Drawing.Point(445, 7);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 26);
            this.btnRefresh.TabIndex = 33;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gbxInfo
            // 
            this.gbxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInfo.Controls.Add(this.btnTaoHoaDon);
            this.gbxInfo.Controls.Add(this.lblMaHD);
            this.gbxInfo.Controls.Add(this.dgvGioHang);
            this.gbxInfo.Controls.Add(this.lblDonGia);
            this.gbxInfo.Controls.Add(this.dtpkNgayBan);
            this.gbxInfo.Controls.Add(this.lblThanhTien);
            this.gbxInfo.Controls.Add(this.tbxThanhTien);
            this.gbxInfo.Controls.Add(this.lblGiamGia);
            this.gbxInfo.Controls.Add(this.tbxGiamGia);
            this.gbxInfo.Controls.Add(this.lblNgayBan);
            this.gbxInfo.Controls.Add(this.tbxDonGia);
            this.gbxInfo.Controls.Add(this.tbxMaHD);
            this.gbxInfo.Location = new System.Drawing.Point(532, 1);
            this.gbxInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInfo.Size = new System.Drawing.Size(440, 421);
            this.gbxInfo.TabIndex = 34;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Thông tin hóa đơn";
            // 
            // pPDHoaDon
            // 
            this.pPDHoaDon.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pPDHoaDon.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pPDHoaDon.ClientSize = new System.Drawing.Size(400, 300);
            this.pPDHoaDon.Enabled = true;
            this.pPDHoaDon.Icon = ((System.Drawing.Icon)(resources.GetObject("pPDHoaDon.Icon")));
            this.pPDHoaDon.Name = "pPDHoaDon";
            this.pPDHoaDon.Visible = false;
            // 
            // pDHoaDon
            // 
            this.pDHoaDon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDHoaDon_PrintPage);
            // 
            // FormTTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 475);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.pnlDSSP);
            this.Controls.Add(this.pnlButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTTHD";
            this.Text = "FormTTHD";
            this.Load += new System.EventHandler(this.FormTTHD_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.pnlDSSP.ResumeLayout(false);
            this.pnlDSSP.PerformLayout();
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.DateTimePicker dtpkNgayBan;
        private System.Windows.Forms.TextBox tbxThanhTien;
        private System.Windows.Forms.TextBox tbxGiamGia;
        private System.Windows.Forms.TextBox tbxDonGia;
        private System.Windows.Forms.TextBox tbxMaHD;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.TextBox tbxTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemGioHang;
        private System.Windows.Forms.Panel pnlDSSP;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHuyHD;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.PrintPreviewDialog pPDHoaDon;
        private System.Drawing.Printing.PrintDocument pDHoaDon;
    }
}