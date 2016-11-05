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
    }
}
