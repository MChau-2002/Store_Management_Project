using StoreManagement.BUS;
using StoreManagement.DAO;
using StoreManagement.DTO;
using StoreManagement.Functions;
using System;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormThemSP : Form
    {
        SanPhamDTO sanPham;
        public FormThemSP()
        {
            InitializeComponent();
        }

        private void FormThemSP_Load(object sender, EventArgs e)
        {
            //Do du lieu cua bang NhaCungCap vao combobox
            cbxPhanLoai.DataSource = PhanLoaiDAO.Instance.DSPhanLoai();
            cbxPhanLoai.DisplayMember = "Tên loại";
            cbxPhanLoai.ValueMember = "Mã loại";
            tbxMaSP.Text = SanPhamBUS.Instance.idGenerate("SP");
        }

        //Lay gia tri tu user
        private void GetValue()
        {
            
            byte[] anh = ImageProcessing.Instance.ImageToArray(pbxAnhSp);
            if (pbxAnhSp.Image == null)
            {
                pbxAnhSp.Image = pbxAnhSp.ErrorImage;
                anh = ImageProcessing.Instance.ImageToArray(pbxAnhSp);
            }
            string maSanPham = tbxMaSP.Text;
            string tenSanPham = tbxTenSP.Text;
            string maLoai = cbxPhanLoai.SelectedValue.ToString();
            int soLuongNhap;
            if (tbxSoLuong.Text.Trim() == "") { soLuongNhap = 0; } else { soLuongNhap = int.Parse(tbxSoLuong.Text); }
            int soLuong = soLuongNhap;
            float giaNhap;
            if (tbxGiaNhap.Text.Trim() == "") { giaNhap = 0; } else { giaNhap = int.Parse(tbxGiaNhap.Text); }
            float giaBan;
            if (tbxGiaBan.Text.Trim() == "") { giaBan = 0; } else { giaBan = int.Parse(tbxGiaBan.Text); }
            //float giamGia = float.Parse(cbxGiamGia.Text);

            sanPham = new SanPhamDTO(anh, maSanPham, tenSanPham, maLoai, soLuong, giaBan, soLuongNhap, giaNhap, 0);
        }

        //Chon anh tu may tinh
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            ImageProcessing.Instance.ChooseImage(pbxAnhSp);
        }

        //Them san pham
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                GetValue();
                if (tbxTenSP.Text.Trim() == "" || tbxSoLuong.Text.Trim() == "" || tbxGiaNhap.Text.Trim() == "" || tbxGiaBan.Text.Trim() == "")
                {
                    MessageBox.Show("Mời nhập đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //them
                if (SanPhamBUS.Instance.ThemSanPham(sanPham) == true)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
                this.Close();
            }
            catch(Exception ex)
            {
                //throw ex;
                MessageBox.Show("Lỗi thêm: " + ex);
            }
        }

    }
}
