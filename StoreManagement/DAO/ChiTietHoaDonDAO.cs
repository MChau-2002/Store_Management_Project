using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using StoreManagement.Functions;

namespace StoreManagement.DAO
{
    class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        public static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietHoaDonDAO();
                return instance;
            }
        }

        public DataTable ChiTietHoaDon() 
        {
            string query = "select MaHoaDon as 'Mã hóa đơn'," +
                "TenSanPham as 'Tên sản phẩm'," +
                "ChiTietHoaDon.SoLuong as 'Số lượng'," +
                "DonGia as 'Đơn giá'," +
                "GiamGia as 'Giảm giá'," +
                "ThanhTien as 'Thành tiền'" +
                "from ChiTietHoaDon inner join SanPham on ChiTietHoaDon.MaSanPham = SanPham.MaSanPham";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimKiemCTHD(string id)
        {
            string query = "select MaHoaDon as 'Mã hóa đơn' ," +
                "TenSanPham as 'Tên sản phẩm' ," +
                "ChiTietHoaDon.SoLuong as 'Số lượng' ," +
                "DonGia as 'Đơn giá' ," +
                "GiamGia as 'Giảm giá' ," +
                "ThanhTien as 'Thành tiền' " +
                "from ChiTietHoaDon inner join SanPham on ChiTietHoaDon.MaSanPham = SanPham.MaSanPham " +
                "where MaHoaDon like @MaHoaDon";
            object[] parameter = { id };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
    }
}
