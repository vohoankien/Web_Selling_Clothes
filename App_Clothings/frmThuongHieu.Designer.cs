namespace App_Clothings
{
    partial class frmThuongHieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNhanHieu = new System.Windows.Forms.TextBox();
            this.txtMaNhanHieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvNhanHieu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uc_ChucNangCanCo = new ThuVien.ChucNangCanCo();
        //    this.dtgvLoaiSP = new ThuVien.LoadDataGrid();
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanHieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(354, 12);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(90, 35);
            this.lbTieuDe.TabIndex = 11;
            this.lbTieuDe.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã thương hiệu";
            // 
            // txtTenNhanHieu
            // 
            this.txtTenNhanHieu.Location = new System.Drawing.Point(190, 91);
            this.txtTenNhanHieu.Name = "txtTenNhanHieu";
            this.txtTenNhanHieu.Size = new System.Drawing.Size(173, 22);
            this.txtTenNhanHieu.TabIndex = 6;
            // 
            // txtMaNhanHieu
            // 
            this.txtMaNhanHieu.Enabled = false;
            this.txtMaNhanHieu.Location = new System.Drawing.Point(190, 44);
            this.txtMaNhanHieu.Name = "txtMaNhanHieu";
            this.txtMaNhanHieu.Size = new System.Drawing.Size(173, 22);
            this.txtMaNhanHieu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên thương hiệu";
            // 
            // dtgvNhanHieu
            // 
            this.dtgvNhanHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanHieu.Location = new System.Drawing.Point(21, 248);
            this.dtgvNhanHieu.Name = "dtgvNhanHieu";
            this.dtgvNhanHieu.RowHeadersWidth = 51;
            this.dtgvNhanHieu.RowTemplate.Height = 24;
            this.dtgvNhanHieu.Size = new System.Drawing.Size(796, 200);
            this.dtgvNhanHieu.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuocGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenNhanHieu);
            this.groupBox1.Controls.Add(this.txtMaNhanHieu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 176);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // uc_ChucNangCanCo
            // 
            this.uc_ChucNangCanCo.Location = new System.Drawing.Point(463, 41);
            this.uc_ChucNangCanCo.Name = "uc_ChucNangCanCo";
            this.uc_ChucNangCanCo.Size = new System.Drawing.Size(448, 166);
            this.uc_ChucNangCanCo.TabIndex = 14;
            // 
            // dtgvLoaiSP
            // 
            //this.dtgvLoaiSP.Location = new System.Drawing.Point(-2, 237);
            //this.dtgvLoaiSP.Name = "dtgvLoaiSP";
            //this.dtgvLoaiSP.Size = new System.Drawing.Size(819, 268);
            //this.dtgvLoaiSP.TabIndex = 10;
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.Location = new System.Drawing.Point(190, 130);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.Size = new System.Drawing.Size(173, 22);
            this.txtQuocGia.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quốc gia";
            // 
            // frmThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 508);
            this.Controls.Add(this.uc_ChucNangCanCo);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.dtgvNhanHieu);
            this.Controls.Add(this.groupBox1);
         //   this.Controls.Add(this.dtgvLoaiSP);
            this.Name = "frmThuongHieu";
            this.Text = "frmThuongHieu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanHieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ThuVien.ChucNangCanCo uc_ChucNangCanCo;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNhanHieu;
        private System.Windows.Forms.TextBox txtMaNhanHieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvNhanHieu;
        private System.Windows.Forms.GroupBox groupBox1;
  //      private ThuVien.LoadDataGrid dtgvLoaiSP;
        private System.Windows.Forms.TextBox txtQuocGia;
        private System.Windows.Forms.Label label3;
    }
}