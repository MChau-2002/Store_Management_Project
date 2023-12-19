using StoreManagement.BUS;
using System;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private const string defaultUsernameText = " Username";
        private const string defaultPasswordText = " Password";

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (TaiKhoanBUS.Instance.CheckAccExist() == false)
            {
                btnDangKy.Visible = true;
                btnDangKy.Enabled = true;
                btnDangNhap.Enabled = false;
            }
            else
            {
                btnDangKy.Visible = false;
                btnDangKy.Enabled = false;
                btnDangNhap.Enabled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxTaiKhoan.Text == defaultUsernameText || tbxMatKhau.Text == defaultPasswordText)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbxTaiKhoan.Text.Trim() == "" || tbxMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Thông tin đăng nhập không thể bỏ trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbxTaiKhoan.Text[0] == ' ' || tbxMatKhau.Text[0] == ' ')
            {
                MessageBox.Show("Thông tin đăng nhập không thể bắt đầu bằng phím cách (space key)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (TaiKhoanBUS.Instance.LoginMethod(tbxTaiKhoan.Text, tbxMatKhau.Text) == true)
                {
                    FormHome home = new FormHome();
                    NhanVienBUS.Instance.SetCurrentNhanVien(tbxTaiKhoan.Text);
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp signUp = new FormSignUp();
            signUp.ShowDialog();
            btnDangKy.Enabled = false;
            btnDangNhap.Enabled = true;
            this.Show();
        }
        
        private void btnXemMK_Click(object sender, EventArgs e)
        {
            if (tbxMatKhau.PasswordChar == '*')
            {
                tbxMatKhau.PasswordChar = '\0';
            }
            else
            {
                tbxMatKhau.PasswordChar = '*';
            }
        }
    }
}
