using StoreManagement.BUS;
using StoreManagement.DTO;
using StoreManagement.Functions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormSignUp : Form
    {
        NhanVienDTO nhanVien;
        TaiKhoanDTO taiKhoanmoi;
        public List<string> vaiTro = new List<string> { "Admin", "Nhân viên" };
        public FormSignUp()
        {
            InitializeComponent();
        }
        public void GetValue()
        {
            byte[] anhNV = ImageProcessing.Instance.ImageToArray(pbxAnhNV);
            if (pbxAnhNV.Image == null)
            {
                pbxAnhNV.Image = pbxAnhNV.ErrorImage;
                anhNV = ImageProcessing.Instance.ImageToArray(pbxAnhNV);
            }
            string maNhanVien = tbxMaNV.Text;
            string tenNhanVien = tbxTenNV.Text;
            string sdt = tbxSdt.Text;
            string taiKhoan = tbxTaiKhoan.Text;
            string matKhau = tbxMatKhau.Text;
            string vaiTro = cbxVaiTro.Text;

            nhanVien = new NhanVienDTO(anhNV, maNhanVien, tenNhanVien, sdt);
            taiKhoanmoi = new TaiKhoanDTO(taiKhoan, maNhanVien, matKhau, vaiTro);
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            cbxVaiTro.DataSource = vaiTro.ToArray();
            tbxMaNV.Text = NhanVienBUS.Instance.idGenerate("NV");
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            ImageProcessing.Instance.ChooseImage(pbxAnhNV);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                GetValue();
                if (NhanVienBUS.Instance.ThemNhanVien(nhanVien) == true)
                {
                    if (TaiKhoanBUS.Instance.ThemTaiKhoan(taiKhoanmoi) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Lỗi thêm: " + ex);
            }
        }
    }
}
