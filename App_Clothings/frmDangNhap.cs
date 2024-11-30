using BLL;
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
    public partial class frmDangNhap : Form
    {
        BLL_TaiKhoan bll_TaiKhoan = new BLL_TaiKhoan();
        public frmDangNhap()
        {
            InitializeComponent();
            ucDangNhap.BtnDangNhapClicked += UcDangNhap_BtnDangNhapClicked;
        }

        private void UcDangNhap_BtnDangNhapClicked(object sender, EventArgs e)
        {
            if(ucDangNhap.TenDN =="")
            {
                MessageBox.Show("Hãy điền tên đăng nhập");
                return ;
            }
            taikhoanuser tk = bll_TaiKhoan.findTaiKhoanTheoTen(ucDangNhap.TenDN);
            if(tk == null)
            {
                MessageBox.Show("Không tim thấy thông tin đăng nhập");
                return;
            }
            bool kq = bll_TaiKhoan.verifyPassword(ucDangNhap.MatKhau,tk.MATKHAU);
            if(kq)
            {
                MessageBox.Show("Đăng nhập thành công");
            }    
            else
            {
                MessageBox.Show("Đăng nhập không thành công!! Kiểm tra lại thông tin đăng nhập");

            }    
        }

        
    }
}
