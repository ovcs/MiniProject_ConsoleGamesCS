﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int dStart = 0, dWidth = 78, dHeight = 24;

            Console.SetWindowSize(dWidth + 1, dHeight + 1);
            Console.SetBufferSize(dWidth + 2, dHeight + 1);

            HorisontalLine upHline = new HorisontalLine(dStart, dWidth, dStart, '*');
            HorisontalLine downHline = new HorisontalLine(dStart, dWidth, dHeight, '*');
            VerticalLine leftVline = new VerticalLine(dStart, dStart, dHeight, '*');
            VerticalLine rightVline = new VerticalLine(dWidth, dStart, dHeight, '*');

            upHline.Drow(); downHline.Drow(); leftVline.Drow(); rightVline.Drow();

            Point p = new Point(dWidth / 2, dHeight / 2, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            
            while(true)
            {
                if (Console.KeyAvailable)
                {
                    snake.MoveKeys(Console.ReadKey());
                }
                snake.Move();
                Thread.Sleep(500);
            }
        }
    }
}
