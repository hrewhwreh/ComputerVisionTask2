using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVision2
{
    public partial class Form1 : Form
    {
        Bitmap source_image;
        Bitmap image1;
        Bitmap image2;
        Bitmap image3;
        Bitmap image4;
        Bitmap image5;
        public Form1()
        {
            InitializeComponent();
        }

        private void сделатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter1 = new Convolution1();
            image1 = filter1.processImage(source_image);
            pictureBox2.Image = image1;
            pictureBox2.Refresh();
            Filters filter2 = new Convolution2();
            image2 = filter2.processImage(source_image);
            pictureBox3.Image = image2;
            pictureBox3.Refresh();
            Filters filter3 = new Convolution3();
            image3 = filter3.processImage(source_image);
            pictureBox4.Image = image3;
            pictureBox4.Refresh();
            Filters filter4 = new Convolution4();
            image4 = filter4.processImage(source_image);
            pictureBox5.Image = image4;
            pictureBox5.Refresh();
            Filters filter5 = new Convolution5();
            image5 = filter5.processImage(source_image);
            pictureBox6.Image = image5;
            pictureBox6.Refresh();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                source_image = new Bitmap(dialog.FileName);
                pictureBox1.Image = source_image;
                pictureBox1.Refresh();
            }
        }

        private void сделатьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Filters filter = new MaxPooling();
            image1 = filter.processImage(image1);
            pictureBox2.Image = image1;
            pictureBox2.Refresh();
            image2 = filter.processImage(image2);
            pictureBox3.Image = image2;
            pictureBox3.Refresh(); 
            image3 = filter.processImage(image3);
            pictureBox4.Image = image3;
            pictureBox4.Refresh();
            image4 = filter.processImage(image4);
            pictureBox5.Image = image4;
            pictureBox5.Refresh();
            image5 = filter.processImage(image5);
            pictureBox6.Image = image5;
            pictureBox6.Refresh();
        }

        private void картинка2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.png;*.bmp;*.jpg";
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            sfd.FileName = ".jpg";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                image1.Save(sfd.FileName);
            }
        }

        private void картинка3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.png;*.bmp;*.jpg";
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            sfd.FileName = ".jpg";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                image2.Save(sfd.FileName);
            }
        }

        private void картинка4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.png;*.bmp;*.jpg";
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            sfd.FileName = ".jpg";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                image3.Save(sfd.FileName);
            }
        }

        private void картинка5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.png;*.bmp;*.jpg";
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            sfd.FileName = ".jpg";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                image4.Save(sfd.FileName);
            }
        }

        private void картинка6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.png;*.bmp;*.jpg";
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            sfd.FileName = ".jpg";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                image5.Save(sfd.FileName);
            }
        }
    }
}
