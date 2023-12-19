using StoreManagement.BUS;
using StoreManagement.DAO;
using StoreManagement.Functions;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormCTHD : Form
    {
        DataTable dataTable;
        public FormCTHD()
        {
            InitializeComponent();
        }

        private void FormCTHD_Load(object sender, EventArgs e)
        {
            dataTable = ChiTietHoaDonDAO.Instance.ChiTietHoaDon();
            dgvCTHD.DataSource = dataTable;
            
            PageProcessing.Instance.Load(dataTable,dgvCTHD,lblPageview);
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string maCTHD = tbxTimKiem.Text;
            ChiTietHoaDonBUS.Instance.TimKiemCTHD(dgvCTHD, maCTHD);
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.SelectedRows[0].Cells["Mã hóa đơn"].Value.ToString() != null)
            {
                pPDHoaDon.Document = pDHoaDon;
                pPDHoaDon.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa có hóa đơn");
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FormCTHD_Load(sender, e);
        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region PageProcessing
        private void btnDauTrang_Click(object sender, EventArgs e)
        {
            PageProcessing.Instance.DauTrang(dataTable, dgvCTHD, lblPageview);
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang tiếp theo không
            PageProcessing.Instance.TrangKeTiep(dataTable, dgvCTHD, lblPageview);
        }

        private void btnEPg_Click(object sender, EventArgs e)
        {
            PageProcessing.Instance.TrangCuoi(dataTable, dgvCTHD, lblPageview);
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang trước đó không
            PageProcessing.Instance.TrangKeTruoc(dataTable, dgvCTHD, lblPageview);
        }

        #endregion

        private void PDHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string maCTHD = dgvCTHD.SelectedRows[0].Cells["Mã hóa đơn"].Value.ToString();
            DataTable data = ChiTietHoaDonDAO.Instance.XemBienLai(maCTHD);
            string ngayBan = "Ngày: " + data.Rows[0]["Ngày bán"].ToString();
            float tongTien = 0;
            string giamGia = "Giảm giá: " + data.Rows[0]["Giảm giá"].ToString() + "%";
            string phaiThanhToan = "Phải thanh toán: " + data.Rows[0]["Thành tiền"].ToString();

            //Header
            e.Graphics.DrawString("SIÊU THỊ MINI".ToUpper(), new Font("Microsoft Sans Serif",
                20, FontStyle.Bold), Brushes.Black, new Point(330, 20));
            e.Graphics.DrawString("Tô ký, Tân Chánh Hiệp, quận 12, Hồ Chí Minh".ToUpper(),new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(200, 60));
            e.Graphics.DrawString("SDT: +84-024681012".ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(330, 80));
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG".ToUpper(), new Font("Microsoft Sans Serif",
                18, FontStyle.Bold), Brushes.Black, new Point(280, 140));
            e.Graphics.DrawString("Mã hóa đơn: " + maCTHD.ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Bold), Brushes.Black, new Point(330, 170));
            e.Graphics.DrawString(ngayBan.ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(330, 190));

            Pen blackPen = new Pen(Color.Black, 1);

            int y = 220;

            Point p1 = new Point(10, y);
            Point p2 = new Point(840, y);

            e.Graphics.DrawLine(blackPen, p1, p2);

            y += 10;

            //CollumnName
            e.Graphics.DrawString("Mã sản phẩm", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(20, y));
            e.Graphics.DrawString("Tên sản phẩm", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(160, y));
            e.Graphics.DrawString("Số lượng", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(360, y));
            e.Graphics.DrawString("Giá", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(460, y));
            e.Graphics.DrawString("Giảm giá", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(560, y));
            e.Graphics.DrawString("Thành tiền", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(700, y));
            //DSSanPham
            for (int i = 0; i < data.Rows.Count; i++)
            {
                y += 20;

                string maSanPham = data.Rows[i]["Mã sản phẩm"].ToString();
                string tenSanPham = data.Rows[i]["Tên sản phẩm"].ToString();
                string soLuong = data.Rows[i]["Số lượng"].ToString();
                string donGia = data.Rows[i]["Đơn giá"].ToString();
                string giamGiaSp = data.Rows[i]["Giảm giá sản phẩm"].ToString();
                string thanhTien = ((float.Parse(donGia) * int.Parse(soLuong)) 
                    - (float.Parse(giamGiaSp) * (float.Parse(donGia) * int.Parse(soLuong))) / 100).ToString();

                tongTien += float.Parse(thanhTien);

                e.Graphics.DrawString(maSanPham, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(20, y));
                e.Graphics.DrawString(tenSanPham, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(160, y));
                e.Graphics.DrawString(soLuong, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(360, y));
                e.Graphics.DrawString(donGia, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(460, y));
                e.Graphics.DrawString(giamGiaSp.ToString(), new Font("Microsoft Sans Serif",
               12, FontStyle.Regular), Brushes.Black, new Point(560, y));
                e.Graphics.DrawString(thanhTien.ToString(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(700, y));
            }


            y += 30;
            Point p3 = new Point(10, y);
            Point p4 = new Point(840, y);
            e.Graphics.DrawLine(blackPen, p3, p4);

            //Footer
            y += 20;
            e.Graphics.DrawString("Tổng tiền: " + tongTien, new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(620 - 80, y));/*
*/
            y += 20;
            e.Graphics.DrawString(giamGia, new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(620 - 80, y));

            y += 20;
            e.Graphics.DrawString(phaiThanhToan, new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(620 - 80, y));

            y += 50;
            e.Graphics.DrawString("Xin cảm ơn quý khách!", new Font("Microsoft Sans Serif",
            14, FontStyle.Bold), Brushes.Black, new Point(300, y));
        }
    }
}
