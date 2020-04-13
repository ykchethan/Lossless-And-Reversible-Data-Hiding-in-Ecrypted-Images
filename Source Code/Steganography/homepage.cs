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
    public partial class homepage : Form
    {

        public string user;
        public string key;
        public homepage()
        {
            InitializeComponent();
        }

        private void homepage_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text != "")
            {

                textintoimage ob = new textintoimage();
                ob.Show();
            }
            else
            {
                MessageBox.Show(" Please enter pyblic key ");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textfromimage ti = new textfromimage();
            ti.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
