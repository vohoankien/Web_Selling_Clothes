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
    public partial class frmQuenMatKhau : DevExpress.XtraEditors.XtraForm
    {
        private taikhoanuser tk;
        BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();
        public frmQuenMatKhau()
        {
            InitializeComponent();
            this.Load += FrmQuenMatKhau_Load;
            this.btnXacThuc.Click += BtnXacThuc_Click;
            this.btnDoiMatKhau.Click += BtnDoiMatKhau_Click;
            this.FormClosing += FrmQuenMatKhau_FormClosing;
            this.btnThoat.Click += BtnThoat_Click;
        }

  

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void FrmQuenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                e.Cancel = true;
        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(txtMatKhauMoi.Text == "" || txtNhapLaiMatKhau.Text == "")
            {
                XtraMessageBox.Show("Điền đầy đủ thông tin!!!");
                return;
            }    
            else
            {
                if(txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
                {
                    XtraMessageBox.Show("Mật khẩu chưa khớp!!!");
                    return;
                }
                taikhoanuser tk = bll_taikhoan.findTaiKhoanTheoTen(txtTenTaiKhoan.Text);
               
                taikhoanuser temp = new taikhoanuser();
                temp.TENTK = tk.TENTK;
                temp.MATKHAU = bll_taikhoan.hashPassword(txtNhapLaiMatKhau.Text);
                temp.MAQUYEN = tk.MAQUYEN;
                bool kq = bll_taikhoan.updateTaiKhoan(temp, tk);
                if(!kq)
                {
                    XtraMessageBox.Show("Đổi mật khẩu không thành công, Liên hệ quản trị viên");
                    return;
                }
                XtraMessageBox.Show("Đổi mật khẩu thành công!!!");
                this.Close();

            }
        }
            
        private void BtnXacThuc_Click(object sender, EventArgs e)
        {
            if(txtTenTaiKhoan.Text==""||txtEmail.Text=="")
            {
                XtraMessageBox.Show("Điền đầy đủ thông tin!!!");
                return;
            }    
            else
            {
                taikhoanuser   tk = bll_taikhoan.findTaiKhoanTheoTenvaEmail(txtTenTaiKhoan.Text);
                if (tk== null || txtEmail.Text != tk.Email)
                {

                    XtraMessageBox.Show("Tài khoản không tồn tại!!!");
                    return;
                }
                btnDoiMatKhau.Enabled = true;
                txtMatKhauMoi.Enabled = true;
                txtNhapLaiMatKhau.Enabled = true;

            }    

        }

        
        private void FrmQuenMatKhau_Load(object sender, EventArgs e)
        {
            txtMatKhauMoi.PasswordChar = '*';
            txtNhapLaiMatKhau.PasswordChar = '*';
            btnDoiMatKhau.Enabled = false;
            txtMatKhauMoi.Enabled = false;
            txtNhapLaiMatKhau.Enabled = false;
        }   
    }
}