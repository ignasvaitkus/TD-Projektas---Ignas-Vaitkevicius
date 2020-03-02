using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense_Projektas.GUI
{
    class Frame : GuiObject
    {
        private char _renderChar;

        public Frame(int x, int y, int width, int height, char renderChar) : base(x, y, width, height)
        {
            RenderChar = renderChar;
        }

        public char RenderChar
        {
            get { return _renderChar; }
            set
            {
                _renderChar = value;
                Render();
            }
        }

        public override void Render()
        {
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                if (i == 0 || i == Height - 1)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        Console.Write(RenderChar);
                    }
                }
                else
                {
                    Console.Write(RenderChar);
                    for (int j = 0; j < Width - 2; j++)
                    {
                        Console.Write(' ');
                    }

                    Console.Write(RenderChar);
                }
            }
        }
    }
}
