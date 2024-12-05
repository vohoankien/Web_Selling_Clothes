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
using DTO;
using BLL;
namespace App_Clothings
{
    public partial class frmSize : DevExpress.XtraEditors.XtraForm
    {
        string masp;
        BLL_Size bll_size = new BLL_Size();
        public string Masp { get => masp; set => masp = value; }

        public frmSize()
        {
            InitializeComponent();
            this.Load += FrmSize_Load;
            this.cbSize.SelectedIndexChanged += CbSize_SelectedIndexChanged;
            this.btnSize.Click += BtnSize_Click;
        }

        private void BtnSize_Click(object sender, EventArgs e)
        {
            if(txtSize.Text =="")
            {
                XtraMessageBox.Show("hãy điền giá trị!!");
                return;
            }    
            size s = new size();    
            s.MASP = masp;
            s.SIZESP = txtSize.Text;
            bool kq = bll_size.insertSize(s);   
            if(!kq)
            {
                XtraMessageBox.Show("Thêm size thất bại!!");
                return;

            }
            XtraMessageBox.Show("Thêm size thành công!!");
            txtSize.Text = "";
            loadDSSize(masp);
        }

        private void CbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSize.SelectedItem != null)
            {
                string selectedValue = cbSize.Text;
                txtSize.Text = selectedValue;     

                // Nếu muốn lấy giá trị từ ValueMember
                // var selectedValue = cbKhuyenMai.SelectedValue.ToString();
                // txtKhuyenMai.Text = selectedValue;
            }
        }

        private void FrmSize_Load(object sender, EventArgs e)
        {
            loadDSSize(masp);
        }
        public void loadDSSize(string masp)
        {
            cbSize.DataSource = bll_size.getALLSize(masp);
            cbSize.DisplayMember = "SIZESP";
            cbSize.ValueMember = "SIZESP";
        }
    }
}