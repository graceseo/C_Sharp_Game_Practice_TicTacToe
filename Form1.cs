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
        /// It handles events from picture boxes. 
        /// if the current cell which the user chose is O, this changed a current image,
        /// and it compares neighbor cells.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ColumnClickEvent(object sender, EventArgs e)
        {
            Image currentCellImage;

            if (currentCell=="x")
            {
                currentCellImage = C_Sharp_Game_Practice_TicTacToe.Properties.Resources.ox_x;
                nextCell = "o";
            }
            else
            {
                currentCellImage = C_Sharp_Game_Practice_TicTacToe.Properties.Resources.ox_o;
                nextCell = "x";
            }

            switch ((sender as PictureBox).Name)
            {
                case "pictureBox1":
                    cellLocation[0, 0] = new Cell(currentCellImage, currentCell);
                    pictureBox1.Image = currentCellImage;
                    pictureBox1.Refresh();
                    break;
                case "pictureBox2":
                    cellLocation[0, 1] = new Cell(currentCellImage, currentCell);
                    pictureBox2.Image = currentCellImage;
                    break;
                case "pictureBox3":
                    cellLocation[0, 2] = new Cell(currentCellImage, currentCell);
                    pictureBox3.Image = currentCellImage;
                    break;
                case "pictureBox4":
                    cellLocation[1, 0] = new Cell(currentCellImage, currentCell);
                    pictureBox4.Image = currentCellImage;
                    break;
                case "pictureBox5":
                    cellLocation[1, 1] = new Cell(currentCellImage, currentCell);
                    pictureBox5.Image = currentCellImage;
                    break;
                case "pictureBox6":
                    cellLocation[1, 2] = new Cell(currentCellImage, currentCell);
                    pictureBox6.Image = currentCellImage;
                    break;
                case "pictureBox7":
                    cellLocation[2, 0] = new Cell(currentCellImage, currentCell);
                    pictureBox7.Image = currentCellImage;
                    break;
                case "pictureBox8":
                    cellLocation[2, 1] = new Cell(currentCellImage, currentCell);
                    pictureBox8.Image = currentCellImage;
                    break;
                case "pictureBox9":
                    cellLocation[2, 2] = new Cell(currentCellImage, currentCell);
                    pictureBox9.Image = currentCellImage;
                    break;
                default:
                    break;
            }
            currentCell = nextCell;
        }
    }
}
