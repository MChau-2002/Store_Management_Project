using StoreManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.BUS
{
    class ChiTietHoaDonBUS
    {
        private static ChiTietHoaDonBUS instance;

        public static ChiTietHoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietHoaDonBUS();
                return instance;
            }
        }

        public void TimKiemCTHD(DataGridView Dgv, string id)
        {
            Dgv.DataSource = ChiTietHoaDonDAO.Instance.TimKiemCTHD(id);
        }
    }
}
