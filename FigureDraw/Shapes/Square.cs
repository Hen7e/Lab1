using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public class Square : Rectangle
    {
        public Square(int x1, int y1, int _height) : base(x1, y1, _height, _height) { }
    }
}
