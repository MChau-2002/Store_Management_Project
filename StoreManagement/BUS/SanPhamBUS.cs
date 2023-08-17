using StoreManagement.DAO;
using StoreManagement.DTO;
using System.Windows.Forms;

namespace StoreManagement.BUS
{
    class SanPhamBUS
    {
        private static SanPhamBUS instance;

        public static SanPhamBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamBUS();
                return instance;
            }
            //set { instance = value; }
        }
        public SanPhamBUS() { }

        public void TimKiemSanPham(DataGridView Dgv, string tenSanPham)
        {
            Dgv.DataSource = SanPhamDAO.Instance.TimKiemSanPham(tenSanPham);
        }

        public bool ThemSanPham(SanPhamDTO sanPham) 
        {
            return SanPhamDAO.Instance.ThemSanPham(sanPham);
        }

        public bool SuaSanPham(SanPhamDTO sanPham)
        {
            return SanPhamDAO.Instance.SuaSanPham(sanPham);
        }

        public bool XoaSanPham(string MaSanPham)
        {
            return SanPhamDAO.Instance.XoaSanPham(MaSanPham);
        }

        public string idGenerate(string prefix)
        {
            int maxRow = SanPhamDAO.Instance.idGenerate();
            string id = prefix + maxRow;
            return id;
        }
    }
}
