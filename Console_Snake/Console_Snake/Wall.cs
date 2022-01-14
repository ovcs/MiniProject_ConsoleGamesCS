using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Snake
{
    class Wall
    {
        public List<Figure> wallList;

        public Wall(int mapStart, int mapWigth, int mapHeigth, char mapSym)
        {
            wallList = new List<Figure>();

            HorisontalLine upHline = new HorisontalLine(mapStart, mapWigth, mapStart, mapSym);
            HorisontalLine downHline = new HorisontalLine(mapStart, mapWigth, mapHeigth, mapSym);
            VerticalLine leftVline = new VerticalLine(mapStart, mapStart, mapHeigth, mapSym);
            VerticalLine rightVline = new VerticalLine(mapWigth, mapStart, mapHeigth, mapSym);

            wallList.Add(upHline);
            wallList.Add(downHline);
            wallList.Add(leftVline);
            wallList.Add(rightVline);
        }

        public void Draw()
        {
            foreach (var wall in wallList) wall.Drow();
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
