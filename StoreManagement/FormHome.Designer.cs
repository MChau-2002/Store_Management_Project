namespace StoreManagement
{
    partial class FormHome
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
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnDSHoaDon = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnPhanloai = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.pnlTittle = new System.Windows.Forms.Panel();
            this.lblTittle = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlButton.SuspendLayout();
            this.pnlTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlButton.Controls.Add(this.btnThanhToan);
            this.pnlButton.Controls.Add(this.btnKhachHang);
            this.pnlButton.Controls.Add(this.btnDSHoaDon);
            this.pnlButton.Controls.Add(this.btnThongKe);
            this.pnlButton.Controls.Add(this.btnPhanloai);
            this.pnlButton.Controls.Add(this.pbxLogo);
            this.pnlButton.Controls.Add(this.btnSanPham);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButton.Location = new System.Drawing.Point(0, 0);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(178, 555);
            this.pnlButton.TabIndex = 0;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThanhToan.Location = new System.Drawing.Point(0, 152);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(178, 40);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 272);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(178, 40);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnDSHoaDon
            // 
            this.btnDSHoaDon.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDSHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDSHoaDon.Location = new System.Drawing.Point(0, 312);
            this.btnDSHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDSHoaDon.Name = "btnDSHoaDon";
            this.btnDSHoaDon.Size = new System.Drawing.Size(178, 40);
            this.btnDSHoaDon.TabIndex = 5;
            this.btnDSHoaDon.Text = "Hóa Đơn";
            this.btnDSHoaDon.UseVisualStyleBackColor = false;
            this.btnDSHoaDon.Click += new System.EventHandler(this.btnDSHoaDon_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKe.Location = new System.Drawing.Point(0, 352);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(178, 40);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnPhanloai
            // 
            this.btnPhanloai.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPhanloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanloai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPhanloai.Location = new System.Drawing.Point(0, 232);
            this.btnPhanloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhanloai.Name = "btnPhanloai";
            this.btnPhanloai.Size = new System.Drawing.Size(178, 40);
            this.btnPhanloai.TabIndex = 2;
            this.btnPhanloai.Text = "Phân Loại";
            this.btnPhanloai.UseVisualStyleBackColor = false;
            this.btnPhanloai.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSanPham.Location = new System.Drawing.Point(0, 192);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(178, 40);
            this.btnSanPham.TabIndex = 0;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // pnlTittle
            // 
            this.pnlTittle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlTittle.Controls.Add(this.lblTenNV);
            this.pnlTittle.Controls.Add(this.lbl);
            this.pnlTittle.Controls.Add(this.lblTittle);
            this.pnlTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTittle.Location = new System.Drawing.Point(178, 0);
            this.pnlTittle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTittle.Name = "pnlTittle";
            this.pnlTittle.Size = new System.Drawing.Size(971, 80);
            this.pnlTittle.TabIndex = 1;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTittle.Location = new System.Drawing.Point(5, 18);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(112, 39);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Home";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(178, 80);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(971, 475);
            this.pnlForm.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl.Location = new System.Drawing.Point(741, 33);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(79, 20);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Xin chào:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTenNV.Location = new System.Drawing.Point(826, 33);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(65, 20);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = " TenNV";
            this.lblTenNV.Click += new System.EventHandler(this.lblTenNV_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::StoreManagement.Properties.Resources.OIP_removebg_preview;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(178, 147);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 555);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlTittle);
            this.Controls.Add(this.pnlButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlTittle.ResumeLayout(false);
            this.pnlTittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlTittle;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Button btnPhanloai;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDSHoaDon;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lbl;
    }
}

