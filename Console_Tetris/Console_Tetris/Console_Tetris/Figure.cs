using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Tetris
{
    class Figure
    {
        protected List<Point> pList;

        public virtual void DrawElement()
        {
            foreach (Point p in pList) p.Output();
        }
    }
}