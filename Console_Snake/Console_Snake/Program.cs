using System;
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
            char filler1 = '+';
            char filler2 = '$';
            int lengthSnake = 4;

            Console.SetWindowSize(dWidth + 1, dHeight + 1);
            Console.SetBufferSize(dWidth + 2, dHeight + 1);

            HorisontalLine upHline = new HorisontalLine(dStart, dWidth, dStart, filler1);
            HorisontalLine downHline = new HorisontalLine(dStart, dWidth, dHeight, filler1);
            VerticalLine leftVline = new VerticalLine(dStart, dStart, dHeight, filler1);
            VerticalLine rightVline = new VerticalLine(dWidth, dStart, dHeight, filler1);

            upHline.Drow(); downHline.Drow(); leftVline.Drow(); rightVline.Drow();

            Point p = new Point(dWidth / 2, dHeight / 2, filler1);
            Snake snake = new Snake(p, lengthSnake, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(dStart, dWidth, dHeight, filler2);
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    snake.MoveKeys(Console.ReadKey());
                }
                Thread.Sleep(200);
            }
        }
    }
}
