using StoreManagement.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
        }
        public NhanVienDAO() { }

        public DataTable GetNhanVien(string TaiKhoan)
        {
            string query = "select AnhNV as 'Ảnh nhân viên' ," +
                "NhanVien.MaNV as 'Mã nhân viên' ," +
                "TenNV as 'Tên nhân viên' , " +
                "sdt as 'SĐT' from NhanVien " +
                "inner join TaiKhoan on NhanVien.MaNV = TaiKhoan.MaNV " +
                "where TaiKhoan.TaiKhoan = @TaiKhoan";
            object[] parameter = { TaiKhoan };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
    }
}
