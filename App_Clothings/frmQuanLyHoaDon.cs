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
using DevExpress.Data.Linq.Helpers;
namespace App_Clothings
{
    public partial class frmQuanLyHoaDon : DevExpress.XtraEditors.XtraForm
    {
        BLL_HoaDon bll_hoadon = new BLL_HoaDon();
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
            this.Load += FrmQuanLyHoaDon_Load;
            this.dtgvHoaDon.CellClick += DtgvHoaDon_CellClick;
            this.btnTimKiem.Click += BtnTimKiem_Click;
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
           IQueryable hd = bll_hoadon.findHoaDonKhachHang(txtTenKH.Text);
            if(hd == null || hd.Count() == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dtgvHoaDon.DataSource = null;
            dtgvHoaDon.DataSource = hd;
            loadDataHoaDon(dtgvHoaDon);
        }

        private void DtgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvHoaDon.Rows[e.RowIndex];
                txtMaHoaDon.Text = row.Cells["MAHD"].Value.ToString();
                txtTenKhachHang.Text = row.Cells["TENND"].Value.ToString();
                txtTongTien.Text = row.Cells["TONGTIEN"].Value.ToString();
                dtpkNgayDat.Text = row.Cells["NGAYDATHANG"].Value.ToString();
                txtSoLuong.Text = row.Cells["SOLUONG"].Value.ToString();
                int tinhTrangValue = Convert.ToInt32(row.Cells["TINHTRANG"].Value);
                cbTinhTrang.SelectedValue = tinhTrangValue;
            }
        }

        private void FrmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dtgvHoaDon.DataSource = bll_hoadon.getAllHoaDonKhachHang();
            loadDataHoaDon(dtgvHoaDon);
            loadTinhTrang();
        }

        public void loadTinhTrang()
        {
            var lst = new List<object>
            {
            new { Text = "Chưa thanh toán", Value = 0 },
            new { Text = "Đã thanh toán", Value = 1 }
            };
            cbTinhTrang.DataSource = lst;
            cbTinhTrang.DisplayMember = "Text";
            cbTinhTrang.ValueMember = "Value";
        }


        public void loadDataHoaDon(DataGridView dt)
        {
            dt.Columns["MAHD"].HeaderText = "Mã hoá đơn";
            dt.Columns["TENND"].HeaderText = "Tên người dùng";
            dt.Columns["SOLUONG"].HeaderText = "Số lượng ";
            dt.Columns["NGAYDATHANG"].HeaderText = "Ngày đặt hàng";
            dt.Columns["TONGTIEN"].HeaderText = "Tổng tiền";
            dt.Columns["TINHTRANG"].Visible = false;
        }
    }
}