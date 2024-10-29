using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien.ThietKeConTrols;

namespace ThuVien
{
    public partial class DangNhap : UserControl
    {
        public DangNhap()
        {
            InitializeComponent();
            this.btnDangNhap.Click += BtnDangNhap_Click;
            this.lblQuenMatKhau.Click += LblQuenMatKhau_Click;
        }

        public string TenDN
        {
            get { return txtTenDN.Text; }
            set { txtTenDN.Text = value; }
        }

        public string MatKhau
        {
            get { return txtMatKhau.Text; }
            set { txtMatKhau.Text = value; }
        }

        public event EventHandler BtnDangNhapClicked;
        public event EventHandler LblQuenMatKhauClicked;

        private void LblQuenMatKhau_Click(object sender, EventArgs e)
        {
            LblQuenMatKhauClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            BtnDangNhapClicked?.Invoke(this, EventArgs.Empty);
        }

       

    }
}
