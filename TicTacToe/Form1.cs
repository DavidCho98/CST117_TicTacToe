using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private TicTacToeButton[,] grid;
        public Form1( )
        {
            InitializeComponent( );

            //test the button
            TicTacToeButton tic_tac_toe_btn = new TicTacToeButton( );
            
            //set the grid            
            setGrid( );
        }

        private void setGrid( )
        {
            //place the buttons on the grid
            Point loc = new Point( 5, 5 );
            //make the array of buttons
            grid = new TicTacToeButton[ 3, 3 ];
            for(int r = 0; r < 3; r++)
            {
                for(int c = 0; c < 3; c++)
                {
                    //make a new button
                    grid[ r, c ] = new TicTacToeButton( );
                    this.Controls.Add( grid[ r, c ] );
                    grid[ r, c ].Location = loc;
                    //update location - go to next col
                    loc.Y = loc.Y + grid[ r, c ].Width + 2;
                }
                //go to beginning of next row
                loc.Y = 5;
                loc.X = loc.X + grid[ r, 0 ].Height + 2;
            }

        }
    }
}
