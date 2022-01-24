using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Tetris
{
    class Point
    {
        public int x;
        public int y;
        public char filler;

        public Point(int _x, int _y, char _filler)
        {
            x = _x; y = _y; filler = _filler;
        }

        public void Output()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(filler);
        }

        public void Clear()
        {
            filler = ' ';
            Output();
        }
    }
}
