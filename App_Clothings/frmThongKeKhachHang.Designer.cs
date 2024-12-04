namespace App_Clothings
{
    partial class frmThongKeKhachHang
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
            DevExpress.XtraCharts.ScatterRadarLineSeriesView scatterRadarLineSeriesView3 = new DevExpress.XtraCharts.ScatterRadarLineSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ScatterRadarLineSeriesView scatterRadarLineSeriesView4 = new DevExpress.XtraCharts.ScatterRadarLineSeriesView();
            this.chartKhacHang = new DevExpress.XtraCharts.ChartControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartKhacHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(scatterRadarLineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(scatterRadarLineSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartKhacHang
            // 
            this.chartKhacHang.Location = new System.Drawing.Point(40, 65);
            this.chartKhacHang.Name = "chartKhacHang";
            series3.Name = "srTongTien";
            series3.View = scatterRadarLineSeriesView3;
            series4.Name = "srSoLuong";
            series4.View = scatterRadarLineSeriesView4;
            this.chartKhacHang.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3,
        series4};
            this.chartKhacHang.Size = new System.Drawing.Size(750, 482);
            this.chartKhacHang.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = global::App_Clothings.Properties.Resources.charttype_radarline;
            this.groupControl1.Controls.Add(this.chartKhacHang);
            this.groupControl1.Location = new System.Drawing.Point(48, 32);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(834, 579);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thống kê";
            // 
            // frmThongKeKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 637);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmThongKeKhachHang";
            this.Text = "Thống kê khách hàng tiềm năng";
            ((System.ComponentModel.ISupportInitialize)(scatterRadarLineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(scatterRadarLineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKhacHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartKhacHang;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}