using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Application
{
    class Character : GameObjects
    {
        private bool isAlive = true;
        public static List<Tile> tiles = new List<Tile>();

        public static List<bool[]> isWallList = new List<bool[]>()
        {
            new bool[] { false, false, false, true, false, true, false, false, false, false },
            new bool[] { false, false, false, true, false, true, false, true, true, false },
            new bool[] { false, true, true, true, false, true, false, true, true, false },
            new bool[] { false, false, false, false, false, true, false, false, false, false },
            new bool[] { true, true, true, true, false, true, true, true, true, false },
            new bool[] { false, true, false, true, false, false, false, false, true, false },
            new bool[] { false, true, false, true, false, true, true, false, true, false },
            new bool[] { false, false, false, false, false, true, true, false, true, false },
            new bool[] { false, true, true, true, false, false, false, false, true, false },
            new bool[] { false, false, false, true, false, true, true, false, true, false },
            new bool[] { false, true, false, true, false, true, false, false, false, false },
        };

        public static List<Tile> TilePositions()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    tiles.Add(new Tile(i * 50, j * 50, isWallList[j][i]));
                }
            }
            return tiles;
        }

        public bool GetIsWall(double coordX, double coordY)
        {
            int coordXnew = (int)(coordX / 50);
            int coordYnew = (int)(coordY / 50);
            return isWallList[coordYnew][coordXnew];
        }
    }
}
