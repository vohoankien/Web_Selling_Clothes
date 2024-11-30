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
    public partial class frmQuanLyKho : Form
    {
        BLL_Kho bll_kho = new BLL_Kho();
        public frmQuanLyKho()
        {
            InitializeComponent();
            this.Load += FrmQuanLyKho_Load;
            this.uc_ChucNangCanCo.BtnRefreshClicked += Uc_ChucNangCanCo_BtnRefreshClicked;
            this.uc_ChucNangCanCo.BtnThemClicked += Uc_ChucNangCanCo_BtnThemClicked;
            this.uc_ChucNangCanCo.BtnXoaClicked += Uc_ChucNangCanCo_BtnXoaClicked;
            this.uc_ChucNangCanCo.BtnSuaClicked += Uc_ChucNangCanCo_BtnSuaClicked;
            this.dtgvKho.CellClick += DtgvKho_CellClick;
        }

        private void DtgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dtgvKho.Rows[e.RowIndex];
                txtMaKho.Text = row.Cells["MAKHO"].Value.ToString();
                txtTenKho.Text = row.Cells["TENKHO"].Value.ToString();

            }
        }

        private void Uc_ChucNangCanCo_BtnSuaClicked(object sender, EventArgs e)
        {
            if (txtMaKho.Text == "")
            {
                MessageBox.Show("Hãy chọn kho cần sửa");
                return;
            }
            else
            {
                string maKho = txtMaKho.Text;
                kho kho = bll_kho.findKho(maKho);
                if (kho == null)
                {
                    MessageBox.Show("Kho không tồn tại, hãy load lại!!!");
                    return;
                }
                if (txtTenKho.Text == "")
                {
                    MessageBox.Show("Tên kho không được để trống, hãy load lại!!!");
                    return;
                }
                else
                {
                    bool kq = bll_kho.updateKho(txtTenKho.Text, kho);
                    if (kq == false)
                    {
                        MessageBox.Show("Cập khoật không thành công");
                        return;
                    }
                    MessageBox.Show("Cập khoật thành công");
                    loadDataKho();
                }
            }
        }

        private void Uc_ChucNangCanCo_BtnXoaClicked(object sender, EventArgs e)
        {
            if (txtMaKho.Text == "")
            {
                MessageBox.Show("Hãy chọn kho cần xoá");
                return;
            }
            string maKho = txtMaKho.Text;
            kho kho = bll_kho.findKho(maKho);
            if (kho == null)
            {
                MessageBox.Show("Kho không tồn tại, hãy load lại!!!");
                return;
            }
            bool kq = bll_kho.deleteKho(kho);
            if (kq == false)
            {
                MessageBox.Show("Xoá không thành công");
                return;
            }
            MessageBox.Show("Xoá thành công");
            loadDataKho();


        }
        private void Uc_ChucNangCanCo_BtnRefreshClicked(object sender, EventArgs e)
        {
            txtMaKho.Text = bll_kho.GenerateMaKho();
            txtTenKho.Text = "";
        }
        private void Uc_ChucNangCanCo_BtnThemClicked(object sender, EventArgs e)
        {
            if (txtMaKho.Text == "" || txtTenKho.Text == "")
            {
                MessageBox.Show("Hãy điền thông tin kho cần thêm");
                return;
            }
            if (bll_kho.findKho(txtMaKho.Text) != null)
            {
                MessageBox.Show("Thêm không thành công");
                return;
            }
            kho kho = new kho();
            kho.MAKHO = bll_kho.GenerateMaKho();
            kho.TENKHO = txtTenKho.Text;
            bool kq = bll_kho.insertKho(kho);
            if (kq == false)
            {
                MessageBox.Show("Thêm không thành công");
                return;

            }
            MessageBox.Show("Thêm thành công");
            loadDataKho();

        }

       
        private void FrmQuanLyKho_Load(object sender, EventArgs e)
        {
            lbTieuDe.Text = "Quản lý kho";
            loadDataKho();
        }
        public void loadDataKho()
        {
            dtgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvKho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvKho.DataSource = bll_kho.getAllKho();
            dtgvKho.Columns["MAKHO"].HeaderText = "Mã sản phẩm";
            dtgvKho.Columns["TENKHO"].HeaderText = "Tên kho";
        }
    }
}
