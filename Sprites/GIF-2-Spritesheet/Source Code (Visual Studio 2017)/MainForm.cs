using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Gif_to_Sheet
{
    public partial class MainForm : Form
    {

        Image gif;
        Bitmap bitmap;
        int Counter = 0;
        string[] GifFiles;
        int frames;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select the folder where your GIFs that need to be converted are saved";
                DialogResult = fbd.ShowDialog();
                if (fbd.SelectedPath != "")
                {
                    Counter = 0;
                    GifFiles = Directory.GetFiles(fbd.SelectedPath);
                    for (int i = 0; i < GifFiles.Length; i++)
                    {
                        if (Path.GetExtension(GifFiles[i]) != ".gif")
                        {
                            var list = new List<string>(GifFiles);
                            list.Remove(GifFiles[i]);
                            GifFiles = list.ToArray();
                        }
                    }
                    gif = Image.FromFile(GifFiles[Counter]);
                    tbFile.Text = GifFiles[Counter];
                    pbSprite.Visible = true;
                    FormatImage();
                    Progress.Text = Counter + "/" + GifFiles.Length;
                }
            }
        }

        private void FormatImage()
        {
            if (gif == null)
                return;
            if (bitmap != null)
                bitmap.Dispose();

            int x = 0;
            int y = 0;

            if (!OriginalSizeCheck.Checked)
            {
                if (WidthBox.Text != "")
                {
                    x = Convert.ToInt32(Regex.Replace(WidthBox.Text, "[^0-9.]", ""));
                }
                else
                {
                    x = 160;
                    WidthBox.Text = x.ToString();
                }

                if (HeightBox.Text != "")
                {
                    y = Convert.ToInt32(Regex.Replace(HeightBox.Text, "[^0-9.]", ""));
                }
                else
                {
                    y = 160;
                    HeightBox.Text = y.ToString();
                }
            }
            else
            {
                x = gif.Size.Width;
                y = gif.Size.Height;
            }

            FrameDimension frameSize = new FrameDimension(gif.FrameDimensionsList[0]);
            Size imageSize = new Size(x, y);

            frames = gif.GetFrameCount(frameSize);

            int columns = 0;
            int rows = 0;

            if (!SingleLineCheck.Checked)
            {
                columns = (int)nudColumns.Value < 1 ? frames : (int)nudColumns.Value;
            }
            else
            {
                columns = 0 < 1 ? frames : (int)nudColumns.Value;
            }
            rows = (int)Math.Ceiling((double)frames / columns);

            bitmap = new Bitmap(columns * imageSize.Width, rows * imageSize.Height);

            Graphics g = Graphics.FromImage(bitmap);
            Brush brush = new SolidBrush(pbBackColor.BackColor);

            g.FillRectangle(brush, new Rectangle(0, 0, bitmap.Width + frames, bitmap.Height + frames));
            for (int i = 0; i < frames; i++)
            {
                gif.SelectActiveFrame(frameSize, i);
                g.DrawImage(gif, (i % columns * x) + (x / 2) - gif.Size.Width / 2, (i / columns * y) + y - gif.Size.Height);
            }

            g.Dispose();

            pbSprite.Image = bitmap;
            pbSprite.Size = bitmap.Size;
        }

        private void nudColumns_ValueChanged(object sender, EventArgs e)
        {
            FormatImage();
        }

        private void pbBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = colorDialog;
            cd.Color = pbBackColor.BackColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pbBackColor.BackColor = cd.Color;
                FormatImage();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select the folder where you want the spritesheets to be saved";
                fbd.ShowDialog();

                if (!GifToFramesCheckbox.Checked)
                {
                    if (fbd.SelectedPath != "")
                    {
                        int displayName = Convert.ToInt32(Regex.Replace(Path.GetFileNameWithoutExtension(GifFiles[Counter]), "[^0-9.]", ""));
                        while (GifFiles.Length > Counter)
                        {
                            gif = Image.FromFile(GifFiles[Counter]);
                            FormatImage();
                            ImageFormat format = ImageFormat.Png;
                            gif.Dispose();

                            string tempString = Path.GetFileNameWithoutExtension(GifFiles[Counter]);
                            tempString = Regex.Replace(tempString, @"[\d-]", string.Empty);

                            if (tempString == "")
                            {
                                pbSprite.Image.Save(fbd.SelectedPath + "\\" + displayName + ".png", format);
                            }
                            else
                            {
                                displayName--;
                                pbSprite.Image.Save(fbd.SelectedPath + "\\" + (displayName) + tempString + ".png", format);
                            }
                            Counter++;
                            displayName++;
                            Progress.Text = Counter + "/" + GifFiles.Length;
                        }
                    }
                }
                else
                {
                    foreach (string file in GifFiles)
                    {
                        string ext = Path.GetExtension(file);
                        if (ext == ".gif")
                        {
                            Console.WriteLine("Splitting : " + file);
                            string filenameNoExt = Path.GetFileNameWithoutExtension(file);

                            if(filenameNoExt.Length == 1 || filenameNoExt.Length == 2)
                            {
                                if(filenameNoExt.Length == 1)
                                {
                                    filenameNoExt = "00" + filenameNoExt;
                                }
                                else if(filenameNoExt.Length == 2)
                                {
                                    filenameNoExt = "0" + filenameNoExt;
                                }
                            }

                            string filenameExt = Path.GetFileName(file);
                            Console.WriteLine();
                            Directory.CreateDirectory(fbd.SelectedPath.ToString() + @"\" +filenameNoExt);
                            Process imProcess = new Process();
                            string output = fbd.SelectedPath.ToString() + @"\" + filenameNoExt + @"\" + filenameNoExt + ".png";
                            string im_command = @"""" + file + @""""
                             + @" -scene 1 +adjoin -coalesce " + @"""" + fbd.SelectedPath.ToString() + @"\" + filenameNoExt + @"\" + filenameNoExt + ".png" + @"""";
                            imProcess.StartInfo.UseShellExecute = false;
                            imProcess.StartInfo.RedirectStandardOutput = true;
                            imProcess.StartInfo.FileName = (AppDomain.CurrentDomain.BaseDirectory + "convert");
                            imProcess.StartInfo.Arguments = im_command;
                            imProcess.Start();
                            imProcess.WaitForExit();
                        }
                    }
                }
            }
        }

        private void LeaveWidth(object sender, EventArgs e)
        {
            FormatImage();
        }

        private void TextChange(object sender, EventArgs e)
        {
            FormatImage();
        }

        private void GifToFramesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            WidthBox.Enabled = !GifToFramesCheckbox.Checked;
            HeightBox.Enabled = !GifToFramesCheckbox.Checked;
            nudColumns.Enabled = !GifToFramesCheckbox.Checked;
        }

        public Bitmap CropImage(Bitmap source, Rectangle section)
        {
            // An empty bitmap which will hold the cropped image
            Bitmap bmp = new Bitmap(section.Width, section.Height);

            Graphics g = Graphics.FromImage(bmp);

            // Draw the given area (section) of the source image
            // at location 0,0 on the empty bitmap (bmp)
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);

            return bmp;
        }

        private void OriginalSizeCheck_CheckedChanged(object sender, EventArgs e)
        {
            WidthBox.Enabled = !OriginalSizeCheck.Checked;
            HeightBox.Enabled = !OriginalSizeCheck.Checked;
            FormatImage();
        }

        private void SingleLineCheck_CheckedChanged(object sender, EventArgs e)
        {
            nudColumns.Enabled = !SingleLineCheck.Checked;
            FormatImage();
        }
    }
}
