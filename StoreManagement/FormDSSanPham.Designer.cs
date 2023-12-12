namespace StoreManagement
{
    partial class FormDSSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.cbxPhanLoai = new System.Windows.Forms.ComboBox();
            this.tbxGiaTien = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.tbxSoLuong = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tbxTenSP = new System.Windows.Forms.TextBox();
            this.tbxMaSP = new System.Windows.Forms.TextBox();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tbxTimKiem = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.lblPageview = new System.Windows.Forms.Label();
            this.btnEPg = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.btnBck = new System.Windows.Forms.Button();
            this.btnDauTrang = new System.Windows.Forms.Button();
            this.tbxGiaNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGiamGia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.pbxAnhSp = new System.Windows.Forms.PictureBox();
            this.gbxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.pnlPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnhSp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaSP
            // 
            this.lblMaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(6, 279);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(109, 20);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã sản phẩm:";
            // 
            // gbxInfo
            // 
            this.gbxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInfo.Controls.Add(this.btnNhapHang);
            this.gbxInfo.Controls.Add(this.cbxGiamGia);
            this.gbxInfo.Controls.Add(this.label2);
            this.gbxInfo.Controls.Add(this.tbxGiaNhap);
            this.gbxInfo.Controls.Add(this.label1);
            this.gbxInfo.Controls.Add(this.cbxPhanLoai);
            this.gbxInfo.Controls.Add(this.pbxAnhSp);
            this.gbxInfo.Controls.Add(this.tbxGiaTien);
            this.gbxInfo.Controls.Add(this.btnSua);
            this.gbxInfo.Controls.Add(this.tbxSoLuong);
            this.gbxInfo.Controls.Add(this.btnXoa);
            this.gbxInfo.Controls.Add(this.tbxTenSP);
            this.gbxInfo.Controls.Add(this.tbxMaSP);
            this.gbxInfo.Controls.Add(this.lblPhanLoai);
            this.gbxInfo.Controls.Add(this.lblGia);
            this.gbxInfo.Controls.Add(this.lblSoLuong);
            this.gbxInfo.Controls.Add(this.lblTenSP);
            this.gbxInfo.Controls.Add(this.lblMaSP);
            this.gbxInfo.Location = new System.Drawing.Point(699, 0);
            this.gbxInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInfo.Size = new System.Drawing.Size(395, 680);
            this.gbxInfo.TabIndex = 1;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Thông tin sản phẩm";
            // 
            // cbxPhanLoai
            // 
            this.cbxPhanLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPhanLoai.FormattingEnabled = true;
            this.cbxPhanLoai.Location = new System.Drawing.Point(134, 376);
            this.cbxPhanLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPhanLoai.Name = "cbxPhanLoai";
            this.cbxPhanLoai.Size = new System.Drawing.Size(255, 28);
            this.cbxPhanLoai.TabIndex = 13;
            // 
            // tbxGiaTien
            // 
            this.tbxGiaTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxGiaTien.Location = new System.Drawing.Point(134, 482);
            this.tbxGiaTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxGiaTien.Name = "tbxGiaTien";
            this.tbxGiaTien.Size = new System.Drawing.Size(255, 26);
            this.tbxGiaTien.TabIndex = 11;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(309, 626);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 38);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSoLuong.Location = new System.Drawing.Point(134, 429);
            this.tbxSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.Size = new System.Drawing.Size(255, 26);
            this.tbxSoLuong.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(29, 626);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 38);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tbxTenSP
            // 
            this.tbxTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTenSP.Location = new System.Drawing.Point(134, 326);
            this.tbxTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTenSP.Name = "tbxTenSP";
            this.tbxTenSP.Size = new System.Drawing.Size(255, 26);
            this.tbxTenSP.TabIndex = 7;
            // 
            // tbxMaSP
            // 
            this.tbxMaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMaSP.Enabled = false;
            this.tbxMaSP.Location = new System.Drawing.Point(134, 279);
            this.tbxMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMaSP.Name = "tbxMaSP";
            this.tbxMaSP.Size = new System.Drawing.Size(255, 26);
            this.tbxMaSP.TabIndex = 6;
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.Location = new System.Drawing.Point(6, 383);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(78, 20);
            this.lblPhanLoai.TabIndex = 4;
            this.lblPhanLoai.Text = "Phân loại:";
            // 
            // lblGia
            // 
            this.lblGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(8, 488);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(69, 20);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "Giá bán:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(6, 436);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(76, 20);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(2, 332);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(114, 20);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(497, 16);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.Location = new System.Drawing.Point(11, 88);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.RowTemplate.Height = 62;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(669, 497);
            this.dgvSanPham.TabIndex = 2;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Location = new System.Drawing.Point(343, 16);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(81, 32);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Location = new System.Drawing.Point(11, 16);
            this.tbxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(303, 26);
            this.tbxTimKiem.TabIndex = 12;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Location = new System.Drawing.Point(602, 16);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 32);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlPage
            // 
            this.pnlPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlPage.Controls.Add(this.lblPageview);
            this.pnlPage.Controls.Add(this.btnEPg);
            this.pnlPage.Controls.Add(this.btnFwd);
            this.pnlPage.Controls.Add(this.btnBck);
            this.pnlPage.Controls.Add(this.btnDauTrang);
            this.pnlPage.Location = new System.Drawing.Point(11, 598);
            this.pnlPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(670, 66);
            this.pnlPage.TabIndex = 14;
            // 
            // lblPageview
            // 
            this.lblPageview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPageview.Location = new System.Drawing.Point(285, 23);
            this.lblPageview.Name = "lblPageview";
            this.lblPageview.Size = new System.Drawing.Size(88, 28);
            this.lblPageview.TabIndex = 4;
            this.lblPageview.Text = " ";
            this.lblPageview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEPg
            // 
            this.btnEPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEPg.Location = new System.Drawing.Point(470, 23);
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
            this.btnFwd.Location = new System.Drawing.Point(399, 23);
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
            this.btnBck.Location = new System.Drawing.Point(214, 23);
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
            this.btnDauTrang.Location = new System.Drawing.Point(143, 23);
            this.btnDauTrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDauTrang.Name = "btnDauTrang";
            this.btnDauTrang.Size = new System.Drawing.Size(45, 29);
            this.btnDauTrang.TabIndex = 0;
            this.btnDauTrang.Text = "|<";
            this.btnDauTrang.UseVisualStyleBackColor = true;
            this.btnDauTrang.Click += new System.EventHandler(this.btnDauTrang_Click);
            // 
            // tbxGiaNhap
            // 
            this.tbxGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxGiaNhap.Location = new System.Drawing.Point(134, 525);
            this.tbxGiaNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxGiaNhap.Name = "tbxGiaNhap";
            this.tbxGiaNhap.Size = new System.Drawing.Size(255, 26);
            this.tbxGiaNhap.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giá nhập:";
            // 
            // cbxGiamGia
            // 
            this.cbxGiamGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGiamGia.FormattingEnabled = true;
            this.cbxGiamGia.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "50"});
            this.cbxGiamGia.Location = new System.Drawing.Point(134, 572);
            this.cbxGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxGiamGia.Name = "cbxGiamGia";
            this.cbxGiamGia.Size = new System.Drawing.Size(255, 28);
            this.cbxGiamGia.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Giảm giá";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapHang.AutoSize = true;
            this.btnNhapHang.Location = new System.Drawing.Point(154, 626);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(97, 38);
            this.btnNhapHang.TabIndex = 18;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // pbxAnhSp
            // 
            this.pbxAnhSp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxAnhSp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbxAnhSp.Location = new System.Drawing.Point(94, 38);
            this.pbxAnhSp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxAnhSp.Name = "pbxAnhSp";
            this.pbxAnhSp.Size = new System.Drawing.Size(213, 225);
            this.pbxAnhSp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAnhSp.TabIndex = 12;
            this.pbxAnhSp.TabStop = false;
            this.pbxAnhSp.Click += new System.EventHandler(this.PbxAnhSp_Click);
            // 
            // FormDSSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1094, 680);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pnlPage);
            this.Controls.Add(this.tbxTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormDSSanPham";
            this.Text = "FormDSSanPham";
            this.Load += new System.EventHandler(this.FormDSSanPham_Load);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.pnlPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnhSp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DgvSanPham_SortCompare(object sender, System.Windows.Forms.DataGridViewSortCompareEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblPhanLoai;
        private System.Windows.Forms.TextBox tbxGiaTien;
        private System.Windows.Forms.TextBox tbxSoLuong;
        private System.Windows.Forms.TextBox tbxTenSP;
        private System.Windows.Forms.TextBox tbxMaSP;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox tbxTimKiem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pbxAnhSp;
        private System.Windows.Forms.ComboBox cbxPhanLoai;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.Label lblPageview;
        private System.Windows.Forms.Button btnEPg;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Button btnBck;
        private System.Windows.Forms.Button btnDauTrang;
        private System.Windows.Forms.ComboBox cbxGiamGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxGiaNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNhapHang;
    }
}