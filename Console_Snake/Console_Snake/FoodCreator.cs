using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Snake
{
    class FoodCreator
    {
        int mapStart;
        int mapWidth;
        int mapHeight;
        char sym;

        Random rnd = new Random();
        
        public FoodCreator(int mapStart, int mapWidth, int mapHeight, char sym)
        {
            this.mapStart = mapStart;
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = new Random().Next(mapStart + 2, mapWidth - 2);
            int y = new Random().Next(mapStart + 2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
