namespace App_Clothings
{
    partial class frmQuanLyKhuyenMai
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKhuyenMai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpkNgayKetThuc = new ThuVien.ThietKeConTrols.dtpkDateTimePicker();
            this.dtpkNgayBatDau = new ThuVien.ThietKeConTrols.dtpkDateTimePicker();
            this.txtPhanTramKhuyenMai = new ThuVien.ThietKeConTrols.txtSo();
            this.txtTenKhuyenMai = new ThuVien.ThietKeConTrols.txtTextBox();
            this.dtgvKhuyenMai = new ThuVien.ThietKeConTrols.dtgvData();
            this.uc_ChucNangCanCo = new ThuVien.ChucNangCanCo();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(420, 17);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(90, 35);
            this.lbTieuDe.TabIndex = 18;
            this.lbTieuDe.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên kho";
            // 
            // txtMaKhuyenMai
            // 
            this.txtMaKhuyenMai.Enabled = false;
            this.txtMaKhuyenMai.Location = new System.Drawing.Point(157, 30);
            this.txtMaKhuyenMai.Name = "txtMaKhuyenMai";
            this.txtMaKhuyenMai.Size = new System.Drawing.Size(113, 22);
            this.txtMaKhuyenMai.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã khuyến mãi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phần trăm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(555, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày kết thúc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpkNgayKetThuc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpkNgayBatDau);
            this.groupBox1.Controls.Add(this.txtPhanTramKhuyenMai);
            this.groupBox1.Controls.Add(this.txtTenKhuyenMai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaKhuyenMai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1013, 166);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // dtpkNgayKetThuc
            // 
            this.dtpkNgayKetThuc.Location = new System.Drawing.Point(707, 97);
            this.dtpkNgayKetThuc.Name = "dtpkNgayKetThuc";
            this.dtpkNgayKetThuc.Size = new System.Drawing.Size(200, 22);
            this.dtpkNgayKetThuc.TabIndex = 16;
            // 
            // dtpkNgayBatDau
            // 
            this.dtpkNgayBatDau.Location = new System.Drawing.Point(157, 98);
            this.dtpkNgayBatDau.Name = "dtpkNgayBatDau";
            this.dtpkNgayBatDau.Size = new System.Drawing.Size(200, 22);
            this.dtpkNgayBatDau.TabIndex = 15;
            // 
            // txtPhanTramKhuyenMai
            // 
            this.txtPhanTramKhuyenMai.Location = new System.Drawing.Point(707, 30);
            this.txtPhanTramKhuyenMai.Name = "txtPhanTramKhuyenMai";
            this.txtPhanTramKhuyenMai.Size = new System.Drawing.Size(113, 22);
            this.txtPhanTramKhuyenMai.TabIndex = 9;
            // 
            // txtTenKhuyenMai
            // 
            this.txtTenKhuyenMai.Location = new System.Drawing.Point(397, 30);
            this.txtTenKhuyenMai.Name = "txtTenKhuyenMai";
            this.txtTenKhuyenMai.Size = new System.Drawing.Size(113, 22);
            this.txtTenKhuyenMai.TabIndex = 8;
            // 
            // dtgvKhuyenMai
            // 
            this.dtgvKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKhuyenMai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhuyenMai.Location = new System.Drawing.Point(26, 253);
            this.dtgvKhuyenMai.Name = "dtgvKhuyenMai";
            this.dtgvKhuyenMai.RowHeadersWidth = 51;
            this.dtgvKhuyenMai.RowTemplate.Height = 24;
            this.dtgvKhuyenMai.Size = new System.Drawing.Size(690, 227);
            this.dtgvKhuyenMai.TabIndex = 20;
            // 
            // uc_ChucNangCanCo
            // 
            this.uc_ChucNangCanCo.Location = new System.Drawing.Point(689, 253);
            this.uc_ChucNangCanCo.Name = "uc_ChucNangCanCo";
            this.uc_ChucNangCanCo.Size = new System.Drawing.Size(439, 166);
            this.uc_ChucNangCanCo.TabIndex = 0;
            // 
            // frmQuanLyKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 510);
            this.Controls.Add(this.dtgvKhuyenMai);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uc_ChucNangCanCo);
            this.Name = "frmQuanLyKhuyenMai";
            this.Text = "QuanLyKhuyenMai";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhuyenMai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTieuDe;
        private ThuVien.ChucNangCanCo uc_ChucNangCanCo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKhuyenMai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private ThuVien.ThietKeConTrols.txtTextBox txtTenKhuyenMai;
        private ThuVien.ThietKeConTrols.txtSo txtPhanTramKhuyenMai;
        private ThuVien.ThietKeConTrols.dtpkDateTimePicker dtpkNgayBatDau;
        private System.Windows.Forms.Label label4;
        private ThuVien.ThietKeConTrols.dtpkDateTimePicker dtpkNgayKetThuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private ThuVien.ThietKeConTrols.dtgvData dtgvKhuyenMai;
    }
}