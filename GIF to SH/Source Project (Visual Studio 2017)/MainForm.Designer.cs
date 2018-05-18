namespace Gif_to_Sheet
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblFile = new System.Windows.Forms.Label();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblColumns = new System.Windows.Forms.Label();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pbSprite = new System.Windows.Forms.PictureBox();
            this.pbBackColor = new System.Windows.Forms.PictureBox();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackColor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(12, 9);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(23, 13);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "File";
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(12, 25);
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new System.Drawing.Size(189, 20);
            this.tbFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(207, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(288, 9);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(47, 13);
            this.lblColumns.TabIndex = 3;
            this.lblColumns.Text = "Columns";
            // 
            // nudColumns
            // 
            this.nudColumns.Location = new System.Drawing.Point(291, 25);
            this.nudColumns.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(111, 20);
            this.nudColumns.TabIndex = 4;
            this.nudColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudColumns.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudColumns.ValueChanged += new System.EventHandler(this.nudColumns_ValueChanged);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.pbSprite);
            this.panelMain.Location = new System.Drawing.Point(12, 73);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(551, 366);
            this.panelMain.TabIndex = 5;
            // 
            // pbSprite
            // 
            this.pbSprite.Location = new System.Drawing.Point(0, 0);
            this.pbSprite.Name = "pbSprite";
            this.pbSprite.Size = new System.Drawing.Size(100, 50);
            this.pbSprite.TabIndex = 0;
            this.pbSprite.TabStop = false;
            this.pbSprite.Visible = false;
            // 
            // pbBackColor
            // 
            this.pbBackColor.BackColor = System.Drawing.Color.Transparent;
            this.pbBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBackColor.Location = new System.Drawing.Point(13, 51);
            this.pbBackColor.Name = "pbBackColor";
            this.pbBackColor.Size = new System.Drawing.Size(16, 16);
            this.pbBackColor.TabIndex = 6;
            this.pbBackColor.TabStop = false;
            this.pbBackColor.Click += new System.EventHandler(this.pbBackColor_Click);
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(35, 51);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(92, 13);
            this.lblBackColor.TabIndex = 7;
            this.lblBackColor.Text = "Background Color";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(207, 46);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Progress
            // 
            this.Progress.AutoSize = true;
            this.Progress.Location = new System.Drawing.Point(288, 51);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(48, 13);
            this.Progress.TabIndex = 9;
            this.Progress.Text = "Progress";
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(500, 46);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(63, 20);
            this.HeightBox.TabIndex = 10;
            this.HeightBox.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Height";
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(390, 47);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(63, 20);
            this.WidthBox.TabIndex = 12;
            this.WidthBox.TextChanged += new System.EventHandler(this.TextChange);
            this.WidthBox.Leave += new System.EventHandler(this.LeaveWidth);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Width";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblBackColor);
            this.Controls.Add(this.pbBackColor);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.nudColumns);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.lblFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIF to Spritesheet";
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pbSprite;
        private System.Windows.Forms.PictureBox pbBackColor;
        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label Progress;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label label2;
    }
}

