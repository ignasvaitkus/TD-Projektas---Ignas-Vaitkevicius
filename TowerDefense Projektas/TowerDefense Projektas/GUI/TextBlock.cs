using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense_Projektas.GUI
{
    sealed class TextBlock : GuiObject
    {
        private List<TextLine> _textBlocks = new List<TextLine>();

        public TextBlock(int x, int y, int width, List<string> textList) : base(x, y, width, 0)
        {
            for (int i = 0; i < textList.Count; i++)
            {
                _textBlocks.Add(new TextLine(x, y + i, width, textList[i]));
            }
        }

        public override void Render()
        {
            for (int i = 0; i < _textBlocks.Count; i++)
            {
                _textBlocks[i].Render();
            }
        }
    }
}
