﻿using System;
using System.Collections.Generic;
using System.Text;
using TowerDefense_Projektas.Map;
using TowerDefense_Projektas.Towers;

namespace TowerDefense_Projektas.GameSettings
{
    class GameStart
    {
        MapLayout mapLayout = new MapLayout();

        MapRender mapRender = new MapRender(0, 0, 0);

        EnemyMovement enemyMovement = new EnemyMovement();

        public static int TowerCount = 0;
        public void GameLoop()
        {
            mapLayout.Map();

            mapLayout.ComputerMap();

            mapRender.PlaceTowers();
            mapLayout.RenderMapLayout();
            mapRender.RenderTowers();
            Console.ForegroundColor = ConsoleColor.Green;
            enemyMovement.StartGame();

            
        }
    }
}
