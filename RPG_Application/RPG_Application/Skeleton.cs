using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Application
{
    class Skeleton : Character
    {
        public Skeleton(Random rand)
        {
            do
            {
                this.positionX = rand.Next(0, 10) * 50;
                this.positionY = rand.Next(0, 11) * 50;
            }
            while (GetIsWall(positionX, positionY) && (positionX + positionY) != 0);
        }

        public double getPositionX()
        {
            return this.positionX;
        }

        public double getPositionY()
        {
            return this.positionY;
        }
    }
}
