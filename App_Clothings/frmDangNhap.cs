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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();

        public frmDangNhap()
        {
            InitializeComponent();
            this.Load += FrmDangNhap_Load;
         //   this.FormClosing += FrmDangNhap_FormClosing;
            btnThoat.Click += BtnThoat_Click;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult dr;
        //    dr = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (dr == DialogResult.No)
        //        e.Cancel = true;
        //}

      

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

       
    }
}