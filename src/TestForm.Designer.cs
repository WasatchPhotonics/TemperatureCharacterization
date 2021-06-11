
namespace TemperatureCharacterization
{
    partial class TestForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainerTopVsBottom = new System.Windows.Forms.SplitContainer();
            this.splitContainerControlsVsGraph = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelControls = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonConnectSpectrometer = new System.Windows.Forms.Button();
            this.buttonConnectTemperatureProbe = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTemperatures = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownIntegTimeMS = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGainDB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSoakTimeMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxContFiringTimesSec = new System.Windows.Forms.TextBox();
            this.textBoxLaserPowerPercs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownIterations = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.chartSpectra = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainerLogVsAmbient = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEventLog = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartAmbient = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTopVsBottom)).BeginInit();
            this.splitContainerTopVsBottom.Panel1.SuspendLayout();
            this.splitContainerTopVsBottom.Panel2.SuspendLayout();
            this.splitContainerTopVsBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlsVsGraph)).BeginInit();
            this.splitContainerControlsVsGraph.Panel1.SuspendLayout();
            this.splitContainerControlsVsGraph.Panel2.SuspendLayout();
            this.splitContainerControlsVsGraph.SuspendLayout();
            this.flowLayoutPanelControls.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntegTimeMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGainDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoakTimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpectra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLogVsAmbient)).BeginInit();
            this.splitContainerLogVsAmbient.Panel1.SuspendLayout();
            this.splitContainerLogVsAmbient.Panel2.SuspendLayout();
            this.splitContainerLogVsAmbient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmbient)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerTopVsBottom
            // 
            this.splitContainerTopVsBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTopVsBottom.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTopVsBottom.Name = "splitContainerTopVsBottom";
            this.splitContainerTopVsBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTopVsBottom.Panel1
            // 
            this.splitContainerTopVsBottom.Panel1.Controls.Add(this.splitContainerControlsVsGraph);
            // 
            // splitContainerTopVsBottom.Panel2
            // 
            this.splitContainerTopVsBottom.Panel2.Controls.Add(this.splitContainerLogVsAmbient);
            this.splitContainerTopVsBottom.Size = new System.Drawing.Size(800, 450);
            this.splitContainerTopVsBottom.SplitterDistance = 265;
            this.splitContainerTopVsBottom.TabIndex = 0;
            // 
            // splitContainerControlsVsGraph
            // 
            this.splitContainerControlsVsGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlsVsGraph.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlsVsGraph.Name = "splitContainerControlsVsGraph";
            // 
            // splitContainerControlsVsGraph.Panel1
            // 
            this.splitContainerControlsVsGraph.Panel1.Controls.Add(this.flowLayoutPanelControls);
            // 
            // splitContainerControlsVsGraph.Panel2
            // 
            this.splitContainerControlsVsGraph.Panel2.Controls.Add(this.chartSpectra);
            this.splitContainerControlsVsGraph.Size = new System.Drawing.Size(800, 265);
            this.splitContainerControlsVsGraph.SplitterDistance = 265;
            this.splitContainerControlsVsGraph.TabIndex = 0;
            // 
            // flowLayoutPanelControls
            // 
            this.flowLayoutPanelControls.AutoScroll = true;
            this.flowLayoutPanelControls.Controls.Add(this.groupBox3);
            this.flowLayoutPanelControls.Controls.Add(this.groupBox4);
            this.flowLayoutPanelControls.Controls.Add(this.groupBox5);
            this.flowLayoutPanelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelControls.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelControls.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelControls.Name = "flowLayoutPanelControls";
            this.flowLayoutPanelControls.Size = new System.Drawing.Size(265, 265);
            this.flowLayoutPanelControls.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.flowLayoutPanel2);
            this.groupBox3.Location = new System.Drawing.Point(2, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(200, 44);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connect";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.buttonConnectSpectrometer);
            this.flowLayoutPanel2.Controls.Add(this.buttonConnectTemperatureProbe);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 15);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(196, 27);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // buttonConnectSpectrometer
            // 
            this.buttonConnectSpectrometer.AutoSize = true;
            this.buttonConnectSpectrometer.Location = new System.Drawing.Point(2, 2);
            this.buttonConnectSpectrometer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnectSpectrometer.Name = "buttonConnectSpectrometer";
            this.buttonConnectSpectrometer.Size = new System.Drawing.Size(80, 23);
            this.buttonConnectSpectrometer.TabIndex = 0;
            this.buttonConnectSpectrometer.Text = "Spectrometer";
            this.buttonConnectSpectrometer.UseVisualStyleBackColor = true;
            this.buttonConnectSpectrometer.Click += new System.EventHandler(this.buttonConnectSpectrometer_Click);
            // 
            // buttonConnectTemperatureProbe
            // 
            this.buttonConnectTemperatureProbe.AutoSize = true;
            this.buttonConnectTemperatureProbe.Location = new System.Drawing.Point(86, 2);
            this.buttonConnectTemperatureProbe.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnectTemperatureProbe.Name = "buttonConnectTemperatureProbe";
            this.buttonConnectTemperatureProbe.Size = new System.Drawing.Size(108, 23);
            this.buttonConnectTemperatureProbe.TabIndex = 1;
            this.buttonConnectTemperatureProbe.Text = "Temperature Probe";
            this.buttonConnectTemperatureProbe.UseVisualStyleBackColor = true;
            this.buttonConnectTemperatureProbe.Click += new System.EventHandler(this.buttonConnectTemperatureProbe_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel1);
            this.groupBox4.Location = new System.Drawing.Point(2, 50);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(217, 180);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parameters";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTemperatures, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownIntegTimeMS, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownGainDB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownSoakTimeMin, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxContFiringTimesSec, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLaserPowerPercs, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownIterations, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(213, 163);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatures";
            // 
            // textBoxTemperatures
            // 
            this.textBoxTemperatures.Location = new System.Drawing.Point(134, 50);
            this.textBoxTemperatures.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTemperatures.Name = "textBoxTemperatures";
            this.textBoxTemperatures.Size = new System.Drawing.Size(69, 20);
            this.textBoxTemperatures.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IntegTimeMS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gain dB";
            // 
            // numericUpDownIntegTimeMS
            // 
            this.numericUpDownIntegTimeMS.Location = new System.Drawing.Point(134, 2);
            this.numericUpDownIntegTimeMS.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownIntegTimeMS.Name = "numericUpDownIntegTimeMS";
            this.numericUpDownIntegTimeMS.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownIntegTimeMS.TabIndex = 4;
            // 
            // numericUpDownGainDB
            // 
            this.numericUpDownGainDB.Location = new System.Drawing.Point(134, 26);
            this.numericUpDownGainDB.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownGainDB.Name = "numericUpDownGainDB";
            this.numericUpDownGainDB.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownGainDB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soak Time Min";
            // 
            // numericUpDownSoakTimeMin
            // 
            this.numericUpDownSoakTimeMin.Location = new System.Drawing.Point(134, 74);
            this.numericUpDownSoakTimeMin.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownSoakTimeMin.Name = "numericUpDownSoakTimeMin";
            this.numericUpDownSoakTimeMin.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownSoakTimeMin.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cont Firing Times Sec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Laser %s";
            // 
            // textBoxContFiringTimesSec
            // 
            this.textBoxContFiringTimesSec.Location = new System.Drawing.Point(134, 98);
            this.textBoxContFiringTimesSec.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContFiringTimesSec.Name = "textBoxContFiringTimesSec";
            this.textBoxContFiringTimesSec.Size = new System.Drawing.Size(69, 20);
            this.textBoxContFiringTimesSec.TabIndex = 10;
            // 
            // textBoxLaserPowerPercs
            // 
            this.textBoxLaserPowerPercs.Location = new System.Drawing.Point(134, 122);
            this.textBoxLaserPowerPercs.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLaserPowerPercs.Name = "textBoxLaserPowerPercs";
            this.textBoxLaserPowerPercs.Size = new System.Drawing.Size(69, 20);
            this.textBoxLaserPowerPercs.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Measurements per setting";
            // 
            // numericUpDownIterations
            // 
            this.numericUpDownIterations.Location = new System.Drawing.Point(134, 146);
            this.numericUpDownIterations.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownIterations.Name = "numericUpDownIterations";
            this.numericUpDownIterations.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownIterations.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flowLayoutPanel1);
            this.groupBox5.Location = new System.Drawing.Point(2, 234);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(98, 54);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Test";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonStart);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(94, 37);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(2, 2);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(56, 19);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // chartSpectra
            // 
            chartArea9.Name = "ChartArea1";
            this.chartSpectra.ChartAreas.Add(chartArea9);
            this.chartSpectra.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chartSpectra.Legends.Add(legend5);
            this.chartSpectra.Location = new System.Drawing.Point(0, 0);
            this.chartSpectra.Name = "chartSpectra";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartSpectra.Series.Add(series9);
            this.chartSpectra.Size = new System.Drawing.Size(531, 265);
            this.chartSpectra.TabIndex = 0;
            this.chartSpectra.Text = "chart2";
            // 
            // splitContainerLogVsAmbient
            // 
            this.splitContainerLogVsAmbient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLogVsAmbient.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLogVsAmbient.Name = "splitContainerLogVsAmbient";
            // 
            // splitContainerLogVsAmbient.Panel1
            // 
            this.splitContainerLogVsAmbient.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainerLogVsAmbient.Panel2
            // 
            this.splitContainerLogVsAmbient.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerLogVsAmbient.Size = new System.Drawing.Size(800, 181);
            this.splitContainerLogVsAmbient.SplitterDistance = 548;
            this.splitContainerLogVsAmbient.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEventLog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Log";
            // 
            // textBoxEventLog
            // 
            this.textBoxEventLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEventLog.Location = new System.Drawing.Point(3, 16);
            this.textBoxEventLog.Multiline = true;
            this.textBoxEventLog.Name = "textBoxEventLog";
            this.textBoxEventLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEventLog.Size = new System.Drawing.Size(542, 162);
            this.textBoxEventLog.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartAmbient);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 181);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ambient";
            // 
            // chartAmbient
            // 
            chartArea10.Name = "ChartArea1";
            this.chartAmbient.ChartAreas.Add(chartArea10);
            this.chartAmbient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartAmbient.Location = new System.Drawing.Point(3, 16);
            this.chartAmbient.Name = "chartAmbient";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Name = "Series1";
            this.chartAmbient.Series.Add(series10);
            this.chartAmbient.Size = new System.Drawing.Size(242, 162);
            this.chartAmbient.TabIndex = 0;
            this.chartAmbient.Text = "chart1";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerTopVsBottom);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.splitContainerTopVsBottom.Panel1.ResumeLayout(false);
            this.splitContainerTopVsBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTopVsBottom)).EndInit();
            this.splitContainerTopVsBottom.ResumeLayout(false);
            this.splitContainerControlsVsGraph.Panel1.ResumeLayout(false);
            this.splitContainerControlsVsGraph.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlsVsGraph)).EndInit();
            this.splitContainerControlsVsGraph.ResumeLayout(false);
            this.flowLayoutPanelControls.ResumeLayout(false);
            this.flowLayoutPanelControls.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntegTimeMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGainDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoakTimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSpectra)).EndInit();
            this.splitContainerLogVsAmbient.Panel1.ResumeLayout(false);
            this.splitContainerLogVsAmbient.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLogVsAmbient)).EndInit();
            this.splitContainerLogVsAmbient.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAmbient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerTopVsBottom;
        private System.Windows.Forms.SplitContainer splitContainerLogVsAmbient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEventLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAmbient;
        private System.Windows.Forms.SplitContainer splitContainerControlsVsGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpectra;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelControls;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonConnectSpectrometer;
        private System.Windows.Forms.Button buttonConnectTemperatureProbe;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTemperatures;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownIntegTimeMS;
        private System.Windows.Forms.NumericUpDown numericUpDownGainDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownSoakTimeMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxContFiringTimesSec;
        private System.Windows.Forms.TextBox textBoxLaserPowerPercs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownIterations;
    }
}