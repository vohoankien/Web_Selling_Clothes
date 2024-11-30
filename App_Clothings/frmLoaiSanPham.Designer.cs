namespace App_Clothings
{
    partial class frmLoaiSanPham
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
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvLoaiSanPham = new System.Windows.Forms.DataGridView();
            this.uc_ChucNangCanCo = new ThuVien.ChucNangCanCo();
         //   this.dtgvLoaiSP = new ThuVien.LoadDataGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(382, 9);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(90, 35);
            this.lbTieuDe.TabIndex = 2;
            this.lbTieuDe.Text = "label1";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Location = new System.Drawing.Point(190, 44);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(173, 22);
            this.txtMaLoai.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã loại sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên loại sản phẩm";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(190, 97);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(173, 22);
            this.txtTenLoai.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenLoai);
            this.groupBox1.Controls.Add(this.txtMaLoai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(49, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 134);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // dtgvLoaiSanPham
            // 
            this.dtgvLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoaiSanPham.Location = new System.Drawing.Point(49, 268);
            this.dtgvLoaiSanPham.Name = "dtgvLoaiSanPham";
            this.dtgvLoaiSanPham.RowHeadersWidth = 51;
            this.dtgvLoaiSanPham.RowTemplate.Height = 24;
            this.dtgvLoaiSanPham.Size = new System.Drawing.Size(796, 200);
            this.dtgvLoaiSanPham.TabIndex = 8;
            // 
            // uc_ChucNangCanCo
            // 
            this.uc_ChucNangCanCo.Location = new System.Drawing.Point(544, 48);
            this.uc_ChucNangCanCo.Name = "uc_ChucNangCanCo";
            this.uc_ChucNangCanCo.Size = new System.Drawing.Size(328, 166);
            this.uc_ChucNangCanCo.TabIndex = 9;
            // 
            // dtgvLoaiSP
            //// 
            //this.dtgvLoaiSP.Location = new System.Drawing.Point(26, 257);
            //this.dtgvLoaiSP.Name = "dtgvLoaiSP";
            //this.dtgvLoaiSP.Size = new System.Drawing.Size(819, 268);
            //this.dtgvLoaiSP.TabIndex = 1;
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 550);
            this.Controls.Add(this.uc_ChucNangCanCo);
            this.Controls.Add(this.dtgvLoaiSanPham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTieuDe);
          //  this.Controls.Add(this.dtgvLoaiSP);
            this.Name = "frmLoaiSanPham";
            this.Text = "frmLoaiSanPham";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       // private ThuVien.LoadDataGrid dtgvLoaiSP;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvLoaiSanPham;
        private ThuVien.ChucNangCanCo uc_ChucNangCanCo;
    }
}