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
        public FormThemSP()
        {
            InitializeComponent();
        }

        SanPhamDTO sanPham;
        private void FormThemSP_Load(object sender, EventArgs e)
        {
            //Do du lieu cua bang NhaCungCap vao combobox
            cbxPhanLoai.DataSource = PhanLoaiDAO.Instance.DSPhanLoai();
            cbxPhanLoai.DisplayMember = "Tên loại";
            cbxPhanLoai.ValueMember = "Mã loại";
            tbxMaSP.Text = SanPhamBUS.Instance.idGenerate("SP");
        }

        //Lay gia tri tu user
        public void GetValue()
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
            int soLuong = int.Parse(tbxSoLuong.Text);
            float giaTien = float.Parse(tbxGiaTien.Text);

            sanPham = new SanPhamDTO(anh, maSanPham, tenSanPham, maLoai, soLuong, giaTien);
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
                if(SanPhamBUS.Instance.ThemSanPham(sanPham) == true)
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
