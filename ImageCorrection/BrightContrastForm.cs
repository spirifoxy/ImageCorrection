using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCorrection
{
    public partial class BrightContrastForm : Form
    {
        public BrightContrastForm()
        {
            InitializeComponent();
        }

        private int truncate(int color)
        {
            if (color < 0)
                color = 0;
            if (color > 255)
                color = 255;
            return color;
        }

        private int truncate(double color)
        {
            return truncate(Convert.ToInt32(color));
        }

        private void brightnessTB_Scroll(object sender, EventArgs e)
        {
            var main = this.Owner as MainForm;
            if (main == null)
                return;
            
            Bitmap oldImage = new Bitmap(imageCopyPB.Image);
            Bitmap newImage = new Bitmap(oldImage.Width, oldImage.Height);

            int value = 100 / brightnessTB.Maximum * brightnessTB.Value; //процент увеличения/уменьшения
            int red, green, blue;
            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    red = oldImage.GetPixel(i, j).R;
                    green = oldImage.GetPixel(i, j).G;
                    blue = oldImage.GetPixel(i, j).B;

                    red = truncate(red + value * 128 / 100);
                    green = truncate(green + value * 128 / 100);
                    blue = truncate(blue + value * 128 / 100);

                    newImage.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
            main.imagePB.Image = newImage;
        }

        private void contrastTB_Scroll(object sender, EventArgs e)
        {
            var main = this.Owner as MainForm;
            if (main == null)
                return;
            
            Bitmap oldImage = new Bitmap(imageCopyPB.Image);
            Bitmap newImage = new Bitmap(oldImage.Width, oldImage.Height);
            
            double value = contrastTB.Value / 10.0;
            
            int red, green, blue;
            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    red = oldImage.GetPixel(i, j).R;
                    green = oldImage.GetPixel(i, j).G;
                    blue = oldImage.GetPixel(i, j).B;

                    red = truncate((value * (red - 128) + 128));
                    green = truncate((value * (green - 128) + 128));
                    blue = truncate((value * (blue - 128) + 128));

                    newImage.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
            main.imagePB.Image = newImage;
        }
        
        private void reDrawHistogram(object sender, EventArgs e)
        {
            var main = this.Owner as MainForm;
            if (main == null)
                return;
            const int varOfBrightness = 101; // яркость принимает значения от 0 до 100

            var histogramImage = new Bitmap(brightHistPB.Width, brightHistPB.Height);
            int[] histogramData = new int[varOfBrightness];


            Bitmap image = new Bitmap(main.imagePB.Image);

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    var brightness = Convert.ToInt32(image.GetPixel(i, j).GetBrightness() * 100);
                    histogramData[brightness]++;
                }
            }

            int maxPixelsValue = histogramData.Max();

            for (int i = 0; i < brightHistPB.Width; i++)
            {
                var curBrightValue = Convert.ToInt32(i * varOfBrightness / brightHistPB.Width);
                for (int j = 0; j < histogramData[curBrightValue]; j++)
                {
                    var y = j * brightHistPB.Height / maxPixelsValue;
                    histogramImage.SetPixel(i, y, Color.Black);
                }
            }

            histogramImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            brightHistPB.Image = histogramImage;
        }

        private void applyChangesButton_Click(object sender, EventArgs e)
        {
            this.FormClosing -= this.BrightContrastForm_FormClosing;
            this.Close();
        }

        private void BrightContrastForm_Load(object sender, EventArgs e)
        {
            var main = this.Owner as MainForm;
            if (main == null)
                return;
            imageCopyPB.Image = main.imagePB.Image;
        }

        private void BrightContrastForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var main = this.Owner as MainForm;
            if (main == null)
                return;
            main.imagePB.Image = imageCopyPB.Image;
        }
        
    }
}
