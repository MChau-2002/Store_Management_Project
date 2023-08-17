using StoreManagement.DAO;
using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.BUS
{
    class HoaDonBUS
    {
        private static HoaDonBUS instance;
        public static HoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonBUS();
                return instance;
            }
        }

        public bool LuuHoaDon(HoaDonDTO hoaDon)
        {
            return HoaDonDAO.Instance.LuuHoaDon(hoaDon);
        }
    }
}
