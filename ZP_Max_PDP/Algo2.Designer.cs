﻿namespace ZP_Max_PDP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine2 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.solutionGrid = new MetroFramework.Controls.MetroGrid();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.computeButton = new MetroFramework.Controls.MetroButton();
            this.rangeRestart = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SolutionChart = new MetroFramework.Controls.MetroTabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.program.SuspendLayout();
            this.TabTabu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTabu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadenceTabu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterPerRestartRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeRestart)).BeginInit();
            this.SolutionChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.program.SelectedIndex = 1;
            this.program.Size = new System.Drawing.Size(972, 550);
            this.program.TabIndex = 65;
            this.program.UseSelectable = true;
            // 
            // TabTabu
            // 
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
            this.TabTabu.Controls.Add(this.solutionGrid);
            this.TabTabu.Controls.Add(this.progressBar);
            this.TabTabu.Controls.Add(this.computeButton);
            this.TabTabu.Controls.Add(this.rangeRestart);
            this.TabTabu.Controls.Add(this.metroLabel1);
            this.TabTabu.HorizontalScrollbarBarColor = true;
            this.TabTabu.HorizontalScrollbarHighlightOnWheel = false;
            this.TabTabu.HorizontalScrollbarSize = 10;
            this.TabTabu.Location = new System.Drawing.Point(4, 38);
            this.TabTabu.Name = "TabTabu";
            this.TabTabu.Size = new System.Drawing.Size(964, 508);
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
            1,
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
            10,
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
            this.bestHillClimbing.Location = new System.Drawing.Point(420, 366);
            this.bestHillClimbing.Name = "bestHillClimbing";
            this.bestHillClimbing.Size = new System.Drawing.Size(16, 19);
            this.bestHillClimbing.TabIndex = 79;
            this.bestHillClimbing.Text = "0";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(71, 366);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(334, 19);
            this.metroLabel7.TabIndex = 78;
            this.metroLabel7.Text = "Liczba elementów rozwiązania wstępnego HillClimbing: ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(237, 441);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 19);
            this.metroLabel5.TabIndex = 77;
            this.metroLabel5.Text = "sekund";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(182, 441);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 0);
            this.timerLabel.TabIndex = 76;
            // 
            // computing
            // 
            this.computing.AutoSize = true;
            this.computing.Location = new System.Drawing.Point(244, 225);
            this.computing.Name = "computing";
            this.computing.Size = new System.Drawing.Size(103, 19);
            this.computing.TabIndex = 75;
            this.computing.Text = "Postęp obliczeń:";
            // 
            // sizeSolutionTabu
            // 
            this.sizeSolutionTabu.AutoSize = true;
            this.sizeSolutionTabu.Location = new System.Drawing.Point(420, 396);
            this.sizeSolutionTabu.Name = "sizeSolutionTabu";
            this.sizeSolutionTabu.Size = new System.Drawing.Size(16, 19);
            this.sizeSolutionTabu.TabIndex = 74;
            this.sizeSolutionTabu.Text = "0";
            // 
            // sizeElements
            // 
            this.sizeElements.AutoSize = true;
            this.sizeElements.Location = new System.Drawing.Point(291, 335);
            this.sizeElements.Name = "sizeElements";
            this.sizeElements.Size = new System.Drawing.Size(16, 19);
            this.sizeElements.TabIndex = 73;
            this.sizeElements.Text = "0";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(71, 441);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.TabIndex = 72;
            this.metroLabel4.Text = "Czas działania:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(71, 396);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(262, 19);
            this.metroLabel3.TabIndex = 71;
            this.metroLabel3.Text = "Liczba elementów rozwiązania TabuSearch: ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(71, 335);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(205, 19);
            this.metroLabel2.TabIndex = 70;
            this.metroLabel2.Text = "Liczba elementów w multizbiorze:";
            // 
            // solutionGrid
            // 
            this.solutionGrid.AllowUserToResizeRows = false;
            this.solutionGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.solutionGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.solutionGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.solutionGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.solutionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.solutionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.solutionGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.solutionGrid.EnableHeadersVisualStyles = false;
            this.solutionGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.solutionGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.solutionGrid.Location = new System.Drawing.Point(612, 51);
            this.solutionGrid.Name = "solutionGrid";
            this.solutionGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.solutionGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.solutionGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.solutionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.solutionGrid.Size = new System.Drawing.Size(288, 409);
            this.solutionGrid.TabIndex = 69;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(71, 257);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(426, 24);
            this.progressBar.TabIndex = 68;
            this.progressBar.Visible = false;
            // 
            // computeButton
            // 
            this.computeButton.BackColor = System.Drawing.Color.Crimson;
            this.computeButton.Location = new System.Drawing.Point(237, 166);
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
            this.SolutionChart.Controls.Add(this.chart1);
            this.SolutionChart.HorizontalScrollbarBarColor = true;
            this.SolutionChart.HorizontalScrollbarHighlightOnWheel = false;
            this.SolutionChart.HorizontalScrollbarSize = 10;
            this.SolutionChart.Location = new System.Drawing.Point(4, 38);
            this.SolutionChart.Name = "SolutionChart";
            this.SolutionChart.Size = new System.Drawing.Size(964, 508);
            this.SolutionChart.TabIndex = 1;
            this.SolutionChart.Text = "  Solution chart ";
            this.SolutionChart.VerticalScrollbarBarColor = true;
            this.SolutionChart.VerticalScrollbarHighlightOnWheel = false;
            this.SolutionChart.VerticalScrollbarSize = 10;
            // 
            // chart1
            // 
            this.chart1.BackSecondaryColor = System.Drawing.Color.Gray;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.InactiveBorder;
            this.chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.LightGray;
            this.chart1.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            stripLine1.BorderColor = System.Drawing.Color.LightGray;
            stripLine1.Interval = 10D;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IsInterlaced = true;
            chartArea1.AxisY.LineWidth = 2;
            stripLine2.BorderColor = System.Drawing.Color.LightGray;
            stripLine2.Interval = 5D;
            chartArea1.AxisY.StripLines.Add(stripLine2);
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Gray;
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Silver;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(21, 34);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Crimson};
            series1.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Crimson;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(947, 398);
            this.chart1.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.solutionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeRestart)).EndInit();
            this.SolutionChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private MetroFramework.Controls.MetroGrid solutionGrid;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
