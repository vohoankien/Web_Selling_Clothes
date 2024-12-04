using BLL;
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
using ThuVien.ThietKeConTrols;

namespace App_Clothings
{
    public partial class frmQuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();
        BLL_NguoiDung bll_nguoidung = new BLL_NguoiDung();
        BLL_PhanQuyen bll_phanquyen = new BLL_PhanQuyen();
        BLL_ThongTinAdmin bll_admin = new BLL_ThongTinAdmin();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            this.Load += FrmQuanLyNhanVien_Load;
            this.uc_ChucNangNangCao.BtnThemClicked += uc_ChucNangNangCao_BtnThemClicked;
            this.uc_ChucNangNangCao.BtnRefreshClicked += uc_ChucNangNangCao_BtnRefreshClicked;
            this.dtgvNhanVien.CellClick += DtgvNhanVien_CellClick;
            this.uc_ChucNangNangCao.BtnXoaClicked += uc_ChucNangNangCao_BtnXoaClicked;
            this.uc_ChucNangNangCao.BtnSuaClicked += uc_ChucNangNangCao_BtnSuaClicked;
        }

       

        string maquyen;
   

        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadTaiKhoan();
            loadCbQuyen();  
        }


        private void uc_ChucNangNangCao_BtnSuaClicked(object sender, EventArgs e)
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
                thongtinadmin nd = bll_admin.findThongTinAdmin(matk);
                taikhoanuser tk_temp = new taikhoanuser();
                tk_temp.MAUSER = matk;
                tk_temp.TENTK = txtTenTK.Text;
                tk_temp.MAQUYEN = cbQuyen.SelectedValue.ToString();
               tk_temp.MATKHAU = tk.MATKHAU ;
                bool kqtk = bll_taikhoan.updateTaiKhoan(tk_temp, tk);
                if (!kqtk)
                {
                    MessageBox.Show("sửa tài khoản không thành công");
                    return;
                }
                thongtinadmin nd_temp = new thongtinadmin();
                nd_temp.TENNV = txtHoTen.Text;
                nd_temp.EMAIL = txtEmail.Text;
                nd_temp.DIACHI = txtDiaChi.Text;
                nd_temp.SODIENTHOAI = txtSoDienThoai.Text;
                nd_temp.MAUSER = nd.MAUSER;
                bool kqnd = bll_admin.updateThongTinAdmin(nd_temp, nd);
                if (!kqnd)
                {
                    MessageBox.Show("Sửa người dùng không thành công");
                    return;
                }
                MessageBox.Show("Sửa tài khoản thành công");
                loadTaiKhoan();
            }

        }

        private void uc_ChucNangNangCao_BtnXoaClicked(object sender, EventArgs e)
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
                thongtinadmin nd = bll_admin.findThongTinAdmin(matk);
                bool kqnd = bll_admin.deleteThongTinAdmin(nd);
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
            txtTenTK.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtMaTK.Text = bll_taikhoan.createAutoMaQuyen();
        }

        private void uc_ChucNangNangCao_BtnRefreshClicked(object sender, EventArgs e)
        {
            clearTextBox();
            txtTenTK.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtHoTen.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMaTK.Text = bll_taikhoan.createAutoMaQuyen();
        }

        private void uc_ChucNangNangCao_BtnThemClicked(object sender, EventArgs e)
        {
            
            taikhoanuser tk = new taikhoanuser();
            tk.TENTK = txtTenTK.Text;
            string s = txtMaTK.Text;
            tk.MAUSER = s;
            tk.MATKHAU = bll_taikhoan.hashPassword("Admin@140703");
            tk.MAQUYEN = maquyen;
            bool kq = bll_taikhoan.insertTaiKhoan(tk);
            if (!kq)
            {
                MessageBox.Show("Tài khoản đã tồn tại!");
                clearTextBox();
                return;
            }
            thongtinadmin nd = new thongtinadmin();
            nd.MAUSER = s;
            nd.TENNV = txtHoTen.Text;
            nd.DIACHI = txtDiaChi.Text;
            nd.SODIENTHOAI = txtSoDienThoai.Text;
            nd.EMAIL = txtEmail.Text;
            bool kqnd = bll_admin.insertAdmin(nd);
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

        public void loadTaiKhoan()
        {
            dtgvNhanVien.DataSource = bll_admin.getAllAdmin();
            dtgvNhanVien.Columns["MAUSER"].HeaderText = "Mã tài khoản";
            dtgvNhanVien.Columns["TENTK"].HeaderText = "Tên tài khoản";
            dtgvNhanVien.Columns["TENNV"].HeaderText = "Tên nhân viên";
            dtgvNhanVien.Columns["EMAIL"].HeaderText = "Email";
            dtgvNhanVien.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dtgvNhanVien.Columns["SODIENTHOAI"].HeaderText = "Số điện thoại";
            dtgvNhanVien.Columns["MAQUYEN"].Visible = false ;

        }
        private void DtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvNhanVien.Rows[e.RowIndex];

                // Gán giá trị của từng cột vào TextBox tương ứng
                txtMaTK.Text = row.Cells["MAUSER"].Value.ToString();
                txtTenTK.Text = row.Cells["TENTK"].Value.ToString();
                txtHoTen.Text = row.Cells["TENNV"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SODIENTHOAI"].Value.ToString();
                // Lấy mã quyền từ DataGridView
                string maQuyen = row.Cells["MAQUYEN"].Value.ToString();
                // Gán mã quyền vào ComboBox
                cbQuyen.SelectedValue = maQuyen;

            }
        }

        public void loadCbQuyen()
        {
            cbQuyen.DataSource = bll_phanquyen.getQuyenNhanVien();
            cbQuyen.DisplayMember = "TENQUYEN";
            cbQuyen.ValueMember = "MAQUYEN";
        }

    }
}