using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Application
{
    class Hero : Character
    {
        public Hero(double posX, double posY)
        {
            this.positionX = posX;
            this.positionY = posY;
        }
    }
}
