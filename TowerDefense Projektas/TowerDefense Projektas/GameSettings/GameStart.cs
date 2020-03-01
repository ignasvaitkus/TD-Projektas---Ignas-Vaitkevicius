using System;
using System.Collections.Generic;
using System.Text;
using TowerDefense_Projektas.Map;
using TowerDefense_Projektas.Towers;

namespace TowerDefense_Projektas.GameSettings
{
    class GameStart
    {
        MapLayout mapLayout = new MapLayout();
        MapRender tower = new MapRender(0, 0);
        public static int TowerCount = 0;
        public void GameLoop()
        {
            mapLayout.Map();

            mapLayout.ComputerMap();

            tower.PlaceTowers();


        }
    }
}
