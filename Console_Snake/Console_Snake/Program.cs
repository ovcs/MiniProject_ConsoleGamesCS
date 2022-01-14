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

            Wall walls = new Wall(dStart, dWidth, dHeight, filler1);
            walls.Draw();

            Point p = new Point(dWidth / 2, dHeight / 2, filler1);
            Snake snake = new Snake(p, lengthSnake, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(dStart, dWidth, dHeight, filler2);
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

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
