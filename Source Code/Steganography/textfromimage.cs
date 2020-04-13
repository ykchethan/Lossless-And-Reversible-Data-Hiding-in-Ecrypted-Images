using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Steganography
{
    public partial class textfromimage : Form
    {
        OpenFileDialog op = new OpenFileDialog();
        public textfromimage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                op.ShowDialog();
                pictureBox1.Image = Image.FromFile(op.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            string extractedText = SteganographyHelper.extractText(bmp);
            textBox1.Text = extractedText;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
