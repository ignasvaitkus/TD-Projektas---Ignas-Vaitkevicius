using System;
using System.Collections.Generic;
using System.Text;
using TowerDefense_Projektas.GameSettings;

namespace TowerDefense_Projektas.GUI
{
    sealed class EndWindow : Window
    {
        private Button resultButton;
        private TextBlock _titleTextBlock;


        public EndWindow() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { });

            //resultButton = new Button(20, 13, 18, 5, "No Info");

        }

        public override void Render()
        {
            base.Render();

            _titleTextBlock.Render();
            if(EnemyMovement.Winner==1) resultButton = new Button(20, 13, 18, 5, "You Won!");
            else resultButton = new Button(20, 13, 18, 5, "You Lost!");
            resultButton.Render();


            Console.SetCursorPosition(0, 0);
        }
    }
}
