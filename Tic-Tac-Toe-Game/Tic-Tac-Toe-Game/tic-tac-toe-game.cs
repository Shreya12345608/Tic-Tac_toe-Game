using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game
{
    class tic_tac_toe_game
    {
       public char[] CreateBoard()
        {
            //game board intilized with empty spaces and
            //zeroth index ignored
            char[] board = new char[10];

            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }

        //tossing for players
        public int GameInput()
        {
            Random random = new Random();
            int RandomValue = random.Next(0, 2);
            if (RandomValue == 0)
                /// Check if  Random Value  == 0 then Playerplay First and input will be X 
                Console.WriteLine("Player play first. Input Will Be X");
            else
                ///  Check if  Random Value  == 1 then Computerplay First and input will be 0 
                Console.WriteLine("Computer play first.  Input Will Be 0");
            return RandomValue;
        }

        //Displaying game board
        public void ShowBoard(char[] board)
        {
           // creating and displaying board
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
        public char[] UserMove(char[] board)
        {
            Console.WriteLine("select the location on Board :  ");
            int ExactLocation = Convert.ToInt32(Console.ReadLine());
            //validating user location
            //while loop check if ExactLocation is (less than)9 And  ExactLoaction is (greater) than 1
            while (ExactLocation > 9 || ExactLocation < 1)
            {
                // if other than this it will give an error
                Console.WriteLine("invalid location, select the location on Board :  ");
                ExactLocation = Convert.ToInt32(Console.ReadLine());
            }
            //loop to check for empty space
            bool emptySpace = false;
            while (true)
            {
                //checking for free space
                ExactLocation = CheckBoard(ExactLocation, board);
                if (ExactLocation == 0)
                {
                    //error Location Already Selected
                    Console.WriteLine("The Location Already Selected . Select Another Location on the  Board : ");
                    ExactLocation = Convert.ToInt32(Console.ReadLine());
                    //loop to check for empty space
                    emptySpace = true;
                }
                else
                {
                    //else ExactLocation = '0'
                    board[ExactLocation] = '0';
                    break;
                }
            }
            return board;
        }
        //check the borad is empty or not
        public int CheckBoard(int ExactLocation, char[] board)
        {
            if (board[ExactLocation] != ' ')
                 return 0;
            else
                 return ExactLocation;
        }
    }
}