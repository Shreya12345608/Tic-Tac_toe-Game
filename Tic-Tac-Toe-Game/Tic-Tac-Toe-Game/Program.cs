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
            //Console.WriteLine("Welcome to TicTacToe game");
            tic_tac_toe_game ticTacToe = new tic_tac_toe_game();
            Console.WriteLine("Tic Tac Toe Game");
            char[] board = ticTacToe.CreateBoard();
            //loop till all empty spaces are filled
            for (int i = 1; i < board.Length; i++)
            {
                ticTacToe.GameInput();
                ticTacToe.ShowBoard(board);
                board = ticTacToe.UserMove(board);
                ticTacToe.ShowBoard(board);
                Console.ReadKey();
            }
        }
    }
}
