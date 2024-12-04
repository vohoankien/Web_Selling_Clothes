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
namespace App_Clothings
{
    public partial class frmQuanLyNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();
        BLL_NguoiDung bll_nguoidung = new BLL_NguoiDung();
        BLL_PhanQuyen bll_phanquyen = new BLL_PhanQuyen();
        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
            this.Load += FrmQuanLyNguoiDung_Load;
            this.uc_ChucNangCoBan.BtnThemClicked += uc_ChucNangCoBan_BtnThemClicked;
            this.uc_ChucNangCoBan.BtnRefreshClicked += uc_ChucNangCoBan_BtnRefreshClicked;
            this.uc_ChucNangCoBan.BtnXoaClicked += uc_ChucNangCoBan_BtnXoaClicked;
            this.uc_ChucNangCoBan.BtnSuaClicked += uc_ChucNangCoBan_BtnSuaClicked;
            this.dtgvKhachHang.CellClick += DtgvKhachHang_CellClick;
        }

        private void DtgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvKhachHang.Rows[e.RowIndex];

                // Gán giá trị của từng cột vào TextBox tương ứng
                txtMaTK.Text = row.Cells["MAUSER"].Value.ToString();
                txtTenTK.Text = row.Cells["TENTK"].Value.ToString();
                txtHoTen.Text = row.Cells["TENND"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SODIENTHOAI"].Value.ToString();
            }
        }

        private void uc_ChucNangCoBan_BtnSuaClicked(object sender, EventArgs e)
        {

            if (txtMaTK.Text == "")
            {
                MessageBox.Show("Hãy chọn tài khoản cần sửa");
                return;
            }
            else
            {
                string matk = txtMaTK.Text;
                taikhoanuser tk = bll_taikhoan.findTaiKhoan(matk);
                nguoidung nd = bll_nguoidung.findNguoiDung(matk);
                nhomquyen quyen = bll_phanquyen.findQuyen("Khách Hàng");

                taikhoanuser tk_temp = new taikhoanuser();
                tk_temp.MAUSER = matk;
                tk_temp.TENTK = txtTenTK.Text;
                tk_temp.MAQUYEN = quyen.MAQUYEN;
                if (txtMatKhau.Text != "")
                    tk_temp.MATKHAU = bll_taikhoan.hashPassword(txtMatKhau.Text);
                else
                {
                    tk_temp.MATKHAU = tk.MATKHAU;
                }
                bool kqtk = bll_taikhoan.updateTaiKhoan(tk_temp, tk);
                if (!kqtk)
                {
                    MessageBox.Show("sửa tài khoản không thành công");
                    return;
                }
                nguoidung nd_temp = new nguoidung();
                nd_temp.MAND = nd.MAND;
                nd_temp.TENND = txtHoTen.Text;
                nd_temp.EMAIL = txtEmail.Text;
                nd_temp.DIACHI = txtDiaChi.Text;
                nd_temp.SODIENTHOAI = txtSoDienThoai.Text;
                nd_temp.MAUSER = nd.MAUSER;
                bool kqnd = bll_nguoidung.updateNguoiDung(nd_temp, nd);
                if (!kqnd)
                {
                    MessageBox.Show("Sửa người dùng không thành công");
                    return;
                }
                MessageBox.Show("Sửa tài khoản thành công");
                loadTaiKhoan();

            }

        }

        private void uc_ChucNangCoBan_BtnXoaClicked(object sender, EventArgs e)
        {
            if (txtMaTK.Text == "")
            {
                MessageBox.Show("Hãy chọn tài khoản cần xoá");
                return;
            }
            else
            {
                string matk = txtMaTK.Text;
                taikhoanuser tk = bll_taikhoan.findTaiKhoan(matk);
                nguoidung nd = bll_nguoidung.findNguoiDung(matk);
                bool kqnd = bll_nguoidung.deleteNguoiDung(nd);
                if (!kqnd)
                {
                    MessageBox.Show("Xoá người dùng không thành công");
                    return;
                }
                bool kqtk = bll_taikhoan.deleteTaiKhoan(tk);

                if (!kqtk)
                {
                    MessageBox.Show("Xoá tài khoản không thành công");
                    return;
                }

                MessageBox.Show("Xoá tài khoản thành công");
                loadTaiKhoan();

            }
        }

        public void clearTextBox()
        {
            txtMaTK.Clear();
            txtMatKhau.Clear();
            txtTenTK.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();

        }

        private void uc_ChucNangCoBan_BtnRefreshClicked(object sender, EventArgs e)
        {
            clearTextBox();
            txtMatKhau.Enabled = true;
            txtTenTK.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtHoTen.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMaTK.Text = bll_taikhoan.createAutoMaQuyen();
        }

        private void uc_ChucNangCoBan_BtnThemClicked(object sender, EventArgs e)
        {
            nhomquyen quyen = bll_phanquyen.findQuyen("Khách Hàng");
            taikhoanuser tk = new taikhoanuser();
            tk.TENTK = txtTenTK.Text;
            string s = txtMaTK.Text;
            tk.MAUSER = s;
            tk.MATKHAU = bll_taikhoan.hashPassword(txtMatKhau.Text);
            tk.MAQUYEN = quyen.MAQUYEN;
            bool kq = bll_taikhoan.insertTaiKhoan(tk);
            if (!kq)
            {
                MessageBox.Show("Tài khoản đã tồn tại!");
                clearTextBox();
                return;
            }
            nguoidung nd = new nguoidung();
            nd.MAND = bll_nguoidung.createMaNguoiDung();
            nd.MAUSER = s;
            nd.TENND = txtHoTen.Text;
            nd.DIACHI = txtDiaChi.Text;
            nd.SODIENTHOAI = txtSoDienThoai.Text;
            nd.EMAIL = txtEmail.Text;
            bool kqnd = bll_nguoidung.insertNguoiDung(nd);
            if (kqnd && kq)
            {
                MessageBox.Show("Thêm thông tin tài khoản thành công");
                clearTextBox();
                loadTaiKhoan();
            }
            else
            {
                MessageBox.Show("Thêm thông tin tài khoản thất bại");
                clearTextBox();
            }

        }
        private void FrmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            loadTaiKhoan();
        }

        public void loadTaiKhoan()
        {
            dtgvKhachHang.DataSource = bll_taikhoan.getAllTaiKhoan();
            dtgvKhachHang.Columns["MAUSER"].HeaderText = "Mã tài khoản";
            dtgvKhachHang.Columns["TENTK"].HeaderText = "Tên tài khoản";
            dtgvKhachHang.Columns["TENND"].HeaderText = "Tên người dùng";
            dtgvKhachHang.Columns["EMAIL"].HeaderText = "Email";
            dtgvKhachHang.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dtgvKhachHang.Columns["SODIENTHOAI"].HeaderText = "Số điện thoại";
        }
    }
}