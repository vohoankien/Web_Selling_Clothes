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
using ThuVien.ThietKeConTrols;
namespace App_Clothings
{
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        BLL_SanPham bll_sanpham = new BLL_SanPham();
        BLL_NguoiDung bll_nguoidung = new BLL_NguoiDung();
        BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan(); 
        BLL_HoaDon bll_hoadon = new BLL_HoaDon();
        string mahd;
        public frmBanHang()
        {
            InitializeComponent();
            this.Load += FrmBanHang_Load;
            this.dtgvKhachHang.CellClick += DtgvKhachHang_CellClick;
            this.btnXacNhan.Click += BtnXacNhan_Click;
            this.btnRefresh.Click += BtnRefresh_Click;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            txtTaiKhoan.Text = "";
            txtMaKhachHang.Text = "";

            dtgvSanPham.Enabled = false;
            dtgvDanhSachDat.Enabled = false;
            btnRemove.Enabled = false;
            btnAdd.Enabled = false;
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            if(txtSoDienThoai.Text ==""|| txtHoTen.Text =="" || txtEmail.Text =="" )
            {
                MessageBox.Show("Xác nhận thông tin  không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtMaKhachHang.Text =="")
            {
                taikhoanuser tk = new taikhoanuser();
                tk.MAUSER = bll_taikhoan.createAutoMaQuyen();
                tk.TENTK = txtEmail.Text;
                tk.MATKHAU = txtSoDienThoai.Text;
                bool kq = bll_taikhoan.insertTaiKhoan(tk );
                if( !kq)
                {
                    MessageBox.Show("Tạo tài khoản a  cho khách hàng không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                nguoidung nd = new nguoidung();
                nd.MAND = bll_nguoidung.createMaNguoiDung();
                nd.TENND = txtHoTen.Text;
                nd.EMAIL = txtEmail.Text;
                nd.SODIENTHOAI = txtSoDienThoai.Text;
                nd.MAUSER = tk.MAUSER;
                kq = bll_nguoidung.insertNguoiDung(nd);
                if(!kq)
                {
                    bll_taikhoan.deleteTaiKhoan(tk);
                    MessageBox.Show("Tạo tài khoản cho khách hàng không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                loadKhachHang();
                MessageBox.Show("Xác nhận thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            nguoidung nguoi = bll_nguoidung.findNguoiDung(txtMaKhachHang.Text);
            hoadon hd = new hoadon();
            hd.MAND = nguoi.MAND;
            hd.MAHD = bll_hoadon.GenerateMaHoaDon();
            bool kt = bll_hoadon.insertHoaDon(hd);
            if (!kt)
            {
                MessageBox.Show("Tạo hoá đơn cho khách hàng không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Xác nhận thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mahd = hd.MAHD;

            txtHoTen.Enabled = false;
            txtEmail.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtTaiKhoan.Enabled = false;
            txtMaKhachHang.Enabled = false;
            btnRefresh.Enabled = false;
            dtgvSanPham.Enabled = true;
            dtgvDanhSachDat.Enabled = true;
            btnRemove.Enabled = true;
            btnAdd.Enabled = true;
            btnHuyDonHang.Enabled = true;
        }

        private void DtgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvKhachHang.Rows[e.RowIndex];
                txtMaKhachHang.Text = row.Cells["MAND"].Value.ToString();
                txtHoTen.Text = row.Cells["TENND"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SODIENTHOAI"].Value?.ToString() ?? string.Empty;
                txtTaiKhoan.Text = row.Cells["MAUSER"].Value.ToString() ?? string.Empty;
            }
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            loadKhachHang();
            loadSanPham();
            loadSanPhamDat();
        }
        public void loadKhachHang()
        {
            dtgvKhachHang.DataSource = bll_nguoidung.getAllNguoiDung();
            dtgvKhachHang.Columns["MAND"].HeaderText = "Mã người dùng";
            dtgvKhachHang.Columns["TENND"].HeaderText = "Tên người dùng";
            dtgvKhachHang.Columns["EMAIL"].HeaderText = "Email";
            dtgvKhachHang.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dtgvKhachHang.Columns["SODIENTHOAI"].HeaderText = "Số điện thoại";
            dtgvKhachHang.Columns["MAUSER"].Visible = false;
        }
        public void loadSanPham()
        {
            dtgvSanPham.DataSource = bll_sanpham.getAllSanPham();
            dtgvSanPham.Columns["MASP"].HeaderText = "Mã sản phẩm";
            dtgvSanPham.Columns["TENSANPHAM"].HeaderText = "Tên sản phẩm";
            dtgvSanPham.Columns["GIA"].HeaderText = "Giá";
            dtgvSanPham.Columns["GIAGIAM"].HeaderText = "Giá giảm";
            dtgvSanPham.Columns["CHATLIEU"].HeaderText = "Chất liệu";
            dtgvSanPham.Columns["HINHANH"].Visible = false;
            dtgvSanPham.Columns["MAKM"].Visible = false;
            dtgvSanPham.Columns["MANH"].Visible = false;
            dtgvSanPham.Columns["MALOAI"].Visible = false;
        }
        public void loadSanPhamDat()
        {

        }
    }
}