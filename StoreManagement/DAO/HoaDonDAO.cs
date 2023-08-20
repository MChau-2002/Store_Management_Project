using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManagement.DTO;
using StoreManagement.Functions;

namespace StoreManagement.DAO
{
    class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAO();
                return instance;
            }
        }

        public HoaDonDAO() { }

        public bool LuuHoaDon(HoaDonDTO hoaDon)
        {
            //if()
            string query = "insert into HoaDon values ( @MaHoaDon , @NgayBan , @ThanhTien , @MaKH , @GhiChu )";
            object[] parameters = { hoaDon.MaHoaDon, hoaDon.NgayBan, hoaDon.ThanhTien, hoaDon.MaKH, hoaDon.GhiChu };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query,parameters) > 0)
            {
                result = true;
            }
            return result;
        }

    }
}
