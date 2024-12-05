namespace App_Clothings
{
    partial class frmTHieu
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
            this.dtgvNhanHieu = new System.Windows.Forms.DataGridView();
            this.uc_ChucNangCanCo = new ThuVien.ThietKeConTrols.uc_ChucNangCoBan();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNhanHieu = new System.Windows.Forms.TextBox();
            this.txtMaNhanHieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanHieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(327, 32);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(276, 35);
            this.lbTieuDe.TabIndex = 19;
            this.lbTieuDe.Text = "Quản lý thương hiệu";
            // 
            // dtgvNhanHieu
            // 
            this.dtgvNhanHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanHieu.Location = new System.Drawing.Point(33, 54);
            this.dtgvNhanHieu.Name = "dtgvNhanHieu";
            this.dtgvNhanHieu.RowHeadersWidth = 51;
            this.dtgvNhanHieu.RowTemplate.Height = 24;
            this.dtgvNhanHieu.Size = new System.Drawing.Size(721, 200);
            this.dtgvNhanHieu.TabIndex = 21;
            // 
            // uc_ChucNangCanCo
            // 
            this.uc_ChucNangCanCo.Location = new System.Drawing.Point(526, 147);
            this.uc_ChucNangCanCo.Name = "uc_ChucNangCanCo";
            this.uc_ChucNangCanCo.Size = new System.Drawing.Size(315, 104);
            this.uc_ChucNangCanCo.TabIndex = 22;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = global::App_Clothings.Properties.Resources.bo_localization;
            this.groupControl1.Controls.Add(this.txtQuocGia);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtTenNhanHieu);
            this.groupControl1.Controls.Add(this.txtMaNhanHieu);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(71, 111);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(409, 181);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "Thương hiệu";
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.Location = new System.Drawing.Point(190, 139);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.Size = new System.Drawing.Size(173, 23);
            this.txtQuocGia.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quốc gia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã thương hiệu";
            // 
            // txtTenNhanHieu
            // 
            this.txtTenNhanHieu.Location = new System.Drawing.Point(190, 100);
            this.txtTenNhanHieu.Name = "txtTenNhanHieu";
            this.txtTenNhanHieu.Size = new System.Drawing.Size(173, 23);
            this.txtTenNhanHieu.TabIndex = 12;
            // 
            // txtMaNhanHieu
            // 
            this.txtMaNhanHieu.Enabled = false;
            this.txtMaNhanHieu.Location = new System.Drawing.Point(190, 53);
            this.txtMaNhanHieu.Name = "txtMaNhanHieu";
            this.txtMaNhanHieu.Size = new System.Drawing.Size(173, 23);
            this.txtMaNhanHieu.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên thương hiệu";
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.SvgImage = global::App_Clothings.Properties.Resources.bo_vendor;
            this.groupControl2.Controls.Add(this.dtgvNhanHieu);
            this.groupControl2.Location = new System.Drawing.Point(71, 331);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(770, 259);
            this.groupControl2.TabIndex = 24;
            this.groupControl2.Text = "Danh sách thương hiệu";
            // 
            // frmTHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 602);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.uc_ChucNangCanCo);
            this.Controls.Add(this.lbTieuDe);
            this.Name = "frmTHieu";
            this.Text = "Quản lý thương hiệu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanHieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.DataGridView dtgvNhanHieu;
        private ThuVien.ThietKeConTrols.uc_ChucNangCoBan uc_ChucNangCanCo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtQuocGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNhanHieu;
        private System.Windows.Forms.TextBox txtMaNhanHieu;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}