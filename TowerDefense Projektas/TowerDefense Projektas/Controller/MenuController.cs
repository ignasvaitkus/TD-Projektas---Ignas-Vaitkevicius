using System;
using TowerDefense_Projektas.Map;
using TowerDefense_Projektas.Towers;

namespace TowerDefense_Projektas.Controller
{
    class MenuController
    {
        MapLayout mapLayout = new MapLayout();
        Tower tower = new Tower(110, 10);
        public void Start()
        {
            mapLayout.Map(); //nupiesia zemelapi
            mapLayout.GetMapCoordinates();
            tower.MoveTower();
            Console.ReadKey();
        }
    }
}
