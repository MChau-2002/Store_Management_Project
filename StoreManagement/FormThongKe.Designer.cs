namespace StoreManagement
{
    partial class FormThongKe
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
            this.chrtDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxThongKe = new System.Windows.Forms.GroupBox();
            this.lblSLKH = new System.Windows.Forms.Label();
            this.tbxSLKH = new System.Windows.Forms.TextBox();
            this.lblSLPL = new System.Windows.Forms.Label();
            this.tbxSLPL = new System.Windows.Forms.TextBox();
            this.lblSLSP = new System.Windows.Forms.Label();
            this.tbxSLSP = new System.Windows.Forms.TextBox();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.tbxHoaDon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDoanhThu)).BeginInit();
            this.gbxThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // chrtDoanhThu
            // 
            this.chrtDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chrtDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtDoanhThu.Legends.Add(legend1);
            this.chrtDoanhThu.Location = new System.Drawing.Point(422, 0);
            this.chrtDoanhThu.Name = "chrtDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            this.chrtDoanhThu.Series.Add(series1);
            this.chrtDoanhThu.Size = new System.Drawing.Size(671, 594);
            this.chrtDoanhThu.TabIndex = 0;
            this.chrtDoanhThu.Text = "Biểu đồ doanh thu";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "BIỂU ĐỒ DOANH THU";
            this.chrtDoanhThu.Titles.Add(title1);
            // 
            // gbxThongKe
            // 
            this.gbxThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxThongKe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxThongKe.Controls.Add(this.lblHoaDon);
            this.gbxThongKe.Controls.Add(this.tbxHoaDon);
            this.gbxThongKe.Controls.Add(this.lblSLKH);
            this.gbxThongKe.Controls.Add(this.tbxSLKH);
            this.gbxThongKe.Controls.Add(this.lblSLPL);
            this.gbxThongKe.Controls.Add(this.tbxSLPL);
            this.gbxThongKe.Controls.Add(this.lblSLSP);
            this.gbxThongKe.Controls.Add(this.tbxSLSP);
            this.gbxThongKe.Location = new System.Drawing.Point(12, 0);
            this.gbxThongKe.Name = "gbxThongKe";
            this.gbxThongKe.Size = new System.Drawing.Size(404, 594);
            this.gbxThongKe.TabIndex = 1;
            this.gbxThongKe.TabStop = false;
            this.gbxThongKe.Text = "Thống Kê";
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
            this.tbxSLKH.Location = new System.Drawing.Point(185, 155);
            this.tbxSLKH.Name = "tbxSLKH";
            this.tbxSLKH.ReadOnly = true;
            this.tbxSLKH.Size = new System.Drawing.Size(213, 26);
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
            this.tbxSLPL.Location = new System.Drawing.Point(185, 100);
            this.tbxSLPL.Name = "tbxSLPL";
            this.tbxSLPL.ReadOnly = true;
            this.tbxSLPL.Size = new System.Drawing.Size(213, 26);
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
            this.tbxSLSP.Location = new System.Drawing.Point(185, 48);
            this.tbxSLSP.Name = "tbxSLSP";
            this.tbxSLSP.ReadOnly = true;
            this.tbxSLSP.Size = new System.Drawing.Size(213, 26);
            this.tbxSLSP.TabIndex = 27;
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
            // tbxHoaDon
            // 
            this.tbxHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxHoaDon.Enabled = false;
            this.tbxHoaDon.Location = new System.Drawing.Point(185, 210);
            this.tbxHoaDon.Name = "tbxHoaDon";
            this.tbxHoaDon.ReadOnly = true;
            this.tbxHoaDon.Size = new System.Drawing.Size(213, 26);
            this.tbxHoaDon.TabIndex = 33;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 594);
            this.Controls.Add(this.gbxThongKe);
            this.Controls.Add(this.chrtDoanhThu);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtDoanhThu)).EndInit();
            this.gbxThongKe.ResumeLayout(false);
            this.gbxThongKe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtDoanhThu;
        private System.Windows.Forms.GroupBox gbxThongKe;
        private System.Windows.Forms.Label lblSLSP;
        private System.Windows.Forms.TextBox tbxSLSP;
        private System.Windows.Forms.Label lblSLKH;
        private System.Windows.Forms.TextBox tbxSLKH;
        private System.Windows.Forms.Label lblSLPL;
        private System.Windows.Forms.TextBox tbxSLPL;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.TextBox tbxHoaDon;
    }
}