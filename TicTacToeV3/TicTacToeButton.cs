using System.Windows.Forms;

namespace TicTacToeV3
{
    class TicTacToeButton : Button
    {
        public bool Occupied = false;
        public static int Btn_Size = 75;
        

        public TicTacToeButton( )
        {
            this.Width = this.Height = Btn_Size;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Text = "*";
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new System.Drawing.Font( "Consolas", 25 );
        }

        public void reset( )
        {
            //reset the button to its original state
            this.BackColor = System.Drawing.Color.LightGray;
            this.Text = "*";

        }
    }
}
