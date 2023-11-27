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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.cbxPhanLoai = new System.Windows.Forms.ComboBox();
            this.pbxAnhSp = new System.Windows.Forms.PictureBox();
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
            this.cbxTimPL = new System.Windows.Forms.ComboBox();
            this.gbxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnhSp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.pnlPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaSP
            // 
            this.lblMaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(5, 225);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(91, 16);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã sản phẩm:";
            // 
            // gbxInfo
            // 
            this.gbxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gbxInfo.Location = new System.Drawing.Point(621, 0);
            this.gbxInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInfo.Size = new System.Drawing.Size(351, 475);
            this.gbxInfo.TabIndex = 1;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Thông tin sản phẩm";
            // 
            // cbxPhanLoai
            // 
            this.cbxPhanLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPhanLoai.FormattingEnabled = true;
            this.cbxPhanLoai.Location = new System.Drawing.Point(119, 302);
            this.cbxPhanLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPhanLoai.Name = "cbxPhanLoai";
            this.cbxPhanLoai.Size = new System.Drawing.Size(227, 24);
            this.cbxPhanLoai.TabIndex = 13;
            // 
            // pbxAnhSp
            // 
            this.pbxAnhSp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxAnhSp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbxAnhSp.Location = new System.Drawing.Point(84, 30);
            this.pbxAnhSp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxAnhSp.Name = "pbxAnhSp";
            this.pbxAnhSp.Size = new System.Drawing.Size(189, 180);
            this.pbxAnhSp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAnhSp.TabIndex = 12;
            this.pbxAnhSp.TabStop = false;
            this.pbxAnhSp.Click += new System.EventHandler(this.PbxAnhSp_Click);
            // 
            // tbxGiaTien
            // 
            this.tbxGiaTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxGiaTien.Location = new System.Drawing.Point(119, 387);
            this.tbxGiaTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxGiaTien.Name = "tbxGiaTien";
            this.tbxGiaTien.Size = new System.Drawing.Size(227, 22);
            this.tbxGiaTien.TabIndex = 11;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(278, 428);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 26);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSoLuong.Location = new System.Drawing.Point(119, 345);
            this.tbxSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.Size = new System.Drawing.Size(227, 22);
            this.tbxSoLuong.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(29, 428);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(67, 26);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tbxTenSP
            // 
            this.tbxTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTenSP.Location = new System.Drawing.Point(119, 262);
            this.tbxTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTenSP.Name = "tbxTenSP";
            this.tbxTenSP.Size = new System.Drawing.Size(227, 22);
            this.tbxTenSP.TabIndex = 7;
            // 
            // tbxMaSP
            // 
            this.tbxMaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMaSP.Enabled = false;
            this.tbxMaSP.Location = new System.Drawing.Point(119, 225);
            this.tbxMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMaSP.Name = "tbxMaSP";
            this.tbxMaSP.Size = new System.Drawing.Size(227, 22);
            this.tbxMaSP.TabIndex = 6;
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.Location = new System.Drawing.Point(5, 308);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(66, 16);
            this.lblPhanLoai.TabIndex = 4;
            this.lblPhanLoai.Text = "Phân loại:";
            // 
            // lblGia
            // 
            this.lblGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(7, 392);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(55, 16);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "Giá tiền:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(5, 350);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(63, 16);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(2, 267);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(96, 16);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(442, 13);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 26);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSanPham.Location = new System.Drawing.Point(10, 70);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.RowTemplate.Height = 62;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(595, 329);
            this.dgvSanPham.TabIndex = 2;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Location = new System.Drawing.Point(305, 13);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(72, 26);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Location = new System.Drawing.Point(10, 13);
            this.tbxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(270, 22);
            this.tbxTimKiem.TabIndex = 12;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Location = new System.Drawing.Point(535, 13);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 26);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlPage
            // 
            this.pnlPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPage.Controls.Add(this.lblPageview);
            this.pnlPage.Controls.Add(this.btnEPg);
            this.pnlPage.Controls.Add(this.btnFwd);
            this.pnlPage.Controls.Add(this.btnBck);
            this.pnlPage.Controls.Add(this.btnDauTrang);
            this.pnlPage.Location = new System.Drawing.Point(10, 410);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(596, 53);
            this.pnlPage.TabIndex = 14;
            // 
            // lblPageview
            // 
            this.lblPageview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPageview.Location = new System.Drawing.Point(152, 18);
            this.lblPageview.Name = "lblPageview";
            this.lblPageview.Size = new System.Drawing.Size(78, 23);
            this.lblPageview.TabIndex = 4;
            this.lblPageview.Text = " ";
            this.lblPageview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEPg
            // 
            this.btnEPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEPg.Location = new System.Drawing.Point(316, 18);
            this.btnEPg.Name = "btnEPg";
            this.btnEPg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEPg.Size = new System.Drawing.Size(40, 23);
            this.btnEPg.TabIndex = 3;
            this.btnEPg.Text = ">|";
            this.btnEPg.UseVisualStyleBackColor = true;
            this.btnEPg.Click += new System.EventHandler(this.btnEPg_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFwd.Location = new System.Drawing.Point(253, 18);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(40, 23);
            this.btnFwd.TabIndex = 2;
            this.btnFwd.Text = ">>";
            this.btnFwd.UseVisualStyleBackColor = true;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // btnBck
            // 
            this.btnBck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBck.Location = new System.Drawing.Point(89, 18);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(40, 23);
            this.btnBck.TabIndex = 1;
            this.btnBck.Text = "<<";
            this.btnBck.UseVisualStyleBackColor = true;
            this.btnBck.Click += new System.EventHandler(this.btnBck_Click);
            // 
            // btnDauTrang
            // 
            this.btnDauTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDauTrang.Location = new System.Drawing.Point(26, 18);
            this.btnDauTrang.Name = "btnDauTrang";
            this.btnDauTrang.Size = new System.Drawing.Size(40, 23);
            this.btnDauTrang.TabIndex = 0;
            this.btnDauTrang.Text = "|<";
            this.btnDauTrang.UseVisualStyleBackColor = true;
            this.btnDauTrang.Click += new System.EventHandler(this.btnDauTrang_Click);
            // 
            // cbxTimPL
            // 
            this.cbxTimPL.FormattingEnabled = true;
            this.cbxTimPL.Location = new System.Drawing.Point(12, 42);
            this.cbxTimPL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTimPL.Name = "cbxTimPL";
            this.cbxTimPL.Size = new System.Drawing.Size(268, 24);
            this.cbxTimPL.TabIndex = 14;
            // 
            // FormDSSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(972, 475);
            this.Controls.Add(this.cbxTimPL);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnhSp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.pnlPage.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cbxTimPL;
    }
}