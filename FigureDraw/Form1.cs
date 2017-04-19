using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureDraw
{
    public partial class Form1 : Form
    {
        public Bitmap bmp;
        public Graphics drw;
        public Pen pen;
        public Line drawingLine;
        public Rectangle drawingRec;
        public Square drawingSqr;
        public Ellipse drawingEll;
        public Circle drawingCrl;
        public Triangle drawingTrgl;

        public Form1()
        {
            InitializeComponent();
        }

        public void InitImage()
        {
            bmp = new Bitmap(pictureBox1.Height, pictureBox1.Width);
            drw = Graphics.FromImage(bmp);
            pen = new Pen(Color.Black);
            pictureBox1.Image = bmp;
            drawingLine = new Line(10, 10, 100, 200);
            drawingRec = new Rectangle(120, 10, 250, 100);
            drawingSqr = new Square(220, 150, 100);
            drawingEll = new Ellipse(80, 40, 100, 200);
            drawingCrl = new Circle(50, 200, 200);
            drawingTrgl = new Triangle(280, 30, 350, 350);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InitImage();
            List<Shape> figures = new List<Shape>();
            if (checkBox7.Checked == true)
            {
                figures.Add(drawingLine);
                figures.Add(drawingRec);
                figures.Add(drawingSqr);
                figures.Add(drawingEll);
                figures.Add(drawingCrl);
                figures.Add(drawingTrgl);
            }
            else 
            {
                if (checkBox1.Checked == true) { figures.Add(drawingLine); };
                if (checkBox2.Checked == true) { figures.Add(drawingRec); };
                if (checkBox3.Checked == true) { figures.Add(drawingSqr); };
                if (checkBox4.Checked == true) { figures.Add(drawingEll); }
                if (checkBox5.Checked == true) { figures.Add(drawingCrl); }
                if (checkBox6.Checked == true) { figures.Add(drawingTrgl); }
            };
            foreach (Shape i in figures)
            {
                i.Draw(drw);
            }
        }
    }
}

