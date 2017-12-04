namespace ZP_Max_PDP
{
    partial class Algo2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine7 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine8 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine5 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine6 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.program = new MetroFramework.Controls.MetroTabControl();
            this.TabTabu = new MetroFramework.Controls.MetroTabPage();
            this.sizeTabu = new System.Windows.Forms.NumericUpDown();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cadenceTabu = new System.Windows.Forms.NumericUpDown();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.iterPerRestartRange = new System.Windows.Forms.NumericUpDown();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.bestHillClimbing = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.timerLabel = new MetroFramework.Controls.MetroLabel();
            this.computing = new MetroFramework.Controls.MetroLabel();
            this.sizeSolutionTabu = new MetroFramework.Controls.MetroLabel();
            this.sizeElements = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.computeButton = new MetroFramework.Controls.MetroButton();
            this.rangeRestart = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SolutionChart = new MetroFramework.Controls.MetroTabPage();
            this.tabSolChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabTabuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.solutionGrid = new MetroFramework.Controls.MetroGrid();
            this.program.SuspendLayout();
            this.TabTabu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTabu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadenceTabu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterPerRestartRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeRestart)).BeginInit();
            this.SolutionChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabSolChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTabuChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(1, 1);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1077, 39);
            this.metroTile1.TabIndex = 4;
            this.metroTile1.Text = "Algorytm właściwy - Tabu Search";
            this.metroTile1.UseSelectable = true;
            // 
            // program
            // 
            this.program.Controls.Add(this.TabTabu);
            this.program.Controls.Add(this.SolutionChart);
            this.program.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.program.Location = new System.Drawing.Point(3, 46);
            this.program.Name = "program";
            this.program.SelectedIndex = 0;
            this.program.Size = new System.Drawing.Size(1072, 550);
            this.program.TabIndex = 65;
            this.program.UseSelectable = true;
            // 
            // TabTabu
            // 
            this.TabTabu.Controls.Add(this.tabTabuChart);
            this.TabTabu.Controls.Add(this.sizeTabu);
            this.TabTabu.Controls.Add(this.metroLabel9);
            this.TabTabu.Controls.Add(this.cadenceTabu);
            this.TabTabu.Controls.Add(this.metroLabel8);
            this.TabTabu.Controls.Add(this.iterPerRestartRange);
            this.TabTabu.Controls.Add(this.metroLabel6);
            this.TabTabu.Controls.Add(this.bestHillClimbing);
            this.TabTabu.Controls.Add(this.metroLabel7);
            this.TabTabu.Controls.Add(this.metroLabel5);
            this.TabTabu.Controls.Add(this.timerLabel);
            this.TabTabu.Controls.Add(this.computing);
            this.TabTabu.Controls.Add(this.sizeSolutionTabu);
            this.TabTabu.Controls.Add(this.sizeElements);
            this.TabTabu.Controls.Add(this.metroLabel4);
            this.TabTabu.Controls.Add(this.metroLabel3);
            this.TabTabu.Controls.Add(this.metroLabel2);
            this.TabTabu.Controls.Add(this.progressBar);
            this.TabTabu.Controls.Add(this.computeButton);
            this.TabTabu.Controls.Add(this.rangeRestart);
            this.TabTabu.Controls.Add(this.metroLabel1);
            this.TabTabu.HorizontalScrollbarBarColor = true;
            this.TabTabu.HorizontalScrollbarHighlightOnWheel = false;
            this.TabTabu.HorizontalScrollbarSize = 10;
            this.TabTabu.Location = new System.Drawing.Point(4, 38);
            this.TabTabu.Name = "TabTabu";
            this.TabTabu.Size = new System.Drawing.Size(1064, 508);
            this.TabTabu.TabIndex = 0;
            this.TabTabu.Text = "TabuSearch settings  ";
            this.TabTabu.VerticalScrollbarBarColor = true;
            this.TabTabu.VerticalScrollbarHighlightOnWheel = false;
            this.TabTabu.VerticalScrollbarSize = 10;
            // 
            // sizeTabu
            // 
            this.sizeTabu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.sizeTabu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sizeTabu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sizeTabu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sizeTabu.Location = new System.Drawing.Point(364, 81);
            this.sizeTabu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeTabu.Name = "sizeTabu";
            this.sizeTabu.Size = new System.Drawing.Size(75, 23);
            this.sizeTabu.TabIndex = 85;
            this.sizeTabu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sizeTabu.ThousandsSeparator = true;
            this.sizeTabu.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(65, 81);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(293, 19);
            this.metroLabel9.TabIndex = 84;
            this.metroLabel9.Text = "Wielkosc listy tabu (% aktualnego rozwiązania P):";
            // 
            // cadenceTabu
            // 
            this.cadenceTabu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cadenceTabu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cadenceTabu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cadenceTabu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadenceTabu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cadenceTabu.Location = new System.Drawing.Point(135, 116);
            this.cadenceTabu.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cadenceTabu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cadenceTabu.Name = "cadenceTabu";
            this.cadenceTabu.Size = new System.Drawing.Size(75, 23);
            this.cadenceTabu.TabIndex = 83;
            this.cadenceTabu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cadenceTabu.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(65, 120);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(64, 19);
            this.metroLabel8.TabIndex = 82;
            this.metroLabel8.Text = "Kadencja:";
            // 
            // iterPerRestartRange
            // 
            this.iterPerRestartRange.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.iterPerRestartRange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iterPerRestartRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iterPerRestartRange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iterPerRestartRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iterPerRestartRange.Location = new System.Drawing.Point(409, 32);
            this.iterPerRestartRange.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.iterPerRestartRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterPerRestartRange.Name = "iterPerRestartRange";
            this.iterPerRestartRange.Size = new System.Drawing.Size(75, 23);
            this.iterPerRestartRange.TabIndex = 81;
            this.iterPerRestartRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iterPerRestartRange.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(295, 36);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(110, 19);
            this.metroLabel6.TabIndex = 80;
            this.metroLabel6.Text = "Iteracji na restart:";
            // 
            // bestHillClimbing
            // 
            this.bestHillClimbing.AutoSize = true;
            this.bestHillClimbing.Location = new System.Drawing.Point(929, 123);
            this.bestHillClimbing.Name = "bestHillClimbing";
            this.bestHillClimbing.Size = new System.Drawing.Size(16, 19);
            this.bestHillClimbing.TabIndex = 79;
            this.bestHillClimbing.Text = "0";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(580, 123);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(334, 19);
            this.metroLabel7.TabIndex = 78;
            this.metroLabel7.Text = "Liczba elementów rozwiązania wstępnego HillClimbing: ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(748, 188);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 19);
            this.metroLabel5.TabIndex = 77;
            this.metroLabel5.Text = "sekund";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(693, 188);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 0);
            this.timerLabel.TabIndex = 76;
            // 
            // computing
            // 
            this.computing.AutoSize = true;
            this.computing.Location = new System.Drawing.Point(755, 13);
            this.computing.Name = "computing";
            this.computing.Size = new System.Drawing.Size(103, 19);
            this.computing.TabIndex = 75;
            this.computing.Text = "Postęp obliczeń:";
            // 
            // sizeSolutionTabu
            // 
            this.sizeSolutionTabu.AutoSize = true;
            this.sizeSolutionTabu.Location = new System.Drawing.Point(929, 153);
            this.sizeSolutionTabu.Name = "sizeSolutionTabu";
            this.sizeSolutionTabu.Size = new System.Drawing.Size(16, 19);
            this.sizeSolutionTabu.TabIndex = 74;
            this.sizeSolutionTabu.Text = "0";
            // 
            // sizeElements
            // 
            this.sizeElements.AutoSize = true;
            this.sizeElements.Location = new System.Drawing.Point(800, 92);
            this.sizeElements.Name = "sizeElements";
            this.sizeElements.Size = new System.Drawing.Size(16, 19);
            this.sizeElements.TabIndex = 73;
            this.sizeElements.Text = "0";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(582, 188);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.TabIndex = 72;
            this.metroLabel4.Text = "Czas działania:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(580, 153);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(315, 19);
            this.metroLabel3.TabIndex = 71;
            this.metroLabel3.Text = "Liczba elementów rozwiązania TabuSearch (max M): ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(580, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(205, 19);
            this.metroLabel2.TabIndex = 70;
            this.metroLabel2.Text = "Liczba elementów w multizbiorze:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(582, 41);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(426, 24);
            this.progressBar.TabIndex = 68;
            this.progressBar.Visible = false;
            // 
            // computeButton
            // 
            this.computeButton.BackColor = System.Drawing.Color.Crimson;
            this.computeButton.Location = new System.Drawing.Point(233, 160);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(113, 41);
            this.computeButton.TabIndex = 67;
            this.computeButton.Text = "Utwórz";
            this.computeButton.UseCustomBackColor = true;
            this.computeButton.UseSelectable = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click_1);
            // 
            // rangeRestart
            // 
            this.rangeRestart.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rangeRestart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rangeRestart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rangeRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rangeRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rangeRestart.Location = new System.Drawing.Point(177, 32);
            this.rangeRestart.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.rangeRestart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rangeRestart.Name = "rangeRestart";
            this.rangeRestart.Size = new System.Drawing.Size(75, 23);
            this.rangeRestart.TabIndex = 66;
            this.rangeRestart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rangeRestart.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(64, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 65;
            this.metroLabel1.Text = "Liczba restartów:";
            // 
            // SolutionChart
            // 
            this.SolutionChart.Controls.Add(this.solutionGrid);
            this.SolutionChart.Controls.Add(this.tabSolChart);
            this.SolutionChart.HorizontalScrollbarBarColor = true;
            this.SolutionChart.HorizontalScrollbarHighlightOnWheel = false;
            this.SolutionChart.HorizontalScrollbarSize = 10;
            this.SolutionChart.Location = new System.Drawing.Point(4, 38);
            this.SolutionChart.Name = "SolutionChart";
            this.SolutionChart.Size = new System.Drawing.Size(1064, 508);
            this.SolutionChart.TabIndex = 1;
            this.SolutionChart.Text = "  Solution chart ";
            this.SolutionChart.VerticalScrollbarBarColor = true;
            this.SolutionChart.VerticalScrollbarHighlightOnWheel = false;
            this.SolutionChart.VerticalScrollbarSize = 10;
            // 
            // tabSolChart
            // 
            this.tabSolChart.BackSecondaryColor = System.Drawing.Color.Gray;
            this.tabSolChart.BorderlineColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabSolChart.BorderSkin.BackSecondaryColor = System.Drawing.Color.White;
            this.tabSolChart.BorderSkin.BorderColor = System.Drawing.Color.LightGray;
            this.tabSolChart.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.tabSolChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            stripLine7.BorderColor = System.Drawing.Color.LightGray;
            stripLine7.Interval = 10D;
            chartArea4.AxisX.StripLines.Add(stripLine7);
            chartArea4.AxisX2.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisY.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.IsInterlaced = true;
            chartArea4.AxisY.LineWidth = 2;
            stripLine8.BorderColor = System.Drawing.Color.LightGray;
            stripLine8.Interval = 5D;
            chartArea4.AxisY.StripLines.Add(stripLine8);
            chartArea4.AxisY2.LineColor = System.Drawing.Color.Gray;
            chartArea4.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea4.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            chartArea4.BackSecondaryColor = System.Drawing.Color.White;
            chartArea4.BorderColor = System.Drawing.Color.Transparent;
            chartArea4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea4.Name = "ChartArea1";
            chartArea4.ShadowColor = System.Drawing.Color.Silver;
            this.tabSolChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.tabSolChart.Legends.Add(legend4);
            this.tabSolChart.Location = new System.Drawing.Point(166, 46);
            this.tabSolChart.Name = "tabSolChart";
            this.tabSolChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.tabSolChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Crimson};
            series4.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            series4.BorderColor = System.Drawing.Color.Transparent;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Crimson;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.tabSolChart.Series.Add(series4);
            this.tabSolChart.Size = new System.Drawing.Size(895, 398);
            this.tabSolChart.TabIndex = 2;
            // 
            // tabTabuChart
            // 
            this.tabTabuChart.BackSecondaryColor = System.Drawing.Color.Gray;
            this.tabTabuChart.BorderlineColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabTabuChart.BorderSkin.BackSecondaryColor = System.Drawing.Color.White;
            this.tabTabuChart.BorderSkin.BorderColor = System.Drawing.Color.LightGray;
            this.tabTabuChart.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.tabTabuChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            stripLine5.BorderColor = System.Drawing.Color.LightGray;
            stripLine5.Interval = 10D;
            chartArea3.AxisX.StripLines.Add(stripLine5);
            chartArea3.AxisX2.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.IsInterlaced = true;
            chartArea3.AxisY.LineWidth = 2;
            stripLine6.BorderColor = System.Drawing.Color.LightGray;
            stripLine6.Interval = 5D;
            chartArea3.AxisY.StripLines.Add(stripLine6);
            chartArea3.AxisY2.LineColor = System.Drawing.Color.Gray;
            chartArea3.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            chartArea3.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.Silver;
            this.tabTabuChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.tabTabuChart.Legends.Add(legend3);
            this.tabTabuChart.Location = new System.Drawing.Point(1, 236);
            this.tabTabuChart.Name = "tabTabuChart";
            this.tabTabuChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.tabTabuChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Crimson};
            series3.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Crimson;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.tabTabuChart.Series.Add(series3);
            this.tabTabuChart.Size = new System.Drawing.Size(1060, 269);
            this.tabTabuChart.TabIndex = 86;
            // 
            // solutionGrid
            // 
            this.solutionGrid.AllowUserToResizeRows = false;
            this.solutionGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.solutionGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.solutionGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.solutionGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.solutionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.solutionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.solutionGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.solutionGrid.EnableHeadersVisualStyles = false;
            this.solutionGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.solutionGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.solutionGrid.Location = new System.Drawing.Point(13, 28);
            this.solutionGrid.Name = "solutionGrid";
            this.solutionGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.solutionGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.solutionGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.solutionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.solutionGrid.Size = new System.Drawing.Size(185, 456);
            this.solutionGrid.TabIndex = 70;
            // 
            // Algo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.program);
            this.Controls.Add(this.metroTile1);
            this.Name = "Algo2";
            this.Size = new System.Drawing.Size(1078, 604);
            this.Load += new System.EventHandler(this.Algo2_Load);
            this.program.ResumeLayout(false);
            this.TabTabu.ResumeLayout(false);
            this.TabTabu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTabu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadenceTabu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterPerRestartRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeRestart)).EndInit();
            this.SolutionChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabSolChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTabuChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTabControl program;
        private MetroFramework.Controls.MetroTabPage TabTabu;
        private MetroFramework.Controls.MetroLabel bestHillClimbing;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel timerLabel;
        private MetroFramework.Controls.MetroLabel computing;
        private MetroFramework.Controls.MetroLabel sizeSolutionTabu;
        private MetroFramework.Controls.MetroLabel sizeElements;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private MetroFramework.Controls.MetroButton computeButton;
        private System.Windows.Forms.NumericUpDown rangeRestart;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage SolutionChart;
        private System.Windows.Forms.NumericUpDown cadenceTabu;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.NumericUpDown iterPerRestartRange;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.NumericUpDown sizeTabu;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart tabSolChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart tabTabuChart;
        private MetroFramework.Controls.MetroGrid solutionGrid;
    }
}
