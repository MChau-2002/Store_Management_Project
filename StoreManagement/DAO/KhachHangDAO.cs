using StoreManagement.DTO;
using StoreManagement.Functions;
using System.Data;

namespace StoreManagement.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return instance;
            }
        }
        public KhachHangDAO() { }
        public DataTable DSKhachHang()
        {
            string query = "select MaKH as 'Mã khách hàng' , " +
                "TenKH as 'Tên khách hàng' , Sdt as 'Số điện thoại' , " +
                "GhiChu as 'Ghi chú' from KhachHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimKiemKH(string TenKH)
        {
            string query = "select MaKH as 'Mã khách hàng', " +
                "TenKH as 'Tên khách hàng' , Sdt as 'Số điện thoại' , " +
                "GhiChu as 'Ghi chú' from KhachHang where TenKH like @TenKH";
            object[] parameter = { "%" + TenKH + "%" };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }

        
        public bool ThemKH(KhachHangDTO KH)
        {
            string query = "insert into KhachHang values ( @MaKH , @tenKH , @Sdt , @GhiChu )";
            object[] parameters = { KH.MaKH, KH.TenKH, KH.Sdt, KH.GhiChu };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                result = true;
            }
            return result;
        }

        public bool SuaKH(KhachHangDTO KH)
        {
            string query = "update KhachHang set TenKH = @TenKH , Sdt = @Sdt , GhiChu = @GhiChu where MaKH = @MaKH";
            object[] parameters = { KH.TenKH, KH.Sdt, KH.GhiChu , KH.MaKH };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                result = true;
            }
            return result;
        }

        public bool XoaKH(string id)
        {
            string query = "Delete KhachHang where MaKH = @MaKH";
            object[] parameter = { id };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0)
            {
                result = true;
            }
            return result;
        }

        public int idGenerate()
        {
            string query = "select * from KhachHang";
            int maxRow = DataProvider.Instance.ExecuteQuery(query).Rows.Count + 1;
            return maxRow;
        }
    }
}
