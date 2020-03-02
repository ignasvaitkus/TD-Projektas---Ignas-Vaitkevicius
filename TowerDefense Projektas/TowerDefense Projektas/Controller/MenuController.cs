using System;
using TowerDefense_Projektas.GameSettings;
using TowerDefense_Projektas.GUI;

namespace TowerDefense_Projektas.Controller
{
    class MenuController
    {
        GameStart gameStart = new GameStart();
        MenuWindow menuWindow = new MenuWindow();
        EndWindow endWindow = new EndWindow();
        int menu;
        public void Start()
        {
            menuWindow.Render();
            
            while (menu == 0)
            {
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);

                switch (pressedChar.Key)
                {
                    case ConsoleKey.Q:
                        menu = 1;
                        break;
                    case ConsoleKey.P:
                        Console.WindowHeight = 45;
                        menu = 2;
                        break;
                }
            }
            gameStart.GameLoop();

            Console.Clear();
            endWindow.Render();

            Console.ReadKey();
        }
    }
}
