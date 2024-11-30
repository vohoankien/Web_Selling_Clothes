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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.Resize += FrmMain_Resize;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            panel_Body.Size = this.ClientSize;
        }

        private Form currentFormChild;
        private void openChirlForm (Form childForm)
        {
            if (currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChirlForm(new frmQuanLyKho());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLýNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChirlForm(new frmQuanLyTaiKhoan());
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChirlForm(new frmLoaiSanPham());

        }

        private void thươngHiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChirlForm(new frmThuongHieu());
        }

        private void quảnLýKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChirlForm(new frmQuanLyKhuyenMai());

        }

        private void quảnLýSảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChirlForm(new frmQuanLySanPham());

        }
    }
}
