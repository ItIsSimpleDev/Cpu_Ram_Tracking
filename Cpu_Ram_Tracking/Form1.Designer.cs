
namespace Cpu_Ram_Tracking
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.RamPerformanceCounter = new System.Diagnostics.PerformanceCounter();
            this.CpuPerformanceCounter = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cpuProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ramProgressBar = new System.Windows.Forms.ProgressBar();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.ramLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.RamPerformanceCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpuPerformanceCounter)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // RamPerformanceCounter
            // 
            this.RamPerformanceCounter.CategoryName = "Memory";
            this.RamPerformanceCounter.CounterName = "% Committed Bytes In Use";
            // 
            // CpuPerformanceCounter
            // 
            this.CpuPerformanceCounter.CategoryName = "Processor";
            this.CpuPerformanceCounter.CounterName = "% Processor Time";
            this.CpuPerformanceCounter.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cpuProgressBar
            // 
            this.cpuProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpuProgressBar.Location = new System.Drawing.Point(141, 20);
            this.cpuProgressBar.Name = "cpuProgressBar";
            this.cpuProgressBar.Size = new System.Drawing.Size(622, 37);
            this.cpuProgressBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "RAM";
            // 
            // ramProgressBar
            // 
            this.ramProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ramProgressBar.Location = new System.Drawing.Point(141, 63);
            this.ramProgressBar.Name = "ramProgressBar";
            this.ramProgressBar.Size = new System.Drawing.Size(622, 37);
            this.ramProgressBar.TabIndex = 2;
            // 
            // cpuLabel
            // 
            this.cpuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLabel.Location = new System.Drawing.Point(769, 20);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(71, 37);
            this.cpuLabel.TabIndex = 4;
            this.cpuLabel.Text = "0 %";
            // 
            // ramLabel
            // 
            this.ramLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ramLabel.AutoSize = true;
            this.ramLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramLabel.Location = new System.Drawing.Point(769, 63);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(71, 37);
            this.ramLabel.TabIndex = 5;
            this.ramLabel.Text = "0 %";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.trackingChart);
            this.panel1.Controls.Add(this.ramProgressBar);
            this.panel1.Controls.Add(this.ramLabel);
            this.panel1.Controls.Add(this.cpuProgressBar);
            this.panel1.Controls.Add(this.cpuLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 551);
            this.panel1.TabIndex = 6;
            // 
            // trackingChart
            // 
            chartArea7.Name = "ChartArea1";
            this.trackingChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.trackingChart.Legends.Add(legend7);
            this.trackingChart.Location = new System.Drawing.Point(141, 106);
            this.trackingChart.Name = "trackingChart";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "CPU";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "RAM";
            this.trackingChart.Series.Add(series13);
            this.trackingChart.Series.Add(series14);
            this.trackingChart.Size = new System.Drawing.Size(622, 432);
            this.trackingChart.TabIndex = 6;
            this.trackingChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 551);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU & RAM";
            ((System.ComponentModel.ISupportInitialize)(this.RamPerformanceCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpuPerformanceCounter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackingChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter RamPerformanceCounter;
        private System.Diagnostics.PerformanceCounter CpuPerformanceCounter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar cpuProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar ramProgressBar;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.Label ramLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart trackingChart;
    }
}

