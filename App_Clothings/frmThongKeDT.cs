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
            List<sanpham> danhSachSanPham = bll_thongke.getSanPhamBanChay();

            Series series = new Series("Sản phẩm bán chạy", ViewType.Pie); 

            foreach (var sp in danhSachSanPham)
            {
                series.Points.Add(new SeriesPoint(sp.TENSANPHAM, sp.Soluongban)); 
            }

            chartSanPham.Series.Clear();

            chartSanPham.Series.Add(series);

            chartSanPham.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True; 
            chartSanPham.Titles.Clear();
            chartSanPham.Titles.Add(new ChartTitle() { Text = "Thống kê sản phẩm bán chạy" });
        }

        private void LoadChartDoanhThuData()
        {
            
            List<hoadon> danhSachDoanhThu = bll_thongke.getDoanhThuTHeoNgay(dtpkBatDau.Value,dtpkKetThuc.Value);

            Series series = new Series("Doanh thu theo thời gian", ViewType.Bar);
            foreach (var sp in danhSachDoanhThu)
            {
                series.Points.Add(new SeriesPoint(sp.Thang, sp.Doanhthu)); // Thêm tên sản phẩm và số lượng bán
            }

            chartDoanhThu.Series.Clear();

            chartDoanhThu.Series.Add(series);

            // Cấu hình các tùy chọn khác cho biểu đồ (tuỳ chỉnh theo nhu cầu)
            chartDoanhThu.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add(new ChartTitle() { Text = "Thống kê doanh thu" });
        }

        
    }
}