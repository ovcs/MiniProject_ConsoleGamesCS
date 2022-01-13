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
            int x1 = 4, x2 = 5;
            char sym1 = '*';
            Draw(x1,y1,sym1);
            Console.ReadKey();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
