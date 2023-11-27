using StoreManagement.BUS;
using StoreManagement.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            if (NhanVienBUS.currentNhanVien != null)
            {
                lblTenNV.Text = NhanVienBUS.currentNhanVien.TenNhanVien.ToString();
            }
            else
            {
                lblTenNV.Text = "N/A";
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

        private void btnDSHoaDon_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormDSHoaDon(), pnlForm);
            lblTittle.Text = "Danh Sách Hóa Đơn";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormThongKe(), pnlForm);
            lblTittle.Text = "Thống Kê";
        }

        private void lblTenNV_Click(object sender, EventArgs e)
        {

        }

    }
}
