namespace App_Clothings
{
    partial class frmThongKeDT
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
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chartSanPham = new DevExpress.XtraCharts.ChartControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.chartDoanhThu = new DevExpress.XtraCharts.ChartControl();
            this.dtpkBatDau = new ThuVien.ThietKeConTrols.dtpkDateTimePicker();
            this.dtpkKetThuc = new ThuVien.ThietKeConTrols.dtpkDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = global::App_Clothings.Properties.Resources.kpi_32x32;
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnThongKe);
            this.groupControl1.Controls.Add(this.dtpkBatDau);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.chartDoanhThu);
            this.groupControl1.Controls.Add(this.dtpkKetThuc);
            this.groupControl1.Location = new System.Drawing.Point(52, 335);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(767, 330);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Doanh thu theo thời gian";
            // 
            // btnThongKe
            // 
            this.btnThongKe.ImageOptions.Image = global::App_Clothings.Properties.Resources.bar_32x321;
            this.btnThongKe.Location = new System.Drawing.Point(663, 53);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(44, 35);
            this.btnThongKe.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(300, 66);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 22);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Kết thúc";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 66);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 22);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Bắt đầu";
            // 
            // chartSanPham
            // 
            this.chartSanPham.Location = new System.Drawing.Point(19, 68);
            this.chartSanPham.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.chartSanPham.Name = "chartSanPham";
            series2.Name = "Series 1";
            series2.View = pieSeriesView1;
            this.chartSanPham.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartSanPham.Size = new System.Drawing.Size(688, 194);
            this.chartSanPham.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = global::App_Clothings.Properties.Resources.drilldownonseries_pie_32x32;
            this.groupControl2.Controls.Add(this.chartSanPham);
            this.groupControl2.Location = new System.Drawing.Point(52, 5);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(767, 297);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Sản phẩm bán chạy";
            // 
            // chartDoanhThu
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartDoanhThu.Diagram = xyDiagram1;
            this.chartDoanhThu.Location = new System.Drawing.Point(19, 101);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.Name = "Series 1";
            this.chartDoanhThu.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartDoanhThu.Size = new System.Drawing.Size(688, 224);
            this.chartDoanhThu.TabIndex = 0;
            // 
            // dtpkBatDau
            // 
            this.dtpkBatDau.CustomFormat = "dd/MM/yyy";
            this.dtpkBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkBatDau.Location = new System.Drawing.Point(97, 65);
            this.dtpkBatDau.Margin = new System.Windows.Forms.Padding(8);
            this.dtpkBatDau.Name = "dtpkBatDau";
            this.dtpkBatDau.Size = new System.Drawing.Size(119, 23);
            this.dtpkBatDau.TabIndex = 2;
            // 
            // dtpkKetThuc
            // 
            this.dtpkKetThuc.CustomFormat = "dd/MM/yyy";
            this.dtpkKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkKetThuc.Location = new System.Drawing.Point(419, 65);
            this.dtpkKetThuc.Margin = new System.Windows.Forms.Padding(8);
            this.dtpkKetThuc.Name = "dtpkKetThuc";
            this.dtpkKetThuc.Size = new System.Drawing.Size(107, 23);
            this.dtpkKetThuc.TabIndex = 3;
            // 
            // frmThongKeDT
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 686);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.IconOptions.LargeImage = global::App_Clothings.Properties.Resources.bar_32x32;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongKeDT";
            this.Text = "Thống kê doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ThuVien.ThietKeConTrols.dtpkDateTimePicker dtpkBatDau;
        private ThuVien.ThietKeConTrols.dtpkDateTimePicker dtpkKetThuc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private DevExpress.XtraCharts.ChartControl chartSanPham;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraCharts.ChartControl chartDoanhThu;
    }
}