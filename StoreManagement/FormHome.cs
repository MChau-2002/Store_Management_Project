using StoreManagement.BUS;
using StoreManagement.Functions;
using System;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormHome : Form
    {
        bool sidebarExpand = false;
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            if (NhanVienBUS.currentNhanVien != null)
            {
                btnTenNV.Text = "Chào, " + NhanVienBUS.currentNhanVien.TenNhanVien.ToString();
            }
            else
            {
                btnTenNV.Text = "Chào, N/A";
            }
            if (NhanVienBUS.currentNhanVien?.VaiTro == "Nhân viên")
            {
                btnThongKe.Visible = false;
                btnThongKe.Enabled = false;
                btnSanPham.Visible = false;
                btnSanPham.Enabled = false;
                btnPhanloai.Visible = false;
                btnPhanloai.Enabled = false;
                btnNhanVien.Visible = false;
                btnNhanVien.Enabled = false;
                btnDSHoaDon.Visible = false;
                btnDSHoaDon.Enabled = false;
                btnKhachHang.Visible = false;
                btnKhachHang.Enabled = false;
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormDSSanPham(), pnlForm);
            lblTittle.Text = "Danh Sách Sản Phẩm";
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormDSKhachHang(), pnlForm);
            lblTittle.Text = "Danh Sách Khách Hàng";
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormDSPhanLoai(), pnlForm);
            lblTittle.Text = "Danh Sách Phân Loại";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormTTHD(), pnlForm);
            lblTittle.Text = "Thanh Toán Hóa Đơn";
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormDSNhanVien(), pnlForm);
            lblTittle.Text = "Danh Sách Nhân Viên";
        }

        private void btnDSHoaDon_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormDSHoaDon(), pnlForm);
            lblTittle.Text = "Danh Sách Hóa Đơn";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormTK(), pnlForm);
            lblTittle.Text = "Thống Kê";
        }

        private void timeSlide_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlTaiKhoan.Height -= 10;
                if (pnlTaiKhoan.Height == pnlTaiKhoan.MinimumSize.Height)
                {
                    sidebarExpand = false;
                    timeSlide.Stop();
                }
            }
            else
            {
                pnlTaiKhoan.Height += 10;
                if (pnlTaiKhoan.Height == pnlTaiKhoan.MaximumSize.Height)
                {
                    sidebarExpand = true;
                    timeSlide.Stop();
                }
            }
        }

        private void btnTenNV_Click(object sender, EventArgs e)
        {
            timeSlide.Start();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FormThongTinNhanVien nhanVien = new FormThongTinNhanVien();
            nhanVien.ShowDialog();
            FormHome_Load(sender, e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,
                        "Bạn chắc chắn đăng xuất không?",
                        "Closing Form",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
