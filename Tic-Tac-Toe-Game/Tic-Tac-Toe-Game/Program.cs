using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Welcome to Tic Tac Toe Game");
            tic_tac_toe_game tttgame = new tic_tac_toe_game();
            //Create empty board
            tttgame.CreateBoard();

            char[] board = tttgame.CreateBoard();
            tttgame.GameInput();
            tttgame.ShowBoard(board);
            Console.ReadKey();
        }
    }
}
