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

namespace ThuVien
{
    public partial class ChucNangNangCao : DevExpress.XtraEditors.XtraUserControl
    {
        public ChucNangNangCao()
        {
            InitializeComponent();
            this.btnThem.Click += BtnThem_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.btnSua.Click += BtnSua_Click;
            this.btnRefresh.Click += BtnRefresh_Clicked;
            this.btnReport.Click += BtnReport_Click;
        }
        public event EventHandler BtnThemClicked;
        public event EventHandler BtnXoaClicked;
        public event EventHandler BtnSuaClicked;
        public event EventHandler BtnRefreshClicked;
        public event EventHandler BtnDongClicked;
        public event EventHandler BtnReportClicked;

        private void BtnReport_Click(object sender, EventArgs e)
        {
            BtnReportClicked?.Invoke(this, EventArgs.Empty);
        }
        private void BtnRefresh_Clicked(object sender, EventArgs e)
        {
            BtnRefreshClicked?.Invoke(this, EventArgs.Empty);

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
