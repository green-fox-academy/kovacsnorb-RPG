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
        FoxDraw foxDraw;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            var floorTiles = new Tile();
            var floorTileList = floorTiles.FloorTilePositions();
            var wallTiles = new Tile();
            var wallTileList = floorTiles.WallTilePositions();
            myHero = new Hero(0, 0);

            for (int i = 0; i < floorTileList.Count; i++)
            {
                foxDraw.AddImage("./Assets/floor.png", floorTileList[i].positionX, floorTileList[i].positionY);
            }

            for (int i = 0; i < wallTileList.Count; i++)
            {
                foxDraw.AddImage("./Assets/wall.png", wallTileList[i].positionX, wallTileList[i].positionY);
            }

            foxDraw.AddImage("./Assets/hero-down.png", myHero.positionX, myHero.positionY);

        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                myHero.HeroMoveLeft();
                foxDraw.AddImage("./Assets/hero-left.png", myHero.getPositionX(), myHero.getPositionY());
            }

            if (e.Key == Key.Right)
            {
                myHero.HeroMoveRight();
                foxDraw.AddImage("./Assets/hero-right.png", myHero.getPositionX(), myHero.getPositionY());
            }

            if (e.Key == Key.Up)
            {
                myHero.HeroMoveUp();
                foxDraw.AddImage("./Assets/hero-up.png", myHero.getPositionX(), myHero.getPositionY());
            }

            if (e.Key == Key.Down)
            {
                myHero.HeroMoveDown();
                foxDraw.AddImage("./Assets/hero-down.png", myHero.getPositionX(), myHero.getPositionY());
            }
        }

        public void DrawTable()
        {
            var floorTiles = new Tile();
            var floorTileList = floorTiles.FloorTilePositions();
            var wallTiles = new Tile();
            var wallTileList = floorTiles.WallTilePositions();

            for (int i = 0; i < floorTileList.Count; i++)
            {
                foxDraw.AddImage("./Assets/floor.png", floorTileList[i].positionX, floorTileList[i].positionY);
            }

            for (int i = 0; i < wallTileList.Count; i++)
            {
                foxDraw.AddImage("./Assets/wall.png", wallTileList[i].positionX, wallTileList[i].positionY);
            }

        }
    }
}
