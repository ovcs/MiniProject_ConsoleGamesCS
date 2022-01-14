using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            pList = new List<Point>();
            direction = _direction;

            for(int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point nextPoint = new Point(pList.Last());
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void MoveKeys(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow: direction = Direction.LEFT; break;
                case ConsoleKey.RightArrow: direction = Direction.RIGHT; break;
                case ConsoleKey.UpArrow: direction = Direction.UP; break;
                case ConsoleKey.DownArrow: direction = Direction.DOWN; break;
            }
        }
    }
}
