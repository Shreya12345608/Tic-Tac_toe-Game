using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game
{
    class tic_tac_toe_game
    {/// <summary>
     /// Method to create an empty board 
     /// </summary>
     /// <returns> return an board</returns>
        public char[] CreateBoard()
        {
            char[] board = new char[10]; //Char storing 10 value 
            //Length property returns the number of Char objects in this instance
            for (int StartingIndex = 0; StartingIndex < board.Length; StartingIndex++) //StartingIndex = 0 ; StartingIndex < 10 ; +1 
               //game board intilized with empty 
                //zero th index ignored
                 // space 10 enpty 
                board[StartingIndex] = ' ';
              //return value of board
           return board;
        }
        /// <summary>
        /// UC2
        /// Taking Random Value b/w 0-2
        /// Check if  Random Value  == 0 then Playerplay First and input will be X 
        ///  Check if  Random Value  == 1 then Computerplay First and input will be 0 
        /// </summary>
        public void GameInput()
        {

            Random random = new Random();
            int RandomValue = random.Next(0, 2);
            if (RandomValue == 0)
                /// Check if  Random Value  == 0 then Playerplay First and input will be X 
                Console.WriteLine("Player play first. Input Will Be X");
            else
                ///  Check if  Random Value  == 1 then Computerplay First and input will be 0 
                Console.WriteLine("Computer play first.  Input Will Be 0");
           
        }
        /// <summary>
        /// UC3
        /// Create a Board vertical and horizontal using char 10
        /// form public char[] CreateBoard()
        /// </summary>
        /// <param name="board"></param>
        public void ShowBoard(char[] board)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
            Console.WriteLine("     |     |      ");
        }
        //user making his move
        public char[] getUserMove(char[] board)
        {
            //Select location in Your Board Where you want your 0
            Console.WriteLine("Select The Location On Board:  ");
            //Store in Int Variable
            int ExactLocation = Convert.ToInt32(Console.ReadLine());
            //validating user location
            //while loop check if ExactLocation is (less than)9 And  ExactLoaction is (greater) than 1
            while (ExactLocation > 9 || ExactLocation < 1)
            {
                // if other than this it will give an error
                Console.WriteLine("Invalid exactLocation, select the location on Board b/w 1 to 9 :  ");
                ExactLocation = Convert.ToInt32(Console.ReadLine()); // ip
                ExactLocation = checkBoard(ExactLocation, board); // 1 to 9 
            }
            //loop for checking Empty Space
            bool emptySpace = false;
            while (true)
            {
                //if 0 == 0
                if (ExactLocation == 0)
                {
                    //error Location Already Selected
                    Console.WriteLine("location already selected");
                    Console.WriteLine("Please Select another location on Board :  ");
                    ExactLocation = Convert.ToInt32(Console.ReadLine());
                    emptySpace = true;
                }
                else
                    board[ExactLocation] = 'x';
                return board;

            }
        }
        //checking if board is empty
        public int checkBoard(int ExactLocation, char[] board)
        {
            if (board[ExactLocation] != ' ')
                return 0;
            else
                return ExactLocation;
        }
    }

}