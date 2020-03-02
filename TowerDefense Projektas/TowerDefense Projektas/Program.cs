using System;
using TowerDefense_Projektas.Controller;

namespace TowerDefense_Projektas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.CursorVisible = false;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WindowHeight =30;
            MenuController menu = new MenuController();
            menu.Start();

        }
    }
}
