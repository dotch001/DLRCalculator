namespace DLR_Projekt.NetApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.upperChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Calculation1btn = new System.Windows.Forms.Button();
            this.Calculation2btn = new System.Windows.Forms.Button();
            this.Input1 = new System.Windows.Forms.NumericUpDown();
            this.Input2 = new System.Windows.Forms.NumericUpDown();
            this.Input3 = new System.Windows.Forms.NumericUpDown();
            this.lowerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PulseDurationDrop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lowerRightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yLabel = new System.Windows.Forms.Label();
            this.DelayLabel = new System.Windows.Forms.Label();
            this.BandWidthDrop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Input4 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CreateSheet = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreateCSV = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.upperChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerRightChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // upperChart
            // 
            this.upperChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.Interval = 10D;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Wavelenght";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Interval = 10D;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Refractive Index";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "UpperChartArea";
            this.upperChart.ChartAreas.Add(chartArea1);
            this.upperChart.Location = new System.Drawing.Point(13, 14);
            this.upperChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upperChart.Name = "upperChart";
            series1.ChartArea = "UpperChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.IsVisibleInLegend = false;
            series1.MarkerSize = 1;
            series1.Name = "upperChart";
            this.upperChart.Series.Add(series1);
            this.upperChart.Size = new System.Drawing.Size(721, 490);
            this.upperChart.TabIndex = 0;
            this.upperChart.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Refractive Index / Wavelength";
            this.upperChart.Titles.Add(title1);
            this.upperChart.Click += new System.EventHandler(this.upperChart_Click);
            // 
            // Calculation1btn
            // 
            this.Calculation1btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Calculation1btn.AutoSize = true;
            this.Calculation1btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculation1btn.Location = new System.Drawing.Point(758, 15);
            this.Calculation1btn.Margin = new System.Windows.Forms.Padding(4);
            this.Calculation1btn.Name = "Calculation1btn";
            this.Calculation1btn.Size = new System.Drawing.Size(553, 119);
            this.Calculation1btn.TabIndex = 2;
            this.Calculation1btn.Text = "Refractive Index Information";
            this.Calculation1btn.UseVisualStyleBackColor = true;
            this.Calculation1btn.Click += new System.EventHandler(this.Calculation1btn_Click);
            // 
            // Calculation2btn
            // 
            this.Calculation2btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Calculation2btn.AutoSize = true;
            this.Calculation2btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculation2btn.Location = new System.Drawing.Point(1319, 14);
            this.Calculation2btn.Margin = new System.Windows.Forms.Padding(4);
            this.Calculation2btn.Name = "Calculation2btn";
            this.Calculation2btn.Size = new System.Drawing.Size(570, 119);
            this.Calculation2btn.TabIndex = 3;
            this.Calculation2btn.Text = "Bandwidth and pulse duration calculations";
            this.Calculation2btn.UseVisualStyleBackColor = true;
            this.Calculation2btn.Click += new System.EventHandler(this.Calculation2btn_Click);
            // 
            // Input1
            // 
            this.Input1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Input1.AutoSize = true;
            this.Input1.DecimalPlaces = 2;
            this.Input1.Location = new System.Drawing.Point(761, 145);
            this.Input1.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.Input1.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(131, 22);
            this.Input1.TabIndex = 7;
            // 
            // Input2
            // 
            this.Input2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Input2.AutoSize = true;
            this.Input2.DecimalPlaces = 2;
            this.Input2.Location = new System.Drawing.Point(1328, 146);
            this.Input2.Margin = new System.Windows.Forms.Padding(0);
            this.Input2.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(131, 22);
            this.Input2.TabIndex = 14;
            // 
            // Input3
            // 
            this.Input3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Input3.AutoSize = true;
            this.Input3.DecimalPlaces = 2;
            this.Input3.Location = new System.Drawing.Point(761, 196);
            this.Input3.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.Input3.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.Input3.Name = "Input3";
            this.Input3.Size = new System.Drawing.Size(131, 22);
            this.Input3.TabIndex = 13;
            // 
            // lowerChart
            // 
            this.lowerChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Interval = 10D;
            chartArea2.AxisX.Maximum = 100D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "Wavelenght";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.Interval = 10D;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.Title = "Refractive Index ";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            chartArea2.Name = "lowerChartArea";
            this.lowerChart.ChartAreas.Add(chartArea2);
            this.lowerChart.Location = new System.Drawing.Point(12, 530);
            this.lowerChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lowerChart.Name = "lowerChart";
            series2.ChartArea = "lowerChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.IsVisibleInLegend = false;
            series2.MarkerSize = 10;
            series2.Name = "lowerChart";
            this.lowerChart.Series.Add(series2);
            this.lowerChart.Size = new System.Drawing.Size(722, 492);
            this.lowerChart.TabIndex = 23;
            this.lowerChart.Text = "chart2";
            title2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "First Derivative";
            this.lowerChart.Titles.Add(title2);
            this.lowerChart.Click += new System.EventHandler(this.lowerChart_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(996, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 35);
            this.label1.TabIndex = 24;
            this.label1.Text = "Pulse duration";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1558, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 35);
            this.label2.TabIndex = 25;
            this.label2.Text = "Central wavelength";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(996, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 35);
            this.label3.TabIndex = 26;
            this.label3.Text = "BBO crystal length";
            // 
            // PulseDurationDrop
            // 
            this.PulseDurationDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PulseDurationDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.PulseDurationDrop.FormattingEnabled = true;
            this.PulseDurationDrop.Items.AddRange(new object[] {
            "fs",
            "ps",
            "ns"});
            this.PulseDurationDrop.Location = new System.Drawing.Point(904, 197);
            this.PulseDurationDrop.Name = "PulseDurationDrop";
            this.PulseDurationDrop.Size = new System.Drawing.Size(86, 21);
            this.PulseDurationDrop.TabIndex = 27;
            this.PulseDurationDrop.Text = "Select";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(899, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 35);
            this.label4.TabIndex = 29;
            this.label4.Text = "mm";
            // 
            // lowerRightChart
            // 
            this.lowerRightChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.Interval = 10D;
            chartArea3.AxisX.Maximum = 100D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "fs²";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.Interval = 10D;
            chartArea3.AxisY.Maximum = 100D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.Title = "GDD";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            chartArea3.Name = "lowerRightChartArea";
            this.lowerRightChart.ChartAreas.Add(chartArea3);
            this.lowerRightChart.Location = new System.Drawing.Point(758, 529);
            this.lowerRightChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lowerRightChart.Name = "lowerRightChart";
            series3.ChartArea = "lowerRightChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.IsVisibleInLegend = false;
            series3.MarkerSize = 10;
            series3.Name = "lowerRightChart";
            this.lowerRightChart.Series.Add(series3);
            this.lowerRightChart.Size = new System.Drawing.Size(721, 492);
            this.lowerRightChart.TabIndex = 30;
            this.lowerRightChart.Text = "lowerRightChart";
            title3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            title3.Name = "Title1";
            title3.Text = "GDD";
            this.lowerRightChart.Titles.Add(title3);
            this.lowerRightChart.Click += new System.EventHandler(this.lowerRightChart_Click);
            // 
            // yLabel
            // 
            this.yLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yLabel.AutoSize = true;
            this.yLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yLabel.Location = new System.Drawing.Point(755, 242);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(282, 35);
            this.yLabel.TabIndex = 31;
            this.yLabel.Text = "Refractive Index = ";
            // 
            // DelayLabel
            // 
            this.DelayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelayLabel.Location = new System.Drawing.Point(755, 287);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(108, 35);
            this.DelayLabel.TabIndex = 33;
            this.DelayLabel.Text = "GDD =";
            // 
            // BandWidthDrop
            // 
            this.BandWidthDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BandWidthDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.BandWidthDrop.FormattingEnabled = true;
            this.BandWidthDrop.Items.AddRange(new object[] {
            "nm",
            "mm"});
            this.BandWidthDrop.Location = new System.Drawing.Point(1468, 201);
            this.BandWidthDrop.Name = "BandWidthDrop";
            this.BandWidthDrop.Size = new System.Drawing.Size(84, 21);
            this.BandWidthDrop.TabIndex = 36;
            this.BandWidthDrop.Text = "Select";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1558, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 35);
            this.label5.TabIndex = 35;
            this.label5.Text = "Bandwidth";
            // 
            // Input4
            // 
            this.Input4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Input4.AutoSize = true;
            this.Input4.DecimalPlaces = 2;
            this.Input4.Location = new System.Drawing.Point(1326, 200);
            this.Input4.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.Input4.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.Input4.Name = "Input4";
            this.Input4.Size = new System.Drawing.Size(131, 22);
            this.Input4.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(755, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(464, 35);
            this.label6.TabIndex = 37;
            this.label6.Text = "Second Harmonic Bandwidth = ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(755, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 35);
            this.label7.TabIndex = 38;
            this.label7.Text = "Bandwidth = ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(755, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 35);
            this.label8.TabIndex = 39;
            this.label8.Text = "GVM =";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(755, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 35);
            this.label9.TabIndex = 40;
            this.label9.Text = "GVM Total =";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1462, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 35);
            this.label10.TabIndex = 41;
            this.label10.Text = "nm";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1322, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(279, 35);
            this.label11.TabIndex = 42;
            this.label11.Text = "Pulse elongation =";
            // 
            // CreateSheet
            // 
            this.CreateSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateSheet.AutoSize = true;
            this.CreateSheet.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.CreateSheet.Location = new System.Drawing.Point(1485, 534);
            this.CreateSheet.Margin = new System.Windows.Forms.Padding(0);
            this.CreateSheet.Name = "CreateSheet";
            this.CreateSheet.Size = new System.Drawing.Size(199, 191);
            this.CreateSheet.TabIndex = 43;
            this.CreateSheet.TabStop = false;
            this.CreateSheet.Text = "Create Excel Sheet";
            this.CreateSheet.UseVisualStyleBackColor = true;
            this.CreateSheet.Click += new System.EventHandler(this.CreateSheet_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateButton.AutoSize = true;
            this.CalculateButton.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(1485, 728);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(405, 268);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.TabStop = false;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DLR_Projekt.NetApp.Properties.Resources.DLR_logo;
            this.pictureBox1.Location = new System.Drawing.Point(1485, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // CreateCSV
            // 
            this.CreateCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateCSV.AutoSize = true;
            this.CreateCSV.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCSV.Location = new System.Drawing.Point(1690, 534);
            this.CreateCSV.Margin = new System.Windows.Forms.Padding(0);
            this.CreateCSV.Name = "CreateCSV";
            this.CreateCSV.Size = new System.Drawing.Size(199, 192);
            this.CreateCSV.TabIndex = 45;
            this.CreateCSV.TabStop = false;
            this.CreateCSV.Text = "Create CSV File";
            this.CreateCSV.UseVisualStyleBackColor = true;
            this.CreateCSV.Click += new System.EventHandler(this.CreateCSV_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1485, 999);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(374, 20);
            this.linkLabel1.TabIndex = 46;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Problems or Bugs? Click here to write an E-Mail!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.CreateCSV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.CreateSheet);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BandWidthDrop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Input4);
            this.Controls.Add(this.DelayLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.lowerRightChart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PulseDurationDrop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lowerChart);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input3);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.Calculation2btn);
            this.Controls.Add(this.Calculation1btn);
            this.Controls.Add(this.upperChart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.upperChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerRightChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart upperChart;
        private System.Windows.Forms.Button Calculation1btn;
        private System.Windows.Forms.Button Calculation2btn;
        private System.Windows.Forms.NumericUpDown Input1;
        private System.Windows.Forms.NumericUpDown Input2;
        private System.Windows.Forms.NumericUpDown Input3;
        private System.Windows.Forms.DataVisualization.Charting.Chart lowerChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PulseDurationDrop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart lowerRightChart;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.ComboBox BandWidthDrop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Input4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CreateSheet;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CreateCSV;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

