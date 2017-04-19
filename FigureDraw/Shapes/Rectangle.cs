using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public class Rectangle : Shape
    {
        public Rectangle(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2 ) { }
        public override void Draw(Graphics drw)
        {
            Pen blackPen = new Pen(Color.Red);
            drw.DrawRectangle(blackPen, x1, y1, x2, y2);
            blackPen.Dispose();
        }
    }
}