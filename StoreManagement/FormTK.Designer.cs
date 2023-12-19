namespace StoreManagement
{
    partial class FormTK
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTK));
            this.gbxThongKe = new System.Windows.Forms.GroupBox();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.chrtDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbxHoaDon = new System.Windows.Forms.TextBox();
            this.lblSLKH = new System.Windows.Forms.Label();
            this.tbxSLKH = new System.Windows.Forms.TextBox();
            this.lblSLPL = new System.Windows.Forms.Label();
            this.tbxSLPL = new System.Windows.Forms.TextBox();
            this.lblSLSP = new System.Windows.Forms.Label();
            this.tbxSLSP = new System.Windows.Forms.TextBox();
            this.gbxBaoCao = new System.Windows.Forms.GroupBox();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.lblPageview = new System.Windows.Forms.Label();
            this.btnEPg = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.btnBck = new System.Windows.Forms.Button();
            this.btnDauTrang = new System.Windows.Forms.Button();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.cbxLoai = new System.Windows.Forms.ComboBox();
            this.dtpkEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.PPDBaoCao = new System.Windows.Forms.PrintPreviewDialog();
            this.pDDaBan = new System.Drawing.Printing.PrintDocument();
            this.pDDoanhThu = new System.Drawing.Printing.PrintDocument();
            this.gbxThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDoanhThu)).BeginInit();
            this.gbxBaoCao.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            this.pnlPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxThongKe
            // 
            this.gbxThongKe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxThongKe.Controls.Add(this.lblHoaDon);
            this.gbxThongKe.Controls.Add(this.chrtDoanhThu);
            this.gbxThongKe.Controls.Add(this.tbxHoaDon);
            this.gbxThongKe.Controls.Add(this.lblSLKH);
            this.gbxThongKe.Controls.Add(this.tbxSLKH);
            this.gbxThongKe.Controls.Add(this.lblSLPL);
            this.gbxThongKe.Controls.Add(this.tbxSLPL);
            this.gbxThongKe.Controls.Add(this.lblSLSP);
            this.gbxThongKe.Controls.Add(this.tbxSLSP);
            this.gbxThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxThongKe.Location = new System.Drawing.Point(0, 0);
            this.gbxThongKe.Name = "gbxThongKe";
            this.gbxThongKe.Size = new System.Drawing.Size(1094, 349);
            this.gbxThongKe.TabIndex = 2;
            this.gbxThongKe.TabStop = false;
            this.gbxThongKe.Text = "Thống Kê";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Location = new System.Drawing.Point(6, 216);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(175, 20);
            this.lblHoaDon.TabIndex = 32;
            this.lblHoaDon.Text = "Hóa đơn tạo tháng này:";
            // 
            // chrtDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtDoanhThu.Legends.Add(legend1);
            this.chrtDoanhThu.Location = new System.Drawing.Point(460, 12);
            this.chrtDoanhThu.Name = "chrtDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            this.chrtDoanhThu.Series.Add(series1);
            this.chrtDoanhThu.Size = new System.Drawing.Size(622, 306);
            this.chrtDoanhThu.TabIndex = 0;
            this.chrtDoanhThu.Text = "Biểu đồ doanh thu";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "BIỂU ĐỒ DOANH THU";
            this.chrtDoanhThu.Titles.Add(title1);
            // 
            // tbxHoaDon
            // 
            this.tbxHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxHoaDon.Enabled = false;
            this.tbxHoaDon.Location = new System.Drawing.Point(306, 210);
            this.tbxHoaDon.Name = "tbxHoaDon";
            this.tbxHoaDon.ReadOnly = true;
            this.tbxHoaDon.Size = new System.Drawing.Size(92, 26);
            this.tbxHoaDon.TabIndex = 33;
            // 
            // lblSLKH
            // 
            this.lblSLKH.AutoSize = true;
            this.lblSLKH.Location = new System.Drawing.Point(6, 161);
            this.lblSLKH.Name = "lblSLKH";
            this.lblSLKH.Size = new System.Drawing.Size(157, 20);
            this.lblSLKH.TabIndex = 30;
            this.lblSLKH.Text = "Tổng số khách hàng:";
            // 
            // tbxSLKH
            // 
            this.tbxSLKH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxSLKH.Enabled = false;
            this.tbxSLKH.Location = new System.Drawing.Point(306, 155);
            this.tbxSLKH.Name = "tbxSLKH";
            this.tbxSLKH.ReadOnly = true;
            this.tbxSLKH.Size = new System.Drawing.Size(92, 26);
            this.tbxSLKH.TabIndex = 31;
            // 
            // lblSLPL
            // 
            this.lblSLPL.AutoSize = true;
            this.lblSLPL.Location = new System.Drawing.Point(6, 106);
            this.lblSLPL.Name = "lblSLPL";
            this.lblSLPL.Size = new System.Drawing.Size(138, 20);
            this.lblSLPL.TabIndex = 28;
            this.lblSLPL.Text = "Tổng số phân loại:";
            // 
            // tbxSLPL
            // 
            this.tbxSLPL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxSLPL.Enabled = false;
            this.tbxSLPL.Location = new System.Drawing.Point(306, 100);
            this.tbxSLPL.Name = "tbxSLPL";
            this.tbxSLPL.ReadOnly = true;
            this.tbxSLPL.Size = new System.Drawing.Size(92, 26);
            this.tbxSLPL.TabIndex = 29;
            // 
            // lblSLSP
            // 
            this.lblSLSP.AutoSize = true;
            this.lblSLSP.Location = new System.Drawing.Point(6, 54);
            this.lblSLSP.Name = "lblSLSP";
            this.lblSLSP.Size = new System.Drawing.Size(144, 20);
            this.lblSLSP.TabIndex = 26;
            this.lblSLSP.Text = "Tổng số sản phẩm:";
            // 
            // tbxSLSP
            // 
            this.tbxSLSP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxSLSP.Enabled = false;
            this.tbxSLSP.Location = new System.Drawing.Point(306, 48);
            this.tbxSLSP.Name = "tbxSLSP";
            this.tbxSLSP.ReadOnly = true;
            this.tbxSLSP.Size = new System.Drawing.Size(93, 26);
            this.tbxSLSP.TabIndex = 27;
            // 
            // gbxBaoCao
            // 
            this.gbxBaoCao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxBaoCao.Controls.Add(this.pnlPrint);
            this.gbxBaoCao.Controls.Add(this.btnXemChiTiet);
            this.gbxBaoCao.Controls.Add(this.btnBaoCao);
            this.gbxBaoCao.Controls.Add(this.cbxLoai);
            this.gbxBaoCao.Controls.Add(this.dtpkEndDate);
            this.gbxBaoCao.Controls.Add(this.dtpkStartDate);
            this.gbxBaoCao.Controls.Add(this.lblEndDate);
            this.gbxBaoCao.Controls.Add(this.lblStartDate);
            this.gbxBaoCao.Controls.Add(this.lblLoai);
            this.gbxBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxBaoCao.Location = new System.Drawing.Point(0, 349);
            this.gbxBaoCao.Name = "gbxBaoCao";
            this.gbxBaoCao.Size = new System.Drawing.Size(1094, 331);
            this.gbxBaoCao.TabIndex = 3;
            this.gbxBaoCao.TabStop = false;
            this.gbxBaoCao.Text = "Lập báo cáo";
            // 
            // pnlPrint
            // 
            this.pnlPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrint.Controls.Add(this.pnlPage);
            this.pnlPrint.Controls.Add(this.dgvBaoCao);
            this.pnlPrint.Location = new System.Drawing.Point(460, 14);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(622, 305);
            this.pnlPrint.TabIndex = 86;
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
            this.pnlPage.Location = new System.Drawing.Point(66, 235);
            this.pnlPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(532, 66);
            this.pnlPage.TabIndex = 85;
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
            // dgvBaoCao
            // 
            this.dgvBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(66, 11);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersWidth = 62;
            this.dgvBaoCao.RowTemplate.Height = 28;
            this.dgvBaoCao.Size = new System.Drawing.Size(532, 217);
            this.dgvBaoCao.TabIndex = 45;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXemChiTiet.AutoSize = true;
            this.btnXemChiTiet.Location = new System.Drawing.Point(267, 242);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(131, 38);
            this.btnXemChiTiet.TabIndex = 84;
            this.btnXemChiTiet.Text = "Xem";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBaoCao.AutoSize = true;
            this.btnBaoCao.Location = new System.Drawing.Point(39, 242);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(131, 38);
            this.btnBaoCao.TabIndex = 83;
            this.btnBaoCao.Text = "Lập báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // cbxLoai
            // 
            this.cbxLoai.FormattingEnabled = true;
            this.cbxLoai.Items.AddRange(new object[] {
            "Sản phẩm tiêu thụ",
            "Chi tiết doanh thu"});
            this.cbxLoai.Location = new System.Drawing.Point(102, 48);
            this.cbxLoai.Name = "cbxLoai";
            this.cbxLoai.Size = new System.Drawing.Size(270, 28);
            this.cbxLoai.TabIndex = 0;
            // 
            // dtpkEndDate
            // 
            this.dtpkEndDate.Location = new System.Drawing.Point(102, 137);
            this.dtpkEndDate.Name = "dtpkEndDate";
            this.dtpkEndDate.Size = new System.Drawing.Size(270, 26);
            this.dtpkEndDate.TabIndex = 0;
            // 
            // dtpkStartDate
            // 
            this.dtpkStartDate.Location = new System.Drawing.Point(102, 90);
            this.dtpkStartDate.Name = "dtpkStartDate";
            this.dtpkStartDate.Size = new System.Drawing.Size(270, 26);
            this.dtpkStartDate.TabIndex = 0;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(34, 137);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(39, 20);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "Đến";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(34, 90);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(27, 20);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Từ";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(34, 48);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(39, 20);
            this.lblLoai.TabIndex = 0;
            this.lblLoai.Text = "Loại";
            // 
            // PPDBaoCao
            // 
            this.PPDBaoCao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PPDBaoCao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PPDBaoCao.ClientSize = new System.Drawing.Size(400, 300);
            this.PPDBaoCao.Enabled = true;
            this.PPDBaoCao.Icon = ((System.Drawing.Icon)(resources.GetObject("PPDBaoCao.Icon")));
            this.PPDBaoCao.Name = "PPDBaoCao";
            this.PPDBaoCao.Visible = false;
            // 
            // pDDaBan
            // 
            this.pDDaBan.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDDaBan_PrintPage);
            // 
            // pDDoanhThu
            // 
            this.pDDoanhThu.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDDoanhThu_PrintPage);
            // 
            // FormTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 680);
            this.Controls.Add(this.gbxBaoCao);
            this.Controls.Add(this.gbxThongKe);
            this.Name = "FormTK";
            this.Text = "FormTK";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.gbxThongKe.ResumeLayout(false);
            this.gbxThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDoanhThu)).EndInit();
            this.gbxBaoCao.ResumeLayout(false);
            this.gbxBaoCao.PerformLayout();
            this.pnlPrint.ResumeLayout(false);
            this.pnlPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxThongKe;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtDoanhThu;
        private System.Windows.Forms.TextBox tbxHoaDon;
        private System.Windows.Forms.Label lblSLKH;
        private System.Windows.Forms.TextBox tbxSLKH;
        private System.Windows.Forms.Label lblSLPL;
        private System.Windows.Forms.TextBox tbxSLPL;
        private System.Windows.Forms.Label lblSLSP;
        private System.Windows.Forms.TextBox tbxSLSP;
        private System.Windows.Forms.GroupBox gbxBaoCao;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.Label lblPageview;
        private System.Windows.Forms.Button btnEPg;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Button btnBck;
        private System.Windows.Forms.Button btnDauTrang;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.ComboBox cbxLoai;
        private System.Windows.Forms.DateTimePicker dtpkEndDate;
        private System.Windows.Forms.DateTimePicker dtpkStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.PrintPreviewDialog PPDBaoCao;
        private System.Drawing.Printing.PrintDocument pDDaBan;
        private System.Drawing.Printing.PrintDocument pDDoanhThu;
        private System.Windows.Forms.Panel pnlPrint;
    }
}