﻿using System;
using System.Collections.Generic;
using TowerDefense_Projektas.Interfaces;

namespace TowerDefense_Projektas.Map
{
    class MapLayout : IRenderable
    {
        public static string mapLayout;
        public static string computerMapLayout;
        
        
            
        
        public List<string> mapLine = new List<string>();
        public void Map()
        {
            

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
            mapLine.Clear();
        }

        public void ComputerMap()
        {


            mapLine.Add("                                                                               █████████████████                        ");
            mapLine.Add("                                                                               █████████████████                        ");
            mapLine.Add("                                                                               █████████████████                        ");
            mapLine.Add("                                                                               █████████████████                        ");
            mapLine.Add("                                                                               █████████████████                        ");
            mapLine.Add("                                                                               █████████████████                        ");
            mapLine.Add("                                                                               █████████████████                        ");
            mapLine.Add("                         ███████████████████████████████████████████████████████████████████████                        ");
            mapLine.Add("                         ███████████████████████████████████████████████████████████████████████                        ");
            mapLine.Add("                         ███████████████████████████████████████████████████████████████████████                        ");
            mapLine.Add("                         ███████████████████████████████████████████████████████████████████████                        ");
            mapLine.Add("                         ███████████████████████████████████████████████████████████████████████                        ");
            mapLine.Add("                         ███████████████████████████████████████████████████████████████████████                        ");
            mapLine.Add("                         ███████████████████████████████████████████████████████████████████████                        ");
            mapLine.Add("                         █████████████████                                                                              ");
            mapLine.Add("                         █████████████████                                                                              ");
            mapLine.Add("                         █████████████████                                                                              ");
            mapLine.Add("                         █████████████████                                                                              ");
            mapLine.Add("                         █████████████████             ██████████████████████████████████████████████████████████       ");
            mapLine.Add("                         █████████████████             ██████████████████████████████████████████████████████████       ");
            mapLine.Add("                         █████████████████             ██████████████████████████████████████████████████████████       ");
            mapLine.Add("                         █████████████████             ██████████████████████████████████████████████████████████       ");
            mapLine.Add("                         █████████████████             ██████████████████████████████████████████████████████████       ");
            mapLine.Add("                         █████████████████             ██████████████████████████████████████████████████████████       ");
            mapLine.Add("                         █████████████████             ██████████████████████████████████████████████████████████       ");
            mapLine.Add("                         ██████████████████████████████████████████████                         █████████████████       ");
            mapLine.Add("                         ██████████████████████████████████████████████                         █████████████████       ");
            mapLine.Add("                         ██████████████████████████████████████████████                         █████████████████       ");
            mapLine.Add("                         ██████████████████████████████████████████████                         █████████████████       ");
            mapLine.Add("                         ██████████████████████████████████████████████                         █████████████████       ");
            mapLine.Add("                         ██████████████████████████████████████████████                         █████████████████       ");
            mapLine.Add("                         ██████████████████████████████████████████████                         █████████████████       ");
            mapLine.Add("                                                                                                █████████████████       ");
            mapLine.Add("                                                                                                █████████████████       ");
            mapLine.Add("                                                                                                █████████████████       ");
            mapLine.Add("        █████████████████████████████████████████████████████████████████████████████████████████████████████████       ");
            mapLine.Add("        █████████████████████████████████████████████████████████████████████████████████████████████████████████       ");
            mapLine.Add("        █████████████████████████████████████████████████████████████████████████████████████████████████████████       ");
            mapLine.Add("        █████████████████████████████████████████████████████████████████████████████████████████████████████████       ");
            mapLine.Add("        █████████████████████████████████████████████████████████████████████████████████████████████████████████       ");
            mapLine.Add("        █████████████████████████████████████████████████████████████████████████████████████████████████████████       ");
            mapLine.Add("        █████████████████████████████████████████████████████████████████████████████████████████████████████████       ");
            mapLine.Add("        █████████████████                                                                                               ");
            mapLine.Add("        █████████████████                                                                                               ");
            mapLine.Add("        █████████████████                                                                                              .");


            computerMapLayout = string.Concat(mapLine);
        }

        public void RenderMapLayout()
        {
            Console.SetCursorPosition(0,0);
                Console.Write(mapLayout);
            
        }


    }
}
