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
        /// <summary>
        /// Taking Random Value b/w 0-2
        /// Check if  Random Value  == 0 then Playerplay First and input will be X 
        ///  Check if  Random Value  == 1 then Computerplay First and input will be 0 
        /// </summary>
        public void GameInput()
         {
            Random random = new Random();
            int RandomValue = random.Next(0,2);
            if (RandomValue == 0)
         /// Check if  Random Value  == 0 then Playerplay First and input will be X 
                Console.WriteLine("Player play first. Input Will Be X");
            else
         ///  Check if  Random Value  == 1 then Computerplay First and input will be 0 
                Console.WriteLine("Computer play first.  Input Will Be 0");

         }

    }           
}

