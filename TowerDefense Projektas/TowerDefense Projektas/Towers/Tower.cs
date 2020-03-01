using System;
using TowerDefense_Projektas.Interfaces;
using TowerDefense_Projektas.Map;
using TowerDefense_Projektas.ParentClass;

namespace TowerDefense_Projektas.Towers
{
    class Tower : MovableObject, IMovable, IRenderable
    {
        MapLayout mapLayout = new MapLayout();
        int coordinates = 0;
        public Tower(int x, int y) : base(x, y)
        {

        }


        public void MoveTower()
        {
            Console.ForegroundColor = ConsoleColor.White;
            int x = 0;
            mapLayout.Render();
            Render();
            while (x == 0)
            {
                //Console.Clear();

                coordinates = 0;
                if (Y == 0) coordinates = X;
                if (Y > 0) coordinates = Y * 120 + X;
                if (MapLayout.computerMapLayout[coordinates] == '█')
                {
                    if (Console.ForegroundColor != ConsoleColor.Red)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        mapLayout.Render();
                        Render();
                    }

                    if (MapLayout.mapLayout[coordinates] == '█')
                    {

                    }
                    Render();
                }
                else if (MapLayout.computerMapLayout[coordinates] == ' ')
                {
                    if (Console.ForegroundColor != ConsoleColor.White)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        mapLayout.Render();
                        Render();
                    }
                }
                else throw new Exception("Klaida zemelapio renderinime");


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

                        if (MapLayout.computerMapLayout[coordinates] == ' ')
                        x = 1;
                        break;
                }
            }
        }

        public void ToLeft()
        {
            if (X >= 0)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(MapLayout.mapLayout[coordinates]);
                X--;
                Render();
            }
        }

        public void ToRight()
        {
            if (X <= 118)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(MapLayout.mapLayout[coordinates]);
                X++;
                Render();
            }
        }

        public void MoveUp()
        {
            if (Y > 0)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(MapLayout.mapLayout[coordinates]);
                Y--;
                Render();
            }
        }

        public void MoveDown()
        {
            if (Y < 45)
            {
                Console.SetCursorPosition(X, Y);

                Console.Write(MapLayout.mapLayout[coordinates]);
                Y++;
                Render();
            }
        }

        public void Render()
        {
            TowerModel towerModel = new TowerModel(X, Y);
            towerModel.Render();

        }
    }
}
