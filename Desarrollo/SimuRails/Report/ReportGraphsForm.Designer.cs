namespace SimuRails.Report
{
    partial class ReportGraphsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.GraphPorEstaciones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.ButtonCerrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelDuracion = new System.Windows.Forms.Label();
            this.LabelNombreSimulacion = new System.Windows.Forms.Label();
            this.PanelFiltro = new System.Windows.Forms.Panel();
            this.ButtonVerReporte = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonGenerarArchivo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.FlowLayOutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PanelGraficoTraza = new System.Windows.Forms.Panel();
            this.GraficoTraza = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelGraficos = new System.Windows.Forms.Panel();
            this.PanelGraphsEstaciones = new System.Windows.Forms.Panel();
            this.BindingSourceTraza = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBoxReportes = new SimuRails.Report.MyComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GraphPorEstaciones)).BeginInit();
            this.panelCabecera.SuspendLayout();
            this.PanelFiltro.SuspendLayout();
            this.FlowLayOutPanel1.SuspendLayout();
            this.PanelGraficoTraza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoTraza)).BeginInit();
            this.panelGraficos.SuspendLayout();
            this.PanelGraphsEstaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTraza)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphPorEstaciones
            // 
            this.GraphPorEstaciones.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.GraphPorEstaciones.BorderlineWidth = 20;
            this.GraphPorEstaciones.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.GraphPorEstaciones.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.GraphPorEstaciones.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.GraphPorEstaciones.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.GraphPorEstaciones.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea3.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.LabelStyle.Angle = -90;
            chartArea3.AxisX.Title = "Estaciones";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.Maximum = 100D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.Title = "Cant Pasajeros";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            chartArea3.BorderColor = System.Drawing.Color.DarkRed;
            chartArea3.Name = "ChartArea1";
            this.GraphPorEstaciones.ChartAreas.Add(chartArea3);
            this.GraphPorEstaciones.DataSource = this.BindingSourceTraza;
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Name = "Legend1";
            this.GraphPorEstaciones.Legends.Add(legend3);
            this.GraphPorEstaciones.Location = new System.Drawing.Point(0, 0);
            this.GraphPorEstaciones.Margin = new System.Windows.Forms.Padding(0);
            this.GraphPorEstaciones.Name = "GraphPorEstaciones";
            this.GraphPorEstaciones.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.GraphPorEstaciones.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.GraphPorEstaciones.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49))))),
        System.Drawing.Color.LightSlateGray};
            series5.BorderWidth = 4;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4;
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.LegendText = "Ida";
            series5.MarkerBorderWidth = 10;
            series5.MarkerSize = 13;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "Series1";
            series5.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
            series5.XValueMember = "Nombre";
            series5.YValueMembers = "ValorIda";
            series6.BorderWidth = 4;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsXValueIndexed = true;
            series6.Legend = "Legend1";
            series6.LegendText = "Vuelta";
            series6.MarkerBorderWidth = 10;
            series6.MarkerSize = 13;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "Series2";
            series6.XValueMember = "Nombre";
            series6.YValueMembers = "ValorVuelta";
            this.GraphPorEstaciones.Series.Add(series5);
            this.GraphPorEstaciones.Series.Add(series6);
            this.GraphPorEstaciones.Size = new System.Drawing.Size(633, 380);
            this.GraphPorEstaciones.TabIndex = 0;
            this.GraphPorEstaciones.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            title3.Name = "Title1";
            title3.Text = "Reporte por estaciones";
            this.GraphPorEstaciones.Titles.Add(title3);
            this.GraphPorEstaciones.Visible = false;
            // 
            // panelCabecera
            // 
            this.panelCabecera.Controls.Add(this.ButtonCerrar);
            this.panelCabecera.Controls.Add(this.label2);
            this.panelCabecera.Controls.Add(this.LabelDuracion);
            this.panelCabecera.Controls.Add(this.LabelNombreSimulacion);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1157, 75);
            this.panelCabecera.TabIndex = 2;
            // 
            // ButtonCerrar
            // 
            this.ButtonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonCerrar.Depth = 0;
            this.ButtonCerrar.Icon = null;
            this.ButtonCerrar.Location = new System.Drawing.Point(1021, 12);
            this.ButtonCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonCerrar.Name = "ButtonCerrar";
            this.ButtonCerrar.Primary = true;
            this.ButtonCerrar.Size = new System.Drawing.Size(124, 30);
            this.ButtonCerrar.TabIndex = 17;
            this.ButtonCerrar.Text = "CERRAR";
            this.toolTip1.SetToolTip(this.ButtonCerrar, "Exportar Reporte en PDF");
            this.ButtonCerrar.UseVisualStyleBackColor = true;
            this.ButtonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(0, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1157, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Resultados de la Simulación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDuracion
            // 
            this.LabelDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDuracion.AutoSize = true;
            this.LabelDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.LabelDuracion.Location = new System.Drawing.Point(871, 42);
            this.LabelDuracion.Name = "LabelDuracion";
            this.LabelDuracion.Size = new System.Drawing.Size(68, 18);
            this.LabelDuracion.TabIndex = 11;
            this.LabelDuracion.Text = "Duracion";
            // 
            // LabelNombreSimulacion
            // 
            this.LabelNombreSimulacion.AutoSize = true;
            this.LabelNombreSimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombreSimulacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.LabelNombreSimulacion.Location = new System.Drawing.Point(169, 42);
            this.LabelNombreSimulacion.Name = "LabelNombreSimulacion";
            this.LabelNombreSimulacion.Size = new System.Drawing.Size(135, 18);
            this.LabelNombreSimulacion.TabIndex = 10;
            this.LabelNombreSimulacion.Text = "NombreSimulacion";
            // 
            // PanelFiltro
            // 
            this.PanelFiltro.Controls.Add(this.ComboBoxReportes);
            this.PanelFiltro.Controls.Add(this.ButtonVerReporte);
            this.PanelFiltro.Controls.Add(this.ButtonGenerarArchivo);
            this.PanelFiltro.Controls.Add(this.label1);
            this.PanelFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFiltro.Location = new System.Drawing.Point(0, 75);
            this.PanelFiltro.Name = "PanelFiltro";
            this.PanelFiltro.Size = new System.Drawing.Size(1157, 39);
            this.PanelFiltro.TabIndex = 0;
            // 
            // ButtonVerReporte
            // 
            this.ButtonVerReporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonVerReporte.Depth = 0;
            this.ButtonVerReporte.Icon = null;
            this.ButtonVerReporte.Location = new System.Drawing.Point(757, 4);
            this.ButtonVerReporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonVerReporte.Name = "ButtonVerReporte";
            this.ButtonVerReporte.Primary = true;
            this.ButtonVerReporte.Size = new System.Drawing.Size(96, 30);
            this.ButtonVerReporte.TabIndex = 15;
            this.ButtonVerReporte.Text = "VER";
            this.toolTip1.SetToolTip(this.ButtonVerReporte, "Ver Reporte");
            this.ButtonVerReporte.UseVisualStyleBackColor = true;
            this.ButtonVerReporte.Click += new System.EventHandler(this.ButtonVerReporte_Click);
            // 
            // ButtonGenerarArchivo
            // 
            this.ButtonGenerarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonGenerarArchivo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonGenerarArchivo.Depth = 0;
            this.ButtonGenerarArchivo.Icon = null;
            this.ButtonGenerarArchivo.Location = new System.Drawing.Point(1021, 4);
            this.ButtonGenerarArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonGenerarArchivo.Name = "ButtonGenerarArchivo";
            this.ButtonGenerarArchivo.Primary = true;
            this.ButtonGenerarArchivo.Size = new System.Drawing.Size(124, 30);
            this.ButtonGenerarArchivo.TabIndex = 13;
            this.ButtonGenerarArchivo.Text = "EXPORTAR";
            this.toolTip1.SetToolTip(this.ButtonGenerarArchivo, "Exportar Reporte en PDF");
            this.ButtonGenerarArchivo.UseVisualStyleBackColor = true;
            this.ButtonGenerarArchivo.Click += new System.EventHandler(this.ButtonGenerarArchivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reportes disponibles";
            this.toolTip1.SetToolTip(this.label1, "Seleccione los gráficos que desea visualizar");
            // 
            // FlowLayOutPanel1
            // 
            this.FlowLayOutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayOutPanel1.Controls.Add(this.GraphPorEstaciones);
            this.FlowLayOutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlowLayOutPanel1.Location = new System.Drawing.Point(0, 0);
            this.FlowLayOutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayOutPanel1.Name = "FlowLayOutPanel1";
            this.FlowLayOutPanel1.Size = new System.Drawing.Size(1191, 380);
            this.FlowLayOutPanel1.TabIndex = 4;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.ReshowDelay = 100;
            // 
            // PanelGraficoTraza
            // 
            this.PanelGraficoTraza.Controls.Add(this.GraficoTraza);
            this.PanelGraficoTraza.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelGraficoTraza.Location = new System.Drawing.Point(0, 0);
            this.PanelGraficoTraza.Name = "PanelGraficoTraza";
            this.PanelGraficoTraza.Size = new System.Drawing.Size(1140, 380);
            this.PanelGraficoTraza.TabIndex = 2;
            // 
            // GraficoTraza
            // 
            this.GraficoTraza.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.GraficoTraza.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.GraficoTraza.BorderlineWidth = 20;
            this.GraficoTraza.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.GraficoTraza.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.GraficoTraza.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.GraficoTraza.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.GraficoTraza.BorderSkin.BorderWidth = 20;
            this.GraficoTraza.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.GraficoTraza.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea4.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea4.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea4.AxisX.LabelStyle.Interval = 0D;
            chartArea4.AxisX.Title = "Servicios";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            chartArea4.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisY.Title = "Cant Pasajeros";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            chartArea4.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.CursorX.IsUserEnabled = true;
            chartArea4.CursorX.IsUserSelectionEnabled = true;
            chartArea4.CursorX.LineColor = System.Drawing.Color.Transparent;
            chartArea4.CursorX.SelectionColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.GraficoTraza.ChartAreas.Add(chartArea4);
            this.GraficoTraza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GraficoTraza.DataSource = this.BindingSourceTraza;
            this.GraficoTraza.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Name = "Legend1";
            this.GraficoTraza.Legends.Add(legend4);
            this.GraficoTraza.Location = new System.Drawing.Point(0, 0);
            this.GraficoTraza.Name = "GraficoTraza";
            this.GraficoTraza.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.GraficoTraza.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49))))),
        System.Drawing.Color.LightSlateGray};
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.LegendText = "Ida";
            series7.MarkerBorderWidth = 10;
            series7.MarkerSize = 10;
            series7.MarkerStep = 10;
            series7.Name = "Series1";
            series7.XValueMember = "Nombre";
            series7.YValueMembers = "ValorIda";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.LegendText = "Vuelta";
            series8.MarkerBorderWidth = 10;
            series8.MarkerSize = 10;
            series8.MarkerStep = 10;
            series8.Name = "Series2";
            series8.XValueMember = "Nombre";
            series8.YValueMembers = "ValorVuelta";
            this.GraficoTraza.Series.Add(series7);
            this.GraficoTraza.Series.Add(series8);
            this.GraficoTraza.Size = new System.Drawing.Size(1140, 380);
            this.GraficoTraza.TabIndex = 2;
            this.GraficoTraza.Text = "chart1";
            title4.BackColor = System.Drawing.Color.White;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            title4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            title4.Name = "Principal";
            title4.Text = "Reporte por servicios";
            this.GraficoTraza.Titles.Add(title4);
            this.GraficoTraza.Visible = false;
            // 
            // panelGraficos
            // 
            this.panelGraficos.AutoScroll = true;
            this.panelGraficos.Controls.Add(this.PanelGraphsEstaciones);
            this.panelGraficos.Controls.Add(this.PanelGraficoTraza);
            this.panelGraficos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraficos.Location = new System.Drawing.Point(0, 114);
            this.panelGraficos.Name = "panelGraficos";
            this.panelGraficos.Size = new System.Drawing.Size(1157, 627);
            this.panelGraficos.TabIndex = 5;
            // 
            // PanelGraphsEstaciones
            // 
            this.PanelGraphsEstaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelGraphsEstaciones.Controls.Add(this.FlowLayOutPanel1);
            this.PanelGraphsEstaciones.Location = new System.Drawing.Point(0, 380);
            this.PanelGraphsEstaciones.Name = "PanelGraphsEstaciones";
            this.PanelGraphsEstaciones.Size = new System.Drawing.Size(1140, 381);
            this.PanelGraphsEstaciones.TabIndex = 3;
            // 
            // BindingSourceTraza
            // 
            this.BindingSourceTraza.DataSource = typeof(SimuRails.Report.ReportHelperGrafico);
            // 
            // ComboBoxReportes
            // 
            this.ComboBoxReportes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxReportes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxReportes.BackColor = System.Drawing.SystemColors.Control;
            this.ComboBoxReportes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ComboBoxReportes.FormattingEnabled = true;
            this.ComboBoxReportes.Location = new System.Drawing.Point(210, 6);
            this.ComboBoxReportes.Name = "ComboBoxReportes";
            this.ComboBoxReportes.Size = new System.Drawing.Size(541, 25);
            this.ComboBoxReportes.TabIndex = 16;
            // 
            // ReportGraphsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1157, 741);
            this.Controls.Add(this.panelGraficos);
            this.Controls.Add(this.PanelFiltro);
            this.Controls.Add(this.panelCabecera);
            this.Name = "ReportGraphsForm";
            this.Text = "Resultado de Simulación";
            this.SizeChanged += new System.EventHandler(this.ReportGraphsForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GraphPorEstaciones)).EndInit();
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            this.PanelFiltro.ResumeLayout(false);
            this.PanelFiltro.PerformLayout();
            this.FlowLayOutPanel1.ResumeLayout(false);
            this.PanelGraficoTraza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GraficoTraza)).EndInit();
            this.panelGraficos.ResumeLayout(false);
            this.PanelGraphsEstaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTraza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GraphPorEstaciones;
        private System.Windows.Forms.BindingSource BindingSourceTraza;
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Panel PanelFiltro;
        private System.Windows.Forms.FlowLayoutPanel FlowLayOutPanel1;
        private System.Windows.Forms.Label LabelNombreSimulacion;
        private System.Windows.Forms.Label LabelDuracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonGenerarArchivo;
        private System.Windows.Forms.ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonVerReporte;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel PanelGraficoTraza;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoTraza;
        private MyComboBox ComboBoxReportes;
        private System.Windows.Forms.Panel panelGraficos;
        private System.Windows.Forms.Panel PanelGraphsEstaciones;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonCerrar;
    }
}