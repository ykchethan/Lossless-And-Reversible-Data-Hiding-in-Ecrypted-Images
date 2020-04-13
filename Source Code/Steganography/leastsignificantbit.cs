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
    public partial class leastsignificantbit : Form
    {

       public  PictureBox pic;

        public leastsignificantbit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp=new Bitmap (pictureBox1 .Image );
            for (int i = 0; i < bmp.Width; i++)
            {

                if (i % 10 == 0)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        Color cc = bmp.GetPixel(i, j);

                        listBox1.Items.Add("R:" + cc.R.ToString() + "G:" + cc.G.ToString() + "B:" + cc.B.ToString());

                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            encodedimage ei = new encodedimage();
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            ei.jkl = bmp;
            ei.Show();

        }

        private void leastsignificantbit_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = pic.Image ;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
