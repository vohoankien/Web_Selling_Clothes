namespace App_Clothings
{
    partial class frmQuanLyTaiKhoan
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
            this.dtgvQLTaiKhoan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMatKhau = new ThuVien.ThietKeConTrols.txtMatKhau();
            this.txtHoTen = new ThuVien.ThietKeConTrols.txtHoTen();
            this.txtSoDienThoai = new ThuVien.ThietKeConTrols.txtSoDienThoai();
            this.ucQLQuyen = new ThuVien.QuanLyQuyen();
            this.ucChucNangNC = new ThuVien.ChucNangNangCao();
            this.txtEmail = new ThuVien.ThietKeConTrols.txtEmail();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLTaiKhoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvQLTaiKhoan
            // 
            this.dtgvQLTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLTaiKhoan.Location = new System.Drawing.Point(17, 32);
            this.dtgvQLTaiKhoan.Name = "dtgvQLTaiKhoan";
            this.dtgvQLTaiKhoan.RowHeadersWidth = 51;
            this.dtgvQLTaiKhoan.RowTemplate.Height = 24;
            this.dtgvQLTaiKhoan.Size = new System.Drawing.Size(615, 356);
            this.dtgvQLTaiKhoan.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvQLTaiKhoan);
            this.groupBox1.Controls.Add(this.ucQLQuyen);
            this.groupBox1.Controls.Add(this.ucChucNangNC);
            this.groupBox1.Location = new System.Drawing.Point(12, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 411);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // txtMaTK
            // 
            this.txtMaTK.Enabled = false;
            this.txtMaTK.Location = new System.Drawing.Point(143, 69);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(176, 22);
            this.txtMaTK.TabIndex = 2;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(143, 117);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(176, 22);
            this.txtTenTK.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Họ và Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(703, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(703, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(813, 117);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(185, 22);
            this.txtDiaChi.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(703, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(703, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Số điện thoại :";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(468, 72);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(176, 22);
            this.txtMatKhau.TabIndex = 26;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(468, 123);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(176, 22);
            this.txtHoTen.TabIndex = 25;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(813, 160);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(185, 22);
            this.txtSoDienThoai.TabIndex = 24;
            // 
            // ucQLQuyen
            // 
            this.ucQLQuyen.Location = new System.Drawing.Point(647, 21);
            this.ucQLQuyen.Name = "ucQLQuyen";
            this.ucQLQuyen.Size = new System.Drawing.Size(349, 220);
            this.ucQLQuyen.TabIndex = 9;
            this.ucQLQuyen.TenQuyen = "";
            // 
            // ucChucNangNC
            // 
            this.ucChucNangNC.Location = new System.Drawing.Point(659, 232);
            this.ucChucNangNC.Name = "ucChucNangNC";
            this.ucChucNangNC.Size = new System.Drawing.Size(394, 201);
            this.ucChucNangNC.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(813, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 22);
            this.txtEmail.TabIndex = 27;
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 637);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.txtMaTK);
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "frmQuanLyTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLTaiKhoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvQLTaiKhoan;
        private ThuVien.ChucNangNangCao ucChucNangNC;
        private ThuVien.QuanLyQuyen ucQLQuyen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ThuVien.ThietKeConTrols.txtSoDienThoai txtSoDienThoai;
        private ThuVien.ThietKeConTrols.txtHoTen txtHoTen;
        private ThuVien.ThietKeConTrols.txtMatKhau txtMatKhau;
        private ThuVien.ThietKeConTrols.txtEmail txtEmail;
    }
}