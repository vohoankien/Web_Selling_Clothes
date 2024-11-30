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
            this.tabControl1.Dock = DockStyle.Fill;
            this.tabControl1.ItemSize = new Size(170, 30);
            this.tabControl1.DrawItem += TabControl1_DrawItem;
            this.tabControl1.MouseDown += TabControl1_MouseDown;
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
            TabPage tabPage = new TabPage("Quản lý khuyến mãi");
            showForm(frm, tabPage);
        }

        private void BtnQuanLySanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuanLySanPham frm = new frmQuanLySanPham();
            TabPage tabPage = new TabPage("Quản lý sản phẩm");
            showForm(frm, tabPage);
        }

        private void BtnQuanLyNhanHieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThuongHieu frm = new frmThuongHieu();
            TabPage tabPage = new TabPage();
            showForm(frm, tabPage);
        }

        private void BtnQuanLyLoaiSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLoaiSanPham frm = new frmLoaiSanPham();
            TabPage tabPage = new TabPage();    
            showForm(frm, tabPage); 
        }

        private void TabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                // Lấy vị trí của Tab
                Rectangle tabRect = tabControl1.GetTabRect(i);

                // Xác định khu vực nút đóng (nằm ở bên phải)
                Rectangle closeButton = new Rectangle(tabRect.Right - 20, tabRect.Top + 5, 15, 15);

                // Kiểm tra nếu click vào nút đóng
                if (closeButton.Contains(e.Location))
                {
                    tabControl1.TabPages.RemoveAt(i); // Đóng Tab
                    break;
                }
            }
        }


        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Lấy thông tin tiêu đề Tab
            string tabText = tabControl1.TabPages[e.Index].Text;

            // Tính toán khoảng cách giữa chữ và nút đóng
            int closeButtonWidth = 20; // Kích thước nút đóng (chiều rộng)
            int textPadding = 5;      // Khoảng cách giữa chữ và biên trái

            // Vẽ tiêu đề Tab với khoảng cách phù hợp
            Rectangle tabRect = e.Bounds;
            Rectangle textRect = new Rectangle(tabRect.Left + textPadding, tabRect.Top + 5,
                                               tabRect.Width - closeButtonWidth - textPadding, tabRect.Height);

            e.Graphics.DrawString(tabText, e.Font, Brushes.Black, textRect);

            // Vẽ nút đóng ở góc phải Tab
            Rectangle closeButton = new Rectangle(tabRect.Right - closeButtonWidth, tabRect.Top + 5, 15, 15);
            e.Graphics.DrawRectangle(Pens.Black, closeButton); // Vẽ viền nút đóng
            e.Graphics.DrawString("X", e.Font, Brushes.Black, closeButton.Left + 3, closeButton.Top);
        }


        private void BtnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuanLyKho frm = new frmQuanLyKho();
            TabPage tabPage = new TabPage("Quản lý kho");
            showForm(frm, tabPage);
        }

        public void showForm(Form formCon,TabPage tabPage)
        {
            formCon.TopLevel = false;
            formCon.Dock = DockStyle.Fill;
            formCon.FormBorderStyle = FormBorderStyle.None;
            tabPage.Controls.Add(formCon);
            formCon.Show();
            // Thêm TabPage vào TabControl
            tabControl1.TabPages.Add(tabPage);
            tabControl1.SelectedTab = tabPage; // Chuyển đến Tab vừa tạo
        }

        private void BtnQuanLyTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabPage tabPage = new TabPage("Quản lý tài khoản");
            frmQuanLyTaiKhoan formCon = new frmQuanLyTaiKhoan();
            showForm(formCon, tabPage);

        }

        private void btnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabPage tabPage = new TabPage("Quản lý bán hàng");
            frmBanHang formCon = new frmBanHang();
            showForm(formCon, tabPage);
        }
    }
}