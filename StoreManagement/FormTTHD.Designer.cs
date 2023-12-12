namespace StoreManagement
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuyHD = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThemGioHang = new System.Windows.Forms.Button();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.dtpkNgayBan = new System.Windows.Forms.DateTimePicker();
            this.tbxPhaiThanhToan = new System.Windows.Forms.TextBox();
            this.tbxGiamGia = new System.Windows.Forms.TextBox();
            this.tbxTongTien = new System.Windows.Forms.TextBox();
            this.tbxMaHD = new System.Windows.Forms.TextBox();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblPhaiThanhToan = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.tbxTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pnlDSSP = new System.Windows.Forms.Panel();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.lblPageview = new System.Windows.Forms.Label();
            this.btnEPg = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.btnBck = new System.Windows.Forms.Button();
            this.btnDauTrang = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.pPDHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.pDHoaDon = new System.Drawing.Printing.PrintDocument();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.pnlDSSP.SuspendLayout();
            this.pnlPage.SuspendLayout();
            this.gbxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButton.Controls.Add(this.btnXoa);
            this.pnlButton.Controls.Add(this.btnHuyHD);
            this.pnlButton.Controls.Add(this.btnThanhToan);
            this.pnlButton.Controls.Add(this.btnThemGioHang);
            this.pnlButton.Location = new System.Drawing.Point(0, 529);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(1094, 65);
            this.pnlButton.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(355, 16);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(153, 38);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa khỏi giỏ hàng";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyHD.AutoSize = true;
            this.btnHuyHD.Location = new System.Drawing.Point(919, 14);
            this.btnHuyHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyHD.Name = "btnHuyHD";
            this.btnHuyHD.Size = new System.Drawing.Size(153, 38);
            this.btnHuyHD.TabIndex = 34;
            this.btnHuyHD.Text = "Hủy hóa đơn";
            this.btnHuyHD.UseVisualStyleBackColor = true;
            this.btnHuyHD.Click += new System.EventHandler(this.btnHuyHD_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThanhToan.AutoSize = true;
            this.btnThanhToan.Location = new System.Drawing.Point(637, 14);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(153, 38);
            this.btnThanhToan.TabIndex = 35;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThemGioHang
            // 
            this.btnThemGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemGioHang.AutoSize = true;
            this.btnThemGioHang.Location = new System.Drawing.Point(54, 16);
            this.btnThemGioHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemGioHang.Name = "btnThemGioHang";
            this.btnThemGioHang.Size = new System.Drawing.Size(172, 38);
            this.btnThemGioHang.TabIndex = 32;
            this.btnThemGioHang.Text = "Thêm vào giỏ hàng";
            this.btnThemGioHang.UseVisualStyleBackColor = true;
            this.btnThemGioHang.Click += new System.EventHandler(this.btnThemGioHang_Click);
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.AutoSize = true;
            this.btnTaoHoaDon.Location = new System.Drawing.Point(371, 58);
            this.btnTaoHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(154, 38);
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
            this.dgvSanPham.Location = new System.Drawing.Point(12, 188);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.RowTemplate.Height = 62;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(568, 332);
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
            this.dgvGioHang.Location = new System.Drawing.Point(10, 265);
            this.dgvGioHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.RowHeadersWidth = 62;
            this.dgvGioHang.RowTemplate.Height = 28;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(468, 255);
            this.dgvGioHang.TabIndex = 2;
            this.dgvGioHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellDoubleClick);
            // 
            // dtpkNgayBan
            // 
            this.dtpkNgayBan.Location = new System.Drawing.Point(137, 64);
            this.dtpkNgayBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkNgayBan.Name = "dtpkNgayBan";
            this.dtpkNgayBan.Size = new System.Drawing.Size(337, 26);
            this.dtpkNgayBan.TabIndex = 29;
            // 
            // tbxPhaiThanhToan
            // 
            this.tbxPhaiThanhToan.Location = new System.Drawing.Point(137, 181);
            this.tbxPhaiThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPhaiThanhToan.Name = "tbxPhaiThanhToan";
            this.tbxPhaiThanhToan.ReadOnly = true;
            this.tbxPhaiThanhToan.Size = new System.Drawing.Size(337, 26);
            this.tbxPhaiThanhToan.TabIndex = 28;
            // 
            // tbxGiamGia
            // 
            this.tbxGiamGia.Location = new System.Drawing.Point(137, 142);
            this.tbxGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxGiamGia.Name = "tbxGiamGia";
            this.tbxGiamGia.Size = new System.Drawing.Size(337, 26);
            this.tbxGiamGia.TabIndex = 27;
            this.tbxGiamGia.TextChanged += new System.EventHandler(this.tbxGiamGia_TextChanged);
            // 
            // tbxTongTien
            // 
            this.tbxTongTien.Location = new System.Drawing.Point(137, 102);
            this.tbxTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTongTien.Name = "tbxTongTien";
            this.tbxTongTien.ReadOnly = true;
            this.tbxTongTien.Size = new System.Drawing.Size(337, 26);
            this.tbxTongTien.TabIndex = 26;
            // 
            // tbxMaHD
            // 
            this.tbxMaHD.Enabled = false;
            this.tbxMaHD.Location = new System.Drawing.Point(137, 28);
            this.tbxMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMaHD.Name = "tbxMaHD";
            this.tbxMaHD.ReadOnly = true;
            this.tbxMaHD.Size = new System.Drawing.Size(337, 26);
            this.tbxMaHD.TabIndex = 25;
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Location = new System.Drawing.Point(6, 70);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(80, 20);
            this.lblNgayBan.TabIndex = 24;
            this.lblNgayBan.Text = "Ngày bán:";
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(6, 148);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(76, 20);
            this.lblGiamGia.TabIndex = 23;
            this.lblGiamGia.Text = "Giảm giá:";
            // 
            // lblPhaiThanhToan
            // 
            this.lblPhaiThanhToan.AutoSize = true;
            this.lblPhaiThanhToan.Location = new System.Drawing.Point(6, 188);
            this.lblPhaiThanhToan.Name = "lblPhaiThanhToan";
            this.lblPhaiThanhToan.Size = new System.Drawing.Size(125, 20);
            this.lblPhaiThanhToan.TabIndex = 22;
            this.lblPhaiThanhToan.Text = "Phải thanh toán:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(6, 109);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(68, 20);
            this.lblDonGia.TabIndex = 21;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(6, 31);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(97, 20);
            this.lblMaHD.TabIndex = 20;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTimKiem.Location = new System.Drawing.Point(12, 11);
            this.tbxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(353, 26);
            this.tbxTimKiem.TabIndex = 30;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Location = new System.Drawing.Point(371, 3);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(91, 38);
            this.btnTimKiem.TabIndex = 31;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // pnlDSSP
            // 
            this.pnlDSSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDSSP.Controls.Add(this.btnTaoHoaDon);
            this.pnlDSSP.Controls.Add(this.pnlPage);
            this.pnlDSSP.Controls.Add(this.btnRefresh);
            this.pnlDSSP.Controls.Add(this.tbxTimKiem);
            this.pnlDSSP.Controls.Add(this.dgvSanPham);
            this.pnlDSSP.Controls.Add(this.btnTimKiem);
            this.pnlDSSP.Location = new System.Drawing.Point(0, 1);
            this.pnlDSSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDSSP.Name = "pnlDSSP";
            this.pnlDSSP.Size = new System.Drawing.Size(595, 526);
            this.pnlDSSP.TabIndex = 33;
            // 
            // pnlPage
            // 
            this.pnlPage.Controls.Add(this.lblPageview);
            this.pnlPage.Controls.Add(this.btnEPg);
            this.pnlPage.Controls.Add(this.btnFwd);
            this.pnlPage.Controls.Add(this.btnBck);
            this.pnlPage.Controls.Add(this.btnDauTrang);
            this.pnlPage.Location = new System.Drawing.Point(12, 102);
            this.pnlPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(568, 66);
            this.pnlPage.TabIndex = 34;
            // 
            // lblPageview
            // 
            this.lblPageview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPageview.Location = new System.Drawing.Point(239, 26);
            this.lblPageview.Name = "lblPageview";
            this.lblPageview.Size = new System.Drawing.Size(88, 28);
            this.lblPageview.TabIndex = 4;
            this.lblPageview.Text = " ";
            this.lblPageview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEPg
            // 
            this.btnEPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEPg.Location = new System.Drawing.Point(424, 26);
            this.btnEPg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEPg.Name = "btnEPg";
            this.btnEPg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEPg.Size = new System.Drawing.Size(45, 29);
            this.btnEPg.TabIndex = 3;
            this.btnEPg.Text = ">|";
            this.btnEPg.UseVisualStyleBackColor = true;
            this.btnEPg.Click += new System.EventHandler(this.btnEPg_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFwd.Location = new System.Drawing.Point(353, 26);
            this.btnFwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(45, 29);
            this.btnFwd.TabIndex = 2;
            this.btnFwd.Text = ">>";
            this.btnFwd.UseVisualStyleBackColor = true;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // btnBck
            // 
            this.btnBck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBck.Location = new System.Drawing.Point(168, 26);
            this.btnBck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(45, 29);
            this.btnBck.TabIndex = 1;
            this.btnBck.Text = "<<";
            this.btnBck.UseVisualStyleBackColor = true;
            this.btnBck.Click += new System.EventHandler(this.btnBck_Click);
            // 
            // btnDauTrang
            // 
            this.btnDauTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDauTrang.Location = new System.Drawing.Point(97, 26);
            this.btnDauTrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDauTrang.Name = "btnDauTrang";
            this.btnDauTrang.Size = new System.Drawing.Size(45, 29);
            this.btnDauTrang.TabIndex = 0;
            this.btnDauTrang.Text = "|<";
            this.btnDauTrang.UseVisualStyleBackColor = true;
            this.btnDauTrang.Click += new System.EventHandler(this.btnDauTrang_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Location = new System.Drawing.Point(468, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 38);
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
            this.gbxInfo.Controls.Add(this.lblMaHD);
            this.gbxInfo.Controls.Add(this.dgvGioHang);
            this.gbxInfo.Controls.Add(this.lblDonGia);
            this.gbxInfo.Controls.Add(this.dtpkNgayBan);
            this.gbxInfo.Controls.Add(this.lblPhaiThanhToan);
            this.gbxInfo.Controls.Add(this.tbxPhaiThanhToan);
            this.gbxInfo.Controls.Add(this.lblGiamGia);
            this.gbxInfo.Controls.Add(this.tbxGiamGia);
            this.gbxInfo.Controls.Add(this.lblNgayBan);
            this.gbxInfo.Controls.Add(this.tbxTongTien);
            this.gbxInfo.Controls.Add(this.tbxMaHD);
            this.gbxInfo.Location = new System.Drawing.Point(598, 1);
            this.gbxInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInfo.Size = new System.Drawing.Size(495, 526);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 594);
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
            this.pnlPage.ResumeLayout(false);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.DateTimePicker dtpkNgayBan;
        private System.Windows.Forms.TextBox tbxPhaiThanhToan;
        private System.Windows.Forms.TextBox tbxGiamGia;
        private System.Windows.Forms.TextBox tbxTongTien;
        private System.Windows.Forms.TextBox tbxMaHD;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblPhaiThanhToan;
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
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.Label lblPageview;
        private System.Windows.Forms.Button btnEPg;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Button btnBck;
        private System.Windows.Forms.Button btnDauTrang;
    }
}