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
using System.Security.Cryptography;
namespace App_Clothings
{
    public partial class frmQuanLyTaiKhoan : Form
    {

        BLL_PhanQuyen bll_Quyen = new BLL_PhanQuyen();
        BLL_TaiKhoan bll_TaiKhoan = new BLL_TaiKhoan();
        BLL_NguoiDung bll_NguoiDung = new BLL_NguoiDung();
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            this.Load += FrmQuanLyTaiKhoan_Load;
            this.ucQLQuyen.BtnThemClicked += UcQLQuyen_BtnThemClicked;
            this.ucQLQuyen.BtnXoaClicked += UcQLQuyen_BtnXoaClicked;
            this.ucQLQuyen.BtnSuaClicked += UcQLQuyen_BtnSuaClicked;
            this.dtgvQLTaiKhoan.CellClick += DtgvQLTaiKhoan_CellClick;
            this.ucChucNangNC.BtnThemClicked += UcChucNangNC_BtnThemClicked;
            this.ucChucNangNC.BtnClearClicked += UcChucNangNC_BtnClearClicked;
            this.ucChucNangNC.BtnXoaClicked += UcChucNangNC_BtnXoaClicked;
            this.ucChucNangNC.BtnSuaClicked += UcChucNangNC_BtnSuaClicked;
        }

        private void UcChucNangNC_BtnSuaClicked(object sender, EventArgs e)
        {

            if (txtMaTK.Text == "")
            {
                MessageBox.Show("Hãy chọn tài khoản cần sửa");
                return;
            }
            else
            {
                string matk = txtMaTK.Text;
                taikhoanuser tk = bll_TaiKhoan.findTaiKhoan(matk);
                nguoidung nd = bll_NguoiDung.findNguoiDung(matk);

                taikhoanuser tk_temp = new taikhoanuser();
                tk_temp.MAUSER = matk;
                tk_temp.TENTK = txtTenTK.Text;
                tk_temp.MAQUYEN = ucQLQuyen.ComboQuyen.SelectedValue.ToString();
                if(txtMatKhau.Text != "")
                    tk_temp.MATKHAU = bll_TaiKhoan.hashPassword(txtMatKhau.Text);
                else
                {
                    tk_temp.MATKHAU = tk.MATKHAU;
                }
                bool kqtk = bll_TaiKhoan.updateTaiKhoan(tk_temp, tk);
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
                nd_temp.SODIENTHOAI =txtSoDienThoai.Text;
                nd_temp.MAUSER = nd.MAUSER;
                bool kqnd = bll_NguoiDung.updateNguoiDung(nd_temp, nd);
                if (!kqnd)
                {
                    MessageBox.Show("Sửa người dùng không thành công");
                    return;
                }
                MessageBox.Show("Sửa tài khoản thành công");
                loadTaiKhoan();

            }

        }

        private void UcChucNangNC_BtnXoaClicked(object sender, EventArgs e)
        {
            if (txtMaTK.Text == "")
            {
                MessageBox.Show("Hãy chọn tài khoản cần xoá");
                return;
            }
            else
            {
                string matk = txtMaTK.Text;
                taikhoanuser tk = bll_TaiKhoan.findTaiKhoan(matk);
                nguoidung nd = bll_NguoiDung.findNguoiDung(matk);
                bool kqnd = bll_NguoiDung.deleteNguoiDung(nd);
                if (!kqnd)
                {
                    MessageBox.Show("Xoá người dùng không thành công");
                    return;
                }
                bool kqtk = bll_TaiKhoan.deleteTaiKhoan(tk);
                if (!kqtk)
                {
                    MessageBox.Show("Xoá tài khoản không thành công");
                    return;
                }

                MessageBox.Show("Xoá tài khoản thành công");
                loadTaiKhoan();

            }
        }

        private void UcChucNangNC_BtnClearClicked(object sender, EventArgs e)
        {
            
            txtMatKhau.Enabled = true;
            txtTenTK.Enabled = true;
            clearTextBox();
            txtSoDienThoai.Enabled = true;
            txtHoTen.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMaTK.Text = bll_TaiKhoan.createAutoMaQuyen();

        }

