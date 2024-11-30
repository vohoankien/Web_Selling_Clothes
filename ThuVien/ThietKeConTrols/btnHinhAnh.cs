using System;
using System.IO;
using System.Windows.Forms;

namespace ThuVien.ThietKeConTrols
{
    public class btnHinhAnh : Button
    {
        // TextBox để hiển thị tên file
        public TextBox TextBox { get; set; }

        // Sự kiện khi người dùng chọn ảnh
        public event EventHandler<ImageSelectedEventArgs> ImageSelected;

        public btnHinhAnh()
        {
            this.Click += BtnHinhAnh_Click;
        }

        private void BtnHinhAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn hình ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileName(openFileDialog.FileName);

                    // Gán tên file vào TextBox (nếu có)
                    if (TextBox != null)
                    {
                        TextBox.Text = fileName;
                        TextBox.Tag = openFileDialog.FileName; // Lưu đường dẫn tạm thời
                    }

                    // Kích hoạt sự kiện ImageSelected
                    ImageSelected?.Invoke(this, new ImageSelectedEventArgs
                    {
                        FilePath = openFileDialog.FileName,
                        FileName = fileName
                    });
                }
            }
        }

        // Phương thức lưu ảnh
       
    }

    // Lớp chứa thông tin sự kiện
    public class ImageSelectedEventArgs : EventArgs
    {
        public string FilePath { get; set; } // Đường dẫn file
        public string FileName { get; set; } // Tên file
    }
}
