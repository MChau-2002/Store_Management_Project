using StoreManagement.BUS;
using StoreManagement.DAO;
using StoreManagement.DTO;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace StoreManagement
{
    public partial class FormTTHD : Form
    {
        ThanhToanDTO thanhToan;
        HoaDonDTO hoaDon;
        FormNhapSoLuong nhapSLuong;

        DataTable gioHang;

        int tongSLSanPham;
        string maHoaDon;

        public FormTTHD()
        {
            InitializeComponent();
        }

        private void FormTTHD_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = SanPhamDAO.Instance.DSSanPham();

            dgvSanPham.Columns["Mã sản phẩm"].Visible = false;

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dgvSanPham.Columns[0];
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;

            LoadGioHang();
            dgvGioHang.DataSource = gioHang;

            btnTaoHoaDon.Enabled = true;
            if (btnTaoHoaDon.Enabled == true)
            {
                pnlButton.Enabled = false;
            }
            dtpkNgayBan.Value = DateTime.Today;

            tongSLSanPham = (int)dgvSanPham.CurrentRow.Cells["Số lượng"].Value;
        }

        private void LoadGioHang()
        {
            gioHang = new DataTable();
            if (gioHang.Columns.Count == 0)
            {
                gioHang.Columns.Add("MÃ SẢN PHẨM", typeof(string));
                gioHang.Columns.Add("TÊN SẢN PHẨM", typeof(string));
                gioHang.Columns.Add("SỐ LƯỢNG", typeof(int));
                gioHang.Columns.Add("GIÁ BÁN", typeof(float));
            }
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            ResetValue();
            pnlButton.Enabled = true;
            dgvGioHang.DataSource = gioHang;
            tbxMaHD.Text = ThanhToanBUS.Instance.idGenerate("HD");
            dtpkNgayBan.Value = DateTime.Today;
            btnTaoHoaDon.Enabled = false;
        }

        //Them san pham vao gio hang
        private void ThemVaoGioHang()
        {
            if (dgvSanPham.SelectedRows[0].Cells["Mã sản phẩm"].Value != null)
            {
                string maSanPham = dgvSanPham.SelectedRows[0].Cells["Mã sản phẩm"].Value.ToString();
                string tenSanPham = dgvSanPham.SelectedRows[0].Cells["Tên sản phẩm"].Value.ToString();
                float giaTien = float.Parse(dgvSanPham.SelectedRows[0].Cells["Giá"].Value.ToString());
                bool found = false;
                int soLuong;

                //Get So Luong
                nhapSLuong = new FormNhapSoLuong();
                nhapSLuong.ShowDialog();
                soLuong = nhapSLuong.GetAmount();

                //Input phai lon hon 0
                if (soLuong > 0)
                {
                    //Check xem Sp đa ton tai trong gio hang chua
                    foreach (DataGridViewRow row in dgvGioHang.Rows)
                    {
                        if (row.Cells["MÃ SẢN PHẨM"].Value != null && row.Cells["MÃ SẢN PHẨM"].Value.ToString() == maSanPham)
                        {
                            tongSLSanPham = (int)dgvSanPham.SelectedRows[0].Cells["Số lượng"].Value - (int)row.Cells["SỐ LƯỢNG"].Value;
                            if (ThanhToanBUS.Instance.checkSoLuong(soLuong, tongSLSanPham) >= 0)
                            {
                                row.Cells["SỐ LƯỢNG"].Value = (int)row.Cells["SỐ LƯỢNG"].Value + soLuong;
                                tongSLSanPham = ThanhToanBUS.Instance.checkSoLuong(soLuong, tongSLSanPham);
                            }
                            found = true;
                        }
                    }
                    if (found == false || dgvGioHang.Rows[0].Cells["MÃ SẢN PHẨM"].Value == null)
                    {
                        tongSLSanPham = (int)dgvSanPham.SelectedRows[0].Cells["Số lượng"].Value;
                        if (ThanhToanBUS.Instance.checkSoLuong(soLuong, tongSLSanPham) >= 0)
                        {
                            DataRow gioHangRow = gioHang.NewRow();
                            gioHangRow["MÃ SẢN PHẨM"] = maSanPham;
                            gioHangRow["TÊN SẢN PHẨM"] = tenSanPham;
                            gioHangRow["SỐ LƯỢNG"] = soLuong;
                            gioHangRow["GIÁ BÁN"] = giaTien;

                            gioHang.Rows.Add(gioHangRow);

                            tongSLSanPham = ThanhToanBUS.Instance.checkSoLuong(soLuong, tongSLSanPham);
                        }
                    }
                }
                TinhTien();
            }
            else
            {
                MessageBox.Show("Mời chọn sản phẩm");
            }
        }

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            ThemVaoGioHang();
        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!btnTaoHoaDon.Enabled)
            {
                ThemVaoGioHang();
            }
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            ResetValue();
            FormTTHD_Load(sender, e);
        }
        //Tim kiem san pham
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ThanhToanBUS.Instance.TimKiemSanPham(dgvSanPham, tbxTimKiem.Text);
        }
        //Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = SanPhamDAO.Instance.DSSanPham();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(dgvGioHang.RowCount > 1)
            {
                GetValueHoaDon();
                try
                {
                    if (HoaDonBUS.Instance.LuuHoaDon(hoaDon) == true)
                    {
                        MessageBox.Show("Lưu hóa đơn thành công");
                        LuuCTHD();
                        pPDHoaDon.Document = pDHoaDon;
                        pPDHoaDon.ShowDialog();
                        btnTaoHoaDon.Enabled = true;
                        ResetValue();
                        FormTTHD_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Lưu hóa đơn ko thành công");
                    }
                }
                catch (Exception ex)
                {
                    //throw ex;
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
        }

        private float TinhTien()
        {
            float tongTien;
            float result = 0;
            float giamGia = 0;
            List<string> listMaSP = new List<string>();
            List<int> listSoLuong = new List<int>();
            List<float> listGia = new List<float>();
            try
            {
                for (int i = 0; i < dgvGioHang.RowCount - 1; i++)
                {
                    listMaSP.Add(dgvGioHang.Rows[i].Cells["MÃ SẢN PHẨM"].Value.ToString());
                    listSoLuong.Add((int)dgvGioHang.Rows[i].Cells["SỐ LƯỢNG"].Value);
                    listGia.Add(float.Parse(dgvGioHang.Rows[i].Cells["GIÁ BÁN"].Value.ToString()));
                }

                if (dgvGioHang.RowCount > 1)
                {

                    if (dgvGioHang.Rows[0].Cells["SỐ LƯỢNG"].Value != null && dgvGioHang.Rows[0].Cells["GIÁ BÁN"].Value != null)
                    {
                        for (int i = 0; i < dgvGioHang.RowCount - 1; i++)
                        {
                            result += (float)listSoLuong[i] * listGia[i];
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
            tongTien = result;

            if (tbxGiamGia.Text != "")
            {
                giamGia = float.Parse(tbxGiamGia.Text) / 100;
            }
            tbxThanhTien.Text = (tongTien - (tongTien * giamGia)).ToString();
            tbxDonGia.Text = tongTien.ToString();
            return result;
        }

        private void tbxGiamGia_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void GetValueHoaDon()
        {
            if(dgvGioHang.RowCount > 1)
            {
                FormDSKhachHang luuKH = new FormDSKhachHang();

                string maHoaDon = tbxMaHD.Text;
                DateTime ngayBan = DateTime.Now;
                string maKH;
                string ghiChu;
                DialogResult result = MessageBox.Show("Bạn có muốn lưu tên khách hàng không?", "Khách hàng", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    luuKH.ShowDialog();
                    maKH = luuKH.chonKH();
                    ghiChu = " ";
                }
                else
                {
                    maKH = "KH1";
                    ghiChu = " ";
                }

                float thanhTien = float.Parse(tbxThanhTien.Text);

                hoaDon = new HoaDonDTO(maHoaDon, ngayBan, thanhTien, maKH, ghiChu);
            }
        }

        //GetValue CTHD
        public void LuuCTHD()
        {
            maHoaDon = tbxMaHD.Text;
            float thanhTien = float.Parse(tbxThanhTien.Text);

            int giamGia = 0;
            if (tbxGiamGia.Text != "")
            {
                giamGia = int.Parse(tbxGiamGia.Text);
            }

            for (int i = 0; i < dgvGioHang.RowCount - 1; i++)
            {
                string maSanPham = dgvGioHang.Rows[i].Cells["MÃ SẢN PHẨM"].Value.ToString();
                int soLuong = (int)dgvGioHang.Rows[i].Cells["SỐ LƯỢNG"].Value;
                float donGia = float.Parse(dgvGioHang.Rows[i].Cells["GIÁ BÁN"].Value.ToString());
                
                thanhToan = new ThanhToanDTO(maHoaDon, maSanPham, soLuong, donGia, giamGia, thanhTien);
                ThanhToanBUS.Instance.UpdateSoLuong(soLuong, maSanPham);
                ThanhToanBUS.Instance.LuuCTHD(thanhToan);
            }
        }

        public void ResetValue()
        {
            tbxMaHD.Text = "";
            tbxDonGia.Text = "";
            tbxGiamGia.Text = "";
            tbxThanhTien.Text = "";
            gioHang.Rows.Clear();
        }

        //In hoa don
        private void pDHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string maHD = "Mã hóa đơn: " + tbxMaHD.Text;
            string ngayBan = "Ngày: " + dtpkNgayBan.Value.ToString();
            string tongTien = "Tổng tiền: " + tbxDonGia.Text;
            string giamGia = "Giảm giá: " + tbxGiamGia.Text + "%";
            string thanhTien = "Thành tiền: " + tbxThanhTien.Text;

            //Header
            e.Graphics.DrawString("TẠP HÓA THÙY DUNG".ToUpper(), new Font("Microsoft Sans Serif",
                20, FontStyle.Bold), Brushes.Black, new Point(280, 20));
            e.Graphics.DrawString("280, tổ 15, khu phố Tám Thước, huyện Kiên Lương, tỉnh Kiên Giang".ToUpper(), 
                new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(150, 60));
            e.Graphics.DrawString("SDT: +84-024681012".ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(330, 80));
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG".ToUpper(), new Font("Microsoft Sans Serif",
                18, FontStyle.Bold), Brushes.Black, new Point(280, 140));
            e.Graphics.DrawString(maHD.ToUpper(), new Font("Microsoft Sans Serif",
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
            12, FontStyle.Bold), Brushes.Black, new Point(180, y));
            e.Graphics.DrawString("Số lượng", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(Right - 120, y));
            e.Graphics.DrawString("Giá", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(Right, y));

            //DSSanPham
            for (int i = 0; i < dgvGioHang.RowCount - 1; i++)
            {
                y += 20;

                string maSanPham = dgvGioHang.Rows[i].Cells["MÃ SẢN PHẨM"].Value.ToString();
                string tenSanPham = dgvGioHang.Rows[i].Cells["TÊN SẢN PHẨM"].Value.ToString();
                int soLuong = (int)dgvGioHang.Rows[i].Cells["SỐ LƯỢNG"].Value;
                float donGia = float.Parse(dgvGioHang.Rows[i].Cells["GIÁ BÁN"].Value.ToString());


                e.Graphics.DrawString(maSanPham, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(20, y));
                e.Graphics.DrawString(tenSanPham, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(180, y));
                e.Graphics.DrawString(soLuong.ToString(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(Right - 120, y));
                e.Graphics.DrawString(donGia.ToString(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(Right, y));
                
            }


            y += 30;
            Point p3 = new Point(10, y);
            Point p4 = new Point(840, y);
            e.Graphics.DrawLine(blackPen, p3, p4);

            //Footer
            y += 20;
            e.Graphics.DrawString(tongTien, new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(Right - 80, y));

            y += 20;
            e.Graphics.DrawString(giamGia, new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(Right - 80, y));

            y += 20;
            e.Graphics.DrawString(thanhTien, new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(Right - 80, y));

            y += 50;
            e.Graphics.DrawString("Xin cảm ơn quý khách!", new Font("Microsoft Sans Serif",
            14, FontStyle.Bold), Brushes.Black, new Point(300, y));
        }
    }
}
