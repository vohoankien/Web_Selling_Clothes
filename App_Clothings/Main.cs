using DevExpress.XtraBars;
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
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
            this.btnQuanLyTaiKhoan.ItemClick += BtnQuanLyTaiKhoan_ItemClick;
            this.btnKho.ItemClick += BtnKho_ItemClick;
            this.btnQuanLyLoaiSanPham.ItemClick += BtnQuanLyLoaiSanPham_ItemClick;
            this.btnQuanLyNhanHieu.ItemClick += BtnQuanLyNhanHieu_ItemClick;
            this.btnQuanLySanPham.ItemClick += BtnQuanLySanPham_ItemClick;
            this.btnKhuyenMai.ItemClick += BtnKhuyenMai_ItemClick;
        }

        private void BtnKhuyenMai_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuanLyKhuyenMai frm = new frmQuanLyKhuyenMai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnQuanLySanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuanLySanPham frm = new frmQuanLySanPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnQuanLyNhanHieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThuongHieu frm = new frmThuongHieu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnQuanLyLoaiSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLoaiSanPham frm = new frmLoaiSanPham();
            frm.MdiParent = this;
            frm.Show();
        }

    


       

        private void BtnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuanLyKho frm = new frmQuanLyKho();
            frm.MdiParent = this;
            frm.Show();
        }

    

        private void BtnQuanLyTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuanLyTaiKhoan frm = new frmQuanLyTaiKhoan();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}