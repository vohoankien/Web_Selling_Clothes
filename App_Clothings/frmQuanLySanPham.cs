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
using System.IO;
using ThuVien.ThietKeConTrols;
namespace App_Clothings
{
    public partial class frmQuanLySanPham : Form
    {
        BLL_LoaiSanPham bll_loaisanpham = new BLL_LoaiSanPham();
        BLL_KhuyenMai bll_khuyenmai = new BLL_KhuyenMai();
        BLL_NhanHieu bll_nhanhieu = new BLL_NhanHieu();
        BLL_SanPham bll_sanpham = new BLL_SanPham();

        public frmQuanLySanPham()
        {
            InitializeComponent();
            this.Load += FrmQuanLySanPham_Load;
            this.dtgvSanPham.CellClick += DtgvSanPham_CellClick;
            this.uc_ChucNangNangCao.BtnThemClicked += Uc_ChucNangNangCao_BtnThemClicked;
            this.uc_ChucNangNangCao.BtnRefreshClicked += Uc_ChucNangNangCao_BtnRefreshClicked;
            this.btnHinhAnh.Click += BtnHinhAnh_Click;
            this.uc_ChucNangNangCao.BtnXoaClicked += Uc_ChucNangNangCao_BtnXoaClicked;
            this.uc_ChucNangNangCao.BtnSuaClicked += Uc_ChucNangNangCao_BtnSuaClicked;
        }
        private void SaveImageToFolder(string filePath, string newFileName)
        {
            string imagesFolder = Path.Combine(Application.StartupPath, "Images");

            // Tạo thư mục nếu chưa tồn tại
            if (!Directory.Exists(imagesFolder))
            {
                Directory.CreateDirectory(imagesFolder);
            }

            // Đường dẫn lưu file mới
            string destPath = Path.Combine(imagesFolder, newFileName);
            File.Copy(filePath, destPath, true); // Ghi đè nếu file đã tồn tại
        }

        private void BtnHinhAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn hình ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string originalFileName = Path.GetFileName(openFileDialog.FileName);

                    // Tạo tên file mới (có thể thay đổi tùy ý)
                    string newFileName = $"SP_{Guid.NewGuid()}_{originalFileName}";

                    // Gán tên file mới vào TextBox (nếu có)
                    if (txtHinhAnh != null)
                    {
                        txtHinhAnh.Text = newFileName; // Lưu tên file mới
                        txtHinhAnh.Tag = openFileDialog.FileName; // Lưu đường dẫn gốc
                    }

