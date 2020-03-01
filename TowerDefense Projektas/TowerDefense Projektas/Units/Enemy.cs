using System;
using System.Collections.Generic;
using System.Text;
using TowerDefense_Projektas.Units;

namespace TowerDefense_Projektas.Enemies
{
    class Enemy:Unit
    {
        private int id;

        public Enemy(int id, int x, int y) : base(x, y)
        {

            this.id = id;
        }


        public int GetId()
        {
            return id;
        }

        public override string ToString()
        {
            Console.SetCursorPosition(X, Y);
            return "#"; 
        }
    }
}
