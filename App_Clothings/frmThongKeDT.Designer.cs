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
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.chartSanPham = new DevExpress.XtraCharts.ChartControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.dtpkBatDau = new ThuVien.ThietKeConTrols.dtpkDateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chartDoanhThu = new DevExpress.XtraCharts.ChartControl();
            this.dtpkKetThuc = new ThuVien.ThietKeConTrols.dtpkDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.907032F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.09296F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 662);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = global::App_Clothings.Properties.Resources.drilldownonseries_pie_32x32;
            this.groupControl2.Controls.Add(this.chartSanPham);
            this.groupControl2.Location = new System.Drawing.Point(48, 18);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(767, 297);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Sản phẩm bán chạy";
            // 
            // chartSanPham
            // 
            this.chartSanPham.Location = new System.Drawing.Point(24, 67);
            this.chartSanPham.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.chartSanPham.Name = "chartSanPham";
            series3.Name = "Series 1";
            series3.View = pieSeriesView2;
            this.chartSanPham.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartSanPham.Size = new System.Drawing.Size(688, 194);
            this.chartSanPham.TabIndex = 0;
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
            this.groupControl1.Location = new System.Drawing.Point(48, 339);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(767, 330);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Doanh thu theo thời gian";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 66);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 22);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Bắt đầu";
            // 
            // btnThongKe
            // 
            this.btnThongKe.ImageOptions.Image = global::App_Clothings.Properties.Resources.bar_32x321;
            this.btnThongKe.Location = new System.Drawing.Point(663, 53);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(6);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(44, 35);
            this.btnThongKe.TabIndex = 6;
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(300, 66);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 22);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Kết thúc";
            // 
            // chartDoanhThu
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartDoanhThu.Diagram = xyDiagram2;
            this.chartDoanhThu.Location = new System.Drawing.Point(23, 98);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series4.Name = "Series 1";
            this.chartDoanhThu.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
            this.chartDoanhThu.Size = new System.Drawing.Size(688, 224);
            this.chartDoanhThu.TabIndex = 0;
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
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(863, 686);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.IconOptions.LargeImage = global::App_Clothings.Properties.Resources.bar_32x32;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongKeDT";
            this.Text = "Thống kê doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraCharts.ChartControl chartSanPham;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private ThuVien.ThietKeConTrols.dtpkDateTimePicker dtpkBatDau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraCharts.ChartControl chartDoanhThu;
        private ThuVien.ThietKeConTrols.dtpkDateTimePicker dtpkKetThuc;
    }
}