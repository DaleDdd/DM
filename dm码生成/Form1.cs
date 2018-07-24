using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataMatrix.net;
using System.Drawing.Imaging;

namespace dm码生成
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Y_zhou_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen p = new Pen(Color.Black, 2);
            Pen pen1 = new Pen(Color.White, 2);
            Point p1 = new Point(29, 0);
            Point p2 = new Point(0, 23);
            Point p3 = new Point(59, 23);
            Point p4 = new Point(29, 23);
            g.DrawLine(p, p1, p2);
            g.DrawLine(p, p2, p3);
            g.DrawLine(p, p1, p3);

            Point[] point= new Point[3];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            SolidBrush b1 = new SolidBrush(Color.Black);
            g.FillPolygon(b1, point);
            g.DrawLine(pen1, p1, p4);

            p.Dispose();
            pen1.Dispose();
            b1.Dispose();
            //g.Dispose();
        }

        private void X_zhou_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen p = new Pen(Color.Black, 2);
            Pen pen1 = new Pen(Color.White, 2);
            Point p1 = new Point(36, 0);
            Point p2 = new Point(59, 29);
            Point p3 = new Point(36, 59);
            Point p4 = new Point(36, 29);
            g.DrawLine(p, p1, p2);
            g.DrawLine(p, p2, p3);
            g.DrawLine(p, p1, p3);

            Point[] point = new Point[3];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            SolidBrush b1 = new SolidBrush(Color.Black);
            g.FillPolygon(b1, point);
            g.DrawLine(pen1, p2, p4);

            p.Dispose();
            pen1.Dispose();
            b1.Dispose();
        }

        private void twink1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen p = new Pen(Color.Black, 2);
            Pen pen1 = new Pen(Color.White, 2);
            Point p1 = new Point(0,36);
            Point p2 = new Point(59, 36);
            Point p3 = new Point(29, 59);
            Point p4 = new Point(29, 36);
            g.DrawLine(p, p1, p2);
            g.DrawLine(p, p2, p3);
            g.DrawLine(p, p1, p3);

            Point[] point = new Point[3];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            SolidBrush b1 = new SolidBrush(Color.Black);          
            g.DrawLine(p, p3, p4);
            p.Dispose();
            pen1.Dispose();
            b1.Dispose();
        }

        private void twink2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen p = new Pen(Color.Black, 2);
            Pen pen1 = new Pen(Color.White, 2);
            Point p1 = new Point(0, 29);
            Point p2 = new Point(23, 0);
            Point p3 = new Point(23, 59);
            Point p4 = new Point(23, 29);
            g.DrawLine(p, p1, p2);
            g.DrawLine(p, p2, p3);
            g.DrawLine(p, p1, p3);

            Point[] point = new Point[3];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            SolidBrush b1 = new SolidBrush(Color.Black);
            
            g.DrawLine(p, p1, p4);

            p.Dispose();
            pen1.Dispose();
            b1.Dispose();
        }

        private void pictureBox17_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen p = new Pen(Color.Black, 2);
            Point p1 = new Point(29, 0);
            Point p2 = new Point(29,59);
            Point p3 = new Point(59,29);
            Point p4 = new Point(0,29);
            g.DrawLine(p, p1, p2);
            g.DrawLine(p, p4, p3);
            p.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g1 = panel1.CreateGraphics();
            Image myImage = new Bitmap(this.panel1.Width, this.panel1.Height, g1);
            Graphics g2 = Graphics.FromImage(myImage);
            IntPtr dc1 = g1.GetHdc();
            IntPtr dc2 = g2.GetHdc();
            BitBlt(dc2, 0, 0, this.panel1.Width, this.panel1.Height, dc1, 0, 0, 13369376);
            g1.ReleaseHdc(dc1);
            g2.ReleaseHdc(dc2);
            myImage.Save(@"C:\Users\woshi\Desktop\dm码生成\dm码.jpg", ImageFormat.Bmp);
        }

            [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll ")]
            private static extern bool BitBlt(
                IntPtr hdcDest, // handle to destination DC 
                int nXDest, // x-coord of destination upper-left corner 
                int nYDest, // y-coord of destination upper-left corner 
                int nWidth, // width of destination rectangle 
                int nHeight, // height of destination rectangle 
                IntPtr hdcSrc, // handle to source DC 
                int nXSrc, // x-coordinate of source upper-left corner 
                int nYSrc, // y-coordinate of source upper-left corner 
                System.Int32 dwRop // raster operation code
                //123
            );

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.ToString()!=""&& textBox2.Text.ToString() != ""&& textBox3.Text.ToString() != "")
            {
                DmtxImageEncoder die = new DmtxImageEncoder();
                DmtxImageEncoderOptions ops = new DmtxImageEncoderOptions();
                ops.SizeIdx = DmtxSymbolSize.DmtxSymbol12x12;//形状
                ops.MarginSize = 4;         //边距
                ops.ModuleSize = 14;        //点阵大小
                string txt1 = "33" + textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt2 = "34"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt3 = "35"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt4 = "36"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt5 = "43"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt6 = "44"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt7 = "45"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt8 = "46"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt9 = "53"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt10 = "54"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt11 = "55"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt12 = "56"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt13 = "63"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt14 = "64"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt15 = "65"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();
                string txt16 = "66"+ textBox3.Text.ToString() + textBox1.Text.ToString() + textBox2.Text.ToString();

                try
                {
                    Bitmap b1 = die.EncodeImage(txt1, ops);
                    pictureBox13.Image = b1;
                    Bitmap b2 = die.EncodeImage(txt2, ops);
                    pictureBox9.Image = b2;
                    Bitmap b3 = die.EncodeImage(txt3, ops);
                    pictureBox5.Image = b3;
                    Bitmap b4 = die.EncodeImage(txt4, ops);
                    pictureBox1.Image = b4;
                    Bitmap b5 = die.EncodeImage(txt5, ops);
                    pictureBox14.Image = b5;
                    Bitmap b6 = die.EncodeImage(txt6, ops);
                    pictureBox10.Image = b6;
                    Bitmap b7 = die.EncodeImage(txt7, ops);
                    pictureBox6.Image = b7;
                    Bitmap b8 = die.EncodeImage(txt8, ops);
                    pictureBox2.Image = b8;
                    Bitmap b9 = die.EncodeImage(txt9, ops);
                    pictureBox15.Image = b9;
                    Bitmap b10 = die.EncodeImage(txt10, ops);
                    pictureBox11.Image = b10;
                    Bitmap b11 = die.EncodeImage(txt11, ops);
                    pictureBox7.Image = b11;
                    Bitmap b12 = die.EncodeImage(txt12, ops);
                    pictureBox3.Image = b12;
                    Bitmap b13 = die.EncodeImage(txt13, ops);
                    pictureBox16.Image = b13;
                    Bitmap b14 = die.EncodeImage(txt14, ops);
                    pictureBox12.Image = b14;
                    Bitmap b15 = die.EncodeImage(txt15, ops);
                    pictureBox8.Image = b15;
                    Bitmap b16 = die.EncodeImage(txt16, ops);
                    pictureBox4.Image = b16;

                }catch
                {
                    MessageBox.Show("请输入合法值");
                }
                Y_zhou.Refresh();
                X_zhou.Refresh();
                twink1.Refresh();
                twink2.Refresh();
                pictureBox17.Refresh();
            }
            else
            {
                MessageBox.Show("请输入合法值");
            }        
        }
    }
}
