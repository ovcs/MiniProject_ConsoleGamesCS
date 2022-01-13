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
            p1.Draw();
            
            Console.ReadKey();
        }
    }
}
