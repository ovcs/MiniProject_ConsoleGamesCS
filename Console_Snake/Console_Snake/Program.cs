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
            Point p1 = new Point();
            p1.x = 4;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();
            
            Console.ReadKey();
        }
    }
}
