namespace App_Clothings
{
    partial class frmSize
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
            this.txtSize = new ThuVien.ThietKeConTrols.txtTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSize = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = global::App_Clothings.Properties.Resources.bo_price_item;
            this.groupControl1.Controls.Add(this.btnSize);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.cbSize);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtSize);
            this.groupControl1.Location = new System.Drawing.Point(29, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(336, 178);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Size sản phẩm";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(154, 67);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 23);
            this.txtSize.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size sản phẩm";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(154, 115);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(177, 24);
            this.cbSize.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách size";
            // 
            // btnSize
            // 
            this.btnSize.ImageOptions.SvgImage = global::App_Clothings.Properties.Resources.actions_add;
            this.btnSize.Location = new System.Drawing.Point(284, 63);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(47, 29);
            this.btnSize.TabIndex = 4;
            // 
            // frmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 212);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmSize";
            this.Text = "Quản lý size";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label label1;
        private ThuVien.ThietKeConTrols.txtTextBox txtSize;
    }
}