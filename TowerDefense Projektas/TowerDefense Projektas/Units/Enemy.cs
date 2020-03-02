using System;
using System.Collections.Generic;
using System.Text;
using TowerDefense_Projektas.Units;

namespace TowerDefense_Projektas.Enemies
{
    class Enemy:Unit
    {
        private int id;
        public int Path;
        public int X;
        public int Y;
        public Enemy(int id,int path, int x, int y) : base(x, y)
        {
            X = x;
            Y = y;
            Path = path;
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

        public void MoveUp()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
            Y--;
            Console.SetCursorPosition(X, Y);
            Console.Write("#");
        }
        public void MoveDown()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
            Y++;
            Console.SetCursorPosition(X, Y);
            Console.Write("#");
        }
        public void MoveLeft()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
            X--;
            Console.SetCursorPosition(X, Y);
            Console.Write("#");
        }
        public void MoveRight()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
            X++;
            Console.SetCursorPosition(X, Y);
            Console.Write("#");
        }
    }
}
