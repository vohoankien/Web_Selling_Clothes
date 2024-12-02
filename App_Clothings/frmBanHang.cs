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
        BLL_ChiTietHoaDon bll_chitiethoadon = new BLL_ChiTietHoaDon();
        BLL_Size bll_size = new BLL_Size();

        string mahd;
        public frmBanHang()
        {
            InitializeComponent();
            this.Load += FrmBanHang_Load;
            this.dtgvKhachHang.CellClick += DtgvKhachHang_CellClick;
            this.btnXacNhan.Click += BtnXacNhan_Click;
            this.btnRefresh.Click += BtnRefresh_Click;
            this.btnAdd.Click += BtnAdd_Click;
 
            this.dtgvDanhSachDat.CellEndEdit += DtgvDanhSachDat_CellEndEdit;
            this.btnMuaHang.Click += BtnMuaHang_Click;
        }

        private void BtnMuaHang_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.MaHD = mahd;
            frm.MaKH = txtMaKhachHang.Text;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private async void DtgvDanhSachDat_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            string macthd = dtgvDanhSachDat.Rows[rowIndex].Cells["MACTHD"].Value.ToString();
            chitiethoadon cthd = bll_chitiethoadon.findCTHD(macthd);

            if (dtgvDanhSachDat.Columns[columnIndex].Name == "SIZE")
            {
                string newValue = dtgvDanhSachDat.Rows[rowIndex].Cells[columnIndex].Value.ToString();
                bool kq = await bll_chitiethoadon.UpdateSizeChiTietHoaDonAsync(newValue, cthd);
                if (!kq)
                {
                    MessageBox.Show("Cập nhật size không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Cập nhật size thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadSanPhamDat();
            }
            else if (dtgvDanhSachDat.Columns[columnIndex].Name == "SOLUONG")
            {
                int newValue = int.Parse(dtgvDanhSachDat.Rows[rowIndex].Cells[columnIndex].Value.ToString());
                bool kq = await bll_chitiethoadon.updateSoLuongChiTietHoaDon(newValue, cthd);
                if (!kq)
                {
                    MessageBox.Show("Cập nhật số lượng không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Cập nhật số lượng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadSanPhamDat();
            }
        }

   

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(dtgvSanPham.SelectedRows.Count>0)
            {
                DataGridViewRow selectedRow = dtgvSanPham.SelectedRows[0];
                chitiethoadon ct = new chitiethoadon();
                ct.MACTHD = bll_chitiethoadon.GenerateMaChiTietHoaDon();
                ct.MASP= selectedRow.Cells["MASP"].Value.ToString();
                ct.MAHD = mahd;
                ct.TINHTRANG = 1;
                ct.SIZE = bll_size.getSizeFirst(ct.MASP);
                ct.SOLUONG = 1;
                bool kq = bll_chitiethoadon.insertChiTietHoaDon(ct);
                if(!kq)
                {
                    MessageBox.Show("Thêm sản phẩm vào danh sách không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Xác nhận thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadSanPhamDat();

                btnMuaHang.Enabled = true;
            }
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

            hoadon hoadon = bll_hoadon.findHoaDon(mahd);
            bll_hoadon.deleteHoaDon(hoadon);
            btnXacNhan.Enabled = true;
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
            btnXacNhan.Enabled = false;
            mahd = hd.MAHD;
            txtHoTen.Enabled = false;
            txtEmail.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtTaiKhoan.Enabled = false;
            txtMaKhachHang.Enabled = false;
            btnRefresh.Enabled = true;
            dtgvSanPham.Enabled = true;
            dtgvDanhSachDat.Enabled = true;
            btnRemove.Enabled = true;
            btnAdd.Enabled = true;
            btnHuyDonHang.Enabled = true;
            loadSanPhamDat();

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
            dtgvDanhSachDat.DataSource = bll_chitiethoadon.getAllChiTietHoaDon(mahd);
            dtgvDanhSachDat.Columns["MACTHD"].HeaderText = "Mã chi tiết hoá đơn";
            dtgvDanhSachDat.Columns["MASP"].HeaderText = "Mã sản phẩm";
            dtgvDanhSachDat.Columns["MAHD"].Visible = false;
            dtgvDanhSachDat.Columns["SIZE"].HeaderText = "Size";
            dtgvDanhSachDat.Columns["SIZE"].ReadOnly = false;
            dtgvDanhSachDat.Columns["SOLUONG"].HeaderText = "Số lượng";
            dtgvDanhSachDat.Columns["SOLUONG"].ReadOnly = false;
            dtgvDanhSachDat.Columns["THANHTIEN"].HeaderText = "Thành tiền";
            dtgvDanhSachDat.Columns["TINHTRANG"].Visible = false;

        }

        
    }
}