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
    public partial class textintoimage : Form
    {

        public string key;
        public textintoimage()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.ShowDialog();
                pictureBox1.Image = Image.FromFile(op.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap kk = new Bitmap(pictureBox1.Image, new Size(pictureBox1.Width, pictureBox1.Height));

                Graphics g = Graphics.FromImage(kk);
                int iii = kk.Height / 8;
                int jjj = kk.Width / 8;

                pictureBox1.Image = kk;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;

            string text = textBox1.Text;
            bmp = SteganographyHelper.embedText(text, bmp);
            try
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.ShowDialog();
                bmp.Save(sv.FileName,System .Drawing .Imaging .ImageFormat .Png );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            leastsignificantbit ls = new leastsignificantbit();
            ls.pic = pictureBox1;
            ls.Show();    
        }
        private void textintoimage_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
