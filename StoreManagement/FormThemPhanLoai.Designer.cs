namespace StoreManagement
{
    partial class FormThemPhanLoai
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
            this.tbxPL = new System.Windows.Forms.TextBox();
            this.tbxMaPL = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaPL = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPL
            // 
            this.tbxPL.Location = new System.Drawing.Point(140, 63);
            this.tbxPL.Name = "tbxPL";
            this.tbxPL.Size = new System.Drawing.Size(485, 26);
            this.tbxPL.TabIndex = 24;
            // 
            // tbxMaPL
            // 
            this.tbxMaPL.Location = new System.Drawing.Point(140, 17);
            this.tbxMaPL.Name = "tbxMaPL";
            this.tbxMaPL.ReadOnly = true;
            this.tbxMaPL.Size = new System.Drawing.Size(485, 26);
            this.tbxMaPL.TabIndex = 23;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(8, 69);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(78, 20);
            this.lblTenKH.TabIndex = 22;
            this.lblTenKH.Text = "Phân loại:";
            // 
            // lblMaPL
            // 
            this.lblMaPL.AutoSize = true;
            this.lblMaPL.Location = new System.Drawing.Point(12, 17);
            this.lblMaPL.Name = "lblMaPL";
            this.lblMaPL.Size = new System.Drawing.Size(103, 20);
            this.lblMaPL.TabIndex = 21;
            this.lblMaPL.Text = "Mã phân loại:";
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(288, 126);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormThemPhanLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 191);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbxPL);
            this.Controls.Add(this.tbxMaPL);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblMaPL);
            this.Name = "FormThemPhanLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemPhanLoai";
            this.Load += new System.EventHandler(this.FormThemPhanLoai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPL;
        private System.Windows.Forms.TextBox tbxMaPL;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaPL;
        private System.Windows.Forms.Button btnThem;
    }
}