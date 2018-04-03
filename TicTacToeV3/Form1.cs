﻿using System.Drawing;
using System.Windows.Forms;

//Lydia's version

namespace TicTacToeV3
{
    public partial class Form1 : Form
    {
        //creates a reference to a grid of buttons
        private TicTacToeButton[,] grid;
        private bool xTurn = true;
        private static int freeCells = 9;

        public Form1( )
        {
            InitializeComponent( );
            this.BackColor = Color.Black;
            setUpGrid( );
        }

        public void setUpGrid( )
        {
            //make space for the grid
            grid = new TicTacToeButton[ 3, 3 ];
            Point loc = new Point( 0, 0 );


            //loop over the rows
            for (int r = 0; r < 3; r++)
            {
                //loop over ea col in this row
                for (int c = 0; c < 3; c++)
                {
                    //create the buttons and place them in the 2-d array
                    grid[ r, c ] = new TicTacToeButton( );
                    //put the button on the form
                    this.Controls.Add( grid[ r, c ] );
                    //set the location for this button
                    grid[ r, c ].Location = loc;
                    loc.X += TicTacToeButton.Btn_Size;
                }

                loc.Y += TicTacToeButton.Btn_Size;
                loc.X = 0;

            }

            //place the buttons on the form in the correct position
        }
    }
}