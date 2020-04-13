using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;

namespace Steganography
{
    public partial class encodedimage : Form
    {
     public     Bitmap jkl ;

        public encodedimage()
        {
            InitializeComponent();
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        } 
        private void encodedimage_Load(object sender, EventArgs e)
        {

            Bitmap bmp=new Bitmap (jkl );
            byte[] arr = imageToByteArray(bmp);

            BitArray bit = new BitArray(arr);
            for (int i = bit.Length - 1; i >= 0; i--)
            {

                if (i % 100 == 0)
                {
                    if (bit[i] == true)
                    {
                        richTextBox1.Text += 1;
                    }
                    else
                    {
                        richTextBox1.Text += 0;

                    }
                }
            }
        }
    }
}
