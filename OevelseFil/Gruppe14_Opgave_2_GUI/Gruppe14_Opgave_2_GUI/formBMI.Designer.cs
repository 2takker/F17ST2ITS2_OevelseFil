namespace Gruppe15_Opgave_2_GUI
{
    partial class formBMI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartBMI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartBMI)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBMI
            // 
            chartArea1.AxisX.Title = "Dato";
            chartArea1.AxisY.Title = "kg";
            chartArea1.Name = "ChartArea1";
            this.chartBMI.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartBMI.Legends.Add(legend1);
            this.chartBMI.Location = new System.Drawing.Point(40, 44);
            this.chartBMI.Name = "chartBMI";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Vaegt";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.MediumSeaGreen;
            series2.Legend = "Legend1";
            series2.Name = "BMI";
            this.chartBMI.Series.Add(series1);
            this.chartBMI.Series.Add(series2);
            this.chartBMI.Size = new System.Drawing.Size(1091, 847);
            this.chartBMI.TabIndex = 0;
            // 
            // formBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 948);
            this.Controls.Add(this.chartBMI);
            this.Name = "formBMI";
            this.Text = "Vægt og BMI";
            ((System.ComponentModel.ISupportInitialize)(this.chartBMI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBMI;
    }
}