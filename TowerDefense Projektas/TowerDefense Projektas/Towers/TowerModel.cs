using System;
using TowerDefense_Projektas.Interfaces;

namespace TowerDefense_Projektas.Towers
{
    class TowerModel : IRenderable
    {
        int x;
        int y;
        public TowerModel(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        private string middle = "X";


        public void RenderNewTower()
        {
            
                Console.SetCursorPosition(x, y);
                Console.WriteLine(middle);

        }
    }
}
