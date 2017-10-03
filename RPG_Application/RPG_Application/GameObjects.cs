
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Application
{
    class GameObjects
    {
        protected int level;
        protected bool isVisible = true;
        protected bool isGameOn = true;
        public double positionX = 0;
        public double positionY = 0;
        public bool isWall = false;
        public List<Tile> floorTiles = new List<Tile>();
        public List<Tile> wallTiles = new List<Tile>();

        public List<Tile> FloorTilePositions()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    floorTiles.Add(new Tile(positionX + i * 50, positionY + j * 50, false));
                }
            }
            return floorTiles;
        }

        public List<Tile> WallTilePositions()
        {
            wallTiles.Add(new Tile(positionX + 3 * 50, positionY + 0 * 50, true));
            wallTiles.Add(new Tile(positionX + 5 * 50, positionY + 0 * 50, true));
            wallTiles.Add(new Tile(positionX + 3 * 50, positionY + 1 * 50, true));
            wallTiles.Add(new Tile(positionX + 5 * 50, positionY + 1 * 50, true));
            wallTiles.Add(new Tile(positionX + 7 * 50, positionY + 1 * 50, true));
            wallTiles.Add(new Tile(positionX + 8 * 50, positionY + 1 * 50, true));
            wallTiles.Add(new Tile(positionX + 1 * 50, positionY + 2 * 50, true));
            wallTiles.Add(new Tile(positionX + 2 * 50, positionY + 2 * 50, true));
            wallTiles.Add(new Tile(positionX + 3 * 50, positionY + 2 * 50, true));
            wallTiles.Add(new Tile(positionX + 5 * 50, positionY + 2 * 50, true));
            wallTiles.Add(new Tile(positionX + 7 * 50, positionY + 2 * 50, true));
            wallTiles.Add(new Tile(positionX + 8 * 50, positionY + 2 * 50, true));
            wallTiles.Add(new Tile(positionX + 5 * 50, positionY + 3 * 50, true));
            wallTiles.Add(new Tile(positionX + 0 * 50, positionY + 4 * 50, true));
            wallTiles.Add(new Tile(positionX + 1 * 50, positionY + 4 * 50, true));
            wallTiles.Add(new Tile(positionX + 2 * 50, positionY + 4 * 50, true));
            wallTiles.Add(new Tile(positionX + 3 * 50, positionY + 4 * 50, true));
            wallTiles.Add(new Tile(positionX + 5 * 50, positionY + 4 * 50, true));
            wallTiles.Add(new Tile(positionX + 6 * 50, positionY + 4 * 50, true));
            wallTiles.Add(new Tile(positionX + 7 * 50, positionY + 4 * 50, true));
            wallTiles.Add(new Tile(positionX + 8 * 50, positionY + 4 * 50, true));
            wallTiles.Add(new Tile(positionX + 1 * 50, positionY + 5 * 50, true));
            wallTiles.Add(new Tile(positionX + 3 * 50, positionY + 5 * 50, true));
            wallTiles.Add(new Tile(positionX + 8 * 50, positionY + 5 * 50, true));
            wallTiles.Add(new Tile(positionX + 1 * 50, positionY + 6 * 50, true));
            wallTiles.Add(new Tile(positionX + 3 * 50, positionY + 6 * 50, true));
            wallTiles.Add(new Tile(positionX + 5 * 50, positionY + 6 * 50, true));
            wallTiles.Add(new Tile(positionX + 6 * 50, positionY + 6 * 50, true));
            wallTiles.Add(new Tile(positionX + 8 * 50, positionY + 6 * 50, true));
            wallTiles.Add(new Tile(positionX + 5 * 50, positionY + 7 * 50, true));
            wallTiles.Add(new Tile(positionX + 6 * 50, positionY + 7 * 50, true));
            wallTiles.Add(new Tile(positionX + 8 * 50, positionY + 7 * 50, true));
            wallTiles.Add(new Tile(positionX + 1 * 50, positionY + 8 * 50, true));
            wallTiles.Add(new Tile(positionX + 2 * 50, positionY + 8 * 50, true));
            wallTiles.Add(new Tile(positionX + 3 * 50, positionY + 8 * 50, true));
            wallTiles.Add(new Tile(positionX + 8 * 50, positionY + 8 * 50, true));
            wallTiles.Add(new Tile(positionX + 3 * 50, positionY + 9 * 50, true));
            wallTiles.Add(new Tile(positionX + 5 * 50, positionY + 9 * 50, true));
            wallTiles.Add(new Tile(positionX + 6 * 50, positionY + 9 * 50, true));
            wallTiles.Add(new Tile(positionX + 8 * 50, positionY + 9 * 50, true));
            wallTiles.Add(new Tile(positionX + 1 * 50, positionY + 10 * 50, true));
            wallTiles.Add(new Tile(positionX + 3 * 50, positionY + 10 * 50, true));
            wallTiles.Add(new Tile(positionX + 5 * 50, positionY + 10 * 50, true));
            return wallTiles;
        }
    }
}
