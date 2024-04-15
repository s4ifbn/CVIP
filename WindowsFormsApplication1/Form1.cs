using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Bitmap orgImg, grayImg, binImg;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File (*.jpg)|*.jpg";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                orgImg = new Bitmap(pictureBox1.Image);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                saveFileDialog1.ShowDialog();
                string loc = saveFileDialog1.FileName;

                pictureBox2.Image.Save(loc);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            Bitmap resImg = new Bitmap(orgImg);

            int brightness = Convert.ToInt32(textBox1.Text);

            for (int y = 0; y < pictureBox1.Height; y++)
            {
                for (int x = 0; x < pictureBox1.Width; x++)
                {
                    Color pixel = resImg.GetPixel(x, y);

                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;

                    int rr = r + brightness;
                    int bb = b + brightness;
                    int gg = g + brightness;

                    if (rr > 255)
                        rr = 255;
                    if (bb > 255)
                        bb = 255;
                    if (gg > 255)
                        gg = 255;
                    if (rr < 0)
                        rr = 0;
                    if (gg < 0)
                        gg = 0;
                    if (bb < 0)
                        bb = 0;

                    resImg.SetPixel(x, y, Color.FromArgb(rr, gg, bb));
                }
            }

            pictureBox2.Image = resImg;
            pictureBox2.Refresh();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {

            Bitmap resImg = new Bitmap(orgImg);

            int brightness = Convert.ToInt32(trackBar1.Value);

            for (int y = 0; y < pictureBox1.Height; y++)
            {
                for (int x = 0; x < pictureBox1.Width; x++)
                {
                    Color pixel = resImg.GetPixel(x, y);

                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;

                    int rr = r + brightness;
                    int bb = b + brightness;
                    int gg = g + brightness;

                    if (rr > 255)
                        rr = 255;
                    if (bb > 255)
                        bb = 255;
                    if (gg > 255)
                        gg = 255;
                    if (rr < 0)
                        rr = 0;
                    if (gg < 0)
                        gg = 0;
                    if (bb < 0)
                        bb = 0;

                    resImg.SetPixel(x, y, Color.FromArgb(rr, gg, bb));
                }
            }

            pictureBox2.Image = resImg;
            pictureBox2.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {


        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File (*.jpg)|*.jpg";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                orgImg = new Bitmap(pictureBox1.Image);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void colorConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // convert RGB to gray
            grayImg = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            for (int y = 0; y < pictureBox1.Height; y++)
            {
                for (int x = 0; x < pictureBox1.Width; x++)
                {

                    Color pixel = orgImg.GetPixel(x, y);

                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;

                    int gray = (int)(r + b + g) / 3;

                    grayImg.SetPixel(x, y, Color.FromArgb(gray, gray, gray));

                }
            }

            pictureBox2.Image = grayImg;
            pictureBox2.Refresh();
        }

        private void saveResultImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                saveFileDialog1.ShowDialog();
                string loc = saveFileDialog1.FileName;

                pictureBox2.Image.Save(loc);
            }
        }

        private void toBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            binImg = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            int threshold = 128;

            for (int y = 0; y < pictureBox1.Height; y++)
            {
                for (int x = 0; x < pictureBox1.Width; x++)
                {
                    Color pixel = orgImg.GetPixel(x, y);

                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;

                    int gray = (int)(r + b + g) / 3;

                    if (gray < threshold)
                        binImg.SetPixel(x, y, Color.Black);
                    else
                        binImg.SetPixel(x, y, Color.White);
                }
            }

            pictureBox2.Image = binImg;
            pictureBox2.Refresh();

        }

        private void zeroOrderHoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap resImg = new Bitmap(pictureBox1.Width * 2, pictureBox1.Height * 2);

            int m = 0, n = 0;

            for (int y = 0; y < (pictureBox1.Height); y++)
            {

                for (int x = 0; x < (pictureBox1.Width); x++)
                {

                    Color pixel = orgImg.GetPixel(x, y);

                    resImg.SetPixel(m, n, pixel);
                    ++m;
                    resImg.SetPixel(m, n, pixel);
                    ++m;
                }

                for (int z = 0; z < m - 1; z++)
                {
                    Color pixel = resImg.GetPixel(z, n);

                    resImg.SetPixel(z, n + 1, pixel);
                }
                n = n + 2;
                m = 0;
            }

            pictureBox2.Image = resImg;
            pictureBox2.Refresh();
        }

        private void firstOrderHoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap resImg = new Bitmap(pictureBox1.Width * 2, pictureBox1.Height * 2);

            int m = 0, n = 0;

            for (int y = 0; y < pictureBox1.Height - 1; y++)
            {

                for (int x = 0; x < pictureBox1.Width - 1; x++)
                {

                    Color pixel1 = orgImg.GetPixel(x, y);
                    Color pixel2 = orgImg.GetPixel(x, y + 1);

                    int r1 = pixel1.R;
                    int g1 = pixel1.G;
                    int b1 = pixel1.B;

                    int r2 = pixel2.R;
                    int g2 = pixel2.G;
                    int b2 = pixel2.B;

                    resImg.SetPixel(m, n, pixel1);
                    ++m;

                    int r = (r1 + r2) / 2;
                    int g = (g1 + g2) / 2;
                    int b = (b1 + b2) / 2;

                    resImg.SetPixel(m, n, Color.FromArgb(r, g, b));
                    ++m;
                }

                for (int z = 0; z < m - 1; z++)
                {
                    Color pixel = resImg.GetPixel(z, n);

                    resImg.SetPixel(z, n + 1, pixel);
                }
                n = n + 2;
                m = 0;
            }

            pictureBox2.Image = resImg;
            pictureBox2.Refresh();
        }

        private void haiderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void convulutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] kernel = { { 0.25, 0.5, 0.25 }, { 0.5, 1, 0.5 }, { 0.25, 0.5, 0.25 } };
            double[,] imgMatrix = { { 3, 5, 7 }, { 2, 7, 6 }, { 3, 4, 9 } };
            double[,] resMatrix = new double[7, 7];
            double[,] convMatrix = new double[7, 7];

            int m, n;
            m = n = 0;
            for (int j = 0; j < 7; j++)
            {

                for (int i = 0; i < 7; i++) {

                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        resMatrix[i, j] = imgMatrix[m, n];
                        textBox3.SelectedText = resMatrix[i, j].ToString() + " ";
                        n++;
                    }
                    else {
                        resMatrix[i, j] = 0;
                        textBox3.SelectedText = "0" + " ";
                    }

                }
                m = j / 2;
                n = 0;
                textBox3.SelectedText = Environment.NewLine;

            }

            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 7; i++)
                {
                    textBox2.SelectedText = resMatrix[i, j].ToString() + " ";
                    
                }
                textBox2.SelectedText = Environment.NewLine;
            }

            textBox2.Clear();

            for (int j = 1; j < 7-1; j++)
            {
                for (int i = 1; i < 7-1; i++)
                {
                    double t0 = kernel[0, 0] * resMatrix[i - 1, j - 1];
                    double t1 = kernel[0, 1] * resMatrix[i - 1, j];
                    double t2 = kernel[0, 2] * resMatrix[i - 1, j + 1];

                    double left = kernel[1, 0] * resMatrix[i, j - 1];
                    double center = kernel[1, 1] * resMatrix[i, j];
                    double right = kernel[1, 2] * resMatrix[i, j + 1];

                    double b0 = kernel[2, 0] * resMatrix[i + 1, j - 1];
                    double b1 = kernel[2, 1] * resMatrix[i + 1, j];
                    double b2 = kernel[2, 2] * resMatrix[i + 1, j + 1];


                    int conValue = (int) (t0 + t1 + t2 + left + center + right + b0 + b1 + b2);

                    convMatrix[i, j] = conValue;



                    textBox2.SelectedText = convMatrix[i, j].ToString() + " ";

                }
                textBox2.SelectedText = Environment.NewLine;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void convolutionOnImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] kernel = { { 0.25, 0.5, 0.25 }, { 0.5, 1, 0.5 }, { 0.25, 0.5, 0.25 } };

            int newHieght = (orgImg.Height * 2) + 1;
            int newWidth = (orgImg.Width * 2) + 1;

            Bitmap resImg = new Bitmap(newWidth, newHieght);
            Bitmap convImg = new Bitmap(newWidth, newHieght);

            int m, n;
            m = n = 0;
            for (int j = 0; j < newHieght; j++)
            {
                for (int i = 0; i < newWidth; i++)
                {
                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        Color pixel = orgImg.GetPixel(m, n);
                        resImg.SetPixel(i, j, pixel);
                        n++;
                    }
                    else
                    {
                        resImg.SetPixel(i, j, Color.FromArgb(0,0,0));
                    }
                }
                m = j / 2;
                n = 0;
            }
            
            for (int j = 1; j < newHieght - 1; j++)
            {
                for (int i = 1; i < newWidth - 1; i++)
                {
                    Color pixel1 = resImg.GetPixel(i-1, j-1);
                    double p1 = (pixel1.R + pixel1.B + pixel1.G) / 3;
                    double t0 = kernel[0, 0] * p1;

                    Color pixel2 = resImg.GetPixel(i - 1, j);
                    double p2 = (pixel2.R + pixel2.B + pixel2.G) / 3;
                    double t1 = kernel[0, 1] * p2;

                    Color pixel3 = resImg.GetPixel(i - 1, j + 1);
                    double p3 = (pixel3.R + pixel3.B + pixel3.G) / 3;
                    double t2 = kernel[0, 2] * p3;

                    Color pixel4 = resImg.GetPixel(i, j - 1);
                    double p4 = (pixel4.R + pixel4.B + pixel4.G) / 3;
                    double left = kernel[1, 0] * p4;

                    Color pixel5 = resImg.GetPixel(i, j);
                    double p5 = (pixel5.R + pixel5.B + pixel5.G) / 3;
                    double center = kernel[1, 1] * p5;

                    Color pixel6 = resImg.GetPixel(i, j + 1);
                    double p6 = (pixel6.R + pixel6.B + pixel6.G) / 3;
                    double right = kernel[1, 2] * p5;

                    Color pixel7 = resImg.GetPixel(i + 1, j - 1);
                    double p7 = (pixel7.R + pixel7.B + pixel7.G) / 3;
                    double b0 = kernel[2, 0] * p5;

                    Color pixel8 = resImg.GetPixel(i + 1, j);
                    double p8 = (pixel8.R + pixel8.B + pixel8.G) / 3;
                    double b1 = kernel[2, 1] * p8;

                    Color pixel9 = resImg.GetPixel(i + 1, j + 1);
                    double p9 = (pixel9.R + pixel9.B + pixel9.G) / 3;
                    double b2 = kernel[2, 2] * p9;

                    int conValue = (int)(t0 + t1 + t2 + left + center + right + b0 + b1 + b2);

                    convImg.SetPixel(i, j, Color.FromArgb(conValue, conValue, conValue));
                }
            }

            pictureBox2.Image = convImg;
            pictureBox2.Refresh();

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
        }

        private void imageAdditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap Img1 = new Bitmap(orgImg);
            Bitmap Img2 = new Bitmap(orgImg);
            Bitmap resImg = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            for (int y = 0; y < pictureBox1.Height; y++)
            {
                for (int x = 0; x < pictureBox1.Width; x++)
                {
                    Color pixel1 = Img1.GetPixel(x, y);
                    Color pixel2 = Img2.GetPixel(x, y);

                    int r = pixel1.R + pixel2.R;
                    int g = pixel1.G + pixel2.G;
                    int b = pixel1.B + pixel2.B;

                    if (r > 255)
                        r = 255;
                    if (b > 255)
                        b = 255;
                    if (g > 255)
                        g = 255;
                    if (r < 0)
                        r = 0;
                    if (g < 0)
                        g = 0;
                    if (b < 0)
                        b = 0;

                    resImg.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            pictureBox3.Image = resImg;
            pictureBox3.Refresh();
        }

        private void imageSubtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap Img1 = new Bitmap(orgImg);
            Bitmap Img2 = new Bitmap(orgImg);
            Bitmap resImg = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            for (int y = 0; y < pictureBox1.Height; y++)
            {
                for (int x = 0; x < pictureBox1.Width; x++)
                {
                    Color pixel1 = Img1.GetPixel(x, y);
                    Color pixel2 = Img2.GetPixel(x, y);

                    int r = pixel1.R - pixel2.R;
                    int g = pixel1.G - pixel2.G;
                    int b = pixel1.B - pixel2.B;

                    if (r > 255)
                        r = 255;
                    if (b > 255)
                        b = 255;
                    if (g > 255)
                        g = 255;
                    if (r < 0)
                        r = 0;
                    if (g < 0)
                        g = 0;
                    if (b < 0)
                        b = 0;

                    resImg.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            pictureBox3.Image = resImg;
            pictureBox3.Refresh();
        }
    }
}
