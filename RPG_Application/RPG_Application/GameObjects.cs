
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
        public bool isEmpty = false;
    }
}
