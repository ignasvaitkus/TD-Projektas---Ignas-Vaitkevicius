using System;
using System.Collections.Generic;
using System.Text;
using TowerDefense_Projektas.Enemies;

namespace TowerDefense_Projektas.GameSettings
{
    class EnemyMovement
    {
        // 0 - Down   1 - Up    2 - Left    3 - Right
        int[,] moveDirections = new int[,] { { 0, 12 }, { 2, 54 }, { 0, 19 }, { 3, 30 }, { 1, 8 }, { 3, 41 }, { 0, 18 }, { 2, 87 }, { 0, 7 } };
        List<Enemy> enemies = new List<Enemy>();

        public void StartMovement()
        {
            enemies.Add(new Enemy(0,87,0));
            Console.WriteLine(enemies[0]);
        }
    }
}
