using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Tetris
{
    class Frame: Figure
    {
        public void Frame(int start, int width, int height, char sym)
        {
            pList = new List<Point>();
            int x = start++;
            int y = start++;
            width--; height--;

            for (; x <= width; x++)
            {
                Point p1 = new Point(x, y, sym);
                pList.Add(p1);
                Point p2 = new Point(x, height, sym);
                pList.Add(p2);
            }
            
            for (x = start++; y < height; y++)
            {
                Point p1 = new Point(x, y, sym);
                pList.Add(p1);
                Point p2 = new Point(width, y, sym);
                pList.Add(p2);
            }
        }
    }
}