        private void UcChucNangNC_BtnThemClicked(object sender, EventArgs e)
        {
            string maquyen = ucQLQuyen.ComboQuyen.SelectedValue.ToString();
            taikhoanuser tk = new taikhoanuser();
            tk.TENTK = txtTenTK.Text;
            string s = bll_TaiKhoan.createAutoMaQuyen();
            tk.MAUSER = s;
            tk.MATKHAU = bll_TaiKhoan.hashPassword(txtMatKhau.Text);
            tk.MAQUYEN = maquyen;
            bool kq = bll_TaiKhoan.insertTaiKhoan(tk);
            if (!kq)
            {
                MessageBox.Show("Tài khoản đã tồn tại!");
                clearTextBox();
                return;
            }
            nguoidung nd = new nguoidung();
            nd.MAND = bll_NguoiDung.createMaNguoiDung();
            nd.MAUSER = s;
            nd.TENND = txtHoTen.Text;
            nd.DIACHI = txtDiaChi.Text;
            nd.SODIENTHOAI = txtSoDienThoai.Text;
            nd.EMAIL = txtEmail.Text;
            bool kqnd = bll_NguoiDung.insertNguoiDung(nd);
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

        public void clearTextBox()
        {
            txtMaTK.Clear();
            txtMatKhau.Clear();
            txtTenTK.Clear();
            txtSoDienThoai.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
        }
        private void DtgvQLTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvQLTaiKhoan.Rows[e.RowIndex];

                // Gán giá trị của từng cột vào TextBox tương ứng
                txtMaTK.Text = row.Cells["MAUSER"].Value.ToString();
                txtTenTK.Text = row.Cells["TENTK"].Value.ToString();
                txtHoTen.Text = row.Cells["TENND"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SODIENTHOAI"].Value.ToString();
            }
        }

        private void UcQLQuyen_BtnSuaClicked(object sender, EventArgs e)
        {
            string s = ucQLQuyen.ComboQuyen.SelectedValue.ToString();

            nhomquyen nq = bll_Quyen.findQuyen(s);
            string tenq = ucQLQuyen.TenQuyen;
            
                 bool kq = bll_Quyen.updateQuyen(tenq, nq);
                if (kq)
                {
                    MessageBox.Show("Sửa quyền thành công!");
                    loadQuyen();
                    ucQLQuyen.TenQuyen = "";

                }
                else
                {
                    MessageBox.Show("Sửa quyền thất bại!");
                    ucQLQuyen.TenQuyen = "";

                }
           

        }

        private void UcQLQuyen_BtnXoaClicked(object sender, EventArgs e)
        {
            string s = ucQLQuyen.ComboQuyen.SelectedValue.ToString();
            nhomquyen nq = bll_Quyen.findQuyen(s);
            bool kq = bll_Quyen.deleteQuyen(nq);
            if(kq)
            {
                MessageBox.Show("Xoá quyền thành công!");
                loadQuyen();
            }    
            else
            {
                MessageBox.Show("Xoá quyền thất bại!");
            }
        }

        private void UcQLQuyen_BtnThemClicked(object sender, EventArgs e)
        {
            string s = ucQLQuyen.TenQuyen;
            nhomquyen nq = new nhomquyen();
            nq.MAQUYEN = bll_Quyen.createAutoMaQuyen();
            nq.TENQUYEN = s;
            bool kq = bll_Quyen.insertQuyen(nq);
            if (kq)
            {
                MessageBox.Show("Thêm quyền thành công!");
                loadQuyen();
                ucQLQuyen.TenQuyen = "";
            }
            else
            {
                MessageBox.Show("Thêm quyền thất bại!");
                ucQLQuyen.TenQuyen = "";
            }
        }

       

       

        private void FrmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            loadQuyen();
            loadTaiKhoan();  
            txtMatKhau.Enabled = false;
            txtHoTen.Enabled = false;
            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTenTK.Enabled = false;
            txtSoDienThoai.Enabled = false;

        }

        public void loadQuyen()
        {
            ucQLQuyen.ComboQuyen.DataSource = bll_Quyen.getAllQuyen();
            ucQLQuyen.ComboQuyen.DisplayMember = "TENQUYEN";
            ucQLQuyen.ComboQuyen.ValueMember = "MAQUYEN";
        }

        public void loadTaiKhoan()
        {
            dtgvQLTaiKhoan.DataSource = bll_TaiKhoan.getAllTaiKhoan();
            dtgvQLTaiKhoan.Columns["MAUSER"].HeaderText = "Mã tài khoản";
            dtgvQLTaiKhoan.Columns["TENTK"].HeaderText = "Tên tài khoản";
            dtgvQLTaiKhoan.Columns["TENND"].HeaderText = "Tên người dùng";
            dtgvQLTaiKhoan.Columns["EMAIL"].HeaderText = "Email";
            dtgvQLTaiKhoan.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dtgvQLTaiKhoan.Columns["SODIENTHOAI"].HeaderText = "Số điện thoại";
            dtgvQLTaiKhoan.Columns["TENQUYEN"].HeaderText = "Tên quyền";
        }

    }
}
