using StoreManagement.BUS;
using StoreManagement.Functions;
using System;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormThongTinNhanVien : Form
    {
        public FormThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void FormThongTinNhanVien_Load(object sender, EventArgs e)
        {
            tbxTenNV.Enabled = false;
            tbxTenNV.ReadOnly = true;
            tbxSdt.Enabled = false;
            tbxSdt.ReadOnly = true;
            btnSua.Visible = true;
            btnChonAnh.Visible = false;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            btnDoiMatKhau.Visible = false;

            NhanVienBUS.Instance.GetCurrentNhanVien(pbxAnhNV, tbxMaNV, tbxTaiKhoan, tbxTenNV, tbxSdt, tbxVaiTro);

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            ImageProcessing.Instance.ChooseImage(pbxAnhNV);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FormDoiMK formDoiMK = new FormDoiMK();
            formDoiMK.ShowDialog();
            FormThongTinNhanVien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tbxTenNV.Enabled = true;
            tbxTenNV.ReadOnly = false;
            tbxSdt.Enabled = true;
            tbxSdt.ReadOnly = false;
            btnSua.Visible = false;
            btnChonAnh.Visible = true;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            btnDoiMatKhau.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVienBUS.Instance.SuaCurrentNhanVien(ImageProcessing.Instance.ImageToArray(pbxAnhNV), tbxMaNV.Text, tbxTenNV.Text, tbxSdt.Text);
            NhanVienBUS.Instance.SetCurrentNhanVien(tbxTaiKhoan.Text);
            btnSua.Visible = true;
            btnHuy_Click(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FormThongTinNhanVien_Load(sender, e);
        }
    }
}
