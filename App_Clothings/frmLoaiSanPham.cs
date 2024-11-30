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
using ThuVien.ThietKeConTrols;

namespace App_Clothings
{
    public partial class frmLoaiSanPham : Form
    {
        BLL_LoaiSanPham bll_loaisanpham = new BLL_LoaiSanPham();
        public frmLoaiSanPham()
        {
            InitializeComponent();
            this.Load += FrmLoaiSanPham_Load;
            this.dtgvLoaiSanPham.CellClick += DtgvLoaiSanPham_CellClick;
            this.uc_ChucNangCanCo.BtnRefreshClicked += Uc_ChucNangCanCo_BtnRefreshClicked;
            this.uc_ChucNangCanCo.BtnThemClicked += Uc_ChucNangCanCo_BtnThemClicked;
            this.uc_ChucNangCanCo.BtnXoaClicked += Uc_ChucNangCanCo_BtnXoaClicked;
            this.uc_ChucNangCanCo.BtnSuaClicked += Uc_ChucNangCanCo_BtnSuaClicked;
           
        }

        private void Uc_ChucNangCanCo_BtnSuaClicked(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "")
            {
                MessageBox.Show("Hãy chọn loại sản phẩm cần sửa");
                return;
            }
            else
            {
                string maloaisanpham = txtMaLoai.Text;
                loaisanpham lsp = bll_loaisanpham.findLoaiSanPham(maloaisanpham);
                if (lsp == null)
                {
                    MessageBox.Show("Loại sản phẩm không tồn tại, hãy load lại!!!");
                    return;
                }
                if (txtTenLoai.Text == "")
                {    
                    MessageBox.Show("Tên loại không được để trống, hãy load lại!!!");
                    return;
                }
                else
                {
                    bool kq = bll_loaisanpham.updateLoaiSanPham(txtTenLoai.Text, lsp);
                    if(kq== false)
                    {
                        MessageBox.Show("Cập nhật không thành công");
                        return;
                    }
                    MessageBox.Show("Cập nhật thành công");
                    loaddataLoaiSanPham();
                }
            }
        }

        private void Uc_ChucNangCanCo_BtnXoaClicked(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "")
            {
                MessageBox.Show("Hãy chọn loại sản phẩm cần sửa");
                return;
            }
            string maloaisanpham = txtMaLoai.Text;
            loaisanpham lsp = bll_loaisanpham.findLoaiSanPham(maloaisanpham);
            if (lsp == null)
            {
                MessageBox.Show("Loại sản phẩm không tồn tại, hãy load lại!!!");
                return;
            }
            bool kq = bll_loaisanpham.deleteLoaiSanPham(lsp);
            if (kq == false)
            {
                MessageBox.Show("Xoá không thành công");
                return;
            }
            MessageBox.Show("Xoá thành công");
            loaddataLoaiSanPham();


        }

        private void Uc_ChucNangCanCo_BtnThemClicked(object sender, EventArgs e)
        {
            if(txtMaLoai.Text =="" || txtTenLoai.Text=="")
            {

                MessageBox.Show("Hãy chọn loại sản phẩm cần sửa");
                return;
            }    
            loaisanpham lsp = new loaisanpham();
            lsp.MALOAI = txtMaLoai.Text;
            lsp.TENLOAI = txtTenLoai.Text;
            bool kq = bll_loaisanpham.insertLoaiSanPham(lsp);
            if (kq == false)
            {
                MessageBox.Show("Thêm không thành công");
                return;

            }
            MessageBox.Show("Thêm thành công");
            loaddataLoaiSanPham();

        }

        private void Uc_ChucNangCanCo_BtnRefreshClicked(object sender, EventArgs e)
        {
            txtMaLoai.Enabled = true;
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
        }

        private void DtgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvLoaiSanPham.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells["MALOAI"].Value.ToString();
                txtTenLoai.Text = row.Cells["TENLOAI"].Value.ToString();
             
            }
        }

        private void FrmLoaiSanPham_Load(object sender, EventArgs e)
        {
            lbTieuDe.Text = "Loại sản phẩm";
            loaddataLoaiSanPham();
        }

        public void loaddataLoaiSanPham()
        {
            dtgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvLoaiSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvLoaiSanPham.DataSource = bll_loaisanpham.getAllLoaiSanPham();
            dtgvLoaiSanPham.Columns["MALOAI"].HeaderText = "Mã sản phẩm";
            dtgvLoaiSanPham.Columns["TENLOAI"].HeaderText = "Tên loại sản phẩm";

        }


    }
}
