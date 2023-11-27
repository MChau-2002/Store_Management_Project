using StoreManagement.DAO;
using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.BUS
{
    class NhanVienBUS
    {
        public static NhanVienDTO currentNhanVien;

        private static NhanVienBUS instance;

        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBUS();
                return instance;
            }
        }

        public NhanVienBUS() { }


        public void GetNhanVien(string TaiKhoan)
        {
            DataTable data = NhanVienDAO.Instance.GetNhanVien(TaiKhoan);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                
                byte[] anhNV = row[0] as byte[] ?? new byte[0];
                string MaNV = row[1] as string;
                string TenNhanVien = row[2] != null ? row[2].ToString() : "";
                string Sdt = row[3].ToString();

                currentNhanVien = new NhanVienDTO(anhNV, MaNV, TenNhanVien, Sdt);
            }
        }
    }
}
