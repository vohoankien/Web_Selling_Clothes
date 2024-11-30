namespace App_Clothings
{
    partial class frmQuanLyKho
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
            this.txtTenKho = new System.Windows.Forms.TextBox();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvKho = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uc_ChucNangCanCo = new ThuVien.ChucNangCanCo();
        //    this.dtgvLoaiSP = new ThuVien.LoadDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(411, 44);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(90, 35);
            this.lbTieuDe.TabIndex = 16;
            this.lbTieuDe.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã kho\r\n";
            // 
            // txtTenKho
            // 
            this.txtTenKho.Location = new System.Drawing.Point(190, 91);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(173, 22);
            this.txtTenKho.TabIndex = 6;
            // 
            // txtMaKho
            // 
            this.txtMaKho.Enabled = false;
            this.txtMaKho.Location = new System.Drawing.Point(190, 44);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(173, 22);
            this.txtMaKho.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên kho";
            // 
            // dtgvKho
            // 
            this.dtgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKho.Location = new System.Drawing.Point(78, 269);
            this.dtgvKho.Name = "dtgvKho";
            this.dtgvKho.RowHeadersWidth = 51;
            this.dtgvKho.RowTemplate.Height = 24;
            this.dtgvKho.Size = new System.Drawing.Size(796, 211);
            this.dtgvKho.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenKho);
            this.groupBox1.Controls.Add(this.txtMaKho);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(78, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 152);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // uc_ChucNangCanCo
            // 
            this.uc_ChucNangCanCo.Location = new System.Drawing.Point(520, 73);
            this.uc_ChucNangCanCo.Name = "uc_ChucNangCanCo";
            this.uc_ChucNangCanCo.Size = new System.Drawing.Size(448, 166);
            this.uc_ChucNangCanCo.TabIndex = 19;
            // 
            // dtgvLoaiSP
            // 
            //this.dtgvLoaiSP.Location = new System.Drawing.Point(55, 269);
            //this.dtgvLoaiSP.Name = "dtgvLoaiSP";
            //this.dtgvLoaiSP.Size = new System.Drawing.Size(819, 268);
            //this.dtgvLoaiSP.TabIndex = 15;
            // 
            // frmQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 581);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.dtgvKho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uc_ChucNangCanCo);
       //     this.Controls.Add(this.dtgvLoaiSP);
            this.Name = "frmQuanLyKho";
            this.Text = "frmQuanLyKho";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKho;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvKho;
        private System.Windows.Forms.GroupBox groupBox1;
        private ThuVien.ChucNangCanCo uc_ChucNangCanCo;
       // private ThuVien.LoadDataGrid dtgvLoaiSP;
    }
}