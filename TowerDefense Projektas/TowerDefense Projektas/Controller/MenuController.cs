using System;
using TowerDefense_Projektas.Map;
using TowerDefense_Projektas.Towers;

namespace TowerDefense_Projektas.Controller
{
    class MenuController
    {
        MapLayout mapLayout = new MapLayout();
        Tower tower = new Tower(0, 0);
        public void Start()
        {
            mapLayout.Map(); //nupiesia zemelapi
            mapLayout.ComputerMap();
            //Console.Clear();

            //mapLayout.GetMapCoordinates();

            tower.MoveTower();
           // Console.ReadKey();
        }
    }
}
