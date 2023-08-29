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
        public FormDSHoaDon()
        {
            InitializeComponent();
        }


        private void FormDSHoaDon_Load(object sender, EventArgs e)
        {
            dgvHD.DataSource = HoaDonDAO.Instance.DSHoaDon();
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
    }
}
