﻿using StoreManagement.BUS;
using StoreManagement.DAO;
using StoreManagement.Functions;
using System;
using System.Data;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormDSNhanVien : Form
    {
        FormThemNhanVien them;
        private DataTable dataTable;

        public FormDSNhanVien()
        {
            InitializeComponent();
        }
        private void FormDSNhanVien_Load(object sender, EventArgs e)
        {
            dataTable = NhanVienDAO.Instance.DSNhanVien();
            dgvNhanVien.DataSource = dataTable;
            dgvNhanVien.Columns["Mã nhân viên"].ReadOnly = true;

            PageProcessing.Instance.Load(dataTable, dgvNhanVien, lblPageview);

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dgvNhanVien.Columns[0];
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = new FormThemNhanVien();
            them.ShowDialog();
            FormDSNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvNhanVien.SelectedCells[0].OwningRow.Cells["Mã nhân viên"].Value.ToString();
                if(dgvNhanVien.SelectedCells[0].OwningRow.Cells["Mã nhân viên"].Value.ToString() != "NV1")
                {
                    if (TaiKhoanBUS.Instance.XoaTaiKhoan(id) == true)
                    {
                        if (NhanVienBUS.Instance.XoaNhanVien(id) == true)
                        {
                            MessageBox.Show("Xóa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xoá thông tin không thành công");
                    }
                    FormDSNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không được xóa tài khoản này");
                }
                
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormDSNhanVien_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenNV = tbxTimKiem.Text.ToString();
            if (tenNV == "")
            {
                MessageBox.Show("Nhập mã nhân viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            NhanVienBUS.Instance.TimKiemNhanVienTheoTen(dgvNhanVien, tenNV);
        }

        #region PageProcessing
        private void btnDauTrang_Click(object sender, EventArgs e)
        {
            PageProcessing.Instance.DauTrang(dataTable, dgvNhanVien, lblPageview);
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang tiếp theo không
            PageProcessing.Instance.TrangKeTiep(dataTable, dgvNhanVien, lblPageview);
        }

        private void btnEPg_Click(object sender, EventArgs e)
        {
            PageProcessing.Instance.TrangCuoi(dataTable, dgvNhanVien, lblPageview);
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang trước đó không
            PageProcessing.Instance.TrangKeTruoc(dataTable, dgvNhanVien, lblPageview);
        }

        #endregion
    }
}
