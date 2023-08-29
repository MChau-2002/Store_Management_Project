using StoreManagement.BUS;
using StoreManagement.DAO;
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
    public partial class FormCTHD : Form
    {
        public FormCTHD()
        {
            InitializeComponent();
        }

        private void FormCTHD_Load(object sender, EventArgs e)
        {
            dgvCTHD.DataSource = ChiTietHoaDonDAO.Instance.ChiTietHoaDon();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maCTHD = tbxTimKiem.Text;
            ChiTietHoaDonBUS.Instance.TimKiemCTHD(dgvCTHD, maCTHD);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
