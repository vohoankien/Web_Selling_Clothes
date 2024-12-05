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
using BLL;
using DevExpress.XtraReports.UI;
namespace App_Clothings
{
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        private string maHD;
        private string maKH;
        BLL_HoaDon bll_hoadon = new BLL_HoaDon();
        BLL_NguoiDung bll_nguoidung = new BLL_NguoiDung();
        BLL_ThanhToan bll_thanhtoan = new BLL_ThanhToan();

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public frmHoaDon()
        {
            InitializeComponent();
            this.Load += FrmHoaDon_Load;
            this.btnThanhToan.Click += BtnThanhToan_Click;
            this.btnReport.Click += BtnReport_Click;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            rptHoaDon report = new rptHoaDon();
            if (report.Parameters["MaHD"] != null)
            {
                report.Parameters["MaHD"].Value = maHD;
            }
            else
            {
                // Tham số MAHD chưa được khởi tạo
                MessageBox.Show("Tham số MAHD không có trong báo cáo.");
                return;
            }
            report.CreateDocument();
            //report.Parameters["MaHD"].Visible = false; // Không hiển thị tham số khi in
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            hoadon hd = bll_hoadon.findHoaDon(MaHD);
            if(hd == null)
            {
                MessageBox.Show("Lỗi trong quá trình tạo đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            DateTime ngay = DateTime.Now;
            bool t = bll_hoadon.updateHoaDon(ngay, 1, hd);
            int tinhtrang = (int)cbThanhToan.SelectedValue;
            thanhtoan tt = new thanhtoan();
            tt.MAHD = maHD;
            tt.MATHANHTOAN = bll_thanhtoan.GenerateMaThanhToan();
            tt.NGAYTHANHTOAN = DateTime.Now;
            tt.TONGTIEN = float.Parse(txtTongTien.Text);
            tt.PHUONGTHUCTHANHTOAN = tinhtrang;
            bool kq = bll_thanhtoan.insertThanhToan(tt);
            if(!kq)
            {
                MessageBox.Show("Thanh toán không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            MessageBox.Show("Thanh toán thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbChuKy.Text = "Đã hoàn thành";
            lbNgay.Text = DateTime.Now.ToString();
            btnReport.Enabled = true;

        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            var lst = new List<object>
            { 
            new { Text = "Thanh toán trực tiếp", Value = 0 },
            new { Text = "Thanh toán online", Value = 1 }
            };
            cbThanhToan.DataSource = lst;
            cbThanhToan.DisplayMember = "Text"; 
            cbThanhToan.ValueMember = "Value";
            loadTTHoaDon();
        }

        public void loadTTHoaDon()
        {
            hoadon hd = bll_hoadon.findHoaDon(MaHD);
            nguoidung nd = bll_nguoidung.findNguoiDungTheoMa(maKH);
            txtTenKH.Text = nd.TENND;
            txtSoDienThoai.Text =nd.SODIENTHOAI;
            txtSoLuong.Text = hd.SOLUONG.ToString();
            txtTongTien.Text = hd.TONGTIEN.ToString();
        }
    }
}