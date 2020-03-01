using System;
using System.Collections.Generic;
using TowerDefense_Projektas.Interfaces;

namespace TowerDefense_Projektas.Map
{
    class MapLayout : IRenderable
    {
        string mapLayout;
        public static int[,] mapCoordinates = new int[Console.WindowHeight + 1, Console.WindowWidth + 1];
        public void Map()
        {
            List<string> mapLine = new List<string>();

            mapLine.Add("                                                                               ██             ██                        ");
            mapLine.Add("                                                                               ██             ██                        ");
            mapLine.Add("                                                                               ██             ██                        ");
            mapLine.Add("                                                                               ██             ██                        ");
            mapLine.Add("                                                                               ██             ██                        ");
            mapLine.Add("                                                                               ██             ██                        ");
            mapLine.Add("                                                                               ██             ██                        ");
            mapLine.Add("                         ████████████████████████████████████████████████████████             ██                        ");
            mapLine.Add("                         ██                                                                   ██                        ");
            mapLine.Add("                         ██                                                                   ██                        ");
            mapLine.Add("                         ██                                                                   ██                        ");
            mapLine.Add("                         ██                                                                   ██                        ");
            mapLine.Add("                         ██                                                                   ██                        ");
            mapLine.Add("                         ██             ████████████████████████████████████████████████████████                        ");
            mapLine.Add("                         ██             ██                                                                              ");
            mapLine.Add("                         ██             ██                                                                              ");
            mapLine.Add("                         ██             ██                                                                              ");
            mapLine.Add("                         ██             ██                                                                              ");
            mapLine.Add("                         ██             ██             ██████████████████████████████████████████████████████████       ");
            mapLine.Add("                         ██             ██             ██                                                      ██       ");
            mapLine.Add("                         ██             ██             ██                                                      ██       ");
            mapLine.Add("                         ██             ██             ██                                                      ██       ");
            mapLine.Add("                         ██             ██             ██                                                      ██       ");
            mapLine.Add("                         ██             ██             ██                                                      ██       ");
            mapLine.Add("                         ██             ██             ██            █████████████████████████████             ██       ");
            mapLine.Add("                         ██             █████████████████            ██                         ██             ██       ");
            mapLine.Add("                         ██                                          ██                         ██             ██       ");
            mapLine.Add("                         ██                                          ██                         ██             ██       ");
            mapLine.Add("                         ██                                          ██                         ██             ██       ");
            mapLine.Add("                         ██                                          ██                         ██             ██       ");
            mapLine.Add("                         ██                                          ██                         ██             ██       ");
            mapLine.Add("                         ██████████████████████████████████████████████                         ██             ██       ");
            mapLine.Add("                                                                                                ██             ██       ");
            mapLine.Add("                                                                                                ██             ██       ");
            mapLine.Add("                                                                                                ██             ██       ");
            mapLine.Add("        ██████████████████████████████████████████████████████████████████████████████████████████             ██       ");
            mapLine.Add("        ██                                                                                                     ██       ");
            mapLine.Add("        ██                                                                                                     ██       ");
            mapLine.Add("        ██                                                                                                     ██       ");
            mapLine.Add("        ██                                                                                                     ██       ");
            mapLine.Add("        ██                                                                                                     ██       ");
            mapLine.Add("        ██             ██████████████████████████████████████████████████████████████████████████████████████████       ");
            mapLine.Add("        ██             ██                                                                                               ");
            mapLine.Add("        ██             ██                                                                                               ");
            mapLine.Add("        ██             ██                                                                                              .");


            mapLayout = string.Concat(mapLine);
        }

        public void Render()
        {
            Console.WriteLine(mapLayout);
        }

        public void GetMapCoordinates()
        {
            int x = 0;
            int exit = 0;
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i <= Console.WindowHeight && exit != 1; i++)
            {
                for (int j = 0; j <= Console.WindowWidth; j++)
                {
                    if (mapLayout[x] == ' ') mapCoordinates[i, j] = 0;
                    else if (mapLayout[x] == '█') mapCoordinates[i, j] = 1;
                    else if (mapLayout[x] == '.')
                    {
                        exit = 1;
                        mapCoordinates[i, j + 1] = 0;
                        break;
                    }
                    else throw new Exception("Ivyko klaida GetMapCoordinates() skaiciavimuose");
                    x++;
                }
            }
        }
    }
}
