using StoreManagement.DTO;
using StoreManagement.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DAO
{
    class ThanhToanDAO
    {
        private static ThanhToanDAO instance;

        public static ThanhToanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThanhToanDAO();
                return instance;
            }
        }
        public ThanhToanDAO() { }

        /*public DataTable TaoGioHang()
        {
            string query = "select ChiTietHoaDon.MaSanPham as 'MÃ SẢN PHẨM' ," +
                " SanPham.TenSanPham as 'TÊN SẢN PHẨM' ," +
                " ChiTietHoaDon.SoLuong as 'SỐ LƯỢNG' , DonGia as 'GIÁ BÁN'"  +
                " from ChiTietHoaDon inner join SanPham on ChiTietHoaDon.MaSanPham = SanPham.MaSanPham";
            return DataProvider.Instance.ExecuteQuery(query);
        }*/

        public DataTable TimKiemSanPham(string tenSanPham)
        {
            string query = "select AnhSanPham as 'Ảnh' ," +
                " MaSanPham as 'Mã sản phẩm' ," +
                " TenSanPham as 'Tên sản phẩm' ," +
                " PhanLoai.TenLoai as 'Tên loại' ," +
                " SoLuong as 'Số lượng' ," +
                " GiaTien as 'Giá' " +
                " from SanPham inner join PhanLoai on SanPham.MaLoai = PhanLoai.MaLoai " +
                " where TenSanPham like @tenSanPham "; ;
            object[] parameter = { "%" + tenSanPham + "%" };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }

        public int idGenerate()
        {
            string query = "select * from HoaDon";
            int maxRow = DataProvider.Instance.ExecuteQuery(query).Rows.Count + 1;
            return maxRow;
        }

        public bool ThemChiTietHoaDon(ThanhToanDTO thanhToan)
        {
            bool result = false;
            string query = "insert into ChiTietHoaDon values ( @MaHoaDon , @MaSanPham , @SoLuong , @DonGia , @GiamGia , @ThanhTien )";
            object[] parameters = { thanhToan.MaHoaDon, thanhToan.MaSanPham, thanhToan.SoLuong, thanhToan.DonGia, thanhToan.GiamGia, thanhToan.ThanhTien };

            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                result = true;
            }
            return result;
        }

        public bool UpdateSoLuong(int soLuong, string maSanPham)
        {
            bool result = false;
            string query = "update SanPham set SoLuong = SoLuong - @SoLuong where MaSanPham = @MaSanPham ";
            object[] parameters = { soLuong, maSanPham };
            if(DataProvider.Instance.ExecuteNonQuery(query,parameters) > 0)
            {
                result = true;
            }
            return result;
        }
/*
        public DataTable ChiTietHoaDon(string id) 
        {
            string query = "select MaHoaDon as 'Mã hóa đơn', " +
                "ChiTietHoaDon.MaSanPham as 'Mã sản phẩm', " +
                "TenSanPham as 'Tên sản phẩm', " +
                "ChiTietHoaDon.SoLuong as 'Số lượng', " +
                "DonGia as 'Đơn giá', GiamGia as 'Giảm giá, " +
                "ThanhTien as 'Thành tiền" +
                "from ChiTietHoaDon inner join SanPham on ChiTietHoaDon.MaSanPham = SanPham.MaSanPham" +
                "and ChiTietHoaDon.MaHoaDon = @id";
            object[] parameter = { id };
            return DataProvider.Instance.ExecuteQuery(query, parameter);

        }*/
    }
}
