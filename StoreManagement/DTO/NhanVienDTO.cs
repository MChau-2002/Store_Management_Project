namespace StoreManagement.DTO
{
    class NhanVienDTO
    {
        private byte[] anhNhanVien;
        public byte[] AnhNhanVien
        {
            get { return anhNhanVien; }
            set { anhNhanVien = value; }
        }

        private string maNhanVien;
        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        private string tenNhanVien;
        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        private string sdt;
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public NhanVienDTO(byte[] anhNhanVien, string maNhanVien, string tenNhanVien, string sdt)
        {
            this.anhNhanVien = anhNhanVien;
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.sdt = sdt;
        }
    }
}
