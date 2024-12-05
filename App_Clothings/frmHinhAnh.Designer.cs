namespace App_Clothings
{
    partial class frmHinhAnh
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHinhAnh = new System.Windows.Forms.ComboBox();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.btnHinhAnh = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox = new ThuVien.ThietKeConTrols.pictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = global::App_Clothings.Properties.Resources.open2;
            this.groupControl1.Controls.Add(this.pictureBox);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.cbHinhAnh);
            this.groupControl1.Controls.Add(this.txtHinhAnh);
            this.groupControl1.Controls.Add(this.btnHinhAnh);
            this.groupControl1.Location = new System.Drawing.Point(27, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(439, 251);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Hình ảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách hình ảnh";
            // 
            // cbHinhAnh
            // 
            this.cbHinhAnh.FormattingEnabled = true;
            this.cbHinhAnh.Location = new System.Drawing.Point(250, 208);
            this.cbHinhAnh.Name = "cbHinhAnh";
            this.cbHinhAnh.Size = new System.Drawing.Size(172, 24);
            this.cbHinhAnh.TabIndex = 8;
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Location = new System.Drawing.Point(92, 93);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(110, 23);
            this.txtHinhAnh.TabIndex = 7;
            // 
            // btnHinhAnh
            // 
            this.btnHinhAnh.ImageOptions.SvgImage = global::App_Clothings.Properties.Resources.insertimage;
            this.btnHinhAnh.Location = new System.Drawing.Point(10, 89);
            this.btnHinhAnh.Name = "btnHinhAnh";
            this.btnHinhAnh.Size = new System.Drawing.Size(46, 29);
            this.btnHinhAnh.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = global::App_Clothings.Properties.Resources.bg;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(250, 44);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(172, 143);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // frmHinhAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 275);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmHinhAnh";
            this.Text = "Quản lý hình ảnh";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private ThuVien.ThietKeConTrols.pictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHinhAnh;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private DevExpress.XtraEditors.SimpleButton btnHinhAnh;
    }
}