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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.NextButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rangeRestart = new System.Windows.Forms.NumericUpDown();
            this.startClimbing = new MetroFramework.Controls.MetroButton();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.rangeRestart)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(1, 1);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1077, 39);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Algorytm wstępny - algorytm wspinaczki";
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
            this.progressBar.Location = new System.Drawing.Point(576, 102);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(377, 24);
            this.progressBar.TabIndex = 40;
            // 
            // Algo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
