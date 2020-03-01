using System;
using System.Collections.Generic;
using TowerDefense_Projektas.GameSettings;
using TowerDefense_Projektas.Interfaces;
using TowerDefense_Projektas.Map;
using TowerDefense_Projektas.ParentClass;

namespace TowerDefense_Projektas.Towers
{
    class MapRender : Tower, IMovable, IRenderable
    {
        MapLayout mapLayout = new MapLayout();
        int coordinates = 0;
        List<int> towers = new List<int>();
        static int towerRender=0;
        
        public MapRender(int x, int y) : base(x, y)
        {

        }


        public void PlaceTowers()
        {
            Console.ForegroundColor = ConsoleColor.White;
            int x = 0;
            mapLayout.RenderNewTower();
            RenderNewTower();
            while (GameStart.TowerCount<=4)
            {
                //Console.Clear();

                coordinates = 0;
                if (Y == 0) coordinates = X;
                if (Y > 0) coordinates = Y * 120 + X;
                if (MapLayout.computerMapLayout[coordinates] == '█' || towers.Contains(coordinates))
                {
                    if (Console.ForegroundColor != ConsoleColor.Red)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        mapLayout.RenderNewTower();
                        RenderNewTower();
                        if (towerRender != 0) RenderTowers();
                    }

                    if (MapLayout.mapLayout[coordinates] == '█')
                    {

                    }
                    RenderNewTower();
                    if (towerRender != 0) RenderTowers();
                }
                else if (MapLayout.computerMapLayout[coordinates] == ' ')
                {
                    if (Console.ForegroundColor != ConsoleColor.White)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        mapLayout.RenderNewTower();
                        RenderNewTower();
                        if (towerRender != 0) RenderTowers();
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
                        { 
                        x = 0;
                        if(!towers.Contains(coordinates)) towers.Add(coordinates);
                        towerRender++;
                        RenderTowers();
                            GameStart.TowerCount++;
                        }
                        break;
                }
            }
        }

        public void ToLeft()
        {
            if (X > 0)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(MapLayout.mapLayout[coordinates]);
                X--;
                RenderNewTower();
                RenderTowers();
            }
        }

        public void ToRight()
        {
            if (X < 118)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(MapLayout.mapLayout[coordinates]);
                X++;
                RenderNewTower();
                RenderTowers();
            }
        }

        public void MoveUp()
        {
            if (Y > 0)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(MapLayout.mapLayout[coordinates]);
                Y--;
                RenderNewTower();
                RenderTowers();
            }
        }

        public void MoveDown()
        {
            if (Y < 44)
            {
                Console.SetCursorPosition(X, Y);

                Console.Write(MapLayout.mapLayout[coordinates]);
                Y++;
                RenderNewTower();
                RenderTowers();
            }
        }

        public void RenderNewTower()
        {
            TowerModel towerModel = new TowerModel(X, Y);
            towerModel.RenderNewTower();

        }

        public void RenderTowers()
        {
            int xCoord=0, yCoord=0;
            for(int i=0;i<towers.Count;i++)
            {
                yCoord = 0;
                int coord = towers[i];
                if(coord!=0) yCoord = -1;
                while(coord>0)
                {
                    yCoord++;
                    coord -= 120;
                }
                if (towers[i] < 120) xCoord = towers[i];
                else xCoord = towers[i] % 120;
                Console.SetCursorPosition(xCoord, yCoord);
                Console.Write("X");
            }
        }
    }
}
