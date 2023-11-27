namespace StoreManagement
{
    partial class FormLogin
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxMatKhau = new System.Windows.Forms.TextBox();
            this.tbxTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaPL = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.tbxMatKhau);
            this.pnlLogin.Controls.Add(this.tbxTaiKhoan);
            this.pnlLogin.Controls.Add(this.lblTenKH);
            this.pnlLogin.Controls.Add(this.lblMaPL);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(449, 263);
            this.pnlLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Location = new System.Drawing.Point(177, 183);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 26);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxMatKhau
            // 
            this.tbxMatKhau.Location = new System.Drawing.Point(161, 119);
            this.tbxMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMatKhau.Name = "tbxMatKhau";
            this.tbxMatKhau.Size = new System.Drawing.Size(234, 22);
            this.tbxMatKhau.TabIndex = 29;
            // 
            // tbxTaiKhoan
            // 
            this.tbxTaiKhoan.Location = new System.Drawing.Point(161, 82);
            this.tbxTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTaiKhoan.Name = "tbxTaiKhoan";
            this.tbxTaiKhoan.Size = new System.Drawing.Size(234, 22);
            this.tbxTaiKhoan.TabIndex = 28;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(48, 119);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(64, 16);
            this.lblTenKH.TabIndex = 27;
            this.lblTenKH.Text = "Mật khẩu:";
            // 
            // lblMaPL
            // 
            this.lblMaPL.AutoSize = true;
            this.lblMaPL.Location = new System.Drawing.Point(48, 82);
            this.lblMaPL.Name = "lblMaPL";
            this.lblMaPL.Size = new System.Drawing.Size(70, 16);
            this.lblMaPL.TabIndex = 26;
            this.lblMaPL.Text = "Tài khoản:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 263);
            this.Controls.Add(this.pnlLogin);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxMatKhau;
        private System.Windows.Forms.TextBox tbxTaiKhoan;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaPL;
    }
}