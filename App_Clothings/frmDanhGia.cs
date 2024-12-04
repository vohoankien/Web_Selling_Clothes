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
using DevExpress.Pdf;
namespace App_Clothings
{
    public partial class frmDanhGia : DevExpress.XtraEditors.XtraForm
    {
        BLL_DanhGia bll_danhgia = new BLL_DanhGia();
        BLl_PhanHoi bll_phanhoi = new BLl_PhanHoi();
        public frmDanhGia()
        {
            InitializeComponent();
            this.Load += FrmDanhGia_Load;
            this.dtgvDanhGia.CellClick += DtgvDanhGia_CellClick;
            btnTraLoi.Click += BtnTraLoi_Click;
            btnCapNhat.Click += BtnCapNhat_Click;
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            int tinhtrang = checkTinhTrang.Checked ? 1 : 0;
            if (dtgvDanhGia.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvDanhGia.SelectedRows[0];
                string madg = selectedRow.Cells["MADANHGIA"].Value.ToString();
                if (txtPhanHoi.Text == "Không có nội dung phản hồi")
                {
                    XtraMessageBox.Show("Hãy nhập nội dung phản hồi!!!");
                    return;
                }
                else
                {
                    phanhoi ph = bll_phanhoi.findPhanHoi(madg);
                   
                    bool kq = bll_phanhoi.updatePhanHoi(txtPhanHoi.Text, ph);
                    if(!kq)
                    {
                        XtraMessageBox.Show("Phản hồi thất bại!!!");
                        return;
                    }    
                    danhgia dg = bll_danhgia.findDanhGia(madg);
                    bool kqdg = bll_danhgia.updateDanhGia(tinhtrang, dg);
                    if (!kqdg)
                    {
                        XtraMessageBox.Show("Không thể thay đổi tình trạng đánh giá!!!");
                        return;
                    }
                    XtraMessageBox.Show("Cập nhật đánh giá thành công");
                    loadDanhSachDanhGia();

                }
            }
        }

        private void BtnTraLoi_Click(object sender, EventArgs e)
        {
            int tinhtrang = checkTinhTrang.Checked ? 1 : 0;
            if (dtgvDanhGia.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvDanhGia.SelectedRows[0];
                string madg = selectedRow.Cells["MADANHGIA"].Value.ToString();
                if (txtPhanHoi.Text == "Không có nội dung phản hồi")
                {
                    phanhoi phoi = bll_phanhoi.findPhanHoi(madg);
                    if (phoi == null)
                    {
                        danhgia danhgia = bll_danhgia.findDanhGia(madg);
                        bool kqdanhgia = bll_danhgia.updateDanhGia(tinhtrang, danhgia);
                        if (!kqdanhgia)
                        {
                            XtraMessageBox.Show("Không thể thay đổi tình trạng đánh giá!!!");
                            return;

                        }
                        else
                            XtraMessageBox.Show("Cập nhật tình trạng đánh giá thành công");
                        return;
                    }
                    XtraMessageBox.Show("Hãy nhập nội dung phản hồi!!!");
                    return;
                }
                else
                {
                   
                    phanhoi ph = new phanhoi();
                    ph.MADANHGIA = madg;
                    ph.MAPHANHOI = bll_phanhoi.GenerateMaPhanHoi();
                    ph.NOIDUNG = txtPhanHoi.Text;
                    bool kq = bll_phanhoi.insertPhanHoi(ph);
                    if(!kq)
                    {
                        XtraMessageBox.Show("Phản hồi đã không thành công.");
                        return;
                    }
                    XtraMessageBox.Show("Phản hồi đã được gửi thành công.");
                    loadDanhSachDanhGia();
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn một hàng để gửi phản hồi.");
            }
        }


        private void DtgvDanhGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvDanhGia.Rows[e.RowIndex];
                txtTenKhachHang.Text = row.Cells["TENND"].Value.ToString();
                txtTenSanPham.Text = row.Cells["TENSANPHAM"].Value.ToString();
                txtSoSao.Text = row.Cells["SOSAO"].Value.ToString();
                txtDanhGia.Text = row.Cells["NOIDUNG"].Value.ToString();
                int tinhTrang = Convert.ToInt32(dtgvDanhGia.Rows[e.RowIndex].Cells["TINHTRANG"].Value);
                checkTinhTrang.Checked = tinhTrang == 1;
                string madg = row.Cells["MADANHGIA"].Value.ToString();
                phanhoi p = bll_phanhoi.findPhanHoi(madg);
                if(p == null)
                {     
                    txtPhanHoi.Text = "Không có nội dung phản hồi";
                    btnTraLoi.Enabled = true;
                    btnCapNhat.Enabled = false;
                }
                else
                {
                    txtPhanHoi.Text = p.NOIDUNG;
                    btnTraLoi.Enabled = false;
                    btnCapNhat.Enabled = true;

                }


            }
        }

        private void FrmDanhGia_Load(object sender, EventArgs e)
        {
            loadDanhSachDanhGia();
        }

        public void loadDanhSachDanhGia()
        {
            dtgvDanhGia.DataSource = bll_danhgia.getAllDanhGia();
            dtgvDanhGia.Columns["MADANHGIA"].HeaderText = "Mã sản phẩm";
            dtgvDanhGia.Columns["TENND"].HeaderText = "Tên sản phẩm";
            dtgvDanhGia.Columns["TENSANPHAM"].HeaderText = "Tên sản phẩm";
            dtgvDanhGia.Columns["NOIDUNG"].HeaderText = "Giá";
            dtgvDanhGia.Columns["SOSAO"].HeaderText = "Giá giảm";
            dtgvDanhGia.Columns["TINHTRANG"].Visible = false;

        }
    }
}