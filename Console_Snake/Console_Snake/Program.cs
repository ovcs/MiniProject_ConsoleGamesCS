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

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList) Console.WriteLine(i);

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            Console.ReadKey();
        }
    }
}
