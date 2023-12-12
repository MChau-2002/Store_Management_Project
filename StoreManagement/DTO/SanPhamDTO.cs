namespace StoreManagement.DTO
{
    class SanPhamDTO
    {
        private byte[] anh;
        public byte[] Anh
        {
            get { return anh; }
            set { anh = value; }
        }

        private string maSanPham;
        public string MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }

        private string tenSanPham;
        public string TenSanPham
        {
            get { return tenSanPham; }
            set { tenSanPham = value; }
        }

        private string maLoai;
        public string MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }

        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private float giaBan;
        public float GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }

        private int soLuongNhap;
        public int SoLuongNhap
        {
            get { return soLuongNhap; }
            set { soLuongNhap = value; }
        }


        private float giaNhap;
        public float GiaNhap
        {
            get { return giaNhap; }
            set { giaNhap = value; }
        }

        private float giamGia;
        public float GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }

        public SanPhamDTO(byte[] anh, string maSanPham, string tenSanPham, string maLoai, int soLuong, float giaBan, int soLuongNhap, float giaNhap, float giamGia)
        {
            this.anh = anh;
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.maLoai = maLoai;
            this.soLuong = soLuong;
            this.giaBan = giaBan;
            this.soLuongNhap = soLuongNhap;
            this.giaNhap = giaNhap;
            this.giamGia = giamGia;
        }
    }
}
