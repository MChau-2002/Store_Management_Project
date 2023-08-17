using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{
    class PhanLoaiDTO
    {
        private string maLoai;
        public string MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }

        private string tenLoai;
        public string TenLoai
        {
            get { return tenLoai; }
            set { tenLoai = value; }
        }

        public PhanLoaiDTO(string maLoai, string tenLoai)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
        }
    }
}
