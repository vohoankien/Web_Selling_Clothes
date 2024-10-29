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
    public partial class QuanLyQuyen : UserControl
    {
        public QuanLyQuyen()
        {
            InitializeComponent();
            this.btnThem.Click += BtnThem_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.btnSua.Click += BtnSua_Click;
        }

        public event EventHandler BtnThemClicked;
        public event EventHandler BtnXoaClicked;
        public event EventHandler BtnSuaClicked;

        private void BtnSua_Click(object sender, EventArgs e)
        {
            BtnSuaClicked?.Invoke(this, EventArgs.Empty);
        }

        public string TenQuyen
        {
            get { return txtQuyen.Text; }
            set { txtQuyen.Text = value; }
        }

        public ComboBox ComboQuyen
        {
            get { return cbLoadData; }
            
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
