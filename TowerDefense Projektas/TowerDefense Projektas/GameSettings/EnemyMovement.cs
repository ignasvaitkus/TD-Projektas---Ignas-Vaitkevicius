using System;
using System.Collections.Generic;
using System.Text;
using TowerDefense_Projektas.Enemies;

namespace TowerDefense_Projektas.GameSettings
{
    class EnemyMovement
    {
        // 0 - Down   1 - Up    2 - Left    3 - Right
        readonly int[,] moveDirections = new int[,] { { 0, 9 }, { 2, 54 }, { 0, 17 }, { 3, 29 }, { 1, 6 }, { 3, 41 }, { 0, 16 }, { 2, 87 }, { 0, 4 } };
        public static List<Enemy> enemies = new List<Enemy>();
        List<int> direction = new List<int>();
        List<int> stepsTotal = new List<int>();
        List<int> stepsMade = new List<int>();
        public int EnemyCount = 0;
        public static int GameTicks=0;
        public static int EnemyRate = 2;
        public static bool NotEnd = true;

        public void StartMovement()
        {
            enemies.Add(new Enemy(0, 0, 87, 0));
            direction.Add(0);
            stepsMade.Add(0);
            stepsTotal.Add(0);
            while (NotEnd)
            {
                
                /*if(EnemyCount<6) */
                //enemies.Add(new Enemy( 0,0, 87, 0));
                //direction.Add(0);
                //stepsMade.Add(0);
                //stepsTotal.Add(0);
                for(int i=0;i<enemies.Count;i++)
                {
                    direction[i] = moveDirections[enemies[i].Path, 0];

                    switch(direction[i])
                    {
                        case 0:
                            stepsTotal[i]= moveDirections[enemies[i].Path, 1];
                            if (stepsTotal[i] >= stepsMade[i])
                            {
                                enemies[i].MoveDown();
                                stepsMade[i]++;
                            }
                            else
                            {
                                stepsMade[i]=0;
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
                                stepsMade[i]=0;
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
                                stepsMade[i]=0;
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
                                stepsMade[i]=0;
                                enemies[i].Path++;
                            }

                            break;

                        default: throw new Exception("Klaida prieso krypties nustatyme");

                    }

                }
              


                System.Threading.Thread.Sleep(40);
                //Console.WriteLine(moveDirections[1, 0]);
            }
        }
    }
}
