using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense_Projektas.GUI
{
    sealed class MenuWindow : Window
    {
        private Button _startButton;

        private Button _quitButton;
        private TextBlock _titleTextBlock;


        public MenuWindow() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { });

            _startButton = new Button(20, 13, 18, 5, "Start-P");

            _quitButton = new Button(80, 13, 18, 5, "Quit-Q");
        }

        public override void Render()
        {
            base.Render();

            _titleTextBlock.Render();

            _startButton.Render();

            _quitButton.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
}
