using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace RPG_Application
{
    public partial class MainWindow : Window
    {
        Hero myHero;
        Skeleton mySkeleton1;
        Skeleton mySkeleton2;
        Skeleton mySkeleton3;
        FoxDraw foxDraw;
        List<Tile> boardTileList;

        public MainWindow()
        {
            Random rand = new Random();
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            //boardTiles = new Tiles();
            boardTileList = Character.TilePositions();
            myHero = new Hero(0, 0);
            mySkeleton1 = new Skeleton(rand);
            mySkeleton2 = new Skeleton(rand);
            mySkeleton3 = new Skeleton(rand);


            DrawTable();
            foxDraw.AddImage("./Assets/hero-down.png", myHero.positionX, myHero.positionY);
            foxDraw.AddImage("./Assets/skeleton.png", mySkeleton1.positionX, mySkeleton1.positionY);
            foxDraw.AddImage("./Assets/skeleton.png", mySkeleton2.positionX, mySkeleton2.positionY);
            foxDraw.AddImage("./Assets/skeleton.png", mySkeleton3.positionX, mySkeleton3.positionY);
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                myHero.HeroMoveLeft();
                DrawTable();
                foxDraw.AddImage("./Assets/hero-left.png", myHero.getPositionX(), myHero.getPositionY());
                foxDraw.AddImage("./Assets/skeleton.png", mySkeleton1.positionX, mySkeleton1.positionY);
                foxDraw.AddImage("./Assets/skeleton.png", mySkeleton2.positionX, mySkeleton2.positionY);
                foxDraw.AddImage("./Assets/skeleton.png", mySkeleton3.positionX, mySkeleton3.positionY);
            }

            if (e.Key == Key.Right)
            {
                myHero.HeroMoveRight();
                DrawTable();
                foxDraw.AddImage("./Assets/hero-right.png", myHero.getPositionX(), myHero.getPositionY());
                foxDraw.AddImage("./Assets/skeleton.png", mySkeleton1.positionX, mySkeleton1.positionY);
                foxDraw.AddImage("./Assets/skeleton.png", mySkeleton2.positionX, mySkeleton2.positionY);
                foxDraw.AddImage("./Assets/skeleton.png", mySkeleton3.positionX, mySkeleton3.positionY);
            }

            if (e.Key == Key.Up)
            {
                myHero.HeroMoveUp();
                DrawTable();
                foxDraw.AddImage("./Assets/hero-up.png", myHero.getPositionX(), myHero.getPositionY());
                foxDraw.AddImage("./Assets/skeleton.png", mySkeleton1.positionX, mySkeleton1.positionY);
                foxDraw.AddImage("./Assets/skeleton.png", mySkeleton2.positionX, mySkeleton2.positionY);
                foxDraw.AddImage("./Assets/skeleton.png", mySkeleton3.positionX, mySkeleton3.positionY);
            }

            if (e.Key == Key.Down)
            {
                myHero.HeroMoveDown();
                DrawTable();
                foxDraw.AddImage("./Assets/hero-down.png", myHero.getPositionX(), myHero.getPositionY());
                foxDraw.AddImage("./Assets/skeleton.png", mySkeleton1.positionX, mySkeleton1.positionY);
                foxDraw.AddImage("./Assets/skeleton.png", mySkeleton2.positionX, mySkeleton2.positionY);
                foxDraw.AddImage("./Assets/skeleton.png", mySkeleton3.positionX, mySkeleton3.positionY);
            }
        }

        public void DrawTable()
        {

            for (int i = 0; i < boardTileList.Count; i++)
            {
                if (boardTileList[i].GetIsWall())
                {
                    foxDraw.AddImage("./Assets/wall.png", boardTileList[i].positionX, boardTileList[i].positionY);
                }
                else
                {
                    foxDraw.AddImage("./Assets/floor.png", boardTileList[i].positionX, boardTileList[i].positionY);
                }
            }
        }
    }
}
