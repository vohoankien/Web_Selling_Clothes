using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using DevExpress.XtraCharts;
namespace App_Clothings
{
    public partial class frmThongKeDT : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeDT()
        {
            InitializeComponent();
            this.Load += FrmThongKeDT_Load;
            this.btnThongKe.Click += BtnThongKe_Click;
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            LoadChartDoanhThuData();
        }

        BLL_ThongKe bll_thongke = new BLL_ThongKe();
        private void FrmThongKeDT_Load(object sender, EventArgs e)
        {
            LoadChartSanPhamData();
            LoadChartDoanhThuData();
        }
        private void LoadChartSanPhamData()
        {
            // Lấy dữ liệu từ hàm getSanPhamBanChay
            List<sanpham> danhSachSanPham = bll_thongke.getSanPhamBanChay();

            // Tạo Series cho biểu đồ
            Series series = new Series("Sản phẩm bán chạy", ViewType.Bar); // Bar chart cho sản phẩm bán chạy

            // Duyệt qua danh sách sản phẩm và thêm dữ liệu vào Series
            foreach (var sp in danhSachSanPham)
            {
                series.Points.Add(new SeriesPoint(sp.TENSANPHAM, sp.Soluongban)); // Thêm tên sản phẩm và số lượng bán
            }

            // Xóa dữ liệu cũ trong chart nếu có
            chartSanPham.Series.Clear();

            // Thêm series vào chart control
            chartSanPham.Series.Add(series);

            // Cấu hình các tùy chọn khác cho biểu đồ (tuỳ chỉnh theo nhu cầu)
            chartSanPham.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True; // Hiển thị Legend
            chartSanPham.Titles.Clear();
            chartSanPham.Titles.Add(new ChartTitle() { Text = "Thống kê sản phẩm bán chạy" });
        }

        private void LoadChartDoanhThuData()
        {
            
            // Lấy dữ liệu từ hàm getSanPhamBanChay
            List<hoadon> danhSachDoanhThu = bll_thongke.getDoanhThuTHeoNgay(dtpkBatDau.Value,dtpkKetThuc.Value);

            // Tạo Series cho biểu đồ
            Series series = new Series("Doanh thu theo thời gian", ViewType.Bar); // Bar chart cho sản phẩm bán chạy

            // Duyệt qua danh sách sản phẩm và thêm dữ liệu vào Series
            foreach (var sp in danhSachDoanhThu)
            {
                series.Points.Add(new SeriesPoint(sp.Ngay, sp.Doanhthu)); // Thêm tên sản phẩm và số lượng bán
            }

            // Xóa dữ liệu cũ trong chart nếu có
            chartDoanhThu.Series.Clear();

            // Thêm series vào chart control
            chartDoanhThu.Series.Add(series);

            // Cấu hình các tùy chọn khác cho biểu đồ (tuỳ chỉnh theo nhu cầu)
            chartDoanhThu.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True; // Hiển thị Legend
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add(new ChartTitle() { Text = "Thống kê doanh thu" });
        }

      
    }
}