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
                        if(Path.GetExtension(GifFiles[i]) != ".gif")
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
            int x;
            if (WidthBox.Text != "")
            {
                x = Convert.ToInt32(Regex.Replace(WidthBox.Text, "[^0-9.]", ""));
            }
            else
            {
                x = 160;
            }
            WidthBox.Text = x.ToString();
            int y;
            if (HeightBox.Text != "")
            {
                y = Convert.ToInt32(Regex.Replace(HeightBox.Text, "[^0-9.]", ""));
            }
            else
            {
                y = 160;
            }
            HeightBox.Text = y.ToString();
            FrameDimension frameSize = new FrameDimension(gif.FrameDimensionsList[0]);
            Size imageSize = new Size(x, y);
            int frames = gif.GetFrameCount(frameSize);
            Console.WriteLine(frames);
            int columns = (int)nudColumns.Value < 1 ? frames : (int)nudColumns.Value;
            int rows = (int)Math.Ceiling((double)frames / columns);
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
        }

        private void LeaveWidth(object sender, EventArgs e)
        {
            FormatImage();
        }

        private void TextChange(object sender, EventArgs e)
        {
            FormatImage();
        }
    }
}
