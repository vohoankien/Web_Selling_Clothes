namespace App_Clothings
{
    partial class frmQuanLyHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dtgvHoaDon = new ThuVien.ThietKeConTrols.dtgvData();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTenKhachHang = new ThuVien.ThietKeConTrols.txtTextBox();
            this.dtpkNgayDat = new ThuVien.ThietKeConTrols.dtpkDateTimePicker();
            this.txtTongTien = new ThuVien.ThietKeConTrols.txtSo();
            this.txtSoLuong = new ThuVien.ThietKeConTrols.txtSo();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ád = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaHoaDon = new DevExpress.XtraEditors.TextEdit();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtTenKH = new ThuVien.ThietKeConTrols.txtTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHoaDon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.SvgImage = global::App_Clothings.Properties.Resources.selectdatamember;
            this.groupControl2.Controls.Add(this.txtTenKH);
            this.groupControl2.Controls.Add(this.btnTimKiem);
            this.groupControl2.Controls.Add(this.dtgvHoaDon);
            this.groupControl2.Location = new System.Drawing.Point(40, 251);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(879, 336);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông tin hoá đơn";
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Location = new System.Drawing.Point(25, 97);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.RowHeadersWidth = 51;
            this.dtgvHoaDon.RowTemplate.Height = 24;
            this.dtgvHoaDon.Size = new System.Drawing.Size(831, 222);
            this.dtgvHoaDon.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = global::App_Clothings.Properties.Resources.filter_32x32;
            this.btnTimKiem.Location = new System.Drawing.Point(25, 51);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(35, 38);
            this.btnTimKiem.TabIndex = 14;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = global::App_Clothings.Properties.Resources.printincludeevaluations_32x321;
            this.groupControl1.Controls.Add(this.cbTinhTrang);
            this.groupControl1.Controls.Add(this.txtTenKhachHang);
            this.groupControl1.Controls.Add(this.dtpkNgayDat);
            this.groupControl1.Controls.Add(this.txtTongTien);
            this.groupControl1.Controls.Add(this.txtSoLuong);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.ád);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtMaHoaDon);
            this.groupControl1.Enabled = false;
            this.groupControl1.Location = new System.Drawing.Point(40, 26);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(879, 196);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin hoá đơn";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(155, 137);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(125, 23);
            this.txtTenKhachHang.TabIndex = 12;
            // 
            // dtpkNgayDat
            // 
            this.dtpkNgayDat.CustomFormat = "dd/MM/yyy";
            this.dtpkNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayDat.Location = new System.Drawing.Point(417, 132);
            this.dtpkNgayDat.Name = "dtpkNgayDat";
            this.dtpkNgayDat.Size = new System.Drawing.Size(120, 23);
            this.dtpkNgayDat.TabIndex = 11;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(719, 73);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(125, 23);
            this.txtTongTien.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(417, 67);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(120, 23);
            this.txtSoLuong.TabIndex = 9;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(609, 137);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 16);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Tình trạng";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(609, 80);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 16);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Tổng tiền";
            // 
            // ád
            // 
            this.ád.Location = new System.Drawing.Point(332, 137);
            this.ád.Name = "ád";
            this.ád.Size = new System.Drawing.Size(50, 16);
            this.ád.TabIndex = 5;
            this.ád.Text = "Ngày đặt";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(332, 70);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Số lượng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(37, 144);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên khách hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã hoá đơn";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(155, 67);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(125, 22);
            this.txtMaHoaDon.TabIndex = 2;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Location = new System.Drawing.Point(719, 132);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(121, 24);
            this.cbTinhTrang.TabIndex = 13;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtTenKH.Location = new System.Drawing.Point(75, 55);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(129, 34);
            this.txtTenKH.TabIndex = 15;
            // 
            // frmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 599);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmQuanLyHoaDon";
            this.Text = "frmQuanLyHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHoaDon.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private ThuVien.ThietKeConTrols.dtgvData dtgvHoaDon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaHoaDon;
        private ThuVien.ThietKeConTrols.txtSo txtSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl ád;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private ThuVien.ThietKeConTrols.txtSo txtTongTien;
        private ThuVien.ThietKeConTrols.txtTextBox txtTenKhachHang;
        private ThuVien.ThietKeConTrols.dtpkDateTimePicker dtpkNgayDat;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private ThuVien.ThietKeConTrols.txtTextBox txtTenKH;
    }
}