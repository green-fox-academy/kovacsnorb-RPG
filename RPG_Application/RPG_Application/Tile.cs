using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPG_Application
{
    class Tile : GameObjects
    {

        public Tile()
        {
        }

        public Tile (double posX, double posY, bool isWall)
        {
            positionX = posX;
            positionY = posY;
            this.isWall = isWall;
        }

        public bool GetIsWall()
        {
            return isWall;
        }
    }
}
