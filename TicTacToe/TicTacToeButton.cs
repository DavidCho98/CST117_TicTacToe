using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class TicTacToeButton : Button
    {
        public TicTacToeButton( )
        {
            this.Width = this.Height = 60;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Font = new System.Drawing.Font( "Consolas", 30.0F );
            this.Text = "*";
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        }
    }
}
