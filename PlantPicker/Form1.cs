using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantPicker
{
    public partial class Form1 : Form
    {
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf0.bmp"), new Size(100, 100)));
            button2.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf1.bmp"), new Size(100, 100)));
            button3.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf2.bmp"), new Size(100, 100)));
            button4.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf3.bmp"), new Size(100, 100)));
            button5.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf4.bmp"), new Size(100, 100)));
            button6.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf5.bmp"), new Size(100, 100)));
            button7.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf6.bmp"), new Size(100, 100)));
            button8.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf7.bmp"), new Size(100, 100)));
            button9.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf8.bmp"), new Size(100, 100)));
            button10.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf9.bmp"), new Size(100, 100)));
            button11.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf10.bmp"), new Size(100, 100)));
            button12.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf11.bmp"), new Size(100, 100)));
            button13.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf12.bmp"), new Size(100, 100)));
            button14.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf13.bmp"), new Size(100, 100)));
            button15.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf14.bmp"), new Size(100, 100)));
            button16.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf15.bmp"), new Size(100, 100)));
            button17.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf16.bmp"), new Size(100, 100)));
            button18.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf17.bmp"), new Size(100, 100)));
            button19.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf18.bmp"), new Size(100, 100)));
            button20.Image = (Image)(new Bitmap(Image.FromFile(@"Ferns\bf19.bmp"), new Size(100, 100)));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
