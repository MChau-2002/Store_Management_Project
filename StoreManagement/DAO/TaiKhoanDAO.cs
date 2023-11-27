using Microsoft.Office.Interop.Excel;
using StoreManagement.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DAO
{
    class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
        }
        public TaiKhoanDAO() { }

        public bool LoginMethod(string TaiKhoan, string MatKhau)
        {
            string query = "select count(*) from TaiKhoan where TaiKhoan = @TaiKhoan and MatKhau = @MatKhau";
            object[] parameters = { TaiKhoan , MatKhau};
            return DataProvider.Instance.ExecuteScalar(query, parameters);
        }
        public int GetMaNV(string TaiKhoan)
        {
            string query = "select * from NhanVien inner join TaiKhoan on NhanVien.MaNV = TaiKhoan.MaNV where TaiKhoan.MaNV = 'NV2'";
            object[] parameters = { TaiKhoan };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
