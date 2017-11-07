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
            this.fileName = new MetroFramework.Controls.MetroTextBox();
            this.openFile = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fullPath = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(187, 187);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(143, 287);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(514, 192);
            this.metroTextBox1.TabIndex = 6;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoadInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.fullPath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.fileName);
            this.Name = "LoadInstance";
            this.Size = new System.Drawing.Size(1080, 604);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox metroTextBox1;

    }
}
