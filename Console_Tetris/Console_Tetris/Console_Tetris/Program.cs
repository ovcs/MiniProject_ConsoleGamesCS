using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Tetris
{
    class Program
    {
        static void Main(string[] args)
        {

            int dStart = 0, dWidth = 50, dHeight = 35;
            char filler1 = '+';
            char filler2 = 'o';

            CreateWindow(dWidth, dHeight);
            
            Point p = new Point(5, 10, filler1);
            p.Output();
            Console.ReadKey();
            p.Clear();
            Console.ReadKey();
        }
        
        static void CreateWindow(int width, int height)
        {
            int setWidth = Console.LargestWindowWidth >= width ? width : Console.LargestWindowWidth;
            int setHeight = Console.LargestWindowHeight >= height ? height : Console.LargestWindowHeight;
            Console.SetWindowSize(setWidth, setHeight);
            Console.SetBufferSize(setWidth+1, setHeight);
        }
    }
}
