﻿using StoreManagement.DTO;
using StoreManagement.Functions;
using System.Data;

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


        public DataTable TimKiemSanPham(string tenSanPham)
        {
            string query = "select AnhSanPham as 'Ảnh' ," +
                " MaSanPham as 'Mã sản phẩm' ," +
                " TenSanPham as 'Tên sản phẩm' ," +
                " PhanLoai.TenLoai as 'Tên loại' ," +
                " SoLuong as 'Số lượng' ," +
                " GiaBan as 'Giá' " +
                " from SanPham inner join PhanLoai on SanPham.MaLoai = PhanLoai.MaLoai " +
                " where TenSanPham like @tenSanPham "; ;
            object[] parameter = { "%" + tenSanPham + "%" };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }

        public int IdGenerate()
        {
            string query = "select * from HoaDon";
            int maxRow = DataProvider.Instance.ExecuteQuery(query).Rows.Count + 1;
            return maxRow;
        }

        public bool LuuCTHD(ThanhToanDTO thanhToan)
        {
            bool result = false;
            string query = "insert into ChiTietHoaDon values ( @MaHoaDon , @MaSanPham , @SoLuong , @DonGia , @GiamGia , @ThanhTien , @GiamGiaSP )";
            object[] parameters = { thanhToan.MaHoaDon, thanhToan.MaSanPham, thanhToan.SoLuong, thanhToan.DonGia, thanhToan.GiamGia, thanhToan.ThanhTien, thanhToan.GiamGiaSP };

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
    }
}
