using System;
using System.Drawing;
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

        private void resetBoard( )
        {
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    grid[ r, c ].reset( );
        }

        private bool checkForWin( )
        {
            //main logic of the program
            
            if(grid[0,0].Text != "*")
            {
                //see if there is a horizontal win
                if (grid[0,0].Text == grid[0,1].Text && grid[0,1].Text == grid[ 0, 2 ].Text)
                {
                    MessageBox.Show( grid[ 0, 0 ].Text + " wins!" );
                    return true;
                }
                //see if there is a vertical win
                if(grid[0,0].Text == grid[1,0].Text && grid[1,0].Text == grid[ 2, 0 ].Text)
                {
                    MessageBox.Show( grid[ 0, 0 ].Text +  " wins!" );
                    return true;
                }

            }
            if(grid[1,1].Text != "*")
            {
                //see if there is a horizontal win
                if (grid[ 1, 0 ].Text == grid[ 1, 1 ].Text && grid[ 1, 1 ].Text == grid[ 1, 2 ].Text)
                {
                    MessageBox.Show( grid[ 1, 0 ].Text + " wins!"  );
                    return true;
                }
                //see if there is a vertical win
                if (grid[ 0,1 ].Text == grid[ 1, 1 ].Text && grid[ 1,1 ].Text == grid[ 2, 1 ].Text)
                {
                    MessageBox.Show( grid[ 1, 1 ].Text +  " wins!");
                    return true;
                }

            }
            if(grid[2,2].Text != "*")
            {
                //see if there is a horizontal win
                if (grid[ 2, 0 ].Text == grid[ 2, 1 ].Text && grid[ 2, 1 ].Text == grid[ 2, 2 ].Text)
                {
                    MessageBox.Show( grid[ 2, 0 ].Text + " wins!" );
                    return true;
                }
                //see if there is a vertical win
                if (grid[ 0, 2 ].Text == grid[ 1, 2 ].Text && grid[ 1, 2 ].Text == grid[ 2, 2 ].Text)
                {
                    MessageBox.Show( grid[ 2,2 ].Text + " wins!");
                    return true;
                }
            }

            //check diagonal win
            if(grid[0,0].Text != "*" &&
                (grid[0,0].Text == grid[1,1].Text && grid[1,1].Text == grid[ 2, 2 ].Text))
            {
                MessageBox.Show( grid[ 2, 2 ].Text + " wins!" );
                return true;
            }
            if(grid[2,0].Text != "*" &&
                (grid[ 2, 0 ].Text == grid[ 1, 1 ].Text && grid[ 1, 1 ].Text == grid[ 0, 2 ].Text))
            {
                MessageBox.Show( grid[ 2, 0 ].Text + " wins!" );
                return true;
            }
            return false;
        }

        private bool checkForDraw( )
        {
            if (checkForWin( )) return false;

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (grid[ r, c ].Text == "*")
                        return false;
                }
            }
            MessageBox.Show( "It's a draw!" );
            return true;
        }

        private void btn_click(object o, EventArgs e )
        {
            TicTacToeButton b = (TicTacToeButton)o;
            if (xTurn)
            {
                b.BackColor = Color.Gold;
                b.Text = "X";
            }
            else
            {
                b.BackColor = Color.Crimson;
                b.Text = "O";
            }

            xTurn = !xTurn;
            if (checkForWin( ) || checkForDraw())
                resetBoard( );

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
                    //add the click event
                    grid[ r, c ].Click += new EventHandler( btn_click );
                    loc.X += TicTacToeButton.Btn_Size;
                }

                loc.Y += TicTacToeButton.Btn_Size;
                loc.X = 0;

            }

            
        }
    }
}