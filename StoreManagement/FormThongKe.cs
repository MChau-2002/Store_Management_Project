using StoreManagement.BUS;
using StoreManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StoreManagement
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            FillChart();
            tbxSLSP.Text = ThongKeBUS.Instance.SLSanPham().ToString();
            tbxSLPL.Text = ThongKeBUS.Instance.SLPhanLoai().ToString();
            tbxSLKH.Text = ThongKeBUS.Instance.SLKhachHang().ToString();
            lblHoaDon.Text = "Tổng số hóa đơn đã tạo trong tháng " + DateTime.Now.Month.ToString() + ":";
            tbxHoaDon.Text = ThongKeBUS.Instance.SLHoaDon().ToString();
        }

        private void FillChart()
        {
            DataTable table = ThongKeBUS.Instance.BieuDoDoanhThu();

            chrtDoanhThu.Series.Clear();
            chrtDoanhThu.ChartAreas[0].AxisX.Title = " Tháng";
            chrtDoanhThu.ChartAreas[0].AxisY.Title = " Doanh Thu";

            Series series = chrtDoanhThu.Series.Add("Doanh Thu");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.Int32;
            series.YValueType = ChartValueType.Int32;

            foreach (DataRow row in table.Rows)
            {
                series.Points.AddXY(row["Thang"], row["DoanhThu"]);
            }
        }
    }
}
