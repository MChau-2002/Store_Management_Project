namespace StoreManagement.DTO
{
    class CurrentNhanVienDTO
    {
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

        private string vaiTro;
        public string VaiTro
        {
            get { return vaiTro; }
            set { vaiTro = value; }
        }

        public CurrentNhanVienDTO( string maNhanVien, string tenNhanVien, string vaiTro)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.vaiTro = vaiTro;
        }

    }
}
