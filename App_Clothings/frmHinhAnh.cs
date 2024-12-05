using BLL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace App_Clothings
{
    public partial class frmHinhAnh : DevExpress.XtraEditors.XtraForm
    {
        string masp;
        BLL_HinhAnh bll_hinhanh = new BLL_HinhAnh();
        public string Masp { get => masp; set => masp = value; }
        public frmHinhAnh()
        {
            InitializeComponent();
            this.Load += FrmHinhAnh_Load;
            this.btnHinhAnh.Click += BtnHinhAnh_Click;
            this.cbHinhAnh.SelectedIndexChanged += CbHinhAnh_SelectedIndexChanged;
        }

        private void CbHinhAnh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHinhAnh.SelectedItem is hinhanh selectedItem)
            {
                string imageName = selectedItem.HINHANHSP; // Truy cập thuộc tính HINHANHSP
                txtHinhAnh.Text = imageName; // Gán giá trị vào TextBox
                pictureBox.ShowImage(imageName); // Hiển thị ảnh
            }
            else
            {
                txtHinhAnh.Text = "";
                pictureBox.ShowImage("anhnen.jpg");

            }
        }



        private void SaveImageToFolder(string filePath, string newFileName)
        {
            string imagesFolder = Path.Combine(Application.StartupPath, "Images");
            string secondaryFolder = @"E:\HK7\PT_PhanMem_UD_ThongMinh\DoAnCuoiKy\webapireactjs_QLQuanAo_PTUDTM\BE\PTUDTM_VER2\qlquanaoreactjs\src\assets\images";

            // Tạo thư mục nếu chưa tồn tại
            if (!Directory.Exists(imagesFolder))
            {
                Directory.CreateDirectory(imagesFolder);
            }

            // Đường dẫn lưu file mới
            string destPath = Path.Combine(imagesFolder, newFileName);
            File.Copy(filePath, destPath, true); // Ghi đè nếu file đã tồn tại
            string secondaryDestPath = Path.Combine(secondaryFolder, newFileName);
            File.Copy(filePath, secondaryDestPath, true); // Ghi đè nếu file đã tồn tại
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
                    hinhanh ha = new hinhanh();
                    ha.MASP = masp;
                    ha.HINHANHSP = txtHinhAnh.Text;
                    bool kq = bll_hinhanh.insertHinhAnh(ha);
                    if(!kq)
                    {
                        XtraMessageBox.Show("Thêm sản phẩm không thành công");
                        return;
                    }
                    XtraMessageBox.Show("Thêm sản phẩm thành công");
                    SaveImageToFolder(openFileDialog.FileName, newFileName);
                    loadDataHinhAnh(masp);
                }
            }


        }

        private void FrmHinhAnh_Load(object sender, EventArgs e)
        {
            loadDataHinhAnh(masp);
        }

        public  void loadDataHinhAnh(string masp)
        {
            cbHinhAnh.DataSource = bll_hinhanh.getALLHinhAnh(masp);
            cbHinhAnh.DisplayMember = "HINHANHSP";
            cbHinhAnh.ValueMember = "HINHANHSP";
        }

    }
}