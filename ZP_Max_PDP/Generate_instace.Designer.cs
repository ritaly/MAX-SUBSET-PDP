namespace ZP_Max_PDP
{
    partial class Generate_instace
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
            this.ElementsLabel = new MetroFramework.Controls.MetroLabel();
            this.NumElements = new System.Windows.Forms.NumericUpDown();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.NumRangeStart = new System.Windows.Forms.NumericUpDown();
            this.Lenght = new MetroFramework.Controls.MetroLabel();
            this.NumRangeEnd = new System.Windows.Forms.NumericUpDown();
            this.ButtonCreateInstance = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRangeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRangeEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // ElementsLabel
            // 
            this.ElementsLabel.AutoSize = true;
            this.ElementsLabel.Enabled = false;
            this.ElementsLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ElementsLabel.Location = new System.Drawing.Point(20, 62);
            this.ElementsLabel.Name = "ElementsLabel";
            this.ElementsLabel.Size = new System.Drawing.Size(239, 19);
            this.ElementsLabel.TabIndex = 0;
            this.ElementsLabel.Text = "Liczba na elementów w multizbiorze : ";
            // 
            // NumElements
            // 
            this.NumElements.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NumElements.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumElements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NumElements.Location = new System.Drawing.Point(263, 62);
            this.NumElements.Name = "NumElements";
            this.NumElements.Size = new System.Drawing.Size(77, 23);
            this.NumElements.TabIndex = 1;
            this.NumElements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.metroTile1.Enabled = false;
            this.metroTile1.ForeColor = System.Drawing.Color.Snow;
            this.metroTile1.Location = new System.Drawing.Point(0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(915, 39);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Tworzenie nowej instancji";
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            // 
            // NumRangeStart
            // 
            this.NumRangeStart.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NumRangeStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumRangeStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumRangeStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumRangeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NumRangeStart.Location = new System.Drawing.Point(171, 110);
            this.NumRangeStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumRangeStart.Name = "NumRangeStart";
            this.NumRangeStart.Size = new System.Drawing.Size(75, 23);
            this.NumRangeStart.TabIndex = 4;
            this.NumRangeStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumRangeStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lenght
            // 
            this.Lenght.AutoSize = true;
            this.Lenght.Enabled = false;
            this.Lenght.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Lenght.Location = new System.Drawing.Point(20, 112);
            this.Lenght.Name = "Lenght";
            this.Lenght.Size = new System.Drawing.Size(259, 19);
            this.Lenght.TabIndex = 3;
            this.Lenght.Text = "Długości odcinków: od                        do";
            // 
            // NumRangeEnd
            // 
            this.NumRangeEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NumRangeEnd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumRangeEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumRangeEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumRangeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NumRangeEnd.Location = new System.Drawing.Point(285, 110);
            this.NumRangeEnd.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumRangeEnd.Name = "NumRangeEnd";
            this.NumRangeEnd.Size = new System.Drawing.Size(77, 23);
            this.NumRangeEnd.TabIndex = 5;
            this.NumRangeEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumRangeEnd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ButtonCreateInstance
            // 
            this.ButtonCreateInstance.BackColor = System.Drawing.Color.Crimson;
            this.ButtonCreateInstance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonCreateInstance.Location = new System.Drawing.Point(70, 180);
            this.ButtonCreateInstance.Name = "ButtonCreateInstance";
            this.ButtonCreateInstance.Size = new System.Drawing.Size(209, 43);
            this.ButtonCreateInstance.TabIndex = 6;
            this.ButtonCreateInstance.Text = "Utwórz instancję";
            this.ButtonCreateInstance.UseCustomBackColor = true;
            this.ButtonCreateInstance.UseCustomForeColor = true;
            this.ButtonCreateInstance.UseSelectable = true;
            this.ButtonCreateInstance.Click += new System.EventHandler(this.ButtonCreateInstance_Click);
            // 
            // Generate_instace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonCreateInstance);
            this.Controls.Add(this.NumRangeEnd);
            this.Controls.Add(this.NumRangeStart);
            this.Controls.Add(this.Lenght);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.NumElements);
            this.Controls.Add(this.ElementsLabel);
            this.Name = "Generate_instace";
            this.Size = new System.Drawing.Size(915, 473);
            ((System.ComponentModel.ISupportInitialize)(this.NumElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRangeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRangeEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ElementsLabel;
        private System.Windows.Forms.NumericUpDown NumElements;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.NumericUpDown NumRangeStart;
        private MetroFramework.Controls.MetroLabel Lenght;
        private System.Windows.Forms.NumericUpDown NumRangeEnd;
        private MetroFramework.Controls.MetroButton ButtonCreateInstance;
    }
}
