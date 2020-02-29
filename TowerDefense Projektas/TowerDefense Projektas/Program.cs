using System;
using TowerDefense_Projektas.Map;

namespace TowerDefense_Projektas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 45;
            MapLayout mapLayout = new MapLayout();
            mapLayout.Map();
            mapLayout.Render();

        }
    }
}
