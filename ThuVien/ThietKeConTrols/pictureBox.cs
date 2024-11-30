using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace ThuVien.ThietKeConTrols
{
    public class pictureBox : PictureBox
    {
        public void ShowImage(string tenAnh)
        {
            string imagePath = System.IO.Path.Combine(Application.StartupPath, "Images",tenAnh);
            this.Image = new Bitmap(imagePath);
        }

    }
}
