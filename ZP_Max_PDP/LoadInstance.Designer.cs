namespace ZP_Max_PDP
{
    partial class LoadInstance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fileName = new MetroFramework.Controls.MetroTextBox();
            this.openFile = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fullPath = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.firstGrid = new MetroFramework.Controls.MetroGrid();
            this.secondGrid = new MetroFramework.Controls.MetroGrid();
            this.infoLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // fileName
            // 
            // 
            // 
            // 
            this.fileName.CustomButton.Image = null;
            this.fileName.CustomButton.Location = new System.Drawing.Point(422, 2);
            this.fileName.CustomButton.Name = "";
            this.fileName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.fileName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fileName.CustomButton.TabIndex = 1;
            this.fileName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fileName.CustomButton.UseSelectable = true;
            this.fileName.CustomButton.Visible = false;
            this.fileName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.fileName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileName.Lines = new string[] {
        "nazwa pliku"};
            this.fileName.Location = new System.Drawing.Point(207, 175);
            this.fileName.MaxLength = 32767;
            this.fileName.Name = "fileName";
            this.fileName.PasswordChar = '\0';
            this.fileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fileName.SelectedText = "";
            this.fileName.SelectionLength = 0;
            this.fileName.SelectionStart = 0;
            this.fileName.ShortcutsEnabled = true;
            this.fileName.Size = new System.Drawing.Size(450, 30);
            this.fileName.TabIndex = 0;
            this.fileName.Text = "nazwa pliku";
            this.fileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fileName.UseSelectable = true;
            this.fileName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fileName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // openFile
            // 
            this.openFile.BackColor = System.Drawing.Color.Crimson;
            this.openFile.Location = new System.Drawing.Point(676, 170);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(149, 41);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "Otwórz plik";
            this.openFile.UseCustomBackColor = true;
            this.openFile.UseSelectable = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(1, 1);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1069, 39);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Wybierz instancję z pliku";
            this.metroTile1.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ZP_Max_PDP.Properties.Resources.folder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = global::ZP_Max_PDP.Properties.Resources.folder;
            this.pictureBox1.Location = new System.Drawing.Point(143, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 41);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // fullPath
            // 
            this.fullPath.ForeColor = System.Drawing.SystemColors.GrayText;
            this.fullPath.Location = new System.Drawing.Point(208, 211);
            this.fullPath.Name = "fullPath";
            this.fullPath.Size = new System.Drawing.Size(449, 20);
            this.fullPath.TabIndex = 4;
            this.fullPath.Text = "ścieżka do pliku";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(143, 126);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(204, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Wybiesz plik CSV z multizbiorem:";
            // 
            // firstGrid
            // 
            this.firstGrid.AllowUserToResizeRows = false;
            this.firstGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.firstGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.firstGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.firstGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.firstGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.firstGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.firstGrid.EnableHeadersVisualStyles = false;
            this.firstGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.firstGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.firstGrid.Location = new System.Drawing.Point(143, 309);
            this.firstGrid.Name = "firstGrid";
            this.firstGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.firstGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.firstGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.firstGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.firstGrid.Size = new System.Drawing.Size(235, 249);
            this.firstGrid.TabIndex = 6;
            // 
            // secondGrid
            // 
            this.secondGrid.AllowUserToResizeRows = false;
            this.secondGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.secondGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.secondGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.secondGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.secondGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.secondGrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.secondGrid.EnableHeadersVisualStyles = false;
            this.secondGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.secondGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.secondGrid.Location = new System.Drawing.Point(422, 309);
            this.secondGrid.Name = "secondGrid";
            this.secondGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.secondGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.secondGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.secondGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.secondGrid.Size = new System.Drawing.Size(235, 249);
            this.secondGrid.TabIndex = 7;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(422, 275);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(158, 19);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "Usunięto błędne wartości:";
            this.infoLabel.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(143, 275);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Wczytane wartości";
            // 
            // LoadInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.secondGrid);
            this.Controls.Add(this.firstGrid);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.fullPath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.fileName);
            this.Name = "LoadInstance";
            this.Size = new System.Drawing.Size(1080, 604);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox fileName;
        private MetroFramework.Controls.MetroButton openFile;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox fullPath;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid firstGrid;
        private MetroFramework.Controls.MetroGrid secondGrid;
        private MetroFramework.Controls.MetroLabel infoLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;

    }
}
