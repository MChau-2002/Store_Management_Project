using StoreManagement.BUS;
using StoreManagement.DAO;
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
    public partial class FormDSHoaDon : Form
    {
        DataTable dataTable;
        public FormDSHoaDon()
        {
            InitializeComponent();
        }


        private void FormDSHoaDon_Load(object sender, EventArgs e)
        {
            dataTable = HoaDonDAO.Instance.DSHoaDon();
            dgvHD.DataSource = dataTable;

            PageProcessing.Instance.Load(dataTable, dgvHD, lblPageview);
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            FormCTHD form = new FormCTHD();
            form.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maHoaDon = tbxTimKiem.Text;
            HoaDonBUS.Instance.TimKiemHD(dgvHD, maHoaDon);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvHD.DataSource = HoaDonDAO.Instance.DSHoaDon();
        }

        private void btnDauTrang_Click(object sender, EventArgs e)
        {
            PageProcessing.Instance.DauTrang(dataTable, dgvHD, lblPageview);
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang tiếp theo không
            PageProcessing.Instance.TrangKeTiep(dataTable, dgvHD, lblPageview);
        }

        private void btnEPg_Click(object sender, EventArgs e)
        {
            PageProcessing.Instance.TrangCuoi(dataTable, dgvHD, lblPageview);
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang trước đó không
            PageProcessing.Instance.TrangKeTruoc(dataTable, dgvHD, lblPageview);
        }
    }
}
