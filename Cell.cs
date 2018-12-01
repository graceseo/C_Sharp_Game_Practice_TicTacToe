using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Game_Practice_TicTacToe
{
    /// <summary>
    /// this class includes image propery and this class' cell type
    /// </summary>
    class Cell
    {
        private Image image;
        private string chosenCell;

        public Cell(Image image, string chosenCell)
        {
            this.image = image;
            this.chosenCell = chosenCell;
        }

        public Image Image { get => image; set => image = value; }
        public string ChosenCell { get => chosenCell; set => chosenCell = value; }
    }
}
