using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game
{
    class tic_tac_toe_game
    {
        public void CreateBoard()
        {
            char[] board = new char[10]; //Char storing 10 value 
            //Length property returns the number of Char objects in this instance
            for (int StartingIndex = 0; StartingIndex < board.Length; StartingIndex++) //StartingIndex = 0 ; StartingIndex < 10 ; +1 
            //game board intilized with empty | and
            //zero th index ignored
             Console.WriteLine(board[StartingIndex] = '|'); // print 10 | 
        }
    }
}
