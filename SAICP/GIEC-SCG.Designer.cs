namespace SAICP
{
    partial class frmClinicalGraphicTracing
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
            DevComponents.DotNetBar.Charts.ChartXy chartXy1 = new DevComponents.DotNetBar.Charts.ChartXy();
            DevComponents.DotNetBar.Charts.Style.Background background1 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.ChartSeries chartSeries1 = new DevComponents.DotNetBar.Charts.ChartSeries();
            DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint1 = new DevComponents.DotNetBar.Charts.SeriesPoint();
            DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint2 = new DevComponents.DotNetBar.Charts.SeriesPoint();
            DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint3 = new DevComponents.DotNetBar.Charts.SeriesPoint();
            DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint4 = new DevComponents.DotNetBar.Charts.SeriesPoint();
            DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint5 = new DevComponents.DotNetBar.Charts.SeriesPoint();
            DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint6 = new DevComponents.DotNetBar.Charts.SeriesPoint();
            DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint7 = new DevComponents.DotNetBar.Charts.SeriesPoint();
            DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint8 = new DevComponents.DotNetBar.Charts.SeriesPoint();
            DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint9 = new DevComponents.DotNetBar.Charts.SeriesPoint();
            DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint10 = new DevComponents.DotNetBar.Charts.SeriesPoint();
            DevComponents.DotNetBar.Charts.ChartSeries chartSeries2 = new DevComponents.DotNetBar.Charts.ChartSeries();
            DevComponents.DotNetBar.Charts.ChartSeries chartSeries3 = new DevComponents.DotNetBar.Charts.ChartSeries();
            DevComponents.DotNetBar.Charts.ChartSeries chartSeries4 = new DevComponents.DotNetBar.Charts.ChartSeries();
            DevComponents.DotNetBar.Charts.ChartSeries chartSeries5 = new DevComponents.DotNetBar.Charts.ChartSeries();
            DevComponents.DotNetBar.Charts.Style.Background background2 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background3 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.BorderColor borderColor1 = new DevComponents.DotNetBar.Charts.Style.BorderColor();
            DevComponents.DotNetBar.Charts.Style.Thickness thickness1 = new DevComponents.DotNetBar.Charts.Style.Thickness();
            DevComponents.DotNetBar.Charts.Style.Padding padding1 = new DevComponents.DotNetBar.Charts.Style.Padding();
            DevComponents.DotNetBar.Charts.Style.Background background4 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.BorderColor borderColor2 = new DevComponents.DotNetBar.Charts.Style.BorderColor();
            DevComponents.DotNetBar.Charts.Style.Thickness thickness2 = new DevComponents.DotNetBar.Charts.Style.Thickness();
            DevComponents.DotNetBar.Charts.Style.Padding padding2 = new DevComponents.DotNetBar.Charts.Style.Padding();
            DevComponents.DotNetBar.Charts.Style.Background background5 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.BorderColor borderColor3 = new DevComponents.DotNetBar.Charts.Style.BorderColor();
            DevComponents.DotNetBar.Charts.Style.Thickness thickness3 = new DevComponents.DotNetBar.Charts.Style.Thickness();
            DevComponents.DotNetBar.Charts.Style.Padding padding3 = new DevComponents.DotNetBar.Charts.Style.Padding();
            DevComponents.DotNetBar.Charts.Style.Padding padding4 = new DevComponents.DotNetBar.Charts.Style.Padding();
            DevComponents.DotNetBar.Charts.ChartTitle chartTitle1 = new DevComponents.DotNetBar.Charts.ChartTitle();
            DevComponents.DotNetBar.Charts.Style.Padding padding5 = new DevComponents.DotNetBar.Charts.Style.Padding();
            DevComponents.DotNetBar.Charts.Style.Background background6 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background7 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background8 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background9 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background10 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background11 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background12 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background13 = new DevComponents.DotNetBar.Charts.Style.Background();
            this.statusBar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblMessage = new DevComponents.DotNetBar.LabelItem();
            this.progressBarItem1 = new DevComponents.DotNetBar.ProgressBarItem();
            this.lblBlank = new DevComponents.DotNetBar.LabelItem();
            this.lblDate = new DevComponents.DotNetBar.LabelItem();
            this.lblHour = new DevComponents.DotNetBar.LabelItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chartControl1 = new DevComponents.DotNetBar.Charts.ChartControl();
            this.cmdBack = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            // 
            // 
            // 
            this.statusBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.statusBar.ContainerControlProcessDialogKey = true;
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar.DragDropSupport = true;
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblMessage,
            this.progressBarItem1,
            this.lblBlank,
            this.lblDate,
            this.lblHour});
            this.statusBar.Location = new System.Drawing.Point(0, 374);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(625, 22);
            this.statusBar.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Text = "Listo";
            // 
            // progressBarItem1
            // 
            // 
            // 
            // 
            this.progressBarItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarItem1.ChunkGradientAngle = 0F;
            this.progressBarItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.progressBarItem1.Name = "progressBarItem1";
            this.progressBarItem1.RecentlyUsed = false;
            this.progressBarItem1.Visible = false;
            // 
            // lblBlank
            // 
            this.lblBlank.Name = "lblBlank";
            this.lblBlank.Stretch = true;
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Text = "Fecha";
            // 
            // lblHour
            // 
            this.lblHour.Name = "lblHour";
            this.lblHour.Text = "Hora";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chartControl1
            // 
            this.chartControl1.BackColor = System.Drawing.Color.White;
            chartXy1.AxisX.MajorGridLines.GridLinesVisualStyle.LineColor = System.Drawing.Color.Gainsboro;
            chartXy1.AxisX.MinorGridLines.GridLinesVisualStyle.LineColor = System.Drawing.Color.WhiteSmoke;
            chartXy1.AxisX.Title.Name = null;
            chartXy1.AxisY.AxisAlignment = DevComponents.DotNetBar.Charts.AxisAlignment.Far;
            chartXy1.AxisY.MajorGridLines.GridLinesVisualStyle.LineColor = System.Drawing.Color.Gainsboro;
            chartXy1.AxisY.MinorGridLines.GridLinesVisualStyle.LineColor = System.Drawing.Color.WhiteSmoke;
            chartXy1.AxisY.Title.Name = null;
            chartXy1.ChartCrosshair.CrosshairLabelMode = DevComponents.DotNetBar.Charts.CrosshairLabelMode.NearestSeries;
            background1.Color1 = System.Drawing.Color.White;
            chartXy1.ChartCrosshair.CrosshairVisualStyle.Background = background1;
            chartXy1.ChartCrosshair.HighlightPoints = true;
            chartXy1.ChartCrosshair.ShowCrosshairLabels = true;
            chartXy1.ChartCrosshair.ShowValueXLabels = true;
            chartXy1.ChartCrosshair.ShowValueXLine = true;
            chartXy1.ChartCrosshair.ShowValueYLabels = true;
            chartXy1.ChartCrosshair.ShowValueYLine = true;
            chartXy1.ChartLineDisplayMode = DevComponents.DotNetBar.Charts.ChartLineDisplayMode.DisplayLine;
            chartSeries1.ChartLineDisplayMode = DevComponents.DotNetBar.Charts.ChartLineDisplayMode.DisplayLine;
            chartSeries1.CrosshairHighlightPoints = DevComponents.DotNetBar.Charts.Style.Tbool.True;
            chartSeries1.EmptyValues = null;
            chartSeries1.Name = "Weight";
            seriesPoint1.ValueX = 0D;
            seriesPoint1.ValueY = new object[] {
        ((object)(31D))};
            seriesPoint2.ValueX = 1D;
            seriesPoint2.ValueY = new object[] {
        ((object)(35D))};
            seriesPoint3.ValueX = 2D;
            seriesPoint3.ValueY = new object[] {
        ((object)(35D))};
            seriesPoint4.ValueX = 3D;
            seriesPoint4.ValueY = new object[] {
        ((object)(47D))};
            seriesPoint5.ValueX = 4D;
            seriesPoint5.ValueY = new object[] {
        ((object)(18D))};
            seriesPoint6.ValueX = 5D;
            seriesPoint6.ValueY = new object[] {
        ((object)(5D))};
            seriesPoint7.ValueX = 6D;
            seriesPoint7.ValueY = new object[] {
        ((object)(35D))};
            seriesPoint8.ValueX = 7D;
            seriesPoint8.ValueY = new object[] {
        ((object)(7D))};
            seriesPoint9.ValueX = 8D;
            seriesPoint9.ValueY = new object[] {
        ((object)(5D))};
            seriesPoint10.ValueX = 9D;
            seriesPoint10.ValueY = new object[] {
        ((object)(40D))};
            chartSeries1.SeriesPoints.Add(seriesPoint1);
            chartSeries1.SeriesPoints.Add(seriesPoint2);
            chartSeries1.SeriesPoints.Add(seriesPoint3);
            chartSeries1.SeriesPoints.Add(seriesPoint4);
            chartSeries1.SeriesPoints.Add(seriesPoint5);
            chartSeries1.SeriesPoints.Add(seriesPoint6);
            chartSeries1.SeriesPoints.Add(seriesPoint7);
            chartSeries1.SeriesPoints.Add(seriesPoint8);
            chartSeries1.SeriesPoints.Add(seriesPoint9);
            chartSeries1.SeriesPoints.Add(seriesPoint10);
            chartSeries1.SeriesType = DevComponents.DotNetBar.Charts.SeriesType.Line;
            chartSeries2.ChartLineDisplayMode = DevComponents.DotNetBar.Charts.ChartLineDisplayMode.DisplayLine;
            chartSeries2.EmptyValues = null;
            chartSeries2.Name = "Size";
            chartSeries3.ChartLineDisplayMode = DevComponents.DotNetBar.Charts.ChartLineDisplayMode.DisplayLine;
            chartSeries3.EmptyValues = null;
            chartSeries3.Name = "Perímetro cefálico";
            chartSeries4.ChartLineDisplayMode = DevComponents.DotNetBar.Charts.ChartLineDisplayMode.DisplayLine;
            chartSeries4.EmptyValues = null;
            chartSeries4.Name = "IMC";
            chartSeries5.ChartLineDisplayMode = DevComponents.DotNetBar.Charts.ChartLineDisplayMode.DisplayLine;
            chartSeries5.EmptyValues = null;
            chartSeries5.Name = "Número de vacunas";
            chartXy1.ChartSeries.Add(chartSeries1);
            chartXy1.ChartSeries.Add(chartSeries2);
            chartXy1.ChartSeries.Add(chartSeries3);
            chartXy1.ChartSeries.Add(chartSeries4);
            chartXy1.ChartSeries.Add(chartSeries5);
            background2.Color1 = System.Drawing.Color.Yellow;
            chartXy1.ChartSeriesVisualStyle.MarkerHighlightVisualStyle.Background = background2;
            chartXy1.ChartSeriesVisualStyle.MarkerHighlightVisualStyle.Size = new System.Drawing.Size(15, 15);
            chartXy1.ChartSeriesVisualStyle.MarkerHighlightVisualStyle.Type = DevComponents.DotNetBar.Charts.PointMarkerType.Ellipse;
            background3.Color1 = System.Drawing.Color.White;
            chartXy1.ChartVisualStyle.Background = background3;
            borderColor1.Bottom = System.Drawing.Color.Black;
            borderColor1.Left = System.Drawing.Color.Black;
            borderColor1.Right = System.Drawing.Color.Black;
            borderColor1.Top = System.Drawing.Color.Black;
            chartXy1.ChartVisualStyle.BorderColor = borderColor1;
            thickness1.Bottom = 1;
            thickness1.Left = 1;
            thickness1.Right = 1;
            thickness1.Top = 1;
            chartXy1.ChartVisualStyle.BorderThickness = thickness1;
            padding1.Bottom = 6;
            padding1.Left = 6;
            padding1.Right = 6;
            padding1.Top = 6;
            chartXy1.ChartVisualStyle.Padding = padding1;
            background4.Color1 = System.Drawing.Color.White;
            chartXy1.ContainerVisualStyles.Default.Background = background4;
            borderColor2.Bottom = System.Drawing.Color.DimGray;
            borderColor2.Left = System.Drawing.Color.DimGray;
            borderColor2.Right = System.Drawing.Color.DimGray;
            borderColor2.Top = System.Drawing.Color.DimGray;
            chartXy1.ContainerVisualStyles.Default.BorderColor = borderColor2;
            thickness2.Bottom = 1;
            thickness2.Left = 1;
            thickness2.Right = 1;
            thickness2.Top = 1;
            chartXy1.ContainerVisualStyles.Default.BorderThickness = thickness2;
            chartXy1.ContainerVisualStyles.Default.DropShadow.Enabled = DevComponents.DotNetBar.Charts.Style.Tbool.True;
            padding2.Bottom = 6;
            padding2.Left = 6;
            padding2.Right = 6;
            padding2.Top = 6;
            chartXy1.ContainerVisualStyles.Default.Padding = padding2;
            chartXy1.Legend.Alignment = DevComponents.DotNetBar.Charts.Style.Alignment.TopRight;
            chartXy1.Legend.AlignVerticalItems = true;
            background5.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartXy1.Legend.ChartLegendVisualStyles.Default.Background = background5;
            borderColor3.Bottom = System.Drawing.Color.Black;
            borderColor3.Left = System.Drawing.Color.Black;
            borderColor3.Right = System.Drawing.Color.Black;
            borderColor3.Top = System.Drawing.Color.Black;
            chartXy1.Legend.ChartLegendVisualStyles.Default.BorderColor = borderColor3;
            thickness3.Bottom = 1;
            thickness3.Left = 1;
            thickness3.Right = 1;
            thickness3.Top = 1;
            chartXy1.Legend.ChartLegendVisualStyles.Default.BorderThickness = thickness3;
            padding3.Bottom = 8;
            padding3.Left = 8;
            padding3.Right = 8;
            padding3.Top = 8;
            chartXy1.Legend.ChartLegendVisualStyles.Default.Margin = padding3;
            padding4.Bottom = 4;
            padding4.Left = 4;
            padding4.Right = 4;
            padding4.Top = 4;
            chartXy1.Legend.ChartLegendVisualStyles.Default.Padding = padding4;
            chartXy1.Legend.Direction = DevComponents.DotNetBar.Charts.Direction.TopToBottom;
            chartXy1.Legend.MaxHorizontalPct = 75D;
            chartXy1.Legend.Placement = DevComponents.DotNetBar.Charts.Placement.Outside;
            chartXy1.Legend.Visible = true;
            chartXy1.Name = "ChartXy1";
            chartTitle1.ChartTitleVisualStyle.Alignment = DevComponents.DotNetBar.Charts.Style.Alignment.MiddleCenter;
            chartTitle1.ChartTitleVisualStyle.Font = new System.Drawing.Font("Georgia", 16F);
            padding5.Bottom = 8;
            padding5.Left = 8;
            padding5.Right = 8;
            padding5.Top = 8;
            chartTitle1.ChartTitleVisualStyle.Padding = padding5;
            chartTitle1.ChartTitleVisualStyle.TextColor = System.Drawing.Color.Navy;
            chartTitle1.Name = "Title1";
            chartTitle1.Text = "Chart Title";
            chartTitle1.XyAlignment = DevComponents.DotNetBar.Charts.XyAlignment.Top;
            chartXy1.Titles.Add(chartTitle1);
            this.chartControl1.ChartPanel.ChartContainers.Add(chartXy1);
            this.chartControl1.ChartPanel.Legend.Visible = false;
            this.chartControl1.ChartPanel.Name = "PrimaryPanel";
            background6.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl1.DefaultVisualStyles.HScrollBarVisualStyles.MouseOver.ArrowBackground = background6;
            background7.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl1.DefaultVisualStyles.HScrollBarVisualStyles.MouseOver.ThumbBackground = background7;
            background8.Color1 = System.Drawing.Color.White;
            this.chartControl1.DefaultVisualStyles.HScrollBarVisualStyles.SelectedMouseOver.ArrowBackground = background8;
            background9.Color1 = System.Drawing.Color.White;
            this.chartControl1.DefaultVisualStyles.HScrollBarVisualStyles.SelectedMouseOver.ThumbBackground = background9;
            background10.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl1.DefaultVisualStyles.VScrollBarVisualStyles.MouseOver.ArrowBackground = background10;
            background11.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl1.DefaultVisualStyles.VScrollBarVisualStyles.MouseOver.ThumbBackground = background11;
            background12.Color1 = System.Drawing.Color.White;
            this.chartControl1.DefaultVisualStyles.VScrollBarVisualStyles.SelectedMouseOver.ArrowBackground = background12;
            background13.Color1 = System.Drawing.Color.White;
            this.chartControl1.DefaultVisualStyles.VScrollBarVisualStyles.SelectedMouseOver.ThumbBackground = background13;
            this.chartControl1.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Size = new System.Drawing.Size(601, 327);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "chartControl1";
            // 
            // cmdBack
            // 
            this.cmdBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBack.Location = new System.Drawing.Point(538, 345);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(75, 23);
            this.cmdBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdBack.TabIndex = 3;
            this.cmdBack.Text = "Regresar";
            // 
            // frmClinicalGraphicTracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 396);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.statusBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmClinicalGraphicTracing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "Seguimiento clínico gráfico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClinicalGraphicTracing_FormClosing);
            this.Load += new System.EventHandler(this.frmClinicalGraphicTracing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroStatusBar statusBar;
        private DevComponents.DotNetBar.LabelItem lblMessage;
        private DevComponents.DotNetBar.ProgressBarItem progressBarItem1;
        private DevComponents.DotNetBar.LabelItem lblBlank;
        private DevComponents.DotNetBar.LabelItem lblDate;
        private DevComponents.DotNetBar.LabelItem lblHour;
        private System.Windows.Forms.Timer timer;
        private DevComponents.DotNetBar.Charts.ChartControl chartControl1;
        private DevComponents.DotNetBar.ButtonX cmdBack;
    }
}