namespace ZP_Max_PDP
{
    partial class StartMenu
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
            this.Generate = new MetroFramework.Controls.MetroTile();
            this.FromFile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.ActiveControl = null;
            this.Generate.BackColor = System.Drawing.SystemColors.Control;
            this.Generate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Generate.Location = new System.Drawing.Point(95, 122);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(250, 75);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Utwórz nową instację";
            this.Generate.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Generate.UseSelectable = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // FromFile
            // 
            this.FromFile.ActiveControl = null;
            this.FromFile.Location = new System.Drawing.Point(95, 251);
            this.FromFile.Name = "FromFile";
            this.FromFile.Size = new System.Drawing.Size(250, 75);
            this.FromFile.TabIndex = 1;
            this.FromFile.Text = "Dodaj instancję z pliku";
            this.FromFile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.FromFile.UseSelectable = true;
            this.FromFile.Click += new System.EventHandler(this.FromFile_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FromFile);
            this.Controls.Add(this.Generate);
            this.Name = "StartMenu";
            this.Size = new System.Drawing.Size(770, 473);
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile Generate;
        private MetroFramework.Controls.MetroTile FromFile;

    }
}
