namespace App_Clothings
{
    partial class frmKhuyenMai
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
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.uc_ChucNangCoBan = new ThuVien.ThietKeConTrols.uc_ChucNangCoBan();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dtgvKhuyenMai = new ThuVien.ThietKeConTrols.dtgvData();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtpkNgayKetThuc = new ThuVien.ThietKeConTrols.dtpkDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkNgayBatDau = new ThuVien.ThietKeConTrols.dtpkDateTimePicker();
            this.txtPhanTramKhuyenMai = new ThuVien.ThietKeConTrols.txtSo();
            this.txtTenKhuyenMai = new ThuVien.ThietKeConTrols.txtTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKhuyenMai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhuyenMai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(353, 18);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(342, 35);
            this.lbTieuDe.TabIndex = 22;
            this.lbTieuDe.Text = "Chương trình khuyến mãi";
            // 
            // uc_ChucNangCoBan
            // 
            this.uc_ChucNangCoBan.Location = new System.Drawing.Point(607, 84);
            this.uc_ChucNangCoBan.Name = "uc_ChucNangCoBan";
            this.uc_ChucNangCoBan.Size = new System.Drawing.Size(325, 111);
            this.uc_ChucNangCoBan.TabIndex = 25;
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = global::App_Clothings.Properties.Resources.salesanalysis_32x32;
            this.groupControl2.Controls.Add(this.dtgvKhuyenMai);
            this.groupControl2.Location = new System.Drawing.Point(49, 422);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(883, 255);
            this.groupControl2.TabIndex = 27;
            this.groupControl2.Text = "Danh sách khuyến mãi";
            // 
            // dtgvKhuyenMai
            // 
            this.dtgvKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKhuyenMai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhuyenMai.Location = new System.Drawing.Point(23, 42);
            this.dtgvKhuyenMai.Name = "dtgvKhuyenMai";
            this.dtgvKhuyenMai.RowHeadersWidth = 51;
            this.dtgvKhuyenMai.RowTemplate.Height = 24;
            this.dtgvKhuyenMai.Size = new System.Drawing.Size(835, 191);
            this.dtgvKhuyenMai.TabIndex = 24;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = global::App_Clothings.Properties.Resources.salesperiodlifetime_32x32;
            this.groupControl1.Controls.Add(this.dtpkNgayKetThuc);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.dtpkNgayBatDau);
            this.groupControl1.Controls.Add(this.txtPhanTramKhuyenMai);
            this.groupControl1.Controls.Add(this.txtTenKhuyenMai);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtMaKhuyenMai);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(49, 211);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(883, 181);
            this.groupControl1.TabIndex = 26;
            this.groupControl1.Text = "Khuyến mãi";
            // 
            // dtpkNgayKetThuc
            // 
            this.dtpkNgayKetThuc.CustomFormat = "dd/MM/yyy";
            this.dtpkNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayKetThuc.Location = new System.Drawing.Point(658, 130);
            this.dtpkNgayKetThuc.Name = "dtpkNgayKetThuc";
            this.dtpkNgayKetThuc.Size = new System.Drawing.Size(200, 23);
            this.dtpkNgayKetThuc.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(499, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ngày kết thúc";
            // 
            // dtpkNgayBatDau
            // 
            this.dtpkNgayBatDau.CustomFormat = "dd/MM/yyy";
            this.dtpkNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayBatDau.Location = new System.Drawing.Point(154, 129);
            this.dtpkNgayBatDau.Name = "dtpkNgayBatDau";
            this.dtpkNgayBatDau.Size = new System.Drawing.Size(200, 23);
            this.dtpkNgayBatDau.TabIndex = 25;
            // 
            // txtPhanTramKhuyenMai
            // 
            this.txtPhanTramKhuyenMai.Location = new System.Drawing.Point(745, 65);
            this.txtPhanTramKhuyenMai.Name = "txtPhanTramKhuyenMai";
            this.txtPhanTramKhuyenMai.Size = new System.Drawing.Size(113, 23);
            this.txtPhanTramKhuyenMai.TabIndex = 22;
            // 
            // txtTenKhuyenMai
            // 
            this.txtTenKhuyenMai.Location = new System.Drawing.Point(447, 61);
            this.txtTenKhuyenMai.Name = "txtTenKhuyenMai";
            this.txtTenKhuyenMai.Size = new System.Drawing.Size(113, 23);
            this.txtTenKhuyenMai.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Phần trăm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã khuyến mãi";
            // 
            // txtMaKhuyenMai
            // 
            this.txtMaKhuyenMai.Enabled = false;
            this.txtMaKhuyenMai.Location = new System.Drawing.Point(168, 62);
            this.txtMaKhuyenMai.Name = "txtMaKhuyenMai";
            this.txtMaKhuyenMai.Size = new System.Drawing.Size(113, 23);
            this.txtMaKhuyenMai.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên khuyến mãi";
            // 
            // frmKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 698);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.uc_ChucNangCoBan);
            this.Controls.Add(this.lbTieuDe);
            this.Name = "frmKhuyenMai";
            this.Text = "Quản lý khuyến mãi";
            this.Load += new System.EventHandler(this.frmKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhuyenMai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private ThuVien.ThietKeConTrols.dtgvData dtgvKhuyenMai;
        private ThuVien.ThietKeConTrols.uc_ChucNangCoBan uc_ChucNangCoBan;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private ThuVien.ThietKeConTrols.dtpkDateTimePicker dtpkNgayKetThuc;
        private System.Windows.Forms.Label label4;
        private ThuVien.ThietKeConTrols.dtpkDateTimePicker dtpkNgayBatDau;
        private ThuVien.ThietKeConTrols.txtSo txtPhanTramKhuyenMai;
        private ThuVien.ThietKeConTrols.txtTextBox txtTenKhuyenMai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKhuyenMai;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}