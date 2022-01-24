using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            int dStart = 0, dWidth = 39, dHeight = 39;
            char filler1 = '+';
            char filler2 = 'o';

            Console.SetWindowSize(dWidth + 1, dHeight + 1);
            Console.SetBufferSize(dWidth + 2, dHeight + 1);
            
            Point p = new Point(5, 10, filler1);
            p.Output();
            Console.ReadKey();
            p.Clear();
            Console.ReadKey();
        }
    }
}
