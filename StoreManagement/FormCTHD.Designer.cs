namespace StoreManagement
{
    partial class FormCTHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCTHD));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbxTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            this.pDHoaDon = new System.Drawing.Printing.PrintDocument();
            this.pPDHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.lblPageview = new System.Windows.Forms.Label();
            this.btnEPg = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.btnBck = new System.Windows.Forms.Button();
            this.btnDauTrang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.pnlPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Location = new System.Drawing.Point(1002, 16);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 32);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Location = new System.Drawing.Point(12, 18);
            this.tbxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(427, 26);
            this.tbxTimKiem.TabIndex = 38;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Location = new System.Drawing.Point(462, 16);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(81, 32);
            this.btnTimKiem.TabIndex = 37;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.AutoSize = true;
            this.btnReturn.Location = new System.Drawing.Point(831, 16);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(79, 32);
            this.btnReturn.TabIndex = 36;
            this.btnReturn.Text = "Trở lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(13, 52);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 62;
            this.dgvCTHD.RowTemplate.Height = 28;
            this.dgvCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHD.Size = new System.Drawing.Size(1069, 471);
            this.dgvCTHD.TabIndex = 35;
            this.dgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellContentClick);
            // 
            // btnXem
            // 
            this.btnXem.AutoSize = true;
            this.btnXem.Location = new System.Drawing.Point(558, 13);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(105, 32);
            this.btnXem.TabIndex = 40;
            this.btnXem.Text = "Xem biên lai";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.BtnXem_Click);
            // 
            // pDHoaDon
            // 
            this.pDHoaDon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PDHoaDon_PrintPage);
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
            // pnlPage
            // 
            this.pnlPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlPage.Controls.Add(this.lblPageview);
            this.pnlPage.Controls.Add(this.btnEPg);
            this.pnlPage.Controls.Add(this.btnFwd);
            this.pnlPage.Controls.Add(this.btnBck);
            this.pnlPage.Controls.Add(this.btnDauTrang);
            this.pnlPage.Location = new System.Drawing.Point(272, 524);
            this.pnlPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(568, 66);
            this.pnlPage.TabIndex = 41;
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
            // FormCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 594);
            this.Controls.Add(this.pnlPage);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbxTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvCTHD);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCTHD";
            this.Load += new System.EventHandler(this.FormCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.pnlPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbxTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Button btnXem;
        private System.Drawing.Printing.PrintDocument pDHoaDon;
        private System.Windows.Forms.PrintPreviewDialog pPDHoaDon;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.Label lblPageview;
        private System.Windows.Forms.Button btnEPg;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Button btnBck;
        private System.Windows.Forms.Button btnDauTrang;
    }
}