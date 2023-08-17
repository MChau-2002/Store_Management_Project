namespace StoreManagement
{
    partial class FormThemSP
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
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.cbxPhanLoai = new System.Windows.Forms.ComboBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.pbxAnhSp = new System.Windows.Forms.PictureBox();
            this.tbxGiaTien = new System.Windows.Forms.TextBox();
            this.tbxSoLuong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbxTenSP = new System.Windows.Forms.TextBox();
            this.tbxMaSP = new System.Windows.Forms.TextBox();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.gbxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnhSp)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.cbxPhanLoai);
            this.gbxInfo.Controls.Add(this.btnChonAnh);
            this.gbxInfo.Controls.Add(this.pbxAnhSp);
            this.gbxInfo.Controls.Add(this.tbxGiaTien);
            this.gbxInfo.Controls.Add(this.tbxSoLuong);
            this.gbxInfo.Controls.Add(this.btnThem);
            this.gbxInfo.Controls.Add(this.tbxTenSP);
            this.gbxInfo.Controls.Add(this.tbxMaSP);
            this.gbxInfo.Controls.Add(this.lblPhanLoai);
            this.gbxInfo.Controls.Add(this.lblGia);
            this.gbxInfo.Controls.Add(this.lblSoLuong);
            this.gbxInfo.Controls.Add(this.lblTenSP);
            this.gbxInfo.Controls.Add(this.lblMaSP);
            this.gbxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxInfo.Location = new System.Drawing.Point(0, 0);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(800, 544);
            this.gbxInfo.TabIndex = 2;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Thông tin sản phẩm";
            // 
            // cbxPhanLoai
            // 
            this.cbxPhanLoai.FormattingEnabled = true;
            this.cbxPhanLoai.Location = new System.Drawing.Point(134, 396);
            this.cbxPhanLoai.Name = "cbxPhanLoai";
            this.cbxPhanLoai.Size = new System.Drawing.Size(660, 28);
            this.cbxPhanLoai.TabIndex = 14;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonAnh.AutoSize = true;
            this.btnChonAnh.Location = new System.Drawing.Point(505, 195);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(88, 30);
            this.btnChonAnh.TabIndex = 13;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // pbxAnhSp
            // 
            this.pbxAnhSp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxAnhSp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbxAnhSp.Location = new System.Drawing.Point(299, 25);
            this.pbxAnhSp.Name = "pbxAnhSp";
            this.pbxAnhSp.Size = new System.Drawing.Size(200, 200);
            this.pbxAnhSp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAnhSp.TabIndex = 12;
            this.pbxAnhSp.TabStop = false;
            // 
            // tbxGiaTien
            // 
            this.tbxGiaTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxGiaTien.Location = new System.Drawing.Point(134, 450);
            this.tbxGiaTien.Name = "tbxGiaTien";
            this.tbxGiaTien.Size = new System.Drawing.Size(660, 26);
            this.tbxGiaTien.TabIndex = 11;
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSoLuong.Location = new System.Drawing.Point(134, 346);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.Size = new System.Drawing.Size(660, 26);
            this.tbxSoLuong.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(364, 502);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbxTenSP
            // 
            this.tbxTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTenSP.Location = new System.Drawing.Point(134, 294);
            this.tbxTenSP.Name = "tbxTenSP";
            this.tbxTenSP.Size = new System.Drawing.Size(660, 26);
            this.tbxTenSP.TabIndex = 7;
            // 
            // tbxMaSP
            // 
            this.tbxMaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMaSP.Location = new System.Drawing.Point(134, 248);
            this.tbxMaSP.Name = "tbxMaSP";
            this.tbxMaSP.ReadOnly = true;
            this.tbxMaSP.Size = new System.Drawing.Size(660, 26);
            this.tbxMaSP.TabIndex = 6;
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.Location = new System.Drawing.Point(6, 404);
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
            this.lblGia.Location = new System.Drawing.Point(8, 456);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(68, 20);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "Giá tiền:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(8, 352);
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
            this.lblTenSP.Location = new System.Drawing.Point(2, 300);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(114, 20);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(6, 248);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(109, 20);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã sản phẩm:";
            // 
            // FormThemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.gbxInfo);
            this.Name = "FormThemSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemSP";
            this.Load += new System.EventHandler(this.FormThemSP_Load);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnhSp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.PictureBox pbxAnhSp;
        private System.Windows.Forms.TextBox tbxGiaTien;
        private System.Windows.Forms.TextBox tbxSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbxTenSP;
        private System.Windows.Forms.TextBox tbxMaSP;
        private System.Windows.Forms.Label lblPhanLoai;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.ComboBox cbxPhanLoai;
    }
}