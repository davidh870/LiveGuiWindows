namespace LiveGuiWindows
{
    partial class LiveGui
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title25 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title26 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title27 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title28 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title29 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title30 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.arduinoSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.photoResChartA0 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.photoResChartA1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.photoResValA0Textbox = new System.Windows.Forms.TextBox();
            this.photoResValA1Textbox = new System.Windows.Forms.TextBox();
            this.portsListView = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoResChartA0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoResChartA1)).BeginInit();
            this.SuspendLayout();
            // 
            // arduinoSerialPort
            // 
            this.arduinoSerialPort.PortName = "COM3";
            this.arduinoSerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.arduinoSerialPort_DataReceived);
            // 
            // photoResChartA0
            // 
            chartArea9.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea9.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
            chartArea9.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea9.AxisY.Maximum = 1000D;
            chartArea9.AxisY.Minimum = 0D;
            chartArea9.AxisY.ScaleView.MinSize = 0D;
            chartArea9.AxisY.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisY.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.Name = "ChartArea1";
            this.photoResChartA0.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.photoResChartA0.Legends.Add(legend9);
            this.photoResChartA0.Location = new System.Drawing.Point(12, 12);
            this.photoResChartA0.Name = "photoResChartA0";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "PhotoResistor";
            this.photoResChartA0.Series.Add(series9);
            this.photoResChartA0.Size = new System.Drawing.Size(776, 381);
            this.photoResChartA0.TabIndex = 2;
            this.photoResChartA0.Text = "chart1";
            title25.Name = "Top Graph Title";
            title25.Text = "Photo Resistor A0 Live Data";
            title26.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title26.Name = "Y Axis Title";
            title26.Text = "Values";
            title27.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title27.Name = "X Axis Title";
            title27.Text = "Ticks";
            this.photoResChartA0.Titles.Add(title25);
            this.photoResChartA0.Titles.Add(title26);
            this.photoResChartA0.Titles.Add(title27);
            // 
            // photoResChartA1
            // 
            chartArea10.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea10.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
            chartArea10.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea10.AxisY.Maximum = 1000D;
            chartArea10.AxisY.Minimum = 0D;
            chartArea10.AxisY.ScaleView.MinSize = 0D;
            chartArea10.AxisY.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisY.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.Name = "ChartArea1";
            this.photoResChartA1.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.photoResChartA1.Legends.Add(legend10);
            this.photoResChartA1.Location = new System.Drawing.Point(12, 431);
            this.photoResChartA1.Name = "photoResChartA1";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "PhotoResistor";
            this.photoResChartA1.Series.Add(series10);
            this.photoResChartA1.Size = new System.Drawing.Size(776, 381);
            this.photoResChartA1.TabIndex = 3;
            this.photoResChartA1.Text = "chart1";
            title28.Name = "Top Graph Title";
            title28.Text = "Photo Resistor A1 Live Data";
            title29.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title29.Name = "Y Axis Title";
            title29.Text = "Values";
            title30.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title30.Name = "X Axis Title";
            title30.Text = "Ticks";
            this.photoResChartA1.Titles.Add(title28);
            this.photoResChartA1.Titles.Add(title29);
            this.photoResChartA1.Titles.Add(title30);
            // 
            // photoResValA0Textbox
            // 
            this.photoResValA0Textbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.photoResValA0Textbox.Location = new System.Drawing.Point(652, 79);
            this.photoResValA0Textbox.Name = "photoResValA0Textbox";
            this.photoResValA0Textbox.Size = new System.Drawing.Size(100, 20);
            this.photoResValA0Textbox.TabIndex = 4;
            // 
            // photoResValA1Textbox
            // 
            this.photoResValA1Textbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.photoResValA1Textbox.Location = new System.Drawing.Point(652, 502);
            this.photoResValA1Textbox.Name = "photoResValA1Textbox";
            this.photoResValA1Textbox.Size = new System.Drawing.Size(100, 20);
            this.photoResValA1Textbox.TabIndex = 5;
            // 
            // portsListView
            // 
            this.portsListView.AllowDrop = true;
            this.portsListView.GridLines = true;
            this.portsListView.HideSelection = false;
            this.portsListView.Location = new System.Drawing.Point(899, 47);
            this.portsListView.Name = "portsListView";
            this.portsListView.Size = new System.Drawing.Size(333, 205);
            this.portsListView.TabIndex = 6;
            this.portsListView.UseCompatibleStateImageBehavior = false;
            this.portsListView.DoubleClick += new System.EventHandler(this.portsListView_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(899, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 13);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Com Ports";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LiveGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 846);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.portsListView);
            this.Controls.Add(this.photoResValA1Textbox);
            this.Controls.Add(this.photoResValA0Textbox);
            this.Controls.Add(this.photoResChartA1);
            this.Controls.Add(this.photoResChartA0);
            this.DoubleBuffered = true;
            this.Name = "LiveGui";
            this.Text = "Live Gui";
            this.Load += new System.EventHandler(this.LiveGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoResChartA0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoResChartA1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort arduinoSerialPort;
        private System.Windows.Forms.DataVisualization.Charting.Chart photoResChartA0;
        private System.Windows.Forms.DataVisualization.Charting.Chart photoResChartA1;
        private System.Windows.Forms.TextBox photoResValA0Textbox;
        private System.Windows.Forms.TextBox photoResValA1Textbox;
        private System.Windows.Forms.ListView portsListView;
        private System.Windows.Forms.TextBox textBox1;
    }
}