                    // Lưu file vào thư mục
                    SaveImageToFolder(openFileDialog.FileName, newFileName);
                }
            }
        }


        private void Uc_ChucNangNangCao_BtnSuaClicked(object sender, EventArgs e)
        {
            // Kiểm tra mã sản phẩm
            if (string.IsNullOrWhiteSpace(txtMaSanPham.Text))
            {
                MessageBox.Show("Hãy chọn sản phẩm cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maSanPham = txtMaSanPham.Text;

            // Tìm sản phẩm
            sanpham km = bll_sanpham.findSanPham(maSanPham);
            if (km == null)
            {
                MessageBox.Show("Khuyến mãi không tồn tại, hãy load lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra tên sản phẩm
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sanpham temp = new sanpham();
            temp.MASP = txtMaSanPham.Text;
            temp.TENSANPHAM = txtTenSanPham.Text;
            temp.GIA = int.Parse(txtGia.Text);
            temp.HINHANH = txtHinhAnh.Text;
            temp.MALOAI = cbLoaiSanPham.SelectedValue.ToString();
            temp.MANH = cbNhanHieu.SelectedValue.ToString();    
            temp.MAKM = cbKhuyenMai.SelectedValue.ToString();
            bool kq = bll_sanpham.updateSanPham(temp,km);
            if (!kq)
            {
                MessageBox.Show("Cập nhật sản phẩm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Cập nhật khuyến mãi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Tải lại dữ liệu
            loadSanPham();
        }


        private void Uc_ChucNangNangCao_BtnXoaClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSanPham.Text))
            {
                MessageBox.Show("Hãy chọn sản phẩm cần xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSanPham = txtMaSanPham.Text;
            sanpham sp = bll_sanpham.findSanPham(maSanPham);

            if (sp == null)
            {
                MessageBox.Show("Sản phẩm không tồn tại, hãy tải lại dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Giải phóng hình ảnh trong PictureBox nếu đang hiển thị
            if (picSanPham.Image != null)
            {
                picSanPham.Image.Dispose();
                picSanPham.Image = null;
            }

            // Xóa ảnh trong thư mục Images
            string imagesFolder = Path.Combine(Application.StartupPath, "Images");
            string imagePath = Path.Combine(imagesFolder, sp.HINHANH);

            if (File.Exists(imagePath))
            {
                try
                {
                    File.Delete(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể xóa ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Xóa sản phẩm khỏi DB
            bool kq = bll_sanpham.deleteSanPham(sp);

            if (!kq)
            {
                MessageBox.Show("Xoá sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Xoá sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadSanPham();
        }


        private void Uc_ChucNangNangCao_BtnRefreshClicked(object sender, EventArgs e)
        {
            txtMaSanPham.Text = bll_sanpham.GenerateMaSanPham();
            txtTenSanPham.Text = "";
            txtChatLieu.Text = "";
            txtGia.Text = "";
            txtHinhAnh.Text = "";  
            picSanPham.ShowImage("anhnen.jpg");
            txtKhuyenMai.Text = "";
        }
        private void Uc_ChucNangNangCao_BtnThemClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSanPham.Text) ||
                string.IsNullOrWhiteSpace(txtTenSanPham.Text) ||
                string.IsNullOrWhiteSpace(txtGia.Text) ||
                string.IsNullOrWhiteSpace(txtChatLieu.Text) || string.IsNullOrWhiteSpace(txtHinhAnh.Text)
              ) // Kiểm tra nếu chưa chọn ảnh
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin và chọn ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string makm;
                // Tạo đối tượng sản phẩm
                if (cbKhuyenMai.SelectedValue.ToString() == null)
                     makm = null;
                else
                     makm = cbKhuyenMai.SelectedValue.ToString();
                sanpham km = new sanpham
                {
                    MASP = txtMaSanPham.Text,
                    TENSANPHAM = txtTenSanPham.Text,
                    GIA = int.Parse(txtGia.Text),
                    CHATLIEU = txtChatLieu.Text,
                    HINHANH = txtHinhAnh.Text, // Lưu tên ảnh vào DB
                    MALOAI = cbLoaiSanPham.SelectedValue.ToString(),
                    MANH = cbNhanHieu.SelectedValue.ToString(),
                    MAKM = makm,
                };

                // Thêm sản phẩm vào DB
                bool kq = bll_sanpham.insertSanPham(km);

                if (!kq)
                {
                    MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Thêm sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      


        private void DtgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvSanPham.Rows[e.RowIndex];
                txtMaSanPham.Text = row.Cells["MASP"].Value.ToString();
                txtTenSanPham.Text = row.Cells["TENSANPHAM"].Value.ToString();
                txtGia.Text = row.Cells["GIA"].Value.ToString();
                txtChatLieu.Text = row.Cells["CHATLIEU"].Value.ToString();
                picSanPham.ShowImage(row.Cells["HINHANH"].Value.ToString());
                txtHinhAnh.Text = row.Cells["HINHANH"].Value.ToString();
                string maQuyen = row.Cells["MALOAI"].Value.ToString();
                cbLoaiSanPham.SelectedValue = maQuyen;
                cbNhanHieu.SelectedValue = row.Cells["MANH"].Value.ToString();
                if (row.Cells["MAKM"] != null && row.Cells["MAKM"].Value != null)
                {
                txtKhuyenMai.Text =  bll_sanpham.getGiaKhuyenMai(txtMaSanPham.Text).ToString();
                }
                else
                {
                    txtKhuyenMai.Text = "0";
                }    
            }
        }

        private void FrmQuanLySanPham_Load(object sender, EventArgs e)
        {
            loadLoaiSanPham();
            loadSanPham();
            loadNhanHieu();
            loadKhuyenMai();
            picSanPham.ShowImage("anhnen.jpg");

        }
        public void loadSanPham()
        {
            dtgvSanPham.DataSource = bll_sanpham.getAllSanPham();
            dtgvSanPham.Columns["MASP"].HeaderText = "Mã sản phẩm";
            dtgvSanPham.Columns["TENSANPHAM"].HeaderText = "Tên sản phẩm";
            dtgvSanPham.Columns["GIA"].HeaderText = "Giá";
            dtgvSanPham.Columns["CHATLIEU"].HeaderText = "Chất liệu";
            dtgvSanPham.Columns["HINHANH"].Visible =false;
            dtgvSanPham.Columns["MAKM"].Visible = false;
            dtgvSanPham.Columns["MANH"].Visible = false;
            dtgvSanPham.Columns["MALOAI"].Visible = false;
        }

        public void loadLoaiSanPham()
        {
            cbLoaiSanPham.DataSource = bll_loaisanpham.getAllLoaiSanPham();
            cbLoaiSanPham.DisplayMember = "TENLOAI";
            cbLoaiSanPham.ValueMember = "MALOAI";
        }

        public void loadNhanHieu()
        {
            cbNhanHieu.DataSource = bll_nhanhieu.getAllNhanHieu();
            cbNhanHieu.DisplayMember = "TENNH";
            cbNhanHieu.ValueMember = "MANH";
        }
        public void loadKhuyenMai()
        {
            cbKhuyenMai.DataSource = bll_khuyenmai.getAllKhuyenMai();
            cbKhuyenMai.DisplayMember = "TENKM";
            cbKhuyenMai.ValueMember = "MAKM";
        }

        //public void loadRowInCBLoaiSanPham ()
        //{
        //}
    }
}
