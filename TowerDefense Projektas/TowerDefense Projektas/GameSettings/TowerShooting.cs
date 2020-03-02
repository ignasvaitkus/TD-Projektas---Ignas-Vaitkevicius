using System;
using System.Collections.Generic;
using System.Text;
using TowerDefense_Projektas.Enemies;
using TowerDefense_Projektas.Towers;

namespace TowerDefense_Projektas.GameSettings
{
    class TowerShooting
    {
        static int DeadTower = 0;

        public void StartShooting(List<Enemy> enemies)
        {

            for (int i = 0; i < MapRender.tower.Count; i++)
            {
                int towerX = MapRender.tower[i].GetX();
                int towerY = MapRender.tower[i].GetY();
                    int straightKey = 0;

                int enemyX = 1;
                int enemyY = 1;
                try
                {
                    enemyX = enemies[DeadTower].X;
                    enemyY = enemies[DeadTower].Y;
                }
                catch (ArgumentOutOfRangeException) { }
                    if (enemyX != 1)
                    {


                        int length;
                        int length1;
                        Console.SetCursorPosition(towerX, towerY);
                        if (enemyX > towerX)
                            length = enemyX - towerX;
                        else length = towerX - enemyX;
                        if (enemyY > towerY)
                            length1 = enemyY - towerY;
                        else length1 = towerY - enemyY;
                        int divider = 0;
                        int xas;
                        int xCount = 0;

                    if(length1+length>30)
                    {
                        i = 10;
                        break;
                    }
                         
                        for (int j = 0; j < length || j < length1; j++)
                        {
                            if (length > length1 && length1 != 0)
                                divider = length / length1;
                            else if (length != 0 && length1 != 0) divider = length1 / length;

                            if (towerX == enemyX && straightKey == 0)
                            {
                                if (towerY > enemyY) towerY--;
                                else towerY++;
                                Console.SetCursorPosition(towerX, towerY);
                            }
                            else if (towerY == enemyY && straightKey == 0)
                            {
                                if (towerX > enemyX) towerX--;
                                else towerX++;
                                Console.SetCursorPosition(towerX, towerY);
                            }
                            else if (xCount % divider == 0)
                            {
                                if (towerY < enemyY && towerX < enemyX)
                                { towerX++; towerY++; }
                                else if (towerY > enemyY && towerX < enemyX) { towerX++; towerY--; }
                                else if (towerY < enemyY && towerX > enemyX) { towerX--; towerY++; }
                                else if (towerY > enemyY && towerX > enemyX) { towerX--; towerY--; }
                                Console.SetCursorPosition(towerX, towerY);
                                straightKey = 1;
                            }
                            else
                            {
                                if (towerX < enemyX)
                                    towerX++;
                                else towerX--;
                                Console.SetCursorPosition(towerX, towerY);
                                straightKey = 1;
                            }


                            Console.Write("◌");
                            xCount++;;
                        }
                        if (towerX == enemies[DeadTower].X && towerY == enemies[DeadTower].Y)
                        {
                            Random rnd = new Random();
                            int dodged = rnd.Next(0, 100);
                        if (dodged % 2 == 0)
                        {
                            enemies[DeadTower].X = 1;
                            enemies[DeadTower].Y = 1;
                            DeadTower++;
                            i = 10;
                            break;
                        }
                        else
                        {
                            i = 10;
                            break;
                        }
                        }
                    }
                    else DeadTower++;
                

            }
        }
    }
}
