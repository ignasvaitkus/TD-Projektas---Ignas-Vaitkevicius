using System;
using System.Collections.Generic;
using System.Text;
using TowerDefense_Projektas.Interfaces;

namespace TowerDefense_Projektas.Map
{
    class MapLayout: IRenderable
    {
        string mapLayout;
        public void Map()
        {
            List<string> words = new List<string>();

            words.Add("                                                                               ██             ██                        ");
            words.Add("                                                                               ██             ██                        ");
            words.Add("                                                                               ██             ██                        ");
            words.Add("                                                                               ██             ██                        ");
            words.Add("                                                                               ██             ██                        ");
            words.Add("                                                                               ██             ██                        ");
            words.Add("                                                                               ██             ██                        ");
            words.Add("                         ████████████████████████████████████████████████████████             ██                        ");
            words.Add("                         ██                                                                   ██                        ");
            words.Add("                         ██                                                                   ██                        ");
            words.Add("                         ██                                                                   ██                        ");
            words.Add("                         ██                                                                   ██                        ");
            words.Add("                         ██                                                                   ██                        ");
            words.Add("                         ██             ████████████████████████████████████████████████████████                        ");
            words.Add("                         ██             ██                                                                              ");
            words.Add("                         ██             ██                                                                              ");
            words.Add("                         ██             ██                                                                              ");
            words.Add("                         ██             ██                                                                              ");
            words.Add("                         ██             ██             ██████████████████████████████████████████████████████████       ");
            words.Add("                         ██             ██             ██                                                      ██       ");
            words.Add("                         ██             ██             ██                                                      ██       ");
            words.Add("                         ██             ██             ██                                                      ██       ");
            words.Add("                         ██             ██             ██                                                      ██       ");
            words.Add("                         ██             ██             ██                                                      ██       ");
            words.Add("                         ██             ██             ██            █████████████████████████████             ██       ");
            words.Add("                         ██             █████████████████            ██                         ██             ██       ");
            words.Add("                         ██                                          ██                         ██             ██       ");
            words.Add("                         ██                                          ██                         ██             ██       ");
            words.Add("                         ██                                          ██                         ██             ██       ");
            words.Add("                         ██                                          ██                         ██             ██       ");
            words.Add("                         ██                                          ██                         ██             ██       ");
            words.Add("                         ██████████████████████████████████████████████                         ██             ██       ");
            words.Add("                                                                                                ██             ██       ");
            words.Add("                                                                                                ██             ██       ");
            words.Add("                                                                                                ██             ██       ");
            words.Add("        ██████████████████████████████████████████████████████████████████████████████████████████             ██       ");
            words.Add("        ██                                                                                                     ██       ");
            words.Add("        ██                                                                                                     ██       ");
            words.Add("        ██                                                                                                     ██       ");
            words.Add("        ██                                                                                                     ██       ");
            words.Add("        ██                                                                                                     ██       ");
            words.Add("        ██             ██████████████████████████████████████████████████████████████████████████████████████████       ");
            words.Add("        ██             ██                                                                                               ");
            words.Add("        ██             ██                                                                                               ");
            words.Add("        ██             ██                                                                                               ");


            mapLayout = string.Concat(words);
        }

        public void Render()
        {

            Console.WriteLine(mapLayout);
        }
    }
}
