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
            this.GifToFramesCheckbox = new System.Windows.Forms.CheckBox();
            this.OriginalSizeCheck = new System.Windows.Forms.CheckBox();
            this.sizeGroup = new System.Windows.Forms.GroupBox();
            this.fileGroup = new System.Windows.Forms.GroupBox();
            this.spritesheetGroup = new System.Windows.Forms.GroupBox();
            this.SingleLineCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackColor)).BeginInit();
            this.sizeGroup.SuspendLayout();
            this.fileGroup.SuspendLayout();
            this.spritesheetGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(6, 22);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(39, 13);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "Folder:";
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(50, 19);
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new System.Drawing.Size(189, 20);
            this.tbFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(9, 45);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(89, 45);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(6, 21);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(50, 13);
            this.lblColumns.TabIndex = 3;
            this.lblColumns.Text = "Columns:";
            // 
            // nudColumns
            // 
            this.nudColumns.Location = new System.Drawing.Point(59, 19);
            this.nudColumns.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(135, 20);
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
            this.panelMain.Location = new System.Drawing.Point(12, 114);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(597, 371);
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
            this.pbBackColor.Location = new System.Drawing.Point(9, 71);
            this.pbBackColor.Name = "pbBackColor";
            this.pbBackColor.Size = new System.Drawing.Size(14, 14);
            this.pbBackColor.TabIndex = 6;
            this.pbBackColor.TabStop = false;
            this.pbBackColor.Click += new System.EventHandler(this.pbBackColor_Click);
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(29, 71);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(92, 13);
            this.lblBackColor.TabIndex = 7;
            this.lblBackColor.Text = "Background Color";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(104, 45);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(81, 45);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Progress
            // 
            this.Progress.AutoSize = true;
            this.Progress.Location = new System.Drawing.Point(191, 61);
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
            this.HeightBox.Location = new System.Drawing.Point(50, 68);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(63, 20);
            this.HeightBox.TabIndex = 10;
            this.HeightBox.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Height";
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(50, 42);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(63, 20);
            this.WidthBox.TabIndex = 12;
            this.WidthBox.TextChanged += new System.EventHandler(this.TextChange);
            this.WidthBox.Leave += new System.EventHandler(this.LeaveWidth);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Width:";
            // 
            // GifToFramesCheckbox
            // 
            this.GifToFramesCheckbox.AutoSize = true;
            this.GifToFramesCheckbox.Location = new System.Drawing.Point(98, 45);
            this.GifToFramesCheckbox.Name = "GifToFramesCheckbox";
            this.GifToFramesCheckbox.Size = new System.Drawing.Size(96, 17);
            this.GifToFramesCheckbox.TabIndex = 14;
            this.GifToFramesCheckbox.Text = "GIF To Frames";
            this.GifToFramesCheckbox.UseVisualStyleBackColor = true;
            this.GifToFramesCheckbox.CheckedChanged += new System.EventHandler(this.GifToFramesCheckbox_CheckedChanged);
            // 
            // OriginalSizeCheck
            // 
            this.OriginalSizeCheck.AutoSize = true;
            this.OriginalSizeCheck.Location = new System.Drawing.Point(9, 19);
            this.OriginalSizeCheck.Name = "OriginalSizeCheck";
            this.OriginalSizeCheck.Size = new System.Drawing.Size(112, 17);
            this.OriginalSizeCheck.TabIndex = 15;
            this.OriginalSizeCheck.Text = "Keep Original Size";
            this.OriginalSizeCheck.UseVisualStyleBackColor = true;
            this.OriginalSizeCheck.CheckedChanged += new System.EventHandler(this.OriginalSizeCheck_CheckedChanged);
            // 
            // sizeGroup
            // 
            this.sizeGroup.Controls.Add(this.label2);
            this.sizeGroup.Controls.Add(this.OriginalSizeCheck);
            this.sizeGroup.Controls.Add(this.WidthBox);
            this.sizeGroup.Controls.Add(this.label1);
            this.sizeGroup.Controls.Add(this.HeightBox);
            this.sizeGroup.Location = new System.Drawing.Point(469, 12);
            this.sizeGroup.Name = "sizeGroup";
            this.sizeGroup.Size = new System.Drawing.Size(140, 96);
            this.sizeGroup.TabIndex = 16;
            this.sizeGroup.TabStop = false;
            this.sizeGroup.Text = "Size";
            // 
            // fileGroup
            // 
            this.fileGroup.Controls.Add(this.lblFile);
            this.fileGroup.Controls.Add(this.tbFile);
            this.fileGroup.Controls.Add(this.btnBrowse);
            this.fileGroup.Controls.Add(this.btnExport);
            this.fileGroup.Controls.Add(this.Progress);
            this.fileGroup.Location = new System.Drawing.Point(12, 12);
            this.fileGroup.Name = "fileGroup";
            this.fileGroup.Size = new System.Drawing.Size(245, 96);
            this.fileGroup.TabIndex = 17;
            this.fileGroup.TabStop = false;
            this.fileGroup.Text = "File";
            // 
            // spritesheetGroup
            // 
            this.spritesheetGroup.Controls.Add(this.SingleLineCheck);
            this.spritesheetGroup.Controls.Add(this.lblColumns);
            this.spritesheetGroup.Controls.Add(this.nudColumns);
            this.spritesheetGroup.Controls.Add(this.GifToFramesCheckbox);
            this.spritesheetGroup.Controls.Add(this.lblBackColor);
            this.spritesheetGroup.Controls.Add(this.pbBackColor);
            this.spritesheetGroup.Location = new System.Drawing.Point(263, 12);
            this.spritesheetGroup.Name = "spritesheetGroup";
            this.spritesheetGroup.Size = new System.Drawing.Size(200, 96);
            this.spritesheetGroup.TabIndex = 18;
            this.spritesheetGroup.TabStop = false;
            this.spritesheetGroup.Text = "Spritesheet";
            // 
            // SingleLineCheck
            // 
            this.SingleLineCheck.AutoSize = true;
            this.SingleLineCheck.Location = new System.Drawing.Point(9, 45);
            this.SingleLineCheck.Name = "SingleLineCheck";
            this.SingleLineCheck.Size = new System.Drawing.Size(78, 17);
            this.SingleLineCheck.TabIndex = 10;
            this.SingleLineCheck.Text = "Single Line";
            this.SingleLineCheck.UseVisualStyleBackColor = true;
            this.SingleLineCheck.CheckedChanged += new System.EventHandler(this.SingleLineCheck_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 497);
            this.Controls.Add(this.spritesheetGroup);
            this.Controls.Add(this.fileGroup);
            this.Controls.Add(this.sizeGroup);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIF to Spritesheet";
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackColor)).EndInit();
            this.sizeGroup.ResumeLayout(false);
            this.sizeGroup.PerformLayout();
            this.fileGroup.ResumeLayout(false);
            this.fileGroup.PerformLayout();
            this.spritesheetGroup.ResumeLayout(false);
            this.spritesheetGroup.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox GifToFramesCheckbox;
        private System.Windows.Forms.CheckBox OriginalSizeCheck;
        private System.Windows.Forms.GroupBox sizeGroup;
        private System.Windows.Forms.GroupBox fileGroup;
        private System.Windows.Forms.GroupBox spritesheetGroup;
        private System.Windows.Forms.CheckBox SingleLineCheck;
    }
}

