using System;
using TowerDefense_Projektas.GameSettings;

namespace TowerDefense_Projektas.Controller
{
    class MenuController
    {
        GameStart gameStart = new GameStart();
        public void Start()
        {
            gameStart.GameLoop();

            Console.ReadKey();
        }
    }
}
