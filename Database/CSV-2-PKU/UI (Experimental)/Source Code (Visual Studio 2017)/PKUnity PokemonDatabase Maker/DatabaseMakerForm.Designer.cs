namespace PKUnity_PokemonDatabase_Maker
{
    partial class DatabaseMakerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseMakerForm));
            this.Credits = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Button();
            this.PokemonGenerationComboBox = new System.Windows.Forms.ComboBox();
            this.GenerationLabel = new System.Windows.Forms.Label();
            this.SourceFolderButton = new System.Windows.Forms.Button();
            this.OutputFolderButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.CSVFilesLabel = new System.Windows.Forms.Label();
            this.PKUnityVersionComboBox = new System.Windows.Forms.ComboBox();
            this.PKUnityVersionLabel = new System.Windows.Forms.Label();
            this.ExamplePokemonOld = new System.Windows.Forms.RichTextBox();
            this.ExampleDataLabel = new System.Windows.Forms.Label();
            this.GenerationWarningLabel = new System.Windows.Forms.Label();
            this.PokemonDataVersionWarningLabel = new System.Windows.Forms.Label();
            this.FolderWarningLabel = new System.Windows.Forms.Label();
            this.FinishedLabel = new System.Windows.Forms.Label();
            this.ExamplePokemonNew = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Credits
            // 
            this.Credits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Credits.AutoSize = true;
            this.Credits.Location = new System.Drawing.Point(12, 428);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(95, 13);
            this.Credits.TabIndex = 0;
            this.Credits.Text = "Made by: Velorexe";
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(603, 423);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(34, 23);
            this.InfoButton.TabIndex = 1;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // PokemonGenerationComboBox
            // 
            this.PokemonGenerationComboBox.FormattingEnabled = true;
            this.PokemonGenerationComboBox.Items.AddRange(new object[] {
            "Blue and Red",
            "Yellow",
            "Gold and Silver",
            "Crystal",
            "Ruby and Saphire",
            "Emerald",
            "FireRed and LeafGreen",
            "Diamond and Pearl",
            "Platinum",
            "Heartgold ans Soulsilver",
            "Black and White",
            "Black 2 and White 2",
            "X and Y",
            "Omega Ruby and Alpha Sapphire",
            "Sun and Moon",
            "Ultra Sun and Ultra Moon"});
            this.PokemonGenerationComboBox.Location = new System.Drawing.Point(12, 25);
            this.PokemonGenerationComboBox.Name = "PokemonGenerationComboBox";
            this.PokemonGenerationComboBox.Size = new System.Drawing.Size(193, 21);
            this.PokemonGenerationComboBox.TabIndex = 2;
            // 
            // GenerationLabel
            // 
            this.GenerationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GenerationLabel.AutoSize = true;
            this.GenerationLabel.Location = new System.Drawing.Point(12, 9);
            this.GenerationLabel.Name = "GenerationLabel";
            this.GenerationLabel.Size = new System.Drawing.Size(62, 13);
            this.GenerationLabel.TabIndex = 3;
            this.GenerationLabel.Text = "Generation:";
            // 
            // SourceFolderButton
            // 
            this.SourceFolderButton.Location = new System.Drawing.Point(15, 386);
            this.SourceFolderButton.Name = "SourceFolderButton";
            this.SourceFolderButton.Size = new System.Drawing.Size(92, 39);
            this.SourceFolderButton.TabIndex = 4;
            this.SourceFolderButton.Text = "Source Folder";
            this.SourceFolderButton.UseVisualStyleBackColor = true;
            this.SourceFolderButton.Click += new System.EventHandler(this.SourceFolderButton_Click);
            // 
            // OutputFolderButton
            // 
            this.OutputFolderButton.Location = new System.Drawing.Point(113, 386);
            this.OutputFolderButton.Name = "OutputFolderButton";
            this.OutputFolderButton.Size = new System.Drawing.Size(92, 39);
            this.OutputFolderButton.TabIndex = 5;
            this.OutputFolderButton.Text = "Output Folder";
            this.OutputFolderButton.UseVisualStyleBackColor = true;
            this.OutputFolderButton.Click += new System.EventHandler(this.OutputFolderButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(211, 386);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(92, 39);
            this.ExportButton.TabIndex = 6;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // CSVFilesLabel
            // 
            this.CSVFilesLabel.AutoSize = true;
            this.CSVFilesLabel.Location = new System.Drawing.Point(15, 367);
            this.CSVFilesLabel.Name = "CSVFilesLabel";
            this.CSVFilesLabel.Size = new System.Drawing.Size(94, 13);
            this.CSVFilesLabel.TabIndex = 7;
            this.CSVFilesLabel.Text = "0 CSV Files Found";
            // 
            // PKUnityVersionComboBox
            // 
            this.PKUnityVersionComboBox.FormattingEnabled = true;
            this.PKUnityVersionComboBox.Items.AddRange(new object[] {
            "Old Format",
            "New Format (Experimental)"});
            this.PKUnityVersionComboBox.Location = new System.Drawing.Point(211, 25);
            this.PKUnityVersionComboBox.Name = "PKUnityVersionComboBox";
            this.PKUnityVersionComboBox.Size = new System.Drawing.Size(252, 21);
            this.PKUnityVersionComboBox.TabIndex = 8;
            this.PKUnityVersionComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PKUnityVersionLabel
            // 
            this.PKUnityVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PKUnityVersionLabel.AutoSize = true;
            this.PKUnityVersionLabel.Location = new System.Drawing.Point(208, 9);
            this.PKUnityVersionLabel.Name = "PKUnityVersionLabel";
            this.PKUnityVersionLabel.Size = new System.Drawing.Size(188, 13);
            this.PKUnityVersionLabel.TabIndex = 9;
            this.PKUnityVersionLabel.Text = "Pokemon Unity PokemonData Version";
            // 
            // ExamplePokemonOld
            // 
            this.ExamplePokemonOld.Location = new System.Drawing.Point(12, 73);
            this.ExamplePokemonOld.Name = "ExamplePokemonOld";
            this.ExamplePokemonOld.ReadOnly = true;
            this.ExamplePokemonOld.Size = new System.Drawing.Size(625, 291);
            this.ExamplePokemonOld.TabIndex = 10;
            this.ExamplePokemonOld.Text = resources.GetString("ExamplePokemonOld.Text");
            // 
            // ExampleDataLabel
            // 
            this.ExampleDataLabel.AutoSize = true;
            this.ExampleDataLabel.Location = new System.Drawing.Point(12, 54);
            this.ExampleDataLabel.Name = "ExampleDataLabel";
            this.ExampleDataLabel.Size = new System.Drawing.Size(243, 13);
            this.ExampleDataLabel.TabIndex = 11;
            this.ExampleDataLabel.Text = "Example of PokemonUnity PokemonData Version:";
            // 
            // GenerationWarningLabel
            // 
            this.GenerationWarningLabel.AutoSize = true;
            this.GenerationWarningLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.GenerationWarningLabel.Location = new System.Drawing.Point(80, 9);
            this.GenerationWarningLabel.Name = "GenerationWarningLabel";
            this.GenerationWarningLabel.Size = new System.Drawing.Size(84, 13);
            this.GenerationWarningLabel.TabIndex = 12;
            this.GenerationWarningLabel.Text = "Please fill this in.";
            this.GenerationWarningLabel.Visible = false;
            // 
            // PokemonDataVersionWarningLabel
            // 
            this.PokemonDataVersionWarningLabel.AutoSize = true;
            this.PokemonDataVersionWarningLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.PokemonDataVersionWarningLabel.Location = new System.Drawing.Point(402, 9);
            this.PokemonDataVersionWarningLabel.Name = "PokemonDataVersionWarningLabel";
            this.PokemonDataVersionWarningLabel.Size = new System.Drawing.Size(84, 13);
            this.PokemonDataVersionWarningLabel.TabIndex = 13;
            this.PokemonDataVersionWarningLabel.Text = "Please fill this in.";
            this.PokemonDataVersionWarningLabel.Visible = false;
            // 
            // FolderWarningLabel
            // 
            this.FolderWarningLabel.AutoSize = true;
            this.FolderWarningLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.FolderWarningLabel.Location = new System.Drawing.Point(309, 412);
            this.FolderWarningLabel.Name = "FolderWarningLabel";
            this.FolderWarningLabel.Size = new System.Drawing.Size(42, 13);
            this.FolderWarningLabel.TabIndex = 14;
            this.FolderWarningLabel.Text = "FILL IN";
            this.FolderWarningLabel.Visible = false;
            // 
            // FinishedLabel
            // 
            this.FinishedLabel.AutoSize = true;
            this.FinishedLabel.Location = new System.Drawing.Point(309, 399);
            this.FinishedLabel.Name = "FinishedLabel";
            this.FinishedLabel.Size = new System.Drawing.Size(147, 13);
            this.FinishedLabel.TabIndex = 15;
            this.FinishedLabel.Text = "Finished writing the database.";
            this.FinishedLabel.Visible = false;
            // 
            // ExamplePokemonNew
            // 
            this.ExamplePokemonNew.Location = new System.Drawing.Point(12, 73);
            this.ExamplePokemonNew.Name = "ExamplePokemonNew";
            this.ExamplePokemonNew.ReadOnly = true;
            this.ExamplePokemonNew.Size = new System.Drawing.Size(625, 291);
            this.ExamplePokemonNew.TabIndex = 16;
            this.ExamplePokemonNew.Text = resources.GetString("ExamplePokemonNew.Text");
            this.ExamplePokemonNew.Visible = false;
            // 
            // DatabaseMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.ExamplePokemonNew);
            this.Controls.Add(this.FinishedLabel);
            this.Controls.Add(this.FolderWarningLabel);
            this.Controls.Add(this.PokemonDataVersionWarningLabel);
            this.Controls.Add(this.GenerationWarningLabel);
            this.Controls.Add(this.ExampleDataLabel);
            this.Controls.Add(this.ExamplePokemonOld);
            this.Controls.Add(this.PKUnityVersionLabel);
            this.Controls.Add(this.PKUnityVersionComboBox);
            this.Controls.Add(this.CSVFilesLabel);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.OutputFolderButton);
            this.Controls.Add(this.SourceFolderButton);
            this.Controls.Add(this.GenerationLabel);
            this.Controls.Add(this.PokemonGenerationComboBox);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.Credits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseMakerForm";
            this.Text = "PKUnity Database Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Credits;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.ComboBox PokemonGenerationComboBox;
        private System.Windows.Forms.Label GenerationLabel;
        private System.Windows.Forms.Button SourceFolderButton;
        private System.Windows.Forms.Button OutputFolderButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label CSVFilesLabel;
        private System.Windows.Forms.ComboBox PKUnityVersionComboBox;
        private System.Windows.Forms.Label PKUnityVersionLabel;
        private System.Windows.Forms.RichTextBox ExamplePokemonOld;
        private System.Windows.Forms.Label ExampleDataLabel;
        private System.Windows.Forms.Label GenerationWarningLabel;
        private System.Windows.Forms.Label PokemonDataVersionWarningLabel;
        private System.Windows.Forms.Label FolderWarningLabel;
        private System.Windows.Forms.Label FinishedLabel;
        private System.Windows.Forms.RichTextBox ExamplePokemonNew;
    }
}

