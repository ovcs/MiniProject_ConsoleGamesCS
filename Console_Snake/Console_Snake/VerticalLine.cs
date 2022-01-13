using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Snake
{
    class VerticalLine
    {
        List<Point> vLine;

        public VerticalLine(int x, int yTop, int yBottom, char sym)
        {
            vLine = new List<Point>();

            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                vLine.Add(p);
            }
        }

        public void Drow()
        {
            foreach (Point p in vLine) p.Draw();
        }
    }
}
