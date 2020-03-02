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
        public static List<Tower> tower = new List<Tower>();
        static int towerRender=0;
        
        public MapRender(int id,int x, int y) : base(id,x, y)
        {
       
        }


        public void PlaceTowers()
        {
            Console.ForegroundColor = ConsoleColor.White;
            int x = 0;
            mapLayout.RenderMapLayout();
            RenderMapLayout();
            while (x!=1)
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
                        mapLayout.RenderMapLayout();
                        RenderMapLayout();
                        if (towerRender != 0) RenderTowers();
                    }

                    if (MapLayout.mapLayout[coordinates] == '█')
                    {

                    }
                    RenderMapLayout();
                    if (towerRender != 0) RenderTowers();
                }
                else if (MapLayout.computerMapLayout[coordinates] == ' ')
                {
                    if (Console.ForegroundColor != ConsoleColor.White)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        mapLayout.RenderMapLayout();
                        RenderMapLayout();
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
                        if(!towers.Contains(coordinates) && GameStart.TowerCount <= 4) towers.Add(coordinates);
                        towerRender++;
                            GameStart.TowerCount++;
                            RenderTowers();
                        }
                        break;

                        case ConsoleKey.S:
                        x = 1;
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
                RenderMapLayout();
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
                RenderMapLayout();
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
                RenderMapLayout();
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
                RenderMapLayout();
                RenderTowers();
            }
        }

        public void RenderMapLayout()
        {
            TowerModel towerModel = new TowerModel(X, Y);
            towerModel.RenderMapLayout();

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
                tower.Add(new Tower(GameStart.TowerCount,xCoord, yCoord));
                Console.Write("X");
            }
        }
    }
}
