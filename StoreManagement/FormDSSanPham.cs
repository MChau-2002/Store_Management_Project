using StoreManagement.BUS;
using StoreManagement.DAO;
using StoreManagement.DTO;
using StoreManagement.Functions;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace StoreManagement
{
    public partial class FormDSSanPham : Form
    {
        SanPhamDTO sanPham;
        FormThemSP them;
        private DataTable dataTable;
        private int itemsPerPage = 5; // Số mục trên mỗi trang
        private int currentPage = 1;
        private int totalItems;
        private int totalPages;

        public FormDSSanPham()
        {
            InitializeComponent();
        }
        private void FormDSSanPham_Load(object sender, EventArgs e)
        {
            
            //Dgv
            dgvSanPham.DataSource = SanPhamDAO.Instance.DSSanPham();
            dgvSanPham.Columns["Ảnh"].ReadOnly = true;
            dgvSanPham.Columns["Mã sản phẩm"].Visible = false;
            // Sắp xếp tăng dần theo cột "Tên Cột"
            dgvSanPham.Sort(dgvSanPham.Columns["Tên sản phẩm"], ListSortDirection.Ascending);

            dataTable = SanPhamDAO.Instance.DSSanPham();
            totalItems = dgvSanPham.Rows.Count;

            // Tính toán số trang
            totalPages = (int)Math.Ceiling((double)totalItems / itemsPerPage);

            // Hiển thị trang đầu tiên
            DisplayDataOnCurrentPage();

            // Cập nhật thông tin trang
            UpdatePageInfo();

           
            //Dua du lieu tu bang NhaCungCap vao combobox
            cbxPhanLoai.DataSource = PhanLoaiDAO.Instance.DSPhanLoai();
            cbxPhanLoai.DisplayMember = "Tên loại";
            cbxPhanLoai.ValueMember = "Mã loại";

            //Xu ly hien thi hinh anh
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dgvSanPham.Columns[0];
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //GroupBox Info
            gbxInfo.Enabled = false;

            clearInfo();
        }

        
        private void DisplayDataOnCurrentPage()
        {
            // Lấy dữ liệu của trang hiện tại
            int startIndex = (currentPage - 1) * itemsPerPage;
            int endIndex = Math.Min(startIndex + itemsPerPage - 1, totalItems - 1);

            // Tạo một DataTable mới chứa dữ liệu của trang hiện tại
            DataTable currentPageData = dataTable.Clone();
            for (int i = startIndex; i <= endIndex; i++)
            {
                currentPageData.ImportRow(dataTable.Rows[i]);
            }

            // Hiển thị dữ liệu trên DataGridView
            dgvSanPham.DataSource = currentPageData;
        }

        private void UpdatePageInfo()
        {
            // Hiển thị thông tin về trang
            lblPageview.Text = $"{currentPage} / {totalPages}";
        }


        //Input
        public void GetValue()
        {
            byte[] anh = ImageProcessing.Instance.ImageToArray(pbxAnhSp);
            string maSanPham = tbxMaSP.Text;
            string tenSanPham = tbxTenSP.Text;
            string maLoai = cbxPhanLoai.SelectedValue.ToString();
            int soLuong = int.Parse(tbxSoLuong.Text);
            float giaTien = float.Parse(tbxGiaTien.Text);

            sanPham = new SanPhamDTO(anh, maSanPham, tenSanPham, maLoai, soLuong, giaTien);
        }

        //Chon anh tu may tinh
        private void PbxAnhSp_Click(object sender, EventArgs e)
        {
            ImageProcessing.Instance.ChooseImage(pbxAnhSp);
        }

        //Lam moi Datagridview
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormDSSanPham_Load(sender, e);
            clearInfo();
        }

        //Chon san pham
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbxInfo.Enabled = true;
            if (dgvSanPham.SelectedRows[0].Cells["Ảnh"].Value.ToString() != null)
            {
                ImageProcessing.Instance.DgvToPbx(dgvSanPham, pbxAnhSp);
            }
            else
            {
                pbxAnhSp.Image = null;
            }
            tbxMaSP.Text = dgvSanPham.SelectedRows[0].Cells["Mã sản phẩm"].Value.ToString();
            tbxTenSP.Text = dgvSanPham.SelectedRows[0].Cells["Tên sản phẩm"].Value.ToString();
            cbxPhanLoai.Text = dgvSanPham.SelectedRows[0].Cells["Tên loại"].Value.ToString();
            tbxSoLuong.Text = dgvSanPham.SelectedRows[0].Cells["Số lượng"].Value.ToString();
            tbxGiaTien.Text = dgvSanPham.SelectedRows[0].Cells["Giá"].Value.ToString();
        }

        //Xoa thong tin
        private void clearInfo()
        {
            gbxInfo.Enabled = false;
            pbxAnhSp.Image = null;
            tbxMaSP.Text = " ";
            tbxTenSP.Text = " ";
            cbxPhanLoai.Text = " ";
            tbxSoLuong.Text = " ";
            tbxGiaTien.Text = " ";
        }

        //Tim kiem san pham
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SanPhamBUS.Instance.TimKiemSanPham(dgvSanPham, tbxTimKiem.Text);
        }
        
        //Mo form ThemSP
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = new FormThemSP();
            them.ShowDialog();
            FormDSSanPham_Load(sender, e);
        }

        //Sua thong tin san pham
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                GetValue();
                if (SanPhamBUS.Instance.SuaSanPham(sanPham) == true)
                {
                    MessageBox.Show("Sửa thông tin thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thông tin không thành công");
                }
                clearInfo();
                FormDSSanPham_Load(sender, e);
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string MaSanPham = tbxMaSP.Text;
                if (SanPhamBUS.Instance.XoaSanPham(MaSanPham) == true)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
                FormDSSanPham_Load(sender, e);
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Lỗi: " + ex);
            }
        }


        private void btnDauTrang_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            DisplayDataOnCurrentPage();
            UpdatePageInfo();
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang tiếp theo không
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayDataOnCurrentPage();
                UpdatePageInfo();
            }
        }

        private void btnEPg_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            DisplayDataOnCurrentPage();
            UpdatePageInfo();
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang trước đó không
            if (currentPage > 1)
            {
                currentPage--;
                DisplayDataOnCurrentPage();
                UpdatePageInfo();
            }
        }

        /*private void dgvSanPham_CustomSortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
           
           for (int i = 0; i < dgvSanPham.RowCount - 1; i++)
           {
                string[] id = dgvSanPham.Rows[i].Cells["Mã sản phẩm"].Value.ToString().Split('-');
                string[] id2 = dgvSanPham.Rows[i + 1].Cells["Mã sản phẩm"].Value.ToString().Split('-');
                int index = int.Parse(id[1]);
                int index2 = int.Parse(id2[1]);
                e.SortResult = index.CompareTo(index2);
                e.Handled = true;
           }
            dgvSanPham.SortCompare += dgvSanPham_CustomSortCompare;
        }*/
    }
}
