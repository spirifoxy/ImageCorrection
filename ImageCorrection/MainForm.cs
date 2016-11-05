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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openImageDialog = new OpenFileDialog();
            openImageDialog.Filter =
                "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" +
                "All files (*.*)|*.*";
            if (openImageDialog.ShowDialog() != DialogResult.OK)
                return;
            Bitmap image;

            try
            {
                image = new Bitmap(openImageDialog.FileName);
                imagePB.Image = image;
                this.Size = new Size(imagePB.Width + 40, imagePB.Height + 80);
                this.MaximumSize = this.Size;
                correctionToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Can not open the sfile",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void brightnessContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var brightContrastForm = new BrightContrastForm();
            brightContrastForm.Owner = this;
            brightContrastForm.ShowDialog();
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap oldImage = new Bitmap(imagePB.Image);
            Bitmap newImage = new Bitmap(oldImage.Width, oldImage.Height);
            
            int red, green, blue;
            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    red = 255 - oldImage.GetPixel(i, j).R;
                    green = 255 - oldImage.GetPixel(i, j).G;
                    blue = 255 - oldImage.GetPixel(i, j).B;
                    newImage.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
            imagePB.Image = newImage;
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap oldImage = new Bitmap(imagePB.Image);
            Bitmap newImage = new Bitmap(oldImage.Width, oldImage.Height);

            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    var c = oldImage.GetPixel(i, j);
                    var b = Convert.ToInt32(0.299 * c.R + 0.5876 * c.B + 0.114 * c.G);
                    newImage.SetPixel(i, j, Color.FromArgb(b, b, b));
                }
            }
            imagePB.Image = newImage;
        }

        private void binarizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap oldImage = new Bitmap(imagePB.Image);
            Bitmap newImage = new Bitmap(oldImage.Width, oldImage.Height);

            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    var c = oldImage.GetPixel(i, j);
                    var b = Convert.ToInt32(0.299 * c.R + 0.5876 * c.B + 0.114 * c.G);

                    Color newColor;
                    if (b < 128)
                        newColor = Color.FromArgb(0, 0, 0);
                    else
                        newColor = Color.FromArgb(255, 255, 255);
                    newImage.SetPixel(i, j, newColor);
                }
            }
            imagePB.Image = newImage;
        }
    }
}
