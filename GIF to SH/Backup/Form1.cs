using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Gif_to_Sheet
{
    public partial class Form1 : Form
    {

        Image gif;
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "GIF Images (*.gif)|*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                gif = Image.FromFile(ofd.FileName);
                tbFile.Text = ofd.FileName;
                pbSprite.Visible = true;
                FormatImage();
            }
        }

        private void FormatImage()
        {
            if (gif == null)
                return;
            if (bitmap != null)
                bitmap.Dispose();
            FrameDimension frameSize = new FrameDimension(gif.FrameDimensionsList[0]);
            Size imageSize = new Size(gif.Size.Width, gif.Size.Height);
            int frames = gif.GetFrameCount(frameSize);
            Console.WriteLine(frames);
            int columns = (int)nudColumns.Value < 1 ? frames : (int)nudColumns.Value;
            int rows = (int)Math.Ceiling((double)frames / columns);
            bitmap = new Bitmap(columns * imageSize.Width, rows * imageSize.Height);
            Graphics g = Graphics.FromImage(bitmap);
            Brush brush = new SolidBrush(pbBackColor.BackColor);
            g.FillRectangle(brush, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            for (int i = 0; i < frames; i++)
            {
                gif.SelectActiveFrame(frameSize, i);
                g.DrawImage(gif, i % columns * imageSize.Width, i / columns * imageSize.Height);
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
            ColorDialog cd = new ColorDialog();
            cd.Color = pbBackColor.BackColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pbBackColor.BackColor = cd.Color;
                FormatImage();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|JPEG Files (*.jpeg)|*.jpeg|GIF Files (*.gif)|*.gif";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ImageFormat format;
                string ext = Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                    case ".jpeg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".gif":
                        format = ImageFormat.Gif;
                        break;
                    default:
                        format = ImageFormat.Png;
                        break;
                }
                pbSprite.Image.Save(sfd.FileName, format);
            }
        }
    }
}
