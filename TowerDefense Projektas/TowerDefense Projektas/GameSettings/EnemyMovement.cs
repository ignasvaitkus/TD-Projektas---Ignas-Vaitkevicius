using System;
using System.Collections.Generic;
using System.Text;
using TowerDefense_Projektas.Enemies;
using TowerDefense_Projektas.Map;
using TowerDefense_Projektas.Towers;

namespace TowerDefense_Projektas.GameSettings
{
    class EnemyMovement
    {
        TowerShooting towerShooting = new TowerShooting();
        MapLayout mapLayout = new MapLayout();
        MapRender mapRender = new MapRender(0, 0, 0);

        // 0 - Down   1 - Up    2 - Left    3 - Right
        readonly int[,] moveDirections = new int[,] { { 0, 9 }, { 2, 54 }, { 0, 17 }, { 3, 29 }, { 1, 6 }, { 3, 41 }, { 0, 16 }, { 2, 87 }, { 0, 6 } };
        private static List<Enemy> enemies = new List<Enemy>();
        List<int> direction = new List<int>();
        List<int> stepsTotal = new List<int>();
        List<int> stepsMade = new List<int>();
        public int EnemyCount = 0;
        public static int GameTicks=1;
        public static int EnemyRate = 2;
        public static bool NotEnd = true;
        public static int Winner = 0;

        public void StartGame()
        {
            enemies.Add(new Enemy(0, 0, 87, 0));
            direction.Add(0);
            stepsMade.Add(0);
            stepsTotal.Add(0);
            while (NotEnd)
            {

                if (EnemyCount < 6 && GameTicks % 5 == 0)
                {
                    enemies.Add(new Enemy(0, 0, 87, 0));
                    direction.Add(0);
                    stepsMade.Add(0);
                    stepsTotal.Add(0);
                    EnemyCount++;
                }
                for(int i=0;i<enemies.Count;i++)
                {
                    if (enemies[i].X != 1)
                    {
                        direction[i] = moveDirections[enemies[i].Path, 0];

                        switch (direction[i])
                        {
                            case 0:
                                stepsTotal[i] = moveDirections[enemies[i].Path, 1];
                                if (stepsTotal[i] >= stepsMade[i])
                                {
                                    enemies[i].MoveDown();
                                    stepsMade[i]++;
                                    if (enemies[i].Path == 8 && stepsMade[i] == 6) NotEnd = false;
                                }
                                else
                                {
                                    stepsMade[i] = 0;
                                    enemies[i].Path++;
                                }

                                break;
                            case 1:
                                stepsTotal[i] = moveDirections[enemies[i].Path, 1];
                                if (stepsTotal[i] >= stepsMade[i])
                                {
                                    enemies[i].MoveUp();
                                    stepsMade[i]++;
                                }
                                else
                                {
                                    stepsMade[i] = 0;
                                    enemies[i].Path++;
                                }

                                break;
                            case 2:
                                stepsTotal[i] = moveDirections[enemies[i].Path, 1];
                                if (stepsTotal[i] >= stepsMade[i])
                                {
                                    enemies[i].MoveLeft();
                                    stepsMade[i]++;
                                }
                                else
                                {
                                    stepsMade[i] = 0;
                                    enemies[i].Path++;
                                }

                                break;
                            case 3:
                                stepsTotal[i] = moveDirections[enemies[i].Path, 1];
                                if (stepsTotal[i] >= stepsMade[i])
                                {
                                    enemies[i].MoveRight();
                                    stepsMade[i]++;
                                }
                                else
                                {
                                    stepsMade[i] = 0;
                                    enemies[i].Path++;
                                }

                                break;

                            default: throw new Exception("Klaida prieso krypties nustatyme");

                        }
                    }
                    else i++;

                }
              

                GameTicks++;
                System.Threading.Thread.Sleep(20);
                towerShooting.StartShooting(enemies);
                System.Threading.Thread.Sleep(20);
                mapLayout.RenderMapLayout();
                mapRender.RenderTowers();

                if(EnemyCount==5)
                {
                    if (enemies[4].X == 1)
                    {
                        NotEnd = false;
                        Winner = 1;
                    }
                }

            }

        }
    }
}
