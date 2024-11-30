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
    public partial class frmQuanLyKhuyenMai : Form
    {
        BLL_KhuyenMai bll_khuyenmai = new BLL_KhuyenMai();
        public frmQuanLyKhuyenMai()
        {
            InitializeComponent();
            this.dtgvKhuyenMai.CellClick += DtgvKhuyenMai_CellClick;
            this.Load += FrmQuanLyKhuyenMai_Load;
            this.uc_ChucNangCanCo.BtnThemClicked += Uc_ChucNangCanCo_BtnThemClicked;
            this.uc_ChucNangCanCo.BtnRefreshClicked += Uc_ChucNangCanCo_BtnRefreshClicked;
            this.uc_ChucNangCanCo.BtnXoaClicked += Uc_ChucNangCanCo_BtnXoaClicked;
            this.uc_ChucNangCanCo.BtnSuaClicked += Uc_ChucNangCanCo_BtnSuaClicked;
        }

        private void Uc_ChucNangCanCo_BtnSuaClicked(object sender, EventArgs e)
        {
            if (txtMaKhuyenMai.Text == "")
            {
                MessageBox.Show("Hãy chọn khuyến mãi cần sửa");
                return;
            }
            else
            {
                string maKhuyenMai = txtMaKhuyenMai.Text;
                khuyenmai km = bll_khuyenmai.findKhuyenMai(maKhuyenMai);
                if (km == null)
                {
                    MessageBox.Show("Khuyến mãi không tồn tại, hãy load lại!!!");
                    return;
                }
                bool kq = bll_khuyenmai.updateKhuyenMai(txtTenKhuyenMai.Text,dtpkNgayBatDau.Value,dtpkNgayKetThuc.Value,int.Parse(txtPhanTramKhuyenMai.Text) ,km);
                if (kq == false)
                {
                    MessageBox.Show("Cập nhật khuyến mãi không thành công");
                    return;
                }
                MessageBox.Show("Cập nhật khuyến mãi thành công");
                loadDataKhuyenMai();

            }
        }

        private void Uc_ChucNangCanCo_BtnXoaClicked(object sender, EventArgs e)
        {
            if (txtMaKhuyenMai.Text == "")
            {
                MessageBox.Show("Hãy chọn KhuyenMai cần xoá");
                return;
            }
            string maKhuyenMai = txtMaKhuyenMai.Text;
            khuyenmai km = bll_khuyenmai.findKhuyenMai(maKhuyenMai);
            if (km == null)
            {
                MessageBox.Show("KhuyenMai không tồn tại, hãy load lại!!!");
                return;
            }
            bool kq = bll_khuyenmai.deleteKhuyenMai(km);
            if (kq == false)
            {
                MessageBox.Show("Xoá không thành công");
                return;
            }
            MessageBox.Show("Xoá thành công");
            loadDataKhuyenMai();


        }
        private void Uc_ChucNangCanCo_BtnRefreshClicked(object sender, EventArgs e)
        {
            txtMaKhuyenMai.Text = bll_khuyenmai.GenerateMaKhuyenMai();
            txtTenKhuyenMai.Text = "";
            dtpkNgayBatDau.Value = DateTime.Now;
            dtpkNgayKetThuc.Value = DateTime.Now;
            txtPhanTramKhuyenMai.Text = "";
        }

        private void Uc_ChucNangCanCo_BtnThemClicked(object sender, EventArgs e)
        {
            if (txtMaKhuyenMai.Text == "")
            {
                MessageBox.Show("Hãy chọn KhuyenMai cần sửa");
                return;
            }
            if (bll_khuyenmai.findKhuyenMai(txtMaKhuyenMai.Text) != null)
            {
                MessageBox.Show("Thêm không thành công");
                return;
            }
            khuyenmai km = new khuyenmai();
            km.MAKM = txtMaKhuyenMai.Text;
            km.TENKM = txtTenKhuyenMai.Text;
            km.PHANTRAMGIAM = int.Parse(txtPhanTramKhuyenMai.Text);
            km.NGAYBD = dtpkNgayBatDau.Value;
            km.NGAYKT = dtpkNgayKetThuc.Value;
            bool kq = bll_khuyenmai.insertKhuyenMai(km);
            if (kq == false)
            {
                MessageBox.Show("Thêm không thành công");
                return;

            }
            MessageBox.Show("Thêm thành công");
            loadDataKhuyenMai();
        }

        private void FrmQuanLyKhuyenMai_Load(object sender, EventArgs e)
        {
            loadDataKhuyenMai();
        }

        public void loadDataKhuyenMai()
        {
            dtgvKhuyenMai.DataSource = bll_khuyenmai.getAllKhuyenMai();
            dtgvKhuyenMai.Columns["MAKM"].HeaderText = "Mã khuyến mãi";
            dtgvKhuyenMai.Columns["TENKM"].HeaderText = "Tên khuyến mãi";
            dtgvKhuyenMai.Columns["PHANTRAMGIAM"].HeaderText = "Phần trăm giảm";
            dtgvKhuyenMai.Columns["NGAYBD"].HeaderText = "Ngày bắt đầu";
            dtgvKhuyenMai.Columns["NGAYKT"].HeaderText = "Ngày kết thúc";
        }

        private void DtgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvKhuyenMai.Rows[e.RowIndex];
                txtMaKhuyenMai.Text = row.Cells["MAKM"].Value.ToString();
                txtTenKhuyenMai.Text = row.Cells["TENKM"].Value.ToString();
                txtPhanTramKhuyenMai.Text = row.Cells["PHANTRAMGIAM"].Value.ToString();
                dtpkNgayBatDau.Text = row.Cells["NGAYBD"].Value.ToString();
                dtpkNgayKetThuc.Text = row.Cells["NGAYKT"].Value.ToString();
            }
        }

     
    }
}
