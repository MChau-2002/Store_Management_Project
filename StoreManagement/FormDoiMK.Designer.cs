namespace StoreManagement
{
    partial class FormDoiMK
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
            this.pnlDoiMK = new System.Windows.Forms.Panel();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.tbxXacNhan = new System.Windows.Forms.TextBox();
            this.lblXacNhanPass = new System.Windows.Forms.Label();
            this.tbxPassMoi = new System.Windows.Forms.TextBox();
            this.tbxPassCu = new System.Windows.Forms.TextBox();
            this.lblPassMoi = new System.Windows.Forms.Label();
            this.lblPassCu = new System.Windows.Forms.Label();
            this.btnXemMK = new System.Windows.Forms.Button();
            this.pnlDoiMK.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDoiMK
            // 
            this.pnlDoiMK.Controls.Add(this.btnXemMK);
            this.pnlDoiMK.Controls.Add(this.btnDoiMatKhau);
            this.pnlDoiMK.Controls.Add(this.tbxXacNhan);
            this.pnlDoiMK.Controls.Add(this.lblXacNhanPass);
            this.pnlDoiMK.Controls.Add(this.tbxPassMoi);
            this.pnlDoiMK.Controls.Add(this.tbxPassCu);
            this.pnlDoiMK.Controls.Add(this.lblPassMoi);
            this.pnlDoiMK.Controls.Add(this.lblPassCu);
            this.pnlDoiMK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoiMK.Location = new System.Drawing.Point(0, 0);
            this.pnlDoiMK.Name = "pnlDoiMK";
            this.pnlDoiMK.Size = new System.Drawing.Size(658, 306);
            this.pnlDoiMK.TabIndex = 0;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDoiMatKhau.AutoSize = true;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(262, 233);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(131, 38);
            this.btnDoiMatKhau.TabIndex = 82;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // tbxXacNhan
            // 
            this.tbxXacNhan.Location = new System.Drawing.Point(200, 175);
            this.tbxXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxXacNhan.Name = "tbxXacNhan";
            this.tbxXacNhan.PasswordChar = '*';
            this.tbxXacNhan.Size = new System.Drawing.Size(384, 26);
            this.tbxXacNhan.TabIndex = 78;
            // 
            // lblXacNhanPass
            // 
            this.lblXacNhanPass.AutoSize = true;
            this.lblXacNhanPass.Location = new System.Drawing.Point(44, 178);
            this.lblXacNhanPass.Name = "lblXacNhanPass";
            this.lblXacNhanPass.Size = new System.Drawing.Size(151, 20);
            this.lblXacNhanPass.TabIndex = 77;
            this.lblXacNhanPass.Text = "Xác nhận mật khẩu:";
            // 
            // tbxPassMoi
            // 
            this.tbxPassMoi.Location = new System.Drawing.Point(200, 118);
            this.tbxPassMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassMoi.Name = "tbxPassMoi";
            this.tbxPassMoi.PasswordChar = '*';
            this.tbxPassMoi.Size = new System.Drawing.Size(384, 26);
            this.tbxPassMoi.TabIndex = 76;
            // 
            // tbxPassCu
            // 
            this.tbxPassCu.Location = new System.Drawing.Point(200, 61);
            this.tbxPassCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassCu.Name = "tbxPassCu";
            this.tbxPassCu.PasswordChar = '*';
            this.tbxPassCu.Size = new System.Drawing.Size(384, 26);
            this.tbxPassCu.TabIndex = 75;
            // 
            // lblPassMoi
            // 
            this.lblPassMoi.AutoSize = true;
            this.lblPassMoi.Location = new System.Drawing.Point(44, 121);
            this.lblPassMoi.Name = "lblPassMoi";
            this.lblPassMoi.Size = new System.Drawing.Size(108, 20);
            this.lblPassMoi.TabIndex = 74;
            this.lblPassMoi.Text = "Mật khẩu mới:";
            // 
            // lblPassCu
            // 
            this.lblPassCu.AutoSize = true;
            this.lblPassCu.Location = new System.Drawing.Point(44, 64);
            this.lblPassCu.Name = "lblPassCu";
            this.lblPassCu.Size = new System.Drawing.Size(100, 20);
            this.lblPassCu.TabIndex = 73;
            this.lblPassCu.Text = "Mật khẩu cũ:";
            // 
            // btnXemMK
            // 
            this.btnXemMK.AutoSize = true;
            this.btnXemMK.Location = new System.Drawing.Point(462, 233);
            this.btnXemMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemMK.Name = "btnXemMK";
            this.btnXemMK.Size = new System.Drawing.Size(122, 38);
            this.btnXemMK.TabIndex = 3;
            this.btnXemMK.Text = "Xem mật khẩu";
            this.btnXemMK.UseVisualStyleBackColor = true;
            this.btnXemMK.Click += new System.EventHandler(this.btnXemMK_Click);
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 306);
            this.Controls.Add(this.pnlDoiMK);
            this.Name = "FormDoiMK";
            this.Text = "FormDoiMK";
            this.pnlDoiMK.ResumeLayout(false);
            this.pnlDoiMK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDoiMK;
        private System.Windows.Forms.TextBox tbxPassMoi;
        private System.Windows.Forms.TextBox tbxPassCu;
        private System.Windows.Forms.Label lblPassMoi;
        private System.Windows.Forms.Label lblPassCu;
        private System.Windows.Forms.TextBox tbxXacNhan;
        private System.Windows.Forms.Label lblXacNhanPass;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnXemMK;
    }
}