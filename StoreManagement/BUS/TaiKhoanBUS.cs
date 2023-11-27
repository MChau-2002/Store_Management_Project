using StoreManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.BUS
{
    class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;
        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBUS();
                return instance;
            }
        }
        public TaiKhoanBUS() { }

        public bool LoginMethod(string username, string password) 
        {
            return TaiKhoanDAO.Instance.LoginMethod(username, password);
        }
    }
}
