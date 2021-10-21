
namespace PhumlaKamnandi.Presentation_Layer
{
    partial class OccupancyLevelReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OccupancyLevelReport));
            this.listViewOccupancy = new System.Windows.Forms.ListView();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.occupancyDateSelector = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartYearlyOccupanyDoughnut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLineYearlyLevels = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalBookings = new System.Windows.Forms.TextBox();
            this.txtBookings4Month = new System.Windows.Forms.TextBox();
            this.txtAvailability = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartYearlyOccupanyDoughnut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLineYearlyLevels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewOccupancy
            // 
            this.listViewOccupancy.HideSelection = false;
            this.listViewOccupancy.Location = new System.Drawing.Point(64, 171);
            this.listViewOccupancy.Name = "listViewOccupancy";
            this.listViewOccupancy.Size = new System.Drawing.Size(795, 243);
            this.listViewOccupancy.TabIndex = 18;
            this.listViewOccupancy.UseCompatibleStateImageBehavior = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(575, 81);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(160, 31);
            this.buttonConfirm.TabIndex = 17;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // occupancyDateSelector
            // 
            this.occupancyDateSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupancyDateSelector.Location = new System.Drawing.Point(146, 85);
            this.occupancyDateSelector.Margin = new System.Windows.Forms.Padding(4);
            this.occupancyDateSelector.Name = "occupancyDateSelector";
            this.occupancyDateSelector.Size = new System.Drawing.Size(408, 27);
            this.occupancyDateSelector.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(68, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(412, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Occupancy Level Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(34, 432);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Yearly Occupancy Levels";
            // 
            // chartYearlyOccupanyDoughnut
            // 
            chartArea1.Name = "ChartArea1";
            this.chartYearlyOccupanyDoughnut.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartYearlyOccupanyDoughnut.Legends.Add(legend1);
            this.chartYearlyOccupanyDoughnut.Location = new System.Drawing.Point(64, 460);
            this.chartYearlyOccupanyDoughnut.Name = "chartYearlyOccupanyDoughnut";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "yearlyOccupancyLevels";
            this.chartYearlyOccupanyDoughnut.Series.Add(series1);
            this.chartYearlyOccupanyDoughnut.Size = new System.Drawing.Size(312, 275);
            this.chartYearlyOccupanyDoughnut.TabIndex = 19;
            this.chartYearlyOccupanyDoughnut.Text = "chart1";
            // 
            // chartLineYearlyLevels
            // 
            chartArea2.Name = "ChartArea1";
            this.chartLineYearlyLevels.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartLineYearlyLevels.Legends.Add(legend2);
            this.chartLineYearlyLevels.Location = new System.Drawing.Point(377, 460);
            this.chartLineYearlyLevels.Name = "chartLineYearlyLevels";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "lineYearlyLevels";
            this.chartLineYearlyLevels.Series.Add(series2);
            this.chartLineYearlyLevels.Size = new System.Drawing.Size(741, 300);
            this.chartLineYearlyLevels.TabIndex = 20;
            this.chartLineYearlyLevels.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total bookings:";
            // 
            // summary
            // 
            this.summary.Controls.Add(this.txtAvailability);
            this.summary.Controls.Add(this.txtBookings4Month);
            this.summary.Controls.Add(this.txtTotalBookings);
            this.summary.Controls.Add(this.label6);
            this.summary.Controls.Add(this.label5);
            this.summary.Controls.Add(this.label4);
            this.summary.Location = new System.Drawing.Point(877, 171);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(306, 168);
            this.summary.TabIndex = 22;
            this.summary.TabStop = false;
            this.summary.Text = "summary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Total bookings for the month:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Availability:";
            // 
            // txtTotalBookings
            // 
            this.txtTotalBookings.Location = new System.Drawing.Point(127, 39);
            this.txtTotalBookings.Name = "txtTotalBookings";
            this.txtTotalBookings.Size = new System.Drawing.Size(148, 22);
            this.txtTotalBookings.TabIndex = 24;
            // 
            // txtBookings4Month
            // 
            this.txtBookings4Month.Location = new System.Drawing.Point(215, 80);
            this.txtBookings4Month.Name = "txtBookings4Month";
            this.txtBookings4Month.Size = new System.Drawing.Size(60, 22);
            this.txtBookings4Month.TabIndex = 25;
            // 
            // txtAvailability
            // 
            this.txtAvailability.Location = new System.Drawing.Point(103, 122);
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.Size = new System.Drawing.Size(172, 22);
            this.txtAvailability.TabIndex = 26;
            // 
            // OccupancyLevelReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 770);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.chartLineYearlyLevels);
            this.Controls.Add(this.chartYearlyOccupanyDoughnut);
            this.Controls.Add(this.listViewOccupancy);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.occupancyDateSelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OccupancyLevelReport";
            this.Text = "OccupancyLevelReport";
            this.Activated += new System.EventHandler(this.OccupancyLevelReport_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OccupancyLevelReport_FormClosed);
            this.Load += new System.EventHandler(this.OccupancyLevelReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartYearlyOccupanyDoughnut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLineYearlyLevels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.summary.ResumeLayout(false);
            this.summary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewOccupancy;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.DateTimePicker occupancyDateSelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYearlyOccupanyDoughnut;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLineYearlyLevels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox summary;
        private System.Windows.Forms.TextBox txtAvailability;
        private System.Windows.Forms.TextBox txtBookings4Month;
        private System.Windows.Forms.TextBox txtTotalBookings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}