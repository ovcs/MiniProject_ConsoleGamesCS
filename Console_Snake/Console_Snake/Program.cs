using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4,5,'*');
            Point p2 = new Point(7, 1, '#');
            Point p3 = new Point(2, 4, '%');
            Point p4 = new Point(6, 2, '(');
            p1.Draw();

            HorisontalLine hline = new HorisontalLine(1,30,8,'+');
            hline.Drow();

            VerticalLine vline = new VerticalLine(1, 1, 8, '+');
            vline.Drow();

            Console.ReadKey();
        }
    }
}
