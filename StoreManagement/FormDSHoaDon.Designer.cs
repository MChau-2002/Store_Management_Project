namespace StoreManagement
{
    partial class FormDSHoaDon
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbxTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCTHD = new System.Windows.Forms.Button();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.pnlHoaDon = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.pnlHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Location = new System.Drawing.Point(1002, 540);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 30);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTimKiem.Location = new System.Drawing.Point(12, 540);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(451, 26);
            this.tbxTimKiem.TabIndex = 33;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Location = new System.Drawing.Point(482, 540);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(81, 30);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnCTHD
            // 
            this.btnCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCTHD.AutoSize = true;
            this.btnCTHD.Location = new System.Drawing.Point(804, 540);
            this.btnCTHD.Name = "btnCTHD";
            this.btnCTHD.Size = new System.Drawing.Size(164, 30);
            this.btnCTHD.TabIndex = 31;
            this.btnCTHD.Text = "Xem chi tiết hóa đơn";
            this.btnCTHD.UseVisualStyleBackColor = true;
            this.btnCTHD.Click += new System.EventHandler(this.btnCTHD_Click);
            // 
            // dgvHD
            // 
            this.dgvHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(12, 12);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowHeadersWidth = 62;
            this.dgvHD.RowTemplate.Height = 28;
            this.dgvHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHD.Size = new System.Drawing.Size(1069, 505);
            this.dgvHD.TabIndex = 30;
            // 
            // pnlHoaDon
            // 
            this.pnlHoaDon.Controls.Add(this.tbxTimKiem);
            this.pnlHoaDon.Controls.Add(this.dgvHD);
            this.pnlHoaDon.Controls.Add(this.btnRefresh);
            this.pnlHoaDon.Controls.Add(this.btnTimKiem);
            this.pnlHoaDon.Controls.Add(this.btnCTHD);
            this.pnlHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHoaDon.Location = new System.Drawing.Point(0, 0);
            this.pnlHoaDon.Name = "pnlHoaDon";
            this.pnlHoaDon.Size = new System.Drawing.Size(1093, 594);
            this.pnlHoaDon.TabIndex = 35;
            // 
            // FormDSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 594);
            this.Controls.Add(this.pnlHoaDon);
            this.Name = "FormDSHoaDon";
            this.Text = "FormDSHoaDon";
            this.Load += new System.EventHandler(this.FormDSHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.pnlHoaDon.ResumeLayout(false);
            this.pnlHoaDon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbxTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCTHD;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.Panel pnlHoaDon;
    }
}