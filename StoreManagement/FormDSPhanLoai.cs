using StoreManagement.BUS;
using StoreManagement.DAO;
using StoreManagement.DTO;
using StoreManagement.Functions;
using System;
using System.Data;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormDSPhanLoai : Form
    {
        PhanLoaiDTO phanLoai;
        private DataTable dataTable;
        public FormDSPhanLoai()
        {
            InitializeComponent();
        }

        private void FormDSPhanLoai_Load(object sender, EventArgs e)
        {
            dataTable = PhanLoaiDAO.Instance.DSPhanLoai();
            dgvPhanLoai.DataSource = dataTable;

            PageProcessing.Instance.Load(dataTable, dgvPhanLoai, lblPageview);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenLoai = tbxTimKiem.Text;
            PhanLoaiBUS.Instance.TimKiemLoai(dgvPhanLoai, tenLoai);
        }

        private void GetValue()
        {
            string MaLoai = dgvPhanLoai.SelectedCells[0].OwningRow.Cells["Mã loại"].Value.ToString();
            string TenLoai = dgvPhanLoai.SelectedCells[0].OwningRow.Cells["Tên loại"].Value.ToString();

            phanLoai = new PhanLoaiDTO(MaLoai, TenLoai);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemPhanLoai them = new FormThemPhanLoai();
            them.ShowDialog();
            FormDSPhanLoai_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvPhanLoai.SelectedCells[0].OwningRow.Cells["Mã loại"].Value.ToString();
                if (CheckExistence() == true && PhanLoaiBUS.Instance.XoaLoai(id) == true)
                {
                    MessageBox.Show("Xoá thông tin thành công");
                }
                else
                {
                    MessageBox.Show("Xoá thông tin không thành công");
                }
                FormDSPhanLoai_Load(sender, e);
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                GetValue();
                if (PhanLoaiBUS.Instance.SuaLoai(phanLoai) == true)
                {
                    MessageBox.Show("Sửa thông tin thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thông tin không thành công");
                }
                FormDSPhanLoai_Load(sender, e);
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormDSPhanLoai_Load(sender, e);
        }

        private bool CheckExistence()
        {
            bool result;
            string id = dgvPhanLoai.SelectedCells[0].OwningRow.Cells["Mã loại"].Value.ToString();
            if (PhanLoaiBUS.Instance.CheckExistence(id) == true)
            {
                MessageBox.Show("Không xóa được do đang có sản phẩm thuộc phân loại này");
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        #region PageProcessing
        private void btnDauTrang_Click(object sender, EventArgs e)
        {
            PageProcessing.Instance.DauTrang(dataTable, dgvPhanLoai, lblPageview);
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang tiếp theo không
            PageProcessing.Instance.TrangKeTiep(dataTable, dgvPhanLoai, lblPageview);
        }

        private void btnEPg_Click(object sender, EventArgs e)
        {
            PageProcessing.Instance.TrangCuoi(dataTable, dgvPhanLoai, lblPageview);
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang trước đó không
            PageProcessing.Instance.TrangKeTruoc(dataTable, dgvPhanLoai, lblPageview);
        }

#endregion
    }
}
