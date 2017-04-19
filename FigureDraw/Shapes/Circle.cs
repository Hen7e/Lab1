using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public class Circle : Ellipse
    {
        public Circle(int x1, int y1, int height) : base(x1, y1, height, height) { }
    }
}
