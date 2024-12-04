using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;
namespace App_Clothings
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();
        BLL_PhanQuyen bll_quyen = new BLL_PhanQuyen();
        public Main()
        {
            InitializeComponent();
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            // Điều chỉnh chiều cao form bằng chiều cao màn hình
            this.Height = screenHeight;

            this.btnQuanLyLoaiSanPham.ItemClick += BtnQuanLyLoaiSanPham_ItemClick;
            this.btnQuanLyNhanHieu.ItemClick += BtnQuanLyNhanHieu_ItemClick;
            this.btnQuanLySanPham.ItemClick += BtnQuanLySanPham_ItemClick;
            this.btnKhuyenMai.ItemClick += BtnKhuyenMai_ItemClick;
            this.btnDoanhThu.ItemClick += BtnDoanhThu_ItemClick;
            this.btnKhachHang.ItemClick += BtnKhachHang_ItemClick;
            this.Load += Main_Load;
            this.FormClosing += Main_FormClosing;
            this.btnQLHoaDon.ItemClick += BtnQLHoaDon_ItemClick;
            this.btnDangNhap.ItemClick += BtnDangNhap_ItemClick;
            this.btnDXuat.ItemClick += BtnDXuat_ItemClick;
            this.btnQLNhanVien.ItemClick += BtnQLNhanVien_ItemClick;
            this.btnQLKhacHang.ItemClick += BtnQLKhacHang_ItemClick;
            this.btnQuenMK.ItemClick += BtnQuenMK_ItemClick;
            
        }

        private void CenterFormInParent(XtraForm formCon)
        {
            int parentWidth = this.Width;
            int parentHeight = this.Height;

            int formConWidth = formCon.Width;
            int formConHeight = formCon.Height;

            int left = (parentWidth - formConWidth) / 2;
            int top = (parentHeight - formConHeight) / 2;

            // Đặt vị trí cho form con
            formCon.Location = new Point(left, top);
        }

        private void BtnQuenMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuenMatKhau frm = new frmQuenMatKhau();
            frm.MdiParent = this;
            CenterFormInParent(frm);
            frm.Show();

        }

        private void BtnQLKhacHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuanLyNguoiDung frm = new frmQuanLyNguoiDung();
            frm.MdiParent = this;
            CenterFormInParent(frm);

            frm.Show();
        }

        private void BtnQLNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
            frm.MdiParent = this;
            CenterFormInParent(frm);

            frm.Show();
        }

        private void BtnDXuat_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (XtraMessageBox.Show("Bạn có muốn đăng xuất hay không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                checkAdmin(true, idLogin);
                BtnDangNhap_ItemClick(sender, e);
            }
        }

        private void BtnQLHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuanLyHoaDon frm = new frmQuanLyHoaDon();
            frm.MdiParent = this;
            CenterFormInParent(frm);
            frm.Show();
        }

        public string idLogin;

        private void checkNhanVien(bool e, string idLogin)
        {
            btnDangNhap.Enabled = e;
            btnQuenMK.Enabled = e;
            btnDangXuat.Enabled = !e;
            btnDXuat.Enabled = !e;
            btnDoanhThu.Enabled = !e;
            btnDoiMK.Enabled = !e;
            btnQuanLyLoaiSanPham.Enabled = false;
            btnKhuyenMai.Enabled = false;
            btnQLNhanVien.Enabled = false;
            btnQLKhacHang.Enabled = !e;
            btnQuanLySanPham.Enabled = !e;
            btnKhachHang.Enabled = !e;
            btnQuanLyNhanHieu.Enabled = false;
            btnDoiMK.Enabled = !e;
            btnDoiMatKhau.Enabled = !e;
            btnQLHoaDon.Enabled = !e;
            btnBanHang.Enabled = !e; 
        }
        private void checkAdmin(bool e, string idLogin)
        {
            btnDangNhap.Enabled = e;
            btnQuenMK.Enabled = e;

            btnDangXuat.Enabled = !e;
            btnDXuat.Enabled = !e;
            btnDoanhThu.Enabled = !e;
            btnDoiMK.Enabled = !e;
            btnNhanVien.Enabled = !e;
            btnQLNhanVien.Enabled = !e;
            btnQLKhacHang.Enabled = !e;
            btnQuanLyLoaiSanPham.Enabled = !e;
            btnKhuyenMai.Enabled = !e;
            btnQuanLyTaiKhoan.Enabled = !e;
            btnKhachHang.Enabled = !e;
            btnQuanLyNhanHieu.Enabled = !e;
            btnDoiMK.Enabled = !e;
            btnDoiMatKhau.Enabled = !e;
            btnQLHoaDon.Enabled = !e;
            btnBanHang.Enabled = !e;
        }



        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ? ","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                e.Cancel = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            checkAdmin(true, idLogin);
            frmThongKeDT frm = new frmThongKeDT();
            frm.MdiParent = this;
            CenterFormInParent(frm);
            frm.Show();
        
            DevExpress.LookAndFeel.DefaultLookAndFeel theme = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            theme.LookAndFeel.SkinName = "Basic";
        }

        private void BtnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongKeKhachHang frm = new frmThongKeKhachHang();
            frm.MdiParent = this;
            CenterFormInParent(frm);
            frm.Show();
        }

        private void BtnDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongKeDT frm = new frmThongKeDT();
            frm.MdiParent = this;
            CenterFormInParent(frm);
            frm.Show();
        }

        private void BtnKhuyenMai_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKhuyenMai frm = new frmKhuyenMai();
            frm.MdiParent = this;
            CenterFormInParent(frm);
            frm.Show();
        }

        private void BtnQuanLySanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQLSanPham frm = new frmQLSanPham();
            frm.MdiParent = this;
            CenterFormInParent(frm);
            frm.Show();
        }

        private void BtnQuanLyNhanHieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTHieu frm = new frmTHieu();
            frm.MdiParent = this;
            CenterFormInParent(frm);
            frm.Show();
        }

        private void BtnQuanLyLoaiSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLSP frm = new frmLSP();
            frm.MdiParent = this;
            CenterFormInParent(frm);
            frm.Show();
        }

    
    


        private void btnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            frm.MdiParent = this;
            CenterFormInParent(frm);
            frm.Show();
        }

        private void BtnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {

            frmDangNhap frm = new frmDangNhap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.txtTenTaiKhoan.Text == "" || frm.txtMatKhau.Text == "")
                {
                    XtraMessageBox.Show("Điền đầy đủ thông tin!!!");
                    return;
                }
                taikhoanuser tk = bll_taikhoan.findTaiKhoanTheoTen(frm.txtTenTaiKhoan.Text);
                if (tk == null)
                {
                    XtraMessageBox.Show("Không tìm thấy tài khoản này!!!");
                    return;
                }
                bool kq = bll_taikhoan.verifyPassword(frm.txtMatKhau.Text, tk.MATKHAU);
                if(!kq)
                {
                    XtraMessageBox.Show("Đăng nhập không thành công!!!");
                    return;
                }
                XtraMessageBox.Show("Đăng nhập thành công!!!");
                nhomquyen nq = bll_quyen.findMaQuyen(tk.MAQUYEN);
                if(nq.TENQUYEN == "Nhân Viên")
                {
                    checkNhanVien(false, tk.MAUSER);
                    MaNV.Caption = tk.MAUSER;
                }
                else if(nq.TENQUYEN == "Admin") 
                { 
                    checkAdmin(false, tk.MAUSER);
                    MaNV.Caption = tk.MAUSER;

                }

                else
                {     
                    XtraMessageBox.Show("Tài khoản không đủ quyền hạn!!");
                    return;
                }
            }
            
        }
    }
}