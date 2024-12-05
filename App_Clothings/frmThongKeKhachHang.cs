using BLL;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Clothings
{
    public partial class frmThongKeKhachHang : DevExpress.XtraEditors.XtraForm
    {
        BLL_ThongKe bll_thongke = new BLL_ThongKe();
        public frmThongKeKhachHang()
        {
            InitializeComponent();
            this.Load += FrmThongKeKhachHang_Load;
        }

        private void FrmThongKeKhachHang_Load(object sender, EventArgs e)
        {
            LoadChartKhachHangData();
        }

        private void LoadChartKhachHangData()
        {
            // Lấy dữ liệu từ hàm getKhachHangThongKe
            List<hoadon> danhsachKH = bll_thongke.getKhachHangThongKe();

            // Series cho Số lượng
            Series seriesSoLuong = new Series("Số lượng", ViewType.RadarLine);
            // Series cho Tổng tiền
            Series seriesTongTien = new Series("Tổng tiền", ViewType.RadarLine);

            // Thêm dữ liệu vào Series
            foreach (var sp in danhsachKH)
            {
                seriesSoLuong.Points.Add(new SeriesPoint(sp.Tennguoidung, sp.SOLUONG));
                seriesTongTien.Points.Add(new SeriesPoint(sp.Tennguoidung, sp.Doanhthu));
            }

            // Xóa các Series cũ
            chartKhacHang.Series.Clear();

            // Thêm cả hai Series
            chartKhacHang.Series.Add(seriesSoLuong);
            chartKhacHang.Series.Add(seriesTongTien);

            // Kiểm tra xem chartKhacHang có đang sử dụng đúng trục XY không
            XYDiagram diagram = chartKhacHang.Diagram as XYDiagram;
            if (diagram != null)
            {
                // Tạo trục Y thứ hai cho 'Tổng tiền'
                SecondaryAxisY secondaryAxisY = new SecondaryAxisY("Trục Y cho Tổng tiền");
                diagram.SecondaryAxesY.Add(secondaryAxisY);

                // Thiết lập các thuộc tính trục Y chính và phụ
                diagram.AxisY.Title.Text = "Số lượng";
                diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                secondaryAxisY.Title.Text = "Tổng tiền";
                secondaryAxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;

                // Đặt seriesTongTien vào trục Y phụ
                seriesTongTien.ArgumentScaleType = ScaleType.Qualitative;
                seriesTongTien.ValueScaleType = ScaleType.Numerical;

                // Đặt seriesSoLuong vào trục Y chính
                seriesSoLuong.ArgumentScaleType = ScaleType.Qualitative;
                seriesSoLuong.ValueScaleType = ScaleType.Numerical;

                // Gán trục Y cho các series
            //    seriesTongTien.ValueAxisY = secondaryAxisY; // Đây là bước đúng để gán trục Y phụ
            }

            // Hiển thị chú thích (Legend)
            chartKhacHang.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Thiết lập tiêu đề cho biểu đồ
            chartKhacHang.Titles.Clear();
            chartKhacHang.Titles.Add(new ChartTitle() { Text = "Thống kê khách hàng theo Số lượng và Tổng tiền" });
        }








    }
}