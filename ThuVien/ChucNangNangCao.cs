using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public partial class ChucNangNangCao : UserControl
    {
        public ChucNangNangCao()
        {
            InitializeComponent();
            this.btnThem.Click += BtnThem_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.btnSua.Click += BtnSua_Click;
            this.btnClear.Click += BtnClear_Clicked;
            this.btnDong.Click += BtnDong_Click;
            this.btnReport.Click += BtnReport_Click;
        }
        public event EventHandler BtnThemClicked;
        public event EventHandler BtnXoaClicked;
        public event EventHandler BtnSuaClicked;
        public event EventHandler BtnClearClicked;
        public event EventHandler BtnDongClicked;
        public event EventHandler BtnReportClicked;

        private void BtnReport_Click(object sender, EventArgs e)
        {
            BtnReportClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            BtnDongClicked?.Invoke(this, EventArgs.Empty);

        }

        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            BtnClearClicked?.Invoke(this, EventArgs.Empty);

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            BtnSuaClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            BtnXoaClicked?.Invoke(this, EventArgs.Empty);

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            BtnThemClicked?.Invoke(this, EventArgs.Empty);

        }

       

    }
}
