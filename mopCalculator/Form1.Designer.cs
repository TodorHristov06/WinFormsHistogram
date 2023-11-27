namespace mopCalculator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.checkAverage = new System.Windows.Forms.CheckBox();
            this.checkMode = new System.Windows.Forms.CheckBox();
            this.checkMedian = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.TestChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.TestChart)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(66, 202);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(128, 20);
            this.txtBoxInput.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(66, 228);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(60, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.BackColor = System.Drawing.Color.Transparent;
            this.lblInput.Location = new System.Drawing.Point(111, 186);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(31, 13);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Input";
            // 
            // checkAverage
            // 
            this.checkAverage.AutoSize = true;
            this.checkAverage.BackColor = System.Drawing.Color.Orange;
            this.checkAverage.ForeColor = System.Drawing.Color.Black;
            this.checkAverage.Location = new System.Drawing.Point(354, 182);
            this.checkAverage.Name = "checkAverage";
            this.checkAverage.Size = new System.Drawing.Size(66, 17);
            this.checkAverage.TabIndex = 5;
            this.checkAverage.Text = "Average";
            this.checkAverage.UseVisualStyleBackColor = false;
            // 
            // checkMode
            // 
            this.checkMode.AutoSize = true;
            this.checkMode.BackColor = System.Drawing.Color.Orange;
            this.checkMode.ForeColor = System.Drawing.Color.Black;
            this.checkMode.Location = new System.Drawing.Point(354, 217);
            this.checkMode.Name = "checkMode";
            this.checkMode.Size = new System.Drawing.Size(65, 17);
            this.checkMode.TabIndex = 6;
            this.checkMode.Text = "Mode    ";
            this.checkMode.UseVisualStyleBackColor = false;
            // 
            // checkMedian
            // 
            this.checkMedian.AutoSize = true;
            this.checkMedian.BackColor = System.Drawing.Color.Orange;
            this.checkMedian.ForeColor = System.Drawing.Color.Black;
            this.checkMedian.Location = new System.Drawing.Point(354, 249);
            this.checkMedian.Name = "checkMedian";
            this.checkMedian.Size = new System.Drawing.Size(64, 17);
            this.checkMedian.TabIndex = 7;
            this.checkMedian.Text = "Median ";
            this.checkMedian.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(132, 228);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // TestChart
            // 
            this.TestChart.BackColor = System.Drawing.Color.Transparent;
            this.TestChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.TestChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.TestChart.Legends.Add(legend4);
            this.TestChart.Location = new System.Drawing.Point(633, 183);
            this.TestChart.Name = "TestChart";
            this.TestChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.TestChart.Series.Add(series4);
            this.TestChart.Size = new System.Drawing.Size(293, 176);
            this.TestChart.TabIndex = 9;
            this.TestChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::mopCalculator.Properties.Resources._360_F_299848927_S0EwX0P6HWGigW6qZWFIBaczKMQuq5D9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 556);
            this.Controls.Add(this.TestChart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.checkMedian);
            this.Controls.Add(this.checkMode);
            this.Controls.Add(this.checkAverage);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBoxInput);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TestChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.CheckBox checkAverage;
        private System.Windows.Forms.CheckBox checkMode;
        private System.Windows.Forms.CheckBox checkMedian;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataVisualization.Charting.Chart TestChart;
    }
}

