﻿using System;
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
    public partial class ChucNangCanCo : UserControl
    {
        public ChucNangCanCo()
        {
            InitializeComponent();
            this.btnThem.Click += BtnThem_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.btnSua.Click += BtnSua_Click;
            this.btnRefresh.Click += BtnRefresh_Click;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
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

        public event EventHandler BtnThemClicked;
        public event EventHandler BtnXoaClicked;
        public event EventHandler BtnSuaClicked;
        public event EventHandler BtnRefreshClicked;

    }
}
