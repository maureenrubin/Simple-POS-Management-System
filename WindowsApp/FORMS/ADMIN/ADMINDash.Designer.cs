namespace WindowsApp.FORMS
{
    partial class ADMINDash
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartPurchase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newAppDataSet = new WindowsApp.NewAppDataSet();
            this.purchaseTableAdapter = new WindowsApp.NewAppDataSetTableAdapters.PurchaseTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(861, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN DASHBOARD";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1169, 61);
            this.panel3.TabIndex = 3;
            // 
            // chartPurchase
            // 
            this.chartPurchase.BackColor = System.Drawing.Color.RosyBrown;
            this.chartPurchase.BorderlineColor = System.Drawing.Color.RosyBrown;
            chartArea1.Name = "ChartArea1";
            this.chartPurchase.ChartAreas.Add(chartArea1);
            this.chartPurchase.DataSource = this.purchaseBindingSource;
            this.chartPurchase.Location = new System.Drawing.Point(39, 102);
            this.chartPurchase.Name = "chartPurchase";
            this.chartPurchase.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Series1";
            this.chartPurchase.Series.Add(series1);
            this.chartPurchase.Size = new System.Drawing.Size(571, 332);
            this.chartPurchase.TabIndex = 4;
            this.chartPurchase.Text = "chart1";
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataMember = "Purchase";
            this.purchaseBindingSource.DataSource = this.newAppDataSet;
            // 
            // newAppDataSet
            // 
            this.newAppDataSet.DataSetName = "NewAppDataSet";
            this.newAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(662, 112);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "Series2";
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(456, 416);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // ADMINDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1169, 669);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chartPurchase);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADMINDash";
            this.Text = "HomeDash";
            this.Load += new System.EventHandler(this.ADMINDash_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPurchase;
        private NewAppDataSet newAppDataSet;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private NewAppDataSetTableAdapters.PurchaseTableAdapter purchaseTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}