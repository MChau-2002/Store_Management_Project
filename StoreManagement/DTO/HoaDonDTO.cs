using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{
    class HoaDonDTO
    {
        private string maHoaDon;

        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        private DateTime ngayBan;

        public DateTime NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }

        private float thanhTien;

        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        private string maKH;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        public HoaDonDTO(string maHoaDon, DateTime ngayBan, float thanhTien, string maKH, string ghiChu)
        {
            this.maHoaDon = maHoaDon;
            this.ngayBan = ngayBan;
            this.thanhTien = thanhTien;
            this.maKH = maKH;
            this.ghiChu = ghiChu;
        }
    }
}
