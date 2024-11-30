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
    public partial class frmThuongHieu : Form
    {
        BLL_NhanHieu bll_nhanhieu = new BLL_NhanHieu();
        public frmThuongHieu()
        {
            InitializeComponent();
            this.Load += FrmThuongHieu_Load;
            this.dtgvNhanHieu.CellClick += DtgvNhanHieu_CellClick;
            this.uc_ChucNangCanCo.BtnRefreshClicked += Uc_ChucNangCanCo_BtnRefreshClicked;
            this.uc_ChucNangCanCo.BtnThemClicked += Uc_ChucNangCanCo_BtnThemClicked;
            this.uc_ChucNangCanCo.BtnXoaClicked += Uc_ChucNangCanCo_BtnXoaClicked;
            this.uc_ChucNangCanCo.BtnSuaClicked += Uc_ChucNangCanCo_BtnSuaClicked;

        }

      
        private void FrmThuongHieu_Load(object sender, EventArgs e)
        {
            loaddataNhanHieu();
        }

        private void Uc_ChucNangCanCo_BtnSuaClicked(object sender, EventArgs e)
        {
            if (txtMaNhanHieu.Text == "")
            {
                MessageBox.Show("Hãy chọn loại thương hiệu cần sửa");
                return;
            }
            else
            {
                string manhanhieu = txtMaNhanHieu.Text;
                nhanhieu nh = bll_nhanhieu.findNhanHieu(manhanhieu);
                if (nh == null)
                {
                    MessageBox.Show("Nhãn hiệu không tồn tại, hãy load lại!!!");
                    return;
                }
                if (txtTenNhanHieu.Text == ""|| txtQuocGia.Text=="")
                {
                    MessageBox.Show("Tên loại không được để trống, hãy load lại!!!");
                    return;
                }
                else
                {
                    bool kq = bll_nhanhieu.updateNhanHieu(txtTenNhanHieu.Text,txtQuocGia.Text, nh);
                    if (kq == false)
                    {
                        MessageBox.Show("Cập nhật không thành công");
                        return;
                    }
                    MessageBox.Show("Cập nhật thành công");
                    loaddataNhanHieu();
                }
            }
        }

        private void Uc_ChucNangCanCo_BtnXoaClicked(object sender, EventArgs e)
        {
            if (txtMaNhanHieu.Text == "")
            {
                MessageBox.Show("Hãy chọn Nhãn hiệu cần xoá");
                return;
            }
            string maNhanHieu = txtMaNhanHieu.Text;
            nhanhieu nh = bll_nhanhieu.findNhanHieu(maNhanHieu);
            if (nh == null)
            {
                MessageBox.Show("Nhãn hiệu không tồn tại, hãy load lại!!!");
                return;
            }
            bool kq = bll_nhanhieu.deleteNhanHieu(nh);
            if (kq == false)
            {
                MessageBox.Show("Xoá không thành công");
                return;
            }
            MessageBox.Show("Xoá thành công");
            loaddataNhanHieu();


        }

        private void Uc_ChucNangCanCo_BtnThemClicked(object sender, EventArgs e)
        {
            if (txtMaNhanHieu.Text == "" || txtTenNhanHieu.Text == ""|| txtQuocGia.Text=="")
            {
                MessageBox.Show("Hãy chọn nhãn hiệu cần thêm");
                return;
            }
            nhanhieu nh = new nhanhieu();
            nh.MANH = txtMaNhanHieu.Text;
            nh.QUOCGIA = txtQuocGia.Text;
            nh.TENNH = txtTenNhanHieu.Text;
            bool kq = bll_nhanhieu.insertNhanHieu(nh);
            if (kq == false)
            {
                MessageBox.Show("Thêm không thành công");
                return;

            }
            MessageBox.Show("Thêm thành công");
            loaddataNhanHieu();

        }

        private void Uc_ChucNangCanCo_BtnRefreshClicked(object sender, EventArgs e)
        {
            txtMaNhanHieu.Text =bll_nhanhieu.GenerateMaNhanHieu();
            txtTenNhanHieu.Text = "";
            txtQuocGia.Text = "";
        }

        private void DtgvNhanHieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvNhanHieu.Rows[e.RowIndex];
                txtMaNhanHieu.Text = row.Cells["MANH"].Value.ToString();
                txtTenNhanHieu.Text = row.Cells["TENNH"].Value.ToString();
                txtQuocGia.Text = row.Cells["QUOCGIA"].Value.ToString();

            }
        }


        private void FrmNhanHieu_Load(object sender, EventArgs e)
        {
            lbTieuDe.Text = "Nhãn hiệu";
            loaddataNhanHieu();
        }

        public void loaddataNhanHieu()
        {
            dtgvNhanHieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvNhanHieu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvNhanHieu.DataSource = bll_nhanhieu.getAllNhanHieu();
            dtgvNhanHieu.Columns["MANH"].HeaderText = "Mã sản phẩm";
            dtgvNhanHieu.Columns["TENNH"].HeaderText = "Tên nhãn hiệu";
            dtgvNhanHieu.Columns["QUOCGIA"].HeaderText = "Tên quốc gia";

        }
    }
}
