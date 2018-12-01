using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Game_Practice_TicTacToe
{
    public partial class Form1 : Form
    {
        string currentCell = "x"; //this is what the current user's cell type
        string nextCell = "o"; //this is what the next user's cell type
        Cell[,] cellLocation = new Cell[3, 3];
        Image currentCellImage;

        /// <summary>
        /// when the form is initialized, all picturebox's click event call one handler
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Click += new EventHandler(ColumnClickEvent);
            pictureBox2.Click += new EventHandler(ColumnClickEvent);
            pictureBox3.Click += new EventHandler(ColumnClickEvent);
            pictureBox4.Click += new EventHandler(ColumnClickEvent);
            pictureBox5.Click += new EventHandler(ColumnClickEvent);
            pictureBox6.Click += new EventHandler(ColumnClickEvent);
            pictureBox7.Click += new EventHandler(ColumnClickEvent);
            pictureBox8.Click += new EventHandler(ColumnClickEvent);
            pictureBox9.Click += new EventHandler(ColumnClickEvent);
        }

        /// <summary>
        /// It handles events from picture boxes' click. 
        /// if the current cell which the user chose is O, this changed a current image,
        /// and it compares neighbor cells.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ColumnClickEvent(object sender, EventArgs e)
        {

            if (currentCell == "x")
            {
                currentCellImage = C_Sharp_Game_Practice_TicTacToe.Properties.Resources.ox_x;
                nextCell = "o";
            }
            else
            {
                currentCellImage = C_Sharp_Game_Practice_TicTacToe.Properties.Resources.ox_o;
                nextCell = "x";
            }

            //this variable recieve a clicked picturebox properties --Grace Seo
            PictureBox clickedPicturebox = (sender as PictureBox);

            if (clickedPicturebox.Image == null)
            {
                clickedPicturebox.Image = currentCellImage;

                //Check picturebox's name, and call a method which inputs cell into a cell array, and check it's winner
                switch (clickedPicturebox.Name)
                {
                    case "pictureBox1":
                        CompareCell(0, 0);
                        break;
                    case "pictureBox2":
                        CompareCell(0, 1);
                        break;
                    case "pictureBox3":
                        CompareCell(0, 2);
                        break;
                    case "pictureBox4":
                        CompareCell(1, 0);
                        break;
                    case "pictureBox5":
                        CompareCell(1, 1);
                        break;
                    case "pictureBox6":
                        CompareCell(1, 2);
                        break;
                    case "pictureBox7":
                        CompareCell(2, 0);
                        break;
                    case "pictureBox8":
                        CompareCell(2, 1);
                        break;
                    case "pictureBox9":
                        CompareCell(2, 2);
                        break;
                    default:
                        break;
                }
                currentCell = nextCell; //only this picturebox is empty, currentCell will be changed.
            }
        }
        /// <summary>
        /// inputs a cell into the cell array, and check it's winner by using row and column parameters
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public void CompareCell(int row, int column)
        {
            cellLocation[row,column] = new Cell(currentCellImage, currentCell);
        }
    }
}
