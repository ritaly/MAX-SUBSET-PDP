namespace ZP_Max_PDP
{
    partial class Algo1
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.NextButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rangeRestart = new System.Windows.Forms.NumericUpDown();
            this.startClimbing = new MetroFramework.Controls.MetroButton();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.solutionGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.sizeElements = new MetroFramework.Controls.MetroLabel();
            this.sizeSolution = new MetroFramework.Controls.MetroLabel();
            this.computing = new MetroFramework.Controls.MetroLabel();
            this.timerLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.rangeRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(1, 1);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1077, 39);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Algorytm wstępny - algorytm wspinaczkowy\r\n";
            this.metroTile1.UseSelectable = true;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NextButton.Location = new System.Drawing.Point(934, 541);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(122, 43);
            this.NextButton.TabIndex = 36;
            this.NextButton.Text = "Dalej >>";
            this.NextButton.UseCustomBackColor = true;
            this.NextButton.UseCustomForeColor = true;
            this.NextButton.UseSelectable = true;
            this.NextButton.Visible = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(123, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(178, 19);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Liczba wielokrotnych startów:";
            // 
            // rangeRestart
            // 
            this.rangeRestart.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rangeRestart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rangeRestart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rangeRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rangeRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rangeRestart.Location = new System.Drawing.Point(318, 104);
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
            this.rangeRestart.TabIndex = 38;
            this.rangeRestart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rangeRestart.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // startClimbing
            // 
            this.startClimbing.BackColor = System.Drawing.Color.Crimson;
            this.startClimbing.Location = new System.Drawing.Point(436, 93);
            this.startClimbing.Name = "startClimbing";
            this.startClimbing.Size = new System.Drawing.Size(113, 41);
            this.startClimbing.TabIndex = 39;
            this.startClimbing.Text = "Utwórz";
            this.startClimbing.UseCustomBackColor = true;
            this.startClimbing.UseSelectable = true;
            this.startClimbing.Click += new System.EventHandler(this.startClimbing_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(123, 194);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(426, 24);
            this.progressBar.TabIndex = 40;
            this.progressBar.Visible = false;
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
            this.solutionGrid.Location = new System.Drawing.Point(658, 60);
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
            this.solutionGrid.TabIndex = 41;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(123, 272);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(205, 19);
            this.metroLabel2.TabIndex = 42;
            this.metroLabel2.Text = "Liczba elementów w multizbiorze:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(123, 309);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(192, 19);
            this.metroLabel3.TabIndex = 43;
            this.metroLabel3.Text = "Liczba elementów rozwiązania: ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(123, 378);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.TabIndex = 44;
            this.metroLabel4.Text = "Czas działania:";
            // 
            // sizeElements
            // 
            this.sizeElements.AutoSize = true;
            this.sizeElements.Location = new System.Drawing.Point(343, 272);
            this.sizeElements.Name = "sizeElements";
            this.sizeElements.Size = new System.Drawing.Size(16, 19);
            this.sizeElements.TabIndex = 45;
            this.sizeElements.Text = "0";
            // 
            // sizeSolution
            // 
            this.sizeSolution.AutoSize = true;
            this.sizeSolution.Location = new System.Drawing.Point(343, 309);
            this.sizeSolution.Name = "sizeSolution";
            this.sizeSolution.Size = new System.Drawing.Size(16, 19);
            this.sizeSolution.TabIndex = 46;
            this.sizeSolution.Text = "0";
            // 
            // computing
            // 
            this.computing.AutoSize = true;
            this.computing.Location = new System.Drawing.Point(296, 162);
            this.computing.Name = "computing";
            this.computing.Size = new System.Drawing.Size(103, 19);
            this.computing.TabIndex = 47;
            this.computing.Text = "Postęp obliczeń:";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(234, 378);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 0);
            this.timerLabel.TabIndex = 48;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(289, 378);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 19);
            this.metroLabel5.TabIndex = 49;
            this.metroLabel5.Text = "sekund";
            // 
            // Algo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.computing);
            this.Controls.Add(this.sizeSolution);
            this.Controls.Add(this.sizeElements);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.solutionGrid);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.startClimbing);
            this.Controls.Add(this.rangeRestart);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.metroTile1);
            this.Name = "Algo1";
            this.Size = new System.Drawing.Size(1078, 604);
            this.Load += new System.EventHandler(this.Algo1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rangeRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton NextButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.NumericUpDown rangeRestart;
        private MetroFramework.Controls.MetroButton startClimbing;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private MetroFramework.Controls.MetroGrid solutionGrid;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel sizeElements;
        private MetroFramework.Controls.MetroLabel sizeSolution;
        private MetroFramework.Controls.MetroLabel computing;
        private MetroFramework.Controls.MetroLabel timerLabel;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}
