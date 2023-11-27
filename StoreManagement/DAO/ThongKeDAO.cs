using StoreManagement.BUS;
using StoreManagement.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace StoreManagement.DAO
{
    class ThongKeDAO
    {
        private static ThongKeDAO instance;
        public static ThongKeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKeDAO();
                return instance;
            }
        }
        public ThongKeDAO() { }

        public DataTable BieuDoDoanhThu()
        {
            string query = "select month(NgayBan) as Thang, sum(TongTien) as DoanhThu from HoaDon group by month(NgayBan)";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int SLSanPham()
        {
            string query = "select * from SanPham";
            int total = DataProvider.Instance.ExecuteQuery(query).Rows.Count;
            return total;
        }

        public int SLPhanLoai()
        {
            string query = "select * from PhanLoai";
            int total = DataProvider.Instance.ExecuteQuery(query).Rows.Count;
            return total;
        }

        public int SLKhachHang()
        {
            string query = "select * from KhachHang";
            int total = DataProvider.Instance.ExecuteQuery(query).Rows.Count;
            return total;
        }
        public int SLHoaDon(string month)
        {
            string query = "select * from HoaDon where month(NgayBan) = @month";
            object[] parameter = { month };
            int total = DataProvider.Instance.ExecuteQuery(query, parameter).Rows.Count;
            return total;
        }
    }
}
