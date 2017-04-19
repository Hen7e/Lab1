using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public abstract class Shape
    {
        private int left_top_point_x1;
        private int left_top_point_y1;
        private int right_bottom_point_x2;
        private int right_bottom_point_y2;
        public int x1
        {
            get { return left_top_point_x1; }
            set { left_top_point_x1 = value; }
        }
        public int y1
        {
            get { return left_top_point_y1; }
            set { left_top_point_y1 = value; }
        }
        public int x2
        {
            get { return right_bottom_point_x2; }
            set { right_bottom_point_x2 = value; }
        }
        public int y2
        {
            get { return right_bottom_point_y2; }
            set { right_bottom_point_y2 = value; }
        }
        public Shape(int x1, int y1, int x2, int y2)
        {
            left_top_point_x1 = x1;
            left_top_point_y1 = y1;
            right_bottom_point_x2 = x2;
            right_bottom_point_y2 = y2;
        }
        public virtual void Draw(Graphics drw) { }
    }
}
