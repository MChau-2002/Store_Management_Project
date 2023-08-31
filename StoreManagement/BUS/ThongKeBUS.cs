using StoreManagement.DAO;
using StoreManagement.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.BUS
{
    class ThongKeBUS
    {
        private static ThongKeBUS instance;
        public static ThongKeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKeBUS();
                return instance;
            }
        }
        public ThongKeBUS() { }

        public DataTable BieuDoDoanhThu()
        {
            DataTable data = ThongKeDAO.Instance.BieuDoDoanhThu();
            return data;
        }
        public int SLSanPham()
        {
            return ThongKeDAO.Instance.SLSanPham();
        }
        public int SLPhanLoai()
        {
            return ThongKeDAO.Instance.SLPhanLoai();
        }
        public int SLKhachHang()
        {
            return ThongKeDAO.Instance.SLKhachHang();
        }
        public int SLHoaDon()
        {
            string month = DateTime.Now.Month.ToString();
            return ThongKeDAO.Instance.SLHoaDon(month);
        }
    }
}
