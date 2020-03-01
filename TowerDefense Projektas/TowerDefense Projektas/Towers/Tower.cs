using System;
using TowerDefense_Projektas.Interfaces;
using TowerDefense_Projektas.Map;
using TowerDefense_Projektas.ParentClass;

namespace TowerDefense_Projektas.Towers
{
    class Tower : MovableObject, IMovable, IRenderable
    {
        MapLayout mapLayout = new MapLayout();
        public Tower(int x, int y) : base(x, y)
        {

        }


        public void MoveTower()
        {
            int x = 0;
            mapLayout.Map();
            while (x == 0)
            {
                Console.Clear();

                //foreach (object xe in MapLayout.mapCoordinates)
                //{ Console.Write(xe); }
                mapLayout.Render();
                Render();
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.UpArrow:
                        MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        MoveDown();
                        break;
                    case ConsoleKey.LeftArrow:
                        ToLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        ToRight();
                        break;
                    case ConsoleKey.Enter:

                        int coordinates=0;
                        if (Y == 0) coordinates = X;
                        if (Y > 0) coordinates = Y * 120 + X;
                       // Console.Clear();
                       // Console.Write(MapLayout.mapLayout[coordinates]);
                       // Console.ReadKey();
                        if (MapLayout.computerMapLayout[coordinates] == ' ')
                        x = 1;
                        break;
                }
            }
        }

        public void ToLeft()
        {
            if(X>=0)
                X--;
            if (X == -1)
                X = 118;
        }

        public void ToRight()
        {
            if(X<=118)
                X++;
            if (X == 119)
                X = 0;
        }

        public void MoveUp()
        {
            if(Y>0)
                Y--;
            if (Y == 0)
                Y = 44;
        }

        public void MoveDown()
        {
            if(Y<45)
                Y++;
            if (Y == 45)
                Y = 0;
        }

        public void Render()
        {
            TowerModel towerModel = new TowerModel(X, Y);
            towerModel.Render();

        }
    }
}